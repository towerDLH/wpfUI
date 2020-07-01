using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace DiagramDesigner.Model
{

    public class RememberClass
    {
        //获得data.bin的路径。
        string filePath = Directory.GetCurrentDirectory() + "\\" + "data.bin";
        //声明一个Dictionary的集合。
        private static Dictionary<string, FlowChar> dicflowcontrol = new Dictionary<string, FlowChar>();
        /// <summary>
        /// 构造方法，读取文件流。
        /// </summary>
        public RememberClass()
        {
            //实例化一个流：FileStream。
        }

        public Action LoadFlowChar;

        public void LoadFlowMD()
        {
            if (LoadFlowChar != null)
            {
                LoadFlowChar.Invoke();
            }
        }

        public Dictionary<string, FlowChar> GetFlowChar()
        {
            //MemoryStream ms = new MemoryStream();
            //using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            //{
            //    byte[] buffer = new byte[fs.Length];
            //    int length = fs.Read(buffer, 0, (int)fs.Length);
            //    fs.Close();
            //    ms.Write(buffer, 0, length); // 将字节写入内存流以备序列化使用
            //    ms.Flush();
            //    //如果有数据。
            //    if (ms.Length > 0)
            //    {
            //        //BinaryFormatter：以二进制格式序列化和反序列化对象或连接对象的整个图形。
            //        //实例化序列化对象。
            //        BinaryFormatter bf = new BinaryFormatter();
            //        //ms.Position = 0;
            //        ms.Seek(0, SeekOrigin.Begin);
            //        //将反序化后的内容转换为dicUserInfo集合。
            //        dicflowcontrol = bf.Deserialize(ms) as Dictionary<string, FlowChar>;
            //    }
            //}
            if (!File.Exists(filePath))
            {
                return dicflowcontrol;
            }
            using (FileStream fsRead = new FileStream(filePath, FileMode.Open))
            {
                int fsLen = (int)fsRead.Length;
                byte[] heByte = new byte[fsLen];
                fsRead.Read(heByte, 0, heByte.Length);
                dicflowcontrol = JsonConvert.DeserializeObject<Dictionary<string, FlowChar>>(System.Text.Encoding.UTF8.GetString(heByte));
                return dicflowcontrol;
            }
        }
        /// <summary>
        /// 此方法用于得到集合中的数量。
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, FlowChar> GetDicCount()
        {
            return dicflowcontrol;
        }

        /// <summary>
        /// 此方法用于流程子控件。
        /// </summary>
        public void AddRemember(FlowChar _flowcharconrol,bool IsMsg=true)
        {
            //实例化一个流：FileStream。
            //using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            //{
            //    //实例化序列化对象。
            //    BinaryFormatter bf = new BinaryFormatter();
            //    //如果已存在此用户，那么就移除掉。
            //    if (dicflowcontrol.ContainsKey(_flowcharconrol.FlowcharPath))
            //    {
            //        dicflowcontrol.Remove(_flowcharconrol.FlowcharPath);
            //    }
            //    //再添加该用户，防止用户更新密码。
            //    dicflowcontrol.Add(_flowcharconrol.FlowcharPath, _flowcharconrol);

            //    //序列化。
            //    try
            //    {
            //        bf.Serialize(fs, dicflowcontrol);
            //    }
            //    catch (Exception e)
            //    {


            //    }
            //}
            var msg = "";
            if (dicflowcontrol.ContainsKey(_flowcharconrol.FlowcharPath))
            {
                msg = "修改成功";
            }
            else
            {
                dicflowcontrol.Add(_flowcharconrol.FlowcharPath, _flowcharconrol);
                msg = "新建成功";
            }
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                if (dicflowcontrol.Any())
                {
                    var reslt = JsonConvert.SerializeObject(dicflowcontrol);
                    byte[] bts = System.Text.Encoding.Default.GetBytes(reslt);
                    fs.Write(bts, 0, bts.Length);
                }
               
                if(IsMsg) MessageBox.Show(msg, "提示信息");
            }
        }
    }
}
