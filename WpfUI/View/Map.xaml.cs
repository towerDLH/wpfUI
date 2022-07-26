using CefSharp;
using CefSharp.Wpf;
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

namespace WpfUI.View
{
    /// <summary>
    /// Map.xaml 的交互逻辑
    /// </summary>
    public partial class Map : UserControl
    {
        //public static Map Instance;

        //static Map()
        //{
        //    var settings = new CefSettings();
        //    Cef.Initialize(settings);
        //    Instance = null;
        //}

        private ChromiumWebBrowser WebView;
        public Map()
        {
            InitializeComponent();
            if (WebView == null)
            {
                WebView = new ChromiumWebBrowser();
                WebView.Width = 620;
                WebView.Height = 480;
                var hander = new CallbackObjectForJs();
                WebView.RegisterJsObject("callbackObj", hander);
            }
            if (WebView.Parent == null)
            {
                MainGrid.Children.Add(WebView);
            }
          //  WebView.RenderProcessMessageHandler=new 
            WebView.Address = AppDomain.CurrentDomain.BaseDirectory + @"index.html";
           // Instance = this;
            WebView.Loaded += (s, e) =>
            {
                //WebView.ShowDevTools();
            };
            
        }

        public void Reload()
        {
            WebView?.Dispatcher.Invoke(() =>
            {
                WebView.WebBrowser.Reload();
            });
        }
        public void bb()
        {
            WebView.ExecuteScriptAsync("ydb1('asdadaasdasdas我是杨道波')");
        }

        private void ButtonJS_Click(object sender, RoutedEventArgs e)
        {
            WebView.ExecuteScriptAsync("ydb1('asdadaasdasdas我是杨道波')");
        }
        public class CallbackObjectForJs
        {
            public void showMessage(string msg)
            {
                MessageBox.Show(msg);
            }
            public string action(string message)
            {
                //MessageBox.Show("测试");
                return "收到网页消息：" + message;
            }

        }
    }
    /// <summary>
    /// 网页JS中调用的方法
    /// </summary>
   
}
