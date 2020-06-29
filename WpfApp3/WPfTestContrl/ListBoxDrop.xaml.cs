using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp3.Model;
using System.Collections.ObjectModel;
using System.Collections;

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// ListBoxDrop.xaml 的交互逻辑
    /// </summary>
    public partial class ListBoxDrop : Window
    {
        ObservableCollection<bar> bars = new ObservableCollection<bar>();
        ObservableCollection<string> zoneList = new ObservableCollection<string>();
        bool leftMouseflag = false;
        /// <summary>
        /// 右边ListBox的结果集合
        /// </summary>
        private static List<bar> AddiphoneList = new List<bar>();
        public ListBoxDrop()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            foreach (TimeZoneInfo tzi in TimeZoneInfo.GetSystemTimeZones())
            {
                zoneList.Add(tzi.ToString());
            }
            lbOne.ItemsSource = zoneList;
        }


        ListBox dragSource = null;
        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));
            if (data != null)
            {
                DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            }
        }
        #region GetDataFromListBox(ListBox,Point)
        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }

                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }

            return null;
        }

        #endregion
        private void ListBox_Drop(object sender, DragEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            object data = e.Data.GetData(typeof(string));
            ((IList)dragSource.ItemsSource).Remove(data);
            parent.Items.Add(data);
        }
    }
    public class bar : Brushback
    {
        private string icoimage;

        public string IcoImage
        {
            get { return icoimage; }
            set
            {
                icoimage = value;
                SetPart("IcoImage");
            }
        }
        private string iconame;

        public string IcoName
        {
            get { return iconame; }
            set
            {
                iconame = value;
                SetPart("IcoName");
            }
        }
    }
}
