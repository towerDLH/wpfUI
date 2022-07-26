using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UI.Model;
using Newtonsoft;
using Newtonsoft.Json;

namespace WpfUI.ViewModel
{
    public class CtlCharRoomViewModel : ViewModelBase
    {
        #region 属性
        private IPEndPoint ServerInfo;
        private Socket ClientSocket;
        //信息接收缓存
        private Byte[] MsgBuffer;
        //信息发送存储
        private Byte[] MsgSend;
        static Socket serverSocket = null;
        static List<Socket> sockets = new List<Socket>();

        private string setText;

        public string SetText
        {
            get { return setText; }
            set { setText = value; RaisePropertyChanged(() => SetText); }
        }
        private string setMsg;

        public string SetMsg
        {
            get { return setMsg; }
            set { setMsg = value; RaisePropertyChanged(() => SetMsg); }
        }
        #endregion
        static byte[] buffer = new byte[1024];
        public CtlCharRoomViewModel()
        {
            //ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //MsgBuffer = new Byte[65535];
            //MsgSend = new Byte[65535];
            //this.LianjieMD();
            //允许子线程刷新数据
            // CheckForIllegalCrossThreadCalls = false;

            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //连接到指定服务器的指定端口
            //方法参考：http://msdn.microsoft.com/zh-cn/library/system.net.sockets.socket.connect.aspx
            ClientSocket.Connect("localhost", 8008);

            Console.WriteLine("connect to the server");
            //实现接受消息的方法

            //方法参考：http://msdn.microsoft.com/zh-cn/library/system.net.sockets.socket.beginreceive.aspx
            

        }
        #region 命令
        private RelayCommand setcommand;

        public RelayCommand SetCommand
        {
            get
            {
                if (setcommand == null)
                    setcommand = new RelayCommand(() => ExcuteSetCommand());
                return setcommand;
            }
            set { setcommand = value; }
        }

        private RelayCommand sendCommand;
        /// <summary>
        /// 登录
        /// </summary>
        public RelayCommand SendCommand
        {
            get
            {
                if (sendCommand == null)
                    sendCommand = new RelayCommand(() => ExcuteSendCommand());
                return sendCommand;

            }
            set { sendCommand = value; }
        }
        #endregion
        #region 方法

        public   void ReceiveMessage(IAsyncResult ar)
        {
            try
            {
                var socket = ar.AsyncState as Socket;

                //方法参考：http://msdn.microsoft.com/zh-cn/library/system.net.sockets.socket.endreceive.aspx
                var length = socket.EndReceive(ar);
                //读取出来消息内容
                var message = Encoding.Unicode.GetString(buffer, 0, length);
                //显示消息
                //Console.WriteLine(message);
                this.SetText += message;
                //接收下一个消息(因为这是一个递归的调用，所以这样就可以一直接收消息了）
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void LianjieMD()
        {
            //服务端IP和端口信息设定,这里的IP可以是127.0.0.1，可以是本机局域网IP，也可以是本机网络IP
            ServerInfo = new IPEndPoint(IPAddress.Parse("192.168.31.5"), Convert.ToInt32(8008));
            try
            {
                //客户端连接服务端指定IP端口，Sockket
                ClientSocket.Connect(ServerInfo);
                stocksignal sendstocksignal = new stocksignal(Loginer.LoginerUser.UserName, "进入系统", 12, 100102);
                //将用户登录信息发送至服务器，由此可以让其他客户端获知
                var strmsg = JsonConvert.SerializeObject(sendstocksignal);
                ClientSocket.Send(Encoding.Unicode.GetBytes(strmsg));
                //开始从连接的Socket异步读取数据。接收来自服务器，其他客户端转发来的信息
                //AsyncCallback引用在异步操作完成时调用的回调方法
                ClientSocket.BeginReceive(MsgBuffer, 0, MsgBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), null);
                this.setText = "登录服务器成功！";
            }
            catch
            {
                this.setText = "登录服务器失败，请确认服务器是否正常工作！";
            }

        }

        private void ReceiveCallBack(IAsyncResult AR)
        {
            try
            {
                //结束挂起的异步读取，返回接收到的字节数。 AR，它存储此异步操作的状态信息以及所有用户定义数据
                int REnd = ClientSocket.EndReceive(AR);

                lock (this.setText)
                {
                    this.SetText += (Encoding.Unicode.GetString(MsgBuffer, 0, REnd) + "\n");
                }
                ClientSocket.BeginReceive(MsgBuffer, 0, MsgBuffer.Length, 0, new AsyncCallback(ReceiveCallBack), null);
            }
            catch
            {
                this.SetText += "已经与服务器断开连接！";
            }
        }
        public void ExcuteSetCommand()
        {
            ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), ClientSocket);
            var message = this.SetMsg;
           // var outputBuffer = Encoding.Unicode.GetBytes(message);
           // ClientSocket.BeginSend(outputBuffer, 0, outputBuffer.Length, SocketFlags.None, null, null);

