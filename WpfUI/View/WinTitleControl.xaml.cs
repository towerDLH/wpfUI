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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfUI.Extension;

namespace WpfUI.View
{
    /// <summary>
    /// WinTitleControl.xaml 的交互逻辑
    /// </summary>
    public partial class WinTitleControl : UserControl
    {
        public WinTitleControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PopupConfig.IsOpen = !PopupConfig.IsOpen;
        }
        /// <summary>
        /// 选择多语言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectLang_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            GlobalClass.ChangeLanguage(btn.Tag.ToString());
        }
    }
}
