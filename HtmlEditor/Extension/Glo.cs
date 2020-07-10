using System;
using System.Collections.Generic;

// 版权所有：2014  All Rights Reserved.
// 文 件 名：Glo.cs
// 功能描述：
// 创建标识：m.sh.lin0328@163.com 2014/12/12 21:35:31
// 修改描述：
//----------------------------------------------------------------*/
namespace Msl.HtmlEditor
{
    internal class Glo
    {
        private static string StartPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
        /// <summary>表情图片路径</summary>
        public static string FaceImagePath
        {
            get
            {
                return StartPath + "\\res\\face\\";
            }
        }
        /// <summary>配置路径</summary>
        public static readonly string EditorConfigPath = StartPath + "\\res\\htmleditor.xml";
        /// <summary>样式文件路径</summary>
        public static readonly string StylesheetPath = StartPath + "\\res\\htmleditor.css";
    }
}
