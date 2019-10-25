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
using WpfApp3.Model;
using System.Collections.ObjectModel;
using System.Threading;

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// ListView.xaml 的交互逻辑
    /// </summary>
    public partial class ListView : Window
    {
        private Timer UpdateScrollTimer = null;//消失状态计时器
        ObservableCollection<Student> liststudnts = new ObservableCollection<Student>();
        public ListView()
        {
            InitializeComponent();
            //  this.DataContext = new Person();


            liststudnts.Add(new Student() { Name="张三",Age=18,Score=100,Ficon= "\xe6b1", FiClor="Green"});
            liststudnts.Add(new Student() { Name = "李四", Age = 18, Score = 98, Ficon = "\xe6b0",FiClor = "Red" });
            liststudnts.Add(new Student() { Name = "赵武", Age = 18, Score = 97, Ficon = "\xe6b2", FiClor = "Gold" });
            liststudnts.Add(new Student() { Name = "孙兵", Age = 18, Score = 96, Ficon = "" });
            liststudnts.Add(new Student() { Name = "王二", Age = 18, Score = 95, Ficon = "" });
            //for (int i = 0; i < 5; i++)
            //{
            //    liststudnts.Add(new Student()
            //    {
            //        Name = ($"{i}1"),
            //        Age = i,
            //        Score = i
            //    });
            //}
            item.ItemsSource = liststudnts;
            UpdateScrollTimer = new Timer(UpdateScrollTimerCallBack, null, 2000, Timeout.Infinite);
            //  a.ItemsSource = liststudnts;
        }

        private void UpdateScrollTimerCallBack(object state)
        {
            this.Dispatcher.Invoke(() =>
            {
                if (this.liststudnts.Count > 0)
                    this.liststudnts.RemoveAt(2);//2s后从头部开始消失
                this.liststudnts.Insert(2, new Student()
                {
                    Name = "张三",
                    Age = 12,
                    Score = 98,
                });
            });
            if (UpdateScrollTimer != null)
                UpdateScrollTimer.Change(5000, Timeout.Infinite);
        }
    }
    public class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        private string ficon;

        public string Ficon
        {
            get { return ficon; }
            set { ficon = value; }
        }

        private string fiClor;

        public string FiClor
        {
            get { return fiClor; }
            set { fiClor = value; }
        }
        

    }
}
