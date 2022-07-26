using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfUI.Extension;
using com.xsw.Keyboard;
using CefSharp;
using Newtonsoft;
using Newtonsoft.Json;

namespace WpfUI.View
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : UserControl
    {

        StringResourceExtension StringResource;
        Window win;
        public static bool isload=false;
        public HomePage()
        {
            InitializeComponent();
            // int count = GlobalClass.LanguageChangeEvent.GetInvocationList().Count();
            StringResource = new StringResourceExtension("All");
            Binding bind = new Binding();
            bind.Source = StringResource;
            bind.Path = new PropertyPath("Value");
            bind.Mode = BindingMode.TwoWay;
            bind.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            win = (this.Parent) as Window;

            // CefSharpSettings.LegacyJavascriptBindingEnabled = true;

          //  this.cefsharp.Address = "http://localhost:8081/tabs?uid=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJsb2dpbklEIjoiMSIsIm5iZiI6MTYzODQzNDk4NywiZXhwIjoxNjM4NDYzNzg3LCJpc3MiOiJXWVkiLCJhdWQiOiJFdmVyeVRlc3RPbmUifQ.rJqX3eaYwvevCHcIJvMrZ4jQY0CnKeMfA6svg8bmRV4l";
            this.cefsharp.Address = AppDomain.CurrentDomain.BaseDirectory + @"index.html";
            this.cefsharp1.Address = "https://www.baidu.com/";
            // this.cefsharp.Address = @"http://192.168.31.165:8080/login";
            //this.cefsharp.Address = "http://hmstxf.chenniao.com/indexCopy.html";
            // this.cefsharp.RegisterJsObject("callbackObj", new CallbackObjectForJs());
            //this.cefsharp.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true;
            //this.cefsharp.JavascriptObjectRepository.Register("boundAsync", new CallbackObjectForJs(), isAsync: true, options: BindingOptions.DefaultBinder);

            // cefsharp.ExecuteScriptAsync("ydb1('asdadaasdasdas我是杨道波')");
            //   this.cefsharp.RegisterJsObject("JsObj", new CallbackObjectForJs(), new CefSharp.BindingOptions { CamelCaseJavascriptNames = false });

            this.cefsharp.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true;
            this.cefsharp.JavascriptObjectRepository.Register("JsObj", new CallbackObjectForJs(), isAsync: true, options: BindingOptions.DefaultBinder);
            cefsharp.MenuHandler = new MenuHandler();
            //  cefsharp.RenderProcessMessageHandler = new RenderProcessMessageHandler();
            //cefsharp.LoadingStateChanged += (sender, args) =>
            //{
            //    //Wait for the Page to finish loading
            //    if (args.IsLoading == false)
            //    {
            //        cefsharp.ExecuteScriptAsync("ydb1('asdadaasdasdas我是杨道波')");
            //    }
            //};
            Console.WriteLine(cefsharp.IsLoading);

            cefsharp.FrameLoadEnd += (sender, args) =>
            {
                //Wait for the MainFrame to finish loading
                if (args.Frame.IsMain)
                {
                    var phonenumbser = new int[1, 2, 3, 4];
                   // cefsharp.ExecuteScriptAsync("ydb1", phonenumbser);
                   // args.Frame.ExecuteJavaScriptAsync("alert('MainFrame finished loading');");
                    cefsharp.ExecuteScriptAsync("ydb1", JsonConvert.SerializeObject(phonenumbser));
                    cefsharp.GetBrowser().MainFrame.ExecuteJavaScriptAsync("document.dispatchEvent(new CustomEvent('event_name', { detail: { para: 'pa12211ra' } }));");
                    isload = true;
                }
            };
            Console.WriteLine(cefsharp.IsLoading);
            //};

            //  umap.bb();
            //  umap.Reload();

            //阻止默认行为

            List<string> liststring = new List<string>();
            for (int i = 0; i < 302; i++)
            {
                liststring.Add(i.ToString());
            }
            var a = Math.Floor(liststring.Count / 100.0);
            var b = liststring.Count % 100;
            for (int i = 0; i < a; i++)
            {
                var c = liststring.Skip(i * 100).Take(100).ToList();
            }
            var d = liststring.Skip((int)a * 100).Take(b).ToList();

        }
        
        public void aa()
          {
           // cefsharp.ExecuteScriptAsync("page.drawmarker", 1);
           // return true;
          //  cefsharp.ExecuteScriptAsync("ydb2('asdadaasdasdas我是杨道波')");
        }
        /// <summary>
        /// 网页JS中调用的方法
        /// </summary>
        public   class CallbackObjectForJs
        {
            public void showMessage(string msg)
            {
              //  int a = msg;
                MessageBox.Show(msg);
            }
            public string action(string message)
            {
                //MessageBox.Show("测试");
                return "收到网页消息：" + message;
            }
           
        }
       
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Window win = new Window();
                CtlFlowView dtlview = new CtlFlowView();
                win.Content = dtlview;
                win.ShowDialog();
            }
        }

        //中
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.ChangeLanguage("zh");

            try
            {
                var emailAcount = "892936485@qq.com";
                var emailPassword = "这个就是刚刚获取的密码";
                var reciver = "这个是另外的一个QQ邮箱地址";
                var content = "这个是邮件内容";
                MailMessage message = new MailMessage();
                //设置发件人,发件人需要与设置的邮件发送服务器的邮箱一致
                MailAddress fromAddr = new MailAddress("892936485@qq.com");
                message.From = fromAddr;
                //设置收件人,可添加多个,添加方法与下面的一样
                message.To.Add(reciver);
                //设置抄送人
                message.CC.Add("这个是我准备的微软邮箱像这样的@outlook.com");
                //设置邮件标题
                message.Subject = "这个是邮箱标题";
                //设置邮件内容
                message.Body = content;
                //设置邮件发送服务器,服务器根据你使用的邮箱而不同,可以到相应的 邮箱管理后台查看,下面是QQ的
                SmtpClient client = new SmtpClient("smtp.qq.com", 25);
                //设置发送人的邮箱账号和密码
                client.Credentials = new NetworkCredential(emailAcount, emailPassword);
                //启用ssl,也就是安全发送
                client.EnableSsl = true;
                //发送邮件
                client.Send(message);
            }
            catch (Exception ex)
            {
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GlobalClass.ChangeLanguage("en");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GlobalClass.ChangeLanguage("es");
        }

        private void TextBox_TouchDown(object sender, TouchEventArgs e)
        {

        }

        private void txtChina_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            var w = this.Parent;
            //LocalData.KeyBoard(win, KeyboardTypeUser.china, this.txtChina);
        }

        private void ButtonJS_Click(object sender, RoutedEventArgs e)
        {
            List<int> phonenumbser = new List<int>() { 1, 2, 3, 4 };
            cefsharp.ExecuteScriptAsync("ydb1", JsonConvert.SerializeObject(phonenumbser));
            cefsharp.GetBrowser().MainFrame.ExecuteJavaScriptAsync("document.dispatchEvent(new CustomEvent('ydb1', { detail: { para: 'pa12211ra' } }));");
            Console.WriteLine(cefsharp.IsLoading);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // cefsharp.ExecuteScriptAsync("ydb1('asdadaasdasdas我是杨道波')");
        }
    }
    public class CefScript
    {
        //object lockObj = new object();
        //[STAThread]
        //public void createPoint(double x, double y, string name, string to)
        //{
        //    DialogBaseFactory.CurrentWindow.Dispatcher.Invoke(() =>
        //    {
        //        lock (lockObj)
        //        {
        //            //   var areas= Factory.FactoryContext
        //            var areas = FactoryContext.FindElements<T_Area>("T_Area");
        //            var area = areas.FirstOrDefault(s => s.Name == name || name.Contains(s.Name));
        //            if (area != null)
        //            {
        //                var query = DialogBaseFactory.DialogBaseList.Where(i => i is LD_CreateWarehouseDialog);
        //                DialogBase dialog = null;
        //                if (!query.Any())
        //                {
        //                    dialog = new LD_CreateWarehouseDialog();
        //                    DialogBaseFactory.RegisterScatterViewItem(dialog, 6);
        //                    dialog.Load();
        //                }
        //                else
        //                {
        //                    dialog = query.FirstOrDefault();
        //                }
        //        (dialog as LD_CreateWarehouseDialog).SetLocationName(name);
        //                dialog.Show();
        //            }
        //        }
        //    });
        //}

        //[STAThread]
        //public void refreshLine(double x, double y, string name, string to)
        //{
        //    DialogBaseFactory.CurrentWindow.Dispatcher.Invoke(() =>
        //    {
        //        lock (lockObj)
        //        {
        //            var areas = FactoryContext.FindElements<T_Area>("T_Area");
        //            var area = areas.FirstOrDefault(s => s.Name == to || to.Contains(s.Name));
        //            if (area != null)
        //            {
        //                var query = DialogBaseFactory.DialogBaseList.Where(i => i is LD_EmsDeployDialog);
        //                DialogBase dialog = null;
        //                if (!query.Any())
        //                {
        //                    dialog = new LD_EmsDeployDialog();
        //                    DialogBaseFactory.RegisterScatterViewItem(dialog, 6);
        //                }
        //                else
        //                {
        //                    dialog = query.FirstOrDefault();
        //                }
        //            (dialog as LD_EmsDeployDialog).SetEmsSetting(name, to);
        //                dialog.Show();
        //            }
        //        }
        //    });
        //}
    }
    public class MenuHandler : IContextMenuHandler
    {
        public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            model.Clear();
        }
        public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            return false;
        }
        public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {
        }
        public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
