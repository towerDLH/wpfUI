using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// MovContonl.xaml 的交互逻辑
    /// </summary>
    public partial class MovContonl : Window
    {
        public MovContonl()
        {
            InitializeComponent();
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            Thumb myThumb = (Thumb)sender;
            double nTop = Canvas.GetTop(myThumb) + e.VerticalChange;
            double nLeft = Canvas.GetLeft(myThumb) + e.HorizontalChange;
            Canvas.SetTop(myThumb, nTop);
            Canvas.SetLeft(myThumb, nLeft);
            tt.Text = "Top:" + nTop.ToString() + "\nLeft:" + nLeft.ToString();
        }

        private void Thumb_DragStarted(object sender, DragStartedEventArgs e)
        {
            tt.Text = "哈哈 这个玩意可以拖";
        }

        private void Thumb_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            tt.Text = "终于拖结束了";
        }
    }
}
