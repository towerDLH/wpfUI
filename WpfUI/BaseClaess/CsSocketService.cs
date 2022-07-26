using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI.BaseClaess
{
    class CsSocketService
    {
        /// <summary>
        /// 作者:WangJunLiang || Wechat:Joronwongx
        /// </summary>

        public delegate void ReceClientData(string strRp, byte[] Buf, int nBufLenght);
        public event ReceClientData SendReceEnvent;

        public struct SocketServiceIP
        {
            public string strIpAddress;
            public int nPort;
            public int nMaxClientConnectCnt;
        };

        #region 线程管理

        //管理者线程
        private Socket m_ServiceMaster = null;
        private BackgroundWorker m_ClientAdministrator_BackgroundWorker = null;

        //用户线程
        public struct SocketServiceChild
        {
            public Socket socket;
            public BackgroundWorker backgroundWorker;
        };
        public Dictionary<string, SocketServiceChild> m_LSocketServiceChild = new Dictionary<string, SocketServiceChild>(); //是二叉树式的存储结构，不支持用索引来取值，想取只能遍历

        #endregion

        #region 监听服务
        //创建多个子服务器的消息接收线程
        private void CreateClientReceClick(object sender, DoWorkEventArgs e)
        {
            while (!m_ClientAdministrator_BackgroundWorker.CancellationPending)
            {
                Socket socketItem = m_ServiceMaster.Accept();                                   //阻塞监听
                if (m_ClientAdministrator_BackgroundWorker.CancellationPending)                   //支线程是否被挂起取消
                    break;
                if (socketItem != null)
                {
                    BackgroundWorker ServiceChild_BackgroundWorker = new BackgroundWorker();
                    ServiceChild_BackgroundWorker.DoWork += ReceClientDataClick;                //持续监听绑定的客户端
                    ServiceChild_BackgroundWorker.WorkerSupportsCancellation = true;            //允许取消

                    var strRp = socketItem.RemoteEndPoint.ToString();                           //获取对方编号

                    SocketServiceChild socketServiceChild = new SocketServiceChild()
                    {
                        socket = socketItem,
                        backgroundWorker = ServiceChild_BackgroundWorker
                    };
                    m_LSocketServiceChild.Add(socketItem.RemoteEndPoint.ToString(), socketServiceChild);
                    ServiceChild_BackgroundWorker.RunWorkerAsync(socketItem);                   //开始执行DoWork,并将客户端的信息传入线程
                }
            }
            m_ServiceMaster.Close();
            m_ServiceMaster = null;
        }

        //内容监听 socketItem代表子客户端的id 一对一的监听服务线程
        private void ReceClientDataClick(object sender, DoWorkEventArgs e)
        {
            try
            {
                Socket socketItem = (Socket)e.Argument;
                var strRp = socketItem.RemoteEndPoint.ToString();                                   //获取对方编号

                while (!m_LSocketServiceChild[strRp].backgroundWorker.CancellationPending)
                {
                    if (socketItem.Poll(10, SelectMode.SelectRead))
                    {
                        m_LSocketServiceChild[strRp].backgroundWorker.CancelAsync();              //停止执行DoWork
                        break;
                    }
                    byte[] buffer = new byte[4096];                                             //new一个接收的缓存区
                    int nReceBufCnt = socketItem.Receive(buffer);                               //Service接收主要函数,阻塞等待接收
                    SendReceEnvent(strRp, buffer, nReceBufCnt);
                }
                m_LSocketServiceChild[strRp].socket.Shutdown(SocketShutdown.Both);
                m_LSocketServiceChild[strRp].socket.Close();
                m_LSocketServiceChild.Remove(strRp);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        #endregion

        //创建连接
        public bool SocketFound(SocketServiceIP ServiceIP)
        {
            try
            {
                if (m_ServiceMaster != null)
                    return false;

                m_ServiceMaster = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                m_ServiceMaster.Bind(new IPEndPoint(IPAddress.Parse(ServiceIP.strIpAddress), ServiceIP.nPort));
                m_ServiceMaster.Listen(ServiceIP.nMaxClientConnectCnt);

                m_ClientAdministrator_BackgroundWorker = new BackgroundWorker();
                m_ClientAdministrator_BackgroundWorker.DoWork += CreateClientReceClick;
                m_ClientAdministrator_BackgroundWorker.WorkerSupportsCancellation = true; //允许取消
                m_ClientAdministrator_BackgroundWorker.RunWorkerAsync();//开始执行DoWork

                return true;
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                m_ServiceMaster = null;
                return false;
            }
        }

        //断开连接
        public bool SocketBreak(string strRp, SocketServiceIP ServiceIP)
        {
            try
            {
                if (m_ServiceMaster != null)
                {
                    if (strRp == "AllConnection")
                    {

                        foreach (var item in m_LSocketServiceChild)
                            item.Value.socket.Shutdown(SocketShutdown.Both);//结束子客户端线程

                        m_ClientAdministrator_BackgroundWorker.CancelAsync();
                        //通过IP和端口号来定位一个所要连接的服务器端
                        new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp).Connect(new IPEndPoint(IPAddress.Parse(ServiceIP.strIpAddress), ServiceIP.nPort));

                    }
                    else
                        m_LSocketServiceChild[strRp].socket.Shutdown(SocketShutdown.Both);
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

        //发送内容
        public void SocketSend(string strRp, byte[] buf)
        {
            try
            {
                if (m_ServiceMaster != null)
                {
                    if (strRp == "AllConnection")
                        foreach (var item in m_LSocketServiceChild)
                            item.Value.socket.Send(buf);
                    else
                        m_LSocketServiceChild[strRp].socket.Send(buf);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }

}
