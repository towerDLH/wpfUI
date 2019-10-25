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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp3.Model;

namespace WpfApp3
{
    /// <summary>
    /// ListView.xaml 的交互逻辑
    /// </summary>
    public partial class ListView : Window
    {
        public ListView()
        {
            InitializeComponent();
            this.DataContext = new Person();
            InitializeComponent();
            list.ItemsSource = Person.Get();
        }

        private void enter(object sender, RoutedEventArgs e)
        {
            Storyboard sbd = Resources["sbCloud"] as Storyboard;
            sbd.Begin();
        }

        private void endBtn(object sender, RoutedEventArgs e)
        {
            Storyboard sbd = Resources["sbCloud"] as Storyboard;
            //sbd.RepeatBehaviorRepeatBehavior.Forever
            //    RepeatBehavior.Forever
        }
    }
}
