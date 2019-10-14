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

namespace Teststyle
{
    /// <summary>
    /// BorderButton.xaml 的交互逻辑
    /// </summary>
    public partial class BorderButton : UserControl
    {
        public BorderButton()
        {
            InitializeComponent();
        }


        public int TestIndex
        {
            get { return (int)GetValue(TestIndexProperty); }
            set { SetValue(TestIndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TestIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TestIndexProperty =
            DependencyProperty.Register("TestIndex", typeof(int), typeof(BorderButton), new PropertyMetadata(0, testChange));

        private static void testChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
