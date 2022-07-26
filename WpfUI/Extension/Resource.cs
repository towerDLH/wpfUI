using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI.Extension
{
    public interface IResource
    {
        string GetString(string name);
        CultureInfo CurrentCulture { set; }
    }
    public class Resource : IResource
    {
        private ResourceManager stringResource;
        //我们这样设置的时候ResourceManager会去查找MultilanguageTest.StringResource.en-us.resx,如果没有会查找MultilanguageTest.StringResource.resx
        private CultureInfo culture = new CultureInfo("zh");
        public Resource()
        {
            //MultilanguageTest.StringResource是根名称，该实例使用指定的System.Reflection.Assmbly查找从指定的跟名称导出的文件中包含的资源
            stringResource = new ResourceManager("WpfUI.Resouce.Langs.lang", typeof(Resource).Assembly);
        }
        /// <summary>
        /// 通过资源名称获取资源内容
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetString(string name)
        {
            return stringResource.GetString(name, culture);
        }
        /// <summary>
        /// 改变当前的区域信息，ResourceManager可以通过当前区域信息去查找.resx文件
        /// </summary>
        public CultureInfo CurrentCulture
        {
            set
            {
                culture = value;
            }
        }
    }
}
