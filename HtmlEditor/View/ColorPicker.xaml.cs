using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.XPath;

namespace Msl.HtmlEditor
{
    public partial class ColorPicker : UserControl
    {
        private bool IsRaiseColorChangedEvent = true;
        private static readonly string SourceColorPath = @"/htmleditor/visualmode/color/add/@value";
        public event EventHandler<PropertyChangedEventArgs<Color>> SelectedColorChanged;
        public ColorPicker()
        {
            InitializeComponent();
            InitColors();
        }
        public Color SelectedColor
        {
            get { return (Color)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }
        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorPicker),
                new UIPropertyMetadata(Colors.Transparent, new PropertyChangedCallback(OnSelectedColorPropertyChanged)));
        private static void OnSelectedColorPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ColorPicker control = sender as ColorPicker;
            if (control != null && control.SelectedColorChanged != null && control.IsRaiseColorChangedEvent)
                control.SelectedColorChanged(control, PropertyChangedEventArgs<Color>.Create((Color)e.NewValue));
        }
        public void Reset()
        {
            IsRaiseColorChangedEvent = false;
            StandardColors.SelectedItem = null;
            SelectedColor = Color.FromRgb(0x01, 0x01, 0x01);
            IsRaiseColorChangedEvent = true;
        }
        private void InitColors()
        {
            List<Tool.MyItem> ls = new List<Tool.MyItem>();
            using (XmlReader reader = XmlTextReader.Create(Glo.EditorConfigPath))
            {
                XPathDocument xmlDoc = new XPathDocument(reader);
                XPathNodeIterator it = xmlDoc.CreateNavigator().Select(SourceColorPath);
                while (it.MoveNext())
                    ls.Add(new Tool.MyItem() { Name = it.Current.Value, Value = it.Current.Value });
            }
            if (ls.Count == 0)
                return;

            StandardColors.ItemsSource = ls;
        }
        private void HandleSelect(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem lbi = sender as ListBoxItem;

            if (lbi == null)
                return;
            try
            {
                string val = ((Tool.MyItem)(lbi).Content).Value;
                SelectedColor = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(val);
            }
            catch (Exception)
            {

            }
        }
    }
    public class PropertyChangedEventArgs<T> : EventArgs
    {
        private PropertyChangedEventArgs() { }

        public T Value { get; private set; }

        public static PropertyChangedEventArgs<T> Create(T val)
        {
            return new PropertyChangedEventArgs<T>() { Value = val };
        }
    }
}
