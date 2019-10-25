using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
namespace WpfApp3
{
    /// <summary>
    /// CharLive.xaml 的交互逻辑
    /// </summary>
    public partial class CharLive : Window
    {
        public SeriesCollection SeriesCollection { get; set; }
        public List<string> Labels { get; set; }
        private double _trend;
        private double[] temp = { 1, 3, 2, 4, -3, 5, 2, 1 };
        public CharLive()
        {
            LineSeries mylineseries = new LineSeries();
            mylineseries.Foreground = new SolidColorBrush(Colors.White);
            //设置折线的标题
            mylineseries.Title = "aa";
            //折线图直线形式
            mylineseries.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries.PointGeometry = null;
            //添加横坐标
            Labels = new List<string> { "1", "3", "2", "4", "-3", "5", "2", "1" };
            //添加折线图的数据
            mylineseries.Values = new ChartValues<double>(temp);
            SeriesCollection = new SeriesCollection { };
            SeriesCollection.Add(mylineseries);
            _trend = 8;
            linestart();
            DataContext = this;
        }
        //连续折线图的方法
        public void linestart()
        {
            Task.Run(() =>
            {
                var r = new Random();
                while (true)
                {
                    int i = 1;
                    Thread.Sleep(2000);
                    _trend = r.Next(-10, 10);
                    //通过Dispatcher在工作线程中更新窗体的UI元素
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //更新横坐标时间
                        Labels.Add(DateTime.Now.ToString());
                        Labels.RemoveAt(0);
                        //更新纵坐标数据
                        SeriesCollection[0].Values.Add(_trend);
                        SeriesCollection[0].Values.RemoveAt(0);
                    });
                }
            });
        }
    }
}