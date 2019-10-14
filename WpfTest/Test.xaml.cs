using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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

namespace WpfTest
{
    /// <summary>
    /// Test.xaml 的交互逻辑
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
            //AA.DispanName = "NameAge";
            //AA.SelectKey = "gid";
            Guid a = Guid.NewGuid();
            Guid b = Guid.NewGuid();
            Guid c = Guid.NewGuid();
            Guid d = Guid.NewGuid();
            List<student> students = new List<student>() { };
            students.Add(new student() { gid = a, NameAge = "张三" });
            students.Add(new student() { gid = b, NameAge = "里斯" });

            students.Add(new student() { gid = c, NameAge = "王五" });
            students.Add(new student() { gid = d, NameAge = "赵六" });

            List<student> select = new List<student>() { };
            select.Add(new student() { gid = a });
            select.Add(new student() { gid = b });
            Testclass test = new Testclass();
            test.Itemms = new ObservableCollection<object>(students);
            test.sellelist = new ObservableCollection<object>(select);
            test.selecttext = "aa";
            Ged.DataContext = test;
            Combox.ItemsSource = students;
            Combox.Text = "as";
            // var sitem=students.ForEach(t=>ts)
            //   Itemms   = new ObservableCollection<object>(students);
            //  sellelist = new ObservableCollection<object>(select);
        }

        private void border_MouseEnter(object sender, MouseEventArgs e)
        {
            //pop1.IsOpen = false;
            ////  pop1.IsOpen = true;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //   Debug.WriteLine(test.Itemms.Count);
            //Debug.WriteLine(AA.Items);
            //Debug.WriteLine(AA.SelectList);
        }
    }
    public class Testclass
    {
        //  private 
        public ObservableCollection<object> Itemms { get; set; }

        public ObservableCollection<object> sellelist { get; set; }

        public string selecttext { get; set; }
    }
    public class student
    {
        public string NameAge { get; set; }
        public Guid gid { get; set; }
    }

}
