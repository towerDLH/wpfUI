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
    /// MarkLine.xaml 的交互逻辑
    /// </summary>
    public partial class MarkLine : UserControl
    {
        public MarkLine()
        {
            InitializeComponent();
        }
        private PointCollection _points = new PointCollection();

        public delegate void Startaction(object sender, DragDeltaEventArgs e);
        public delegate void Endaction(object sender, DragDeltaEventArgs e);
        public event Startaction StartEvent;
        public event Startaction EndEvent;
        private void thmStart_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            Thumb thm = (Thumb)sender;
            double y = Canvas.GetTop(thm) + e.VerticalChange;
            double x = Canvas.GetLeft(thm) + e.HorizontalChange;
            Canvas.SetTop(thm, Canvas.GetTop(thm) + e.VerticalChange);
            Canvas.SetLeft(thm, Canvas.GetLeft(thm) + e.HorizontalChange);
            _points = this.DataPoints;
            this.DataPoints = new PointCollection()
            {
                new Point(x+thm.ActualWidth/2,y+thm.ActualHeight/2),
                _points[1]
            };
            if (StartEvent != null)
            {
                StartEvent.Invoke(sender, e);
            }
        }

        private void thmEnd_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            Thumb thm = (Thumb)sender;
            double y = Canvas.GetTop(thm) + e.VerticalChange;
            double x = Canvas.GetLeft(thm) + e.HorizontalChange;
            Canvas.SetTop(thm, Canvas.GetTop(thm) + e.VerticalChange);
            Canvas.SetLeft(thm, Canvas.GetLeft(thm) + e.HorizontalChange);
            _points = this.DataPoints;
            this.DataPoints = new PointCollection()
            {
                _points[0],
                new Point(x+thm.ActualWidth/2,y+thm.ActualHeight/2)
            };
            if (EndEvent != null)
            {
                EndEvent.Invoke(sender, e);
            }
        }



        #region 端点数据集


        public PointCollection DataPoints
        {
            get { return (PointCollection)GetValue(DataPointsProperty); }
            set { SetValue(DataPointsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DataPoints.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DataPointsProperty =
            DependencyProperty.Register("DataPoints", typeof(PointCollection), typeof(MarkLine), new PropertyMetadata(new PointCollection() { new Point(8, 8), new Point(16, 16) }, DataPointsChanged));

        private static void DataPointsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MarkLine line = (MarkLine)d;
            if (e.NewValue != e.OldValue)
            {
                //数据集改变时重新绘制线段和设置端点圆形位置
                PointCollection points = (PointCollection)e.NewValue;
                Canvas.SetTop(line.thmStart, points[0].Y - 8);
                Canvas.SetLeft(line.thmStart, points[0].X - 8);
                Canvas.SetTop(line.thmEnd, points[1].Y - 8);
                Canvas.SetLeft(line.thmEnd, points[1].X - 8);
            }
        }


        #endregion


    }
}
