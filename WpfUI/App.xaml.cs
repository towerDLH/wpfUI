using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
            //Add Custom assembly resolver
            AppDomain.CurrentDomain.AssemblyResolve += Resolver;

            //Any CefSharp references have to be in another method with NonInlining
            // attribute so the assembly rolver has time to do it's thing.
            InitializeCefSharp();
        }
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void InitializeCefSharp()
        {
            var settings = new CefSettings();

            // Set BrowserSubProcessPath based on app bitness at runtime
            settings.BrowserSubprocessPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                                                   Environment.Is64BitProcess ? "x64" : "x86",
                                                   "CefSharp.BrowserSubprocess.exe");

            // Make sure you set performDependencyCheck false
            Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);
        }
        private static Assembly Resolver(object sender, ResolveEventArgs args)
        {
            if (args.Name.StartsWith("CefSharp"))
            {
                string assemblyName = args.Name.Split(new[] { ',' }, 2)[0] + ".dll";
                string archSpecificPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                                                       Environment.Is64BitProcess ? "x64" : "x86",
                                                       assemblyName);

                return File.Exists(archSpecificPath)
                           ? Assembly.LoadFile(archSpecificPath)
                           : null;
            }

            return null;
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
