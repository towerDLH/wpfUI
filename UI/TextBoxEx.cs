using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:UI"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:UI;assembly=UI"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误: 
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:TextBoxEx/>
    ///
    /// </summary>
    public class TextBoxEx : TextBox
    {
        #region 依赖属性
        public static readonly DependencyProperty XWmkTextProperty;//水印文字
        public static readonly DependencyProperty XWmkForegroundProperty;//水印着色
        public static readonly DependencyProperty XIsErrorProperty;//是否字段有误
        public static readonly DependencyProperty XAllowNullProperty;//是否允许为空
        public static readonly DependencyProperty XRegExpProperty;//正则表达式
        #endregion
        static TextBoxEx()
        {
            TextBoxEx.XWmkTextProperty = DependencyProperty.Register("XWmkText", typeof(String), typeof(TextBoxEx), new PropertyMetadata(null));
            TextBoxEx.XAllowNullProperty = DependencyProperty.Register("XAllowNull", typeof(bool), typeof(TextBoxEx), new PropertyMetadata(true));
            TextBoxEx.XIsErrorProperty = DependencyProperty.Register("XIsError", typeof(bool), typeof(TextBoxEx), new PropertyMetadata(false));
            TextBoxEx.XRegExpProperty = DependencyProperty.Register("XRegExp", typeof(string), typeof(TextBoxEx), new PropertyMetadata(""));
            TextBoxEx.XWmkForegroundProperty = DependencyProperty.Register("XWmkForeground", typeof(Brush),
                typeof(TextBoxEx), new PropertyMetadata(Brushes.Silver));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextBoxEx), new FrameworkPropertyMetadata(typeof(TextBoxEx)));
        }



        public bool IsError
        {
            get { return (bool)GetValue(IsErrorProperty); }
            set { SetValue(IsErrorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsError.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsErrorProperty =
            DependencyProperty.Register("IsError", typeof(bool), typeof(TextBoxEx), new PropertyMetadata(false));


        public TextBoxEx()
        {
            this.LostFocus += new RoutedEventHandler(XTextBox_LostFocus);
            this.GotFocus += new RoutedEventHandler(XTextBox_GotFocus);
            this.TextChanged += XTextBox_Change;
            this.PreviewMouseDown += new MouseButtonEventHandler(XTextBox_PreviewMouseDown);
        }

        private void XTextBox_Change(object sender, RoutedEventArgs e)
        {
            //this.XIsError = false;

            if (Regex.IsMatch(this.Text.Trim(), XRegExp) == false)
            {
                this.BorderBrush = new SolidColorBrush(Colors.Red);
                // this.XIsError = true;
            }
            else {
                this.BorderBrush = new SolidColorBrush(Colors.Gray);
            }
        }

        /// <summary>
        /// 失去焦点时检查输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void XTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            this.XIsError = false;
            if (XAllowNull == false && this.Text.Trim() == "")
            {
                this.XIsError = true;
            }
            if (Regex.IsMatch(this.Text.Trim(), XRegExp) == false)
            {
                this.XIsError = true;
            }
        }

        /// <summary>
        /// 获得焦点时选中文字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void XTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            this.SelectAll();
        }

        /// <summary>
        /// 鼠标点击时选中文字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void XTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.IsFocused == false)
            {
                TextBox textBox = sender as TextBox;
                textBox.Focus();
                e.Handled = true;
            }
        }

        #region 公布属性
        /// <summary>
        /// 公布属性XWmkText（水印文字）
        /// </summary>
        public String XWmkText
        {
            get
            {
                return base.GetValue(TextBoxEx.XWmkTextProperty) as String;
            }
            set
            {
                base.SetValue(TextBoxEx.XWmkTextProperty, value);
            }
        }

        /// <summary>
        /// 公布属性XWmkForeground（水印着色）
        /// </summary>
        public Brush XWmkForeground
        {
            get
            {
                return base.GetValue(TextBoxEx.XWmkForegroundProperty) as Brush;
            }
            set
            {
                base.SetValue(TextBoxEx.XWmkForegroundProperty, value);
            }
        }

        /// <summary>
        /// 公布属性XIsError（是否字段有误）
        /// </summary>
        public bool XIsError
        {
            get
            {
                return (bool)base.GetValue(TextBoxEx.XIsErrorProperty);
            }
            set
            {
                base.SetValue(TextBoxEx.XIsErrorProperty, value);
            }
        }

        /// <summary>
        /// 公布属性XAllowNull（是否允许为空）
        /// </summary>
        public bool XAllowNull
        {
            get
            {
                return (bool)base.GetValue(TextBoxEx.XAllowNullProperty);
            }
            set
            {
                base.SetValue(TextBoxEx.XAllowNullProperty, value);
            }
        }

        /// <summary>
        /// 公布属性XRegExp（正则表达式）
        /// </summary>
        public string XRegExp
        {
            get
            {
                return base.GetValue(TextBoxEx.XRegExpProperty) as string;
            }
            set
            {
                base.SetValue(TextBoxEx.XRegExpProperty, value);
            }
        }
        #endregion
    }
}

