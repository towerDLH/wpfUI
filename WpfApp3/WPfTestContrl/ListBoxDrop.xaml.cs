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

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// ListBoxDrop.xaml 的交互逻辑
    /// </summary>
    public partial class ListBoxDrop : Window
    {
        ObservableCollection<bar> bars = new ObservableCollection<bar>();
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
            for (int i = 0; i < 5; i++)
            {
                bars.Add(new bar() { IcoName = $"{i}", IcoImage =  $"/WpfApp3;component/Image/{i}.jpg" });
            }
            listBox1.ItemsSource = bars;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            leftMouseflag = true;
            Image image = sender as Image;
            this.Img.Source = image.Source;
            Point point = e.GetPosition(null);
            this.Img.SetValue(Canvas.LeftProperty, point.X);
            this.Img.SetValue(Canvas.TopProperty, point.Y - 5.0);
            this.Img.Visibility = Visibility.Visible;
        }
        private void LayoutRoot_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            //如果得知鼠标左键松动的位置是右边的ListBox上时则为右边的ListBox添加一列
            Point point = e.GetPosition(null);

            if (point.X > 400 && point.X < 450 && point.Y < 400 && leftMouseflag == true)
            {
                string bimg = this.Img.Source.ToString() ;
                this.Img.Visibility = Visibility.Collapsed;
                AddiphoneList.Add(new bar()
                {
                    IcoName = "2",
                    IcoImage = bimg
                });
                this.listBox2.ItemsSource = null;
                this.listBox2.ItemsSource = AddiphoneList;
            }
            else
            {
                this.Img.Visibility = Visibility.Collapsed;
                this.Img.Source = null;
            }
            leftMouseflag = false;
        }

        private void LayoutRoot_MouseMove(object sender, MouseEventArgs e)
        {
            //让图片跟随鼠标的移动而移动
            Point point = e.GetPosition(null);
            this.Img.SetValue(Canvas.LeftProperty, point.X);
            this.Img.SetValue(Canvas.TopProperty, point.Y - 5.0);
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
