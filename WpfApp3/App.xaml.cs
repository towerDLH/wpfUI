using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using log4net;
namespace WpfApp3
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

            // 初始化语言
            Language = string.IsNullOrEmpty(Language) ? "Lanage-E" : Language;

            var splashScreen = new SplashScreen("Image/2.jpg");
            splashScreen.Show(true);
        }

        private static string language;

        public static string Language
        {
            get { return language; }
            set
            {
                if (language != value)
                {
                    language = value;
                    List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
                    foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
                    {
                        dictionaryList.Add(dictionary);
                    }
                    string requestedLanguage = string.Format(@"/WpfApp3;component/Lanage/{0}.xaml", Language);
                    ResourceDictionary resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedLanguage));
                    if (resourceDictionary == null)
                    {
                        requestedLanguage = @"/WpfApp3;component/Lanage/Lanage-E.xaml";
                        resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedLanguage));
                    }
                    if (resourceDictionary != null)
                    {
                        Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
                        Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
                    }
                }
            }
        }
    }
}
 
