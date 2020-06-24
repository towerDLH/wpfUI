using DiagramDesigner.Controls;
using DiagramDesigner.Data;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// FlowWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FlowWindow : Window
    {
        private Dictionary<string, Uri> allViews = new Dictionary<string, Uri>(); //包含所有页面

        public FlowWindow()
        {
            InitializeComponent();
        }

        public void GetFlowChild()
        {


            allViews.Add("page1", new Uri("pages/Page1.xaml", UriKind.Relative));
            allViews.Add("page2", new Uri("pages/Page2.xaml", UriKind.Relative));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
