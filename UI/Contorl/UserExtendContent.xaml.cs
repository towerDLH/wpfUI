using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI.Contorl
{
    /// <summary>
    /// UserExtendContent.xaml 的交互逻辑
    /// </summary>
    public partial class UserExtendContent:Grid 
    {
        public UserExtendContent()
        {
            InitializeComponent();
        }

        private void Btn_SetColorClick(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// 博客
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBlog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hyperlink0_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baidu.com/");  
        }
    }
}
