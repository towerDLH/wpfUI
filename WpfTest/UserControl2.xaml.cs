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

namespace WpfTest
{
    /// <summary>
    /// UserControl2.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl2 : UserControl
    {
      
        public string contenttext
        {
            get { return (string)GetValue(contenttextProperty); }
            set { SetValue(contenttextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for contenttext.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty contenttextProperty =
            DependencyProperty.Register("contenttext", typeof(string), typeof(UserControl2), new PropertyMetadata(""));


        public UserControl2()
        {
            InitializeComponent();
        }
    }
}
