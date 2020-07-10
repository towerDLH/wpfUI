using System;

namespace Msl.HtmlEditor
{
    /// <summary>
    /// 提供 System.Drawing.Color 和 System.Windows.Media.Color 之间的转换方法。
    /// </summary>
    internal static class ColorExtension
    {
        /// <summary>
        /// 将 System.Drawing.Color 转换到 System.Windows.Media.Color。
        /// </summary>
        public static System.Windows.Media.Color ColorConvert(this System.Drawing.Color color)
        {
            return System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        /// <summary>
        /// 将 System.Windows.Media.Color 转换到 System.Drawing.Color。
        /// </summary>
        public static System.Drawing.Color ColorConvert(this System.Windows.Media.Color color)
        {
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        /// <summary>
        /// 判断 System.Drawing.Color 和 System.Windows.Media.Color 是否表示相同的颜色。
        /// </summary>
        public static bool ColorEqual(this System.Drawing.Color drawingColor, System.Windows.Media.Color mediaColor)
        {
            return (drawingColor.A == mediaColor.A &&
                    drawingColor.R == mediaColor.R &&
                    drawingColor.G == mediaColor.G &&
                    drawingColor.B == mediaColor.B);
        }

        /// <summary>
        /// 判断 System.Windows.Media.Color 和 System.Drawing.Color 是否表示相同的颜色。
        /// </summary>
        public static bool ColorEqual(this System.Windows.Media.Color mediaColor, System.Drawing.Color drawingColor)
        {
            return (drawingColor.A == mediaColor.A &&
                    drawingColor.R == mediaColor.R &&
                    drawingColor.G == mediaColor.G &&
                    drawingColor.B == mediaColor.B);
        }

        /// <summary>
        /// 将表达式转换到 System.Windows.Media.Color。
        /// </summary>
        //public static System.Windows.Media.Color ConvertToColor(string value)
        //{
        //    return (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(value);
        //}

        public static readonly System.Windows.Media.Color DefaultBackColor = System.Windows.SystemColors.WindowColor;

        public static readonly System.Windows.Media.Color DefaultForeColor = System.Windows.SystemColors.WindowTextColor;
    }
}
