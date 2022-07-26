using com.xsw.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfUI.Extension
{
    public class LocalData
    {
        #region 输入法键盘
        static PopupUser g_popup = new PopupUser();
        /// <summary>
        /// 显示输入法键盘
        /// </summary>
        /// <param name="_win"></param>
        /// <param name="_type"></param>
        /// <param name="_element">输入中文的控件</param>
        /// <returns></returns>
        public static PopupUser KeyBoard(Window _win, KeyboardTypeUser _type = KeyboardTypeUser.none, UIElement _element = null)
        {
            if (_type == KeyboardTypeUser.none)
            {
                _type = KeyboardTypeUser.china;
            }
            g_popup.PopupAnimation = PopupAnimation.Slide;
            g_popup.Placement = PlacementMode.Relative;
            if (_win.ActualWidth > 0)
            {
                g_popup.Width = _win.ActualWidth;
            }
            else
            {
                g_popup.Width = 1288;
            }
            g_popup.HorizontalAlignment = HorizontalAlignment.Center;
            g_popup.Margin = new Thickness(0);
            g_popup.HorizontalOffset = 0;
            if (_win.ActualHeight > 380)
            {
                if (g_popup.ActualHeight > 0)
                {
                    g_popup.VerticalOffset = (_win.ActualHeight - g_popup.ActualHeight);
                }
                else
                {
                    g_popup.VerticalOffset = (_win.ActualHeight - 380);
                }
            }
            else
            {
                g_popup.VerticalOffset = 340;
            }
            g_popup.Margin = new Thickness(5, 5, 5, 5);
            g_popup.AllowsTransparency = true;
            g_popup.ShowKeyboard(_type, _element);
            g_popup.PlacementTarget = _win;   //表示Popup控件的放置的位置依赖的对象
            g_popup.IsOpen = true;

            return g_popup;
        }
        #endregion
    }
}
