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
    /// workflowContrl.xaml 的交互逻辑
    /// </summary>
    public partial class workflowContrl : UserControl
    {
        public workflowContrl()
        {
            InitializeComponent();
        }

        private void thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            Thumb myThumb = (Thumb)sender;
            Canvas.SetLeft(this, Canvas.GetLeft(myThumb) + e.HorizontalChange);
            Canvas.SetTop(this, Canvas.GetTop(myThumb) + e.VerticalChange);
        }

        private void link_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string v;
            if (sender is TextBlock)
            {
                TextBlock ui = sender as TextBlock;

                v = this.Name + "," + ui.Text;

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
