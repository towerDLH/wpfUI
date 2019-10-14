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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loading();
        }
        public void Loading()
        {
            List<Mould> moulds = new List<Mould>() { };
            List<gongxu> tumModels = new List<gongxu>() { };
            moulds.Add(new Mould() { mouldMode_code = "AAA", mouldName = " 不锈钢粉" });
            moulds.Add(new Mould() { mouldMode_code = "BBB", mouldName = "塑料" });
            tumModels.Add(new gongxu() { gongxuID = "1", gongxuName = "dd" });
            tumModels.Add(new gongxu() { gongxuID = "2", gongxuName = "ddd" });
            MouldList.ItemsSource = moulds;
            //gongxulist.ItemsSource = tumModels;
        }

        private void Gongxulist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //gongxu a = new gongxu();
            //a = gongxulist.SelectedItem as gongxu;

        }

        private void MouldList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mould m = new Mould();
            m = MouldList.SelectedItem as Mould;
        }

        private void PopupOutSidePanel_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            if (sender == e.OriginalSource)
            {
               
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void border_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }
    }
    internal class Mould
    {
        public string mouldMode_code { get; set; }
        public string mouldName { get; set; }
    }
    internal class TumModel
    {
        public List<Mould> mouls { get; set; }
        public List<gongxu> gongxus { get; set; }
    }
    internal class gongxu
    {
        public string gongxuID { get; set; }
        public string gongxuName { get; set; }
    }
}
