using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfUI.Extension
{
    [MarkupExtensionReturnType(typeof(BindingExpression))]
    public class StringResourceExtension : MarkupExtension, INotifyPropertyChanged
    {
        /// <summary>
        /// 资源的名称，与资源文件StringResource.resx对应
        /// </summary>
        [ConstructorArgument("key")]
        public string Key
        {
            get;
            set;
        }
        string _DefaultValue;
        /// <summary>
        /// 默认值，为了使在设计器的情况时把默认值绑到设计器
        /// </summary>
        public string DefaultValue
        {
            get
            {
                return _DefaultValue;
            }
            set
            {
                _DefaultValue = value;
            }
        }
        string _Value;
        /// <summary>
        /// 资源的具体内容，通过资源名称也就是上面的Key找到对应内容
        /// </summary>
        public string Value
        {
            get
            {
                ///如果为设计器模式,本地的资源没有实例化，我们不能从资源文件得到内容，所以从KEY或默认值绑定到设计器去
                if (GlobalClass.InDesignMode)
                {
                    if (Key != null && DefaultValue != null)
                        return DefaultValue;
                    if (Key == null && DefaultValue != null)
                        return DefaultValue;
                    if (Key != null && DefaultValue == null)
                        return Key;
                    if (Key == null && DefaultValue == null)
                        return "NULL";
                }
                else
                {
                    if (Key != null)
                    {
                        string strResault = null;
                        try
                        {
                            strResault = GlobalClass.GetString(Key);
                        }
                        catch
                        {
                        }
                        if (strResault == null)
                        {
                            strResault = _DefaultValue;
                        }
                        return strResault;
                    }
                }
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        public StringResourceExtension(string key)
            : this()
        {
            Key = key;
            GlobalClass.LanguageChangeEvent += new EventHandler<EventArgs>(Language_Event);
        }
        public StringResourceExtension(string key, string DefaultValue)
            : this()
        {
            Key = key;
            _DefaultValue = DefaultValue;
            GlobalClass.LanguageChangeEvent += new EventHandler<EventArgs>(Language_Event);

        }
        public StringResourceExtension()
        {
        }
        /// <summary>
        /// 每一标记扩展实现的 ProvideValue 方法能在可提供上下文的运行时使用 IServiceProvider。然后会查询此 IServiceProvider 以获取传递信息的特定服务
        ///当 XAML 处理器在处理一个类型节点和成员值，且该成员值是标记扩展时，它将调用该标记扩展的 ProvideValue 方法并将结果写入到对象关系图或序列化流,XAML 对象编写器将服务环境通过 serviceProvider 参数传递到每个此类实现。
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            IProvideValueTarget target = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;

            Setter setter = target.TargetObject as Setter;
            if (setter != null)
            {
                return new Binding("Value") { Source = this, Mode = BindingMode.OneWay };
            }
            else
            {
                Binding binding = new Binding("Value") { Source = this, Mode = BindingMode.OneWay };
                return binding.ProvideValue(serviceProvider);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        static readonly System.ComponentModel.PropertyChangedEventArgs
            valueChangedEventArgs = new System.ComponentModel.PropertyChangedEventArgs("Value");

        protected void NotifyValueChanged()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, valueChangedEventArgs);
        }
        /// <summary>
        /// 语言改变通知事件，当程序初始化的时候会绑定到全局的GlobalClass.LanguageChangeEvent事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Language_Event(object sender, EventArgs e)
        {
            //通知Value值已经改变，需重新获取
            NotifyValueChanged();
        }
    }
}
