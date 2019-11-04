using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Fileupload
    {
        /// <summary>
        /// 共享文件链接
        /// </summary>
        /// <param name="path">共享路径</param>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        public static bool connectState(string path, string userName, string passWord)
        {
            bool Flag = false;
            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                string dosLine = @"net use " + path + " /User:" + userName + " " + passWord + " /PERSISTENT:YES";
                proc.StandardInput.WriteLine(dosLine);
                proc.StandardInput.WriteLine("exit");
                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                }
                string errormsg = proc.StandardError.ReadToEnd();
                proc.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="fileNamePath">原路径</param>
        /// <param name="urlPath">上传路径</param>
        /// <param name="User">用户名</param>
        /// <param name="Pwd">密码</param>
        /// <param name="islog"></param>
        /// <returns></returns>
        public bool UpLoadFile(string path, string fileNamePath, string urlPath, string User, string Pwd, int islog, out string Mage)
        {
            //  string.
            // if()
            if (!connectState(path, User, Pwd))
            {
                Mage = "共享路径链接失败";
                return false;
            }
            var flag = false;
            WebClient myWebClient = new WebClient();
            NetworkCredential cread = new NetworkCredential(User, Pwd, "Domain");
            myWebClient.Credentials = cread;
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            Stream postStream = null;
            try
            {
                byte[] postArray = r.ReadBytes((int)fs.Length);
                postStream = myWebClient.OpenWrite(urlPath);
                if (postStream.CanWrite)
                {
                    postStream.Write(postArray, 0, postArray.Length);
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                postStream.Close();
                Mage = "文件写入失败";
                return flag;
            }
            catch (Exception ex)
            {
                if (islog > 0)
                    if (postStream != null)
                        postStream.Close();
                Mage = "文件写入失败";
                return false;
            }

        }
    }
}
