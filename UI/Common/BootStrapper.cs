using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UI.Base;
using UI.Interface;

namespace UI.Common
{
    public class BootStrapper
    {
        /// <summary>
        /// 注册方法
        /// </summary>
        public static void Initialize(IAutoFacLocator autoFacLocator, Assembly asb)
        {
            ServiceProvider.RegisterServiceLocator(autoFacLocator);
            ServiceProvider.Instance.Register(asb);
        }
    }
}
