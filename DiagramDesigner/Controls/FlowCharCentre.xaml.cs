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

namespace DiagramDesigner.Controls
{
    /// <summary>
    /// FlowCharCentre.xaml 的交互逻辑
    /// </summary>
    public partial class FlowCharCentre : UserControl
    {


        public object FlowContent
        {
            get { return (object)GetValue(FlowContentProperty); }
            set { SetValue(FlowContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FlowContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FlowContentProperty =
            DependencyProperty.Register("FlowContent", typeof(object), typeof(FlowCharCentre), new PropertyMetadata(null));



        public FlowCharCentre()
        {
            InitializeComponent();
        }
    }
}
