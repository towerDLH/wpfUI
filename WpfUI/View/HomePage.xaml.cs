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

namespace WpfUI.View
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Window win = new Window();
                CtlFlowView dtlview = new CtlFlowView();
                win.Content = dtlview;
                win.ShowDialog();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnXz_Click(object sender, RoutedEventArgs e)
        {
           
        }
        Point m_offset = new Point(0, 0);
        bool m_isDrag = false;
        private void PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement el = (FrameworkElement)sender;
            m_offset = e.GetPosition(el);
            m_isDrag = true;
        }

        private void PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (m_isDrag && e.LeftButton == MouseButtonState.Pressed)
            {
                this.imageview.Cursor = Cursors.SizeAll;
                Point p = e.GetPosition((FrameworkElement)sender);
                double x = imageview.Margin.Left + (p.X - m_offset.X);
                double y = imageview.Margin.Top + (p.Y - m_offset.Y);
                if (Math.Abs(x) > 10 || Math.Abs(y) > 10)
                {
                    imageview.Margin = new Thickness(x, y, 0, 0);
                }
            }
        }

        private void PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (m_isDrag)
            {
                m_isDrag = false;
            }
            this.imageview.Cursor = Cursors.Arrow;
        }

    }
}