            stocksignal sendstocksignal = new stocksignal(Loginer.LoginerUser.UserName, this.SetMsg, 12, 100102);
            //将用户登录信息发送至服务器，由此可以让其他客户端获知
            var strmsg = JsonConvert.SerializeObject(sendstocksignal);
            var outputBuffer = Encoding.Unicode.GetBytes(strmsg);
            ClientSocket.BeginSend(outputBuffer, 0, outputBuffer.Length, SocketFlags.None, null, null);
            //MsgSend = Encoding.Unicode.GetBytes(strmsg);
            //if (ClientSocket.Connected)
            //{
            //    //将数据发送到连接的 System.Net.Sockets.Socket。
            //    ClientSocket.Send(MsgSend);
            //    this.SetMsg = "";
            //}
            //else
            //{
            //    this.setText += "当前与服务器断开连接，无法发送信息！";
            //    // MessageBox.Show("当前与服务器断开连接，无法发送信息！");
            //}
            //String text =this.SetText;
            ////设定服务器IP地址  
            //IPAddress ip = IPAddress.Parse("127.0.0.1");
            //Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //try
            //{
            //    clientSocket.Connect(new IPEndPoint(ip, 6002)); //配置服务器IP与端口  

            //}
            //catch
            //{
            //    Console.WriteLine("连接服务器失败，请按回车键退出！");
            //    return;
            //}
            //clientSocket.Send(Encoding.ASCII.GetBytes(text));
        }
        public void ExcuteSendCommand()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(ip, 6002));  //绑定IP地址：端口  
            serverSocket.Listen(10);    //设定最多10个排队连接请求             
            //通过Clientsoket发送数据  
            Thread myThread = new Thread(ListenClientConnect);
            myThread.Start();
        }
        //监听客户端发来的请求  
        public void ListenClientConnect()
        {
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
                sockets.Add(clientSocket);
                //为接受数据创建一个线程
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(clientSocket);
            }
        }
        public void ReceiveMessage(object clientSocket)
        {
            Socket connection = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    byte[] result = new byte[1024];
                    //通过clientSocket接收数据  
                    int receiveNumber = connection.Receive(result);
                    //把接受的数据从字节类型转化为字符类型
                    String recStr = Encoding.ASCII.GetString(result, 0, receiveNumber);


                    //获取当前客户端的ip地址
                    IPAddress clientIP = (connection.RemoteEndPoint as IPEndPoint).Address;
                    //获取客户端端口
                    int clientPort = (connection.RemoteEndPoint as IPEndPoint).Port;
                    String sendStr = clientIP + ":" + clientPort.ToString() + "--->" + recStr;
                    foreach (Socket socket in sockets)
                    {
                        socket.Send(Encoding.ASCII.GetBytes(sendStr));
                    }
                    SetText += "\r\n" + sendStr;
                    //显示内容
                    //text1.Dispatcher.BeginInvoke(

                    //        new Action(() => { text1.Text += "\r\n" + sendStr; }), null);

                }
                catch (Exception ex)
                {
                    connection.Shutdown(SocketShutdown.Both);
                    connection.Close();
                    break;
                }
            }

        }
        #endregion
    }

    public class stocksignal
    {
        public stocksignal(string usrname, string message, int groupid, int stocktype)
        {
            UserName = usrname;
            Message = message;
            GroupID = groupid;
            Stocktype = stocktype;
        }
        public string Message { get; set; }
        public string UserName { get; set; }
        public int GroupID { get; set; }
        /// <summary>
        /// 100101 更新金额 100102 通信 100103 回合累加
        /// </summary>
        public int Stocktype { get; set; } 
    }
}
