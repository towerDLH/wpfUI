using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

namespace WpfApp3
{
    /// <summary>
    /// Window9.xaml 的交互逻辑
    /// </summary>
    public partial class Window9 : Window
    {
        List<Student> liststudes = new List<Student>();
        public Window9()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN");
            Thread.CurrentThread.CurrentCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy";
            //Storyboard sbd = Resources["sbCloud"]as Storyboard;
            //sbd.Begin();

            liststudes.Add(new Student() { Number = 1, Text = "张三" });
            liststudes.Add(new Student() { Number = 2, Text = "李四" });
            liststudes.Add(new Student() { Number = 3, Text = "王五" });
            liststudes.Add(new Student() { Number = 4, Text = "赵六" });
            mcom.ItemsSource = liststudes;
            mcom.DisplayMemberPath = "Number";
            mcom.SelectedValuePath = "Text";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string a = "\\\\192.168.0.114\\File\\7eadbf4a-6828-41b5-bbdf-6e7475dc64ae.docx";
            var b = a.Replace("/", "/");
          //  Regex.Unescape();
            MessageBox.Show(b);
            if (YearRa?.IsChecked ?? false)
            {
                MessageBox.Show("年");

            }
            if (YueRa?.IsChecked ?? false)
            {
                MessageBox.Show("月");
            }
            ad.Text = "\xe6b1";
        }

      

    }
}
