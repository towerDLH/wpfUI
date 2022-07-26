using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfUI.Extension
{
    /// <summary>
    /// 全局类
    /// </summary>
    public static class GlobalClass
    {
        static bool? inDesignMode = null;
        /// <summary>
        /// 判断是设计器还是程序运行
        /// </summary>
        public static bool InDesignMode
        {
            get
            {
                if (inDesignMode == null)
                {
#if SILVERLIGHT
                    inDesignMode = DesignerProperties.IsInDesignTool;
#else
                    var prop = DesignerProperties.IsInDesignModeProperty;
                    inDesignMode = (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;

                    if (!inDesignMode.GetValueOrDefault(false) && Process.GetCurrentProcess().ProcessName.StartsWith("devenv", StringComparison.Ordinal))
                        inDesignMode = true;
#endif
                }

                return inDesignMode.GetValueOrDefault(false);
            }
        }
        /// <summary>
        /// 语言改变通知事件
        /// </summary>
        public static EventHandler<EventArgs> LanguageChangeEvent;
        static Resource StringResource;
        static GlobalClass()
        {
            StringResource = new Resource();
        }
        /// <summary>
        /// 获取资源内容
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetString(string key)
        {
            return StringResource.GetString(key);
        }
        /// <summary>
        /// 改变语言
        /// </summary>
        /// <param name="language">CultureInfo列表(http://www.csharpwin.com/csharpspace/8948r7277.shtml)</param>
        public static void ChangeLanguage(string language)
        {
            CultureInfo culture = new CultureInfo(language);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            StringResource.CurrentCulture = culture;

            if (LanguageChangeEvent != null)
            {
                LanguageChangeEvent(null, null);
            }
        }
    }
}
