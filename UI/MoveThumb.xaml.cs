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

namespace UI
{
    /// <summary>
    /// MoveThumb.xaml 的交互逻辑
    /// </summary>
    public partial class MoveThumb : UserControl
    {
        public double nTop = 0;
        public double nLeft = 0;
        public MoveThumb()
        {
            InitializeComponent();
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            UIElement thumb = e.Source as UIElement;
            var g = this.Parent as Panel;
            Thumb myThumb = (Thumb)sender;
            //    防止Thumb控件被拖出容器。  
            double nTop = Canvas.GetTop(myThumb) + e.VerticalChange;
            double nLeft = Canvas.GetLeft(myThumb) + e.HorizontalChange;
            //if (nLeft < 0 || nTop < 0  )
            //{
            //    return;
            //}
            Point ptChange = new Point(e.HorizontalChange, e.VerticalChange);
            Canvas.SetTop(myThumb, nTop);
            Canvas.SetLeft(myThumb, nLeft);
        }

        private void TextBlock_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string v;
            if (sender is TextBlock)
            {
                TextBlock ui = sender as TextBlock;
                Random r = new Random();
                var a = r.Next(10);
                v = a.ToString() + "," + ui.Text;
                DragDrop.DoDragDrop(ui, v, DragDropEffects.Link);
            }
            if (sender is Image)
            {
                Image ui = sender as Image;

                v = this.Name + "," + this.Name;

                DragDrop.DoDragDrop(ui, v, DragDropEffects.Link);
            }
        }
    }
}
