using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    [TemplatePart(Name = "Dtg", Type = typeof(TextBlock))]
    [ContentProperty("Items")]
    [DefaultProperty("Items")]
    public class IconButton : Button
    {
        private const string Dtg = "Ctx";
        /// <summary>
        /// 下拉列表框显示的表格
        /// </summary>
        TextBlock txt;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Bindable(true)]
        public Collection<object> Items { get; }

        internal static readonly DependencyPropertyKey HasItemsPropertyKey =
            DependencyProperty.RegisterReadOnly(nameof(HasItems), typeof(bool), typeof(IconButton),
                new PropertyMetadata(false));
        public static readonly DependencyProperty HasItemsProperty = HasItemsPropertyKey.DependencyProperty;


        public bool HasItems => (bool)GetValue(HasItemsProperty);
        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton), new FrameworkPropertyMetadata(typeof(IconButton)));

        }



        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(IconButton),   new PropertyMetadata(0)  );

         

        public IconButton()
        {
            var items = new ObservableCollection<object>();
            items.CollectionChanged += (s, e) =>
            {
                if (e.NewItems != null && e.NewItems.Count > 0)
                {
                    SetValue(HasItemsPropertyKey, true);
                }
                OnItemsChanged(s, e);
            };
            Items = items;
            A();
        }
        /// <summary>
        /// 在应用模板的方法
        /// </summary>
        public override void OnApplyTemplate()
        {
            txt = GetTemplateChild(Dtg) as TextBlock;
            txt.Text = "dsfasfsadf";
        }
        public void A()
        {
          
            //var index = Items.Count;
            //this.dataGrid = UI.IconButton.ZbExternt.GetChildObject<DataGrid>(this.popup.Child, "PART_popupDataGrid");
        }
        protected virtual void OnItemsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // Refresh();
            // UpdateItems();
        }

    }
}
