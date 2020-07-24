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

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// BombDropper.xaml 的交互逻辑
    /// </summary>
    public partial class BombDropper : Window
    {
        public BombDropper()
        {
            InitializeComponent();
        }

        private void canTest1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            RectangleGeometry rect = new RectangleGeometry();
            rect.Rect = new Rect(0, 0, canTest1.ActualWidth, canTest1.ActualHeight);
            canTest1.Clip = rect;
        }

        private void BtnGeam_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
