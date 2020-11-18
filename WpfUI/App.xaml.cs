using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using UI.Base;
using UI.Common;
using UI.Interface;

namespace WpfUI
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.DispatcherUnhandledException += new System.Windows.Threading.DispatcherUnhandledExceptionEventHandler(App_DispatcherUnhandledException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }
        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is System.Exception)
            {
                LogHelper.ErrorLog(null, (System.Exception)e.ExceptionObject);
            }
        }

        public static void HandleException(Exception ex)
        {
            LogHelper.ErrorLog(null, ex);
        }
        void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            LogHelper.ErrorLog(null, e.Exception);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.ConfigureServices();
            var dialog = ServiceProvider.Instance.Get<IModelDialog>("LoginViewDlg");
            //// var dialog = ServiceProvider.Instance.Get<IModelDialog>("MainViewDlg");
            dialog.BindDefaultViewModel();
            dialog.ShowDialog();
        }

        /// <summary>
        /// 启动项注册
        /// </summary>
        protected void ConfigureServices()
        {
            AutofacLocator autofacLocator = new AutofacLocator();  //创建IOC容器
            Assembly asm = Assembly.GetExecutingAssembly();
            autofacLocator.Register(asm);   //注册服务
            BootStrapper.Initialize(autofacLocator, asm);
        }
    }
}
