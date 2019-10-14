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
using System.Windows.Shapes;
using System.ComponentModel;
namespace WpfApp3
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        private student Model;
        public Window1()
        {
            Model = new student();
            InitializeComponent();
            //  grd.DataContext = GetNum();
            var a = System.Enum.GetValues(typeof(Stuent));
            cmboxStretch.ItemsSource = System.Enum.GetValues(typeof(Stuent));
        }

        public double Add(double one, double two)

        {

            return one + two;

        }



        public string Add(string arg1, string arg2)

        {

            int x = 0;

            int y = 0;

            if (int.TryParse(arg1, out x) && int.TryParse(arg2, out y))

            {

                return this.Add(x, y).ToString();

            }

            else

            {

                return "Input Error!";

            }

        }
        private List<student> GetNum()
        {
            //decimal a = (decimal)-1.12;
            //MessageBox.Show(a.ToString());
            Guid a = Guid.NewGuid();
            Guid b = Guid.NewGuid();
            Guid c = Guid.NewGuid();
            Guid d = Guid.NewGuid();
            List<student> students = new List<student>() { };
            students.Add(new student() { Userid = a, NameAge = "张三", Age = 12 });
            students.Add(new student() { Userid = b, NameAge = "里斯", Age = 12 });
            students.Add(new student() { Userid = c, NameAge = "王五", Age = 12 });
            students.Add(new student() { Userid = d, NameAge = "赵六", Age = 12 });
            students.Add(new student() { Userid = a, NameAge = "张三", Age = 12 });
            students.Add(new student() { Userid = b, NameAge = "里斯", Age = 12 });
            students.Add(new student() { Userid = c, NameAge = "王五", Age = 34 });
            students.Add(new student() { Userid = d, NameAge = "赵六", Age = 54 });
            students.Add(new student() { Userid = a, NameAge = "张三", Age = 12 });
            students.Add(new student() { Userid = b, NameAge = "里斯", Age = 43 });
            students.Add(new student() { Userid = c, NameAge = "王五", Age = 12 });
            students.Add(new student() { Userid = d, NameAge = "赵六", Age = 23 });
            students.Add(new student() { Userid = a, NameAge = "张三", Age = 86 });
            students.Add(new student() { Userid = b, NameAge = "里斯", Age = 87 });
            students.Add(new student() { Userid = c, NameAge = "王五", Age = 678 });
            students.Add(new student() { Userid = d, NameAge = "赵六", Age = 45 });
            students.Add(new student() { Userid = a, NameAge = "张三", Age = 23 });
            students.Add(new student() { Userid = b, NameAge = "里斯", Age = 12 });
            students.Add(new student() { Userid = c, NameAge = "王五", Age = 12 });
            students.Add(new student() { Userid = d, NameAge = "赵六", Age = 23 });
            students.Add(new student() { Userid = a, NameAge = "张三", Age = 12 });
            students.Add(new student() { Userid = b, NameAge = "里斯", Age = 12 });
            students.Add(new student() { Userid = c, NameAge = "王五", Age = 12 });
            students.Add(new student() { Userid = d, NameAge = "赵六", Age = 12 });
            students.Add(new student() { Userid = a, NameAge = "张三", Age = 12 });
            students.Add(new student() { Userid = b, NameAge = "里斯", Age = 12 });
            students.Add(new student() { Userid = c, NameAge = "王五", Age = 12 });
            students.Add(new student() { Userid = d, NameAge = "赵六", Age = 12 });
            return students;
        }





        private class student : INotifyPropertyChanged
        {

            private Guid userid;

            public Guid Userid
            {
                get { return userid; }
                set
                {
                    userid = value;
                    SetName("Userid");
                }
            }
            private string nameAge;

            public string NameAge
            {
                get { return nameAge; }
                set
                {
                    nameAge = value;
                    SetName("NameAge");
                }
            }

            public int age;
            public int Age { get { return age; } set { age = value; SetName("Age"); } }

            public event PropertyChangedEventHandler PropertyChanged;
            public void SetName(string propertyName)
            {
                PropertyChangedEventHandler handler = this.PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        private enum Stuent
        {
            男 = 1,
            女 = 2

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = cmboxStretch.SelectedItem;
            var b = (Stuent)a;
            //if(a=) Stuent.女
        }
    }
    
        
    }

