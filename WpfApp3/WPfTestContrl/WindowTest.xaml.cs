using LiveCharts;
using LiveCharts.Wpf;
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
using UI;
using UI.Model;
using Util.Controls;

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// WindowTest.xaml 的交互逻辑
    /// </summary>
    public partial class WindowTest : WindowsBase
    {
        public EqupmentRece bs;
        public WindowTest()
        {
            InitializeComponent();
            bs = new EqupmentRece();
            LineSeries mylineseries = new LineSeries();

            //设置折线的标题
            mylineseries.Title = "温度";
            //折线图直线形式
            mylineseries.LineSmoothness = 0;
            mylineseries.PointGeometry = DefaultGeometries.Circle;
            //折线图的无点样式
            mylineseries.PointGeometry = null;

            LineSeries mylineseries1 = new LineSeries();

            //设置折线的标题
            mylineseries1.Title = "湿度";
            //折线图直线形式
            //mylineseries1.LineSmoothness = 0;
            mylineseries1.PointGeometry = DefaultGeometries.Circle;
            //折线图的无点样式
            mylineseries1.PointGeometry = null;
            //添加横坐标
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Labels.Add(list[i].order_create_time.ToString());
            //    temp[i] = list.Where(t => t.order_create_time < list[i].order_create_time).Count();
            //}
            List<string> numberlist = new List<string>();
            var temp = new double[8];
            for (int i = 0; i < 8; i++) //如果数据库中的数据没有要求横坐标的长度时
            {
                temp[i] = i * 2;
                numberlist.Add(i.ToString());
            }
            mylineseries.Values = new ChartValues<double>(temp);
            bs.SeriesCollection.Add(mylineseries);
            bs.Labels = numberlist;
            this.DataContext = bs;
        }
    }

    public class EqupmentRece : ObservableObject
    {
        private SeriesCollection seriescollection = new SeriesCollection();

        public SeriesCollection SeriesCollection
        {
            get { return seriescollection; }
            set { seriescollection = value; SetPerty("SeriesCollection"); }
        }
        private List<string> labels = new List<string>();

        public List<string> Labels
        {
            get { return labels; }
            set { labels = value; SetPerty("Labels"); }
        }

        //public SeriesCollection SeriesCollection { get; set; }
        //public List<string> Labels { get; set; }

    }
}
