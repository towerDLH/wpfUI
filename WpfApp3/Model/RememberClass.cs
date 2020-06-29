using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WpfApp3.Model
{
    public class RememberClass
    {
        //获得data.bin的路径。
        string filePath = System.Windows.Forms.Application.StartupPath + "\\" + "data.bin";
        //声明一个Dictionary的集合。
        private static Dictionary<string, FlowCharControl> dicflowcontrol = new Dictionary<string, FlowCharControl>();
        /// <summary>
        /// 构造方法，读取文件流。
        /// </summary>
        public RememberClass()
        {
            //实例化一个流：FileStream。
        }


        public Dictionary<string, FlowCharControl> GetFlowChar()
        {
            MemoryStream ms = new MemoryStream();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fs.Length];
                int length = fs.Read(buffer, 0, (int)fs.Length);
                fs.Close();
                ms.Write(buffer, 0, length); // 将字节写入内存流以备序列化使用
                ms.Flush();
                //如果有数据。
                if (ms.Length > 0)
                {
                    //BinaryFormatter：以二进制格式序列化和反序列化对象或连接对象的整个图形。
                    //实例化序列化对象。
                    BinaryFormatter bf = new BinaryFormatter();
                    ms.Position = 0;
                    //将反序化后的内容转换为dicUserInfo集合。
                    dicflowcontrol = bf.Deserialize(ms) as Dictionary<string, FlowCharControl>;
                }
            }
            return dicflowcontrol;
        }
        /// <summary>
        /// 此方法用于得到集合中的数量。
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, FlowCharControl> GetDicCount()
        {
            return dicflowcontrol;
        }

        /// <summary>
        /// 此方法用于流程子控件。
        /// </summary>
        public void AddRemember(FlowCharControl _flowcharconrol)
        {
            //实例化一个流：FileStream。
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                //实例化序列化对象。
                BinaryFormatter bf = new BinaryFormatter();
                //如果已存在此用户，那么就移除掉。
                if (dicflowcontrol.ContainsKey(_flowcharconrol.FilePath))
                {
                    dicflowcontrol.Remove(_flowcharconrol.FilePath);
                }
                //再添加该用户，防止用户更新密码。
                dicflowcontrol.Add(_flowcharconrol.FilePath, _flowcharconrol);

                //序列化。
                try
                {
                    bf.Serialize(fs, dicflowcontrol);
                }
                catch (Exception e)
                {

                    
                }
            }
        }
    }
}
