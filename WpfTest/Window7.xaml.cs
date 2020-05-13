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

namespace WpfTest
{
    /// <summary>
    /// Window7.xaml 的交互逻辑
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private bool isSelect;

        public bool IsSelect
        {
            get { return isSelect; }
            set { isSelect = value; }
        }

        private void border_MouseEnter(object sender, MouseEventArgs e)
        {
            // pop1.IsOpen = false;
            pop1.IsOpen = true;
            
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (IsSelect)
            {
                //是，关闭。
                pop1.IsOpen = false;
            }

            //重置鼠标是否移入弹框GRID区域变量值
            IsSelect = true;
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            pop1.IsOpen = false;
            pop1.IsOpen = true;
        }

        private void TextBox_MouseMove(object sender, MouseEventArgs e)
        {
            IsSelect = true;
        }
    }

    [Serializable]
    class User
    {
        //记住密码
        private string loginID;
        public string LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }

        private string pwd;
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

    }
}
