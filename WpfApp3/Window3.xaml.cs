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

namespace WpfApp3
{
    /// <summary>
    /// Window3.xaml 的交互逻辑
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
          //  this.dataGrid1.ItemsSource = CityInformation.GetInfo();
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            UIElement thumb = e.Source as UIElement;

            //    防止Thumb控件被拖出容器。  
            //    if (nTop <= 0)
            //        nTop = 0;
            //    if (nTop >= (g.Height - myThumb.Height))
            //        nTop = g.Height - myThumb.Height;
            //    if (nLeft <= 0)
            //        nLeft = 0;
            //    if (nLeft >= (g.Width - myThumb.Width))
            //        nLeft = g.Width - myThumb.Width;
            //    Canvas.SetTop(myThumb, nTop);
            //    Canvas.SetLeft(myThumb, nLeft);
            //    tt.Text = "Top:" + nTop.ToString() + "\nLeft:" + nLeft.ToString();


            Canvas.SetLeft(thumb, Canvas.GetLeft(thumb) + e.HorizontalChange);
            Canvas.SetTop(thumb, Canvas.GetTop(thumb) + e.VerticalChange);
        }
    }
    public class CityInformation
    {
        public bool OnlineOrderFlag { get; set; }
        public string AddrName { get; set; }
        public string CityName { get; set; }
        public string TelNum { get; set; }
        public double TotalSum { get; set; }
        public static List<CityInformation> GetInfo()
        {
            return new List<CityInformation>()
{
new CityInformation() { AddrName="四川", CityName = "成都", TelNum="123", TotalSum = 1.23 },
new CityInformation() { AddrName="广东", CityName = "广州", TelNum="234", TotalSum = 1.23 },
new CityInformation() { AddrName="广西", CityName = "南宁", TelNum="0152", TotalSum = 1.23 },
new CityInformation() { AddrName="贵州", CityName = "贵阳", TelNum="0123", TotalSum = 1.23 },
new CityInformation() { AddrName="四川", CityName = "成都", TelNum="123", TotalSum = 10.23 }
};
        }
    }
}
