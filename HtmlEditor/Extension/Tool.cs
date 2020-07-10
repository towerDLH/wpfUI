using System;
using System.Text.RegularExpressions;
using System.Windows;

// 版权所有：2014  All Rights Reserved.
// 文 件 名：Tool.cs
// 功能描述：
// 创建标识：m.sh.lin0328@163.com 2014/12/13 11:55:01
// 修改描述：
//----------------------------------------------------------------*/
namespace Msl.HtmlEditor
{
    internal static class Tool
    {
        /// <summary>
        /// 添加项
        /// </summary>
        public struct MyItem
        {
            public string Name { set; get; }
            public string Value { set; get; }
        }
        /// <summary>
        /// 将表达式转换到 Media.Color
        /// </summary>
        public static System.Windows.Media.Color StringToColor(string value)
        {
            return (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(value);
        }
        /// <summary>
        /// Perform html encoding.
        /// </summary>
        public static string HtmlEncoding(this string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                value = value.Replace("<", "&lt;");
                value = value.Replace(">", "&gt;");
                value = value.Replace(" ", "&nbsp;");
                value = value.Replace("\"", "&quot;");
                value = value.Replace("\'", "&#39;");
                value = value.Replace("&", "&amp;");
                return value;
            }
            return string.Empty;
        }

        /// <summary>
        /// Perform html decoding.
        /// </summary>
        public static string HtmlDecoding(this string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                value = value.Replace("&lt;", "<");
                value = value.Replace("&gt;", ">");
                value = value.Replace("&nbsp;", " ");
                value = value.Replace("&quot;", "\"");
                value = value.Replace("&#39;", "\'");
                value = value.Replace("&amp;", "&");
                return value;
            }
            return string.Empty;
        }

        /// <summary>
        /// Filter all html tags.
        /// </summary>
        public static string FilterAllTags(this string value)
        {
            Regex match = new Regex("<[^>]+>");
            return match.Replace(value, string.Empty);
        }
        /// <summary>
        /// Get the window container of framework element.
        /// </summary>
        public static Window GetParentWindow(this FrameworkElement element)
        {
            DependencyObject dp = element;
            while (dp != null)
            {
                DependencyObject tp = LogicalTreeHelper.GetParent(dp);
                if (tp is Window) return tp as Window;
                else dp = tp;
            }
            return null;
        }
    }
}
