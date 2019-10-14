using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace WpfApp3
{
    /// <summary>
    /// Window4.xaml 的交互逻辑
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            ObjForTest root = new ObjForTest("root", "root", 0, "", 0);
            ObjForTest c1 = new ObjForTest("CEO", "Leo", 45, "M", 1);
            ObjForTest c2 = new ObjForTest("CFO", "Tami", 46, "FM", 1);
            ObjForTest c3 = new ObjForTest("COO", "Jack", 47, "M", 1);
            ObjForTest cc1 = new ObjForTest("Manager", "John", 30, "M", 2);
            ObjForTest cc2 = new ObjForTest("Manager", "Lee", 31, "FM", 2);
            ObjForTest cc3 = new ObjForTest("Manager", "Chris", 32, "M", 2);
            ObjForTest ccc1 = new ObjForTest("Worker", "Evan", 25, "FM", 3);
            root.Children.Add(c1);
            root.Children.Add(c2);
            root.Children.Add(c3);
            c1.Children.Add(cc1);
            c2.Children.Add(cc2);
            c3.Children.Add(cc3);
            cc1.Children.Add(ccc1);
        //    this._list.ItemsSource = root.Children;
            List<Students> students = new List<Students>();
            List<Result> results = new List<Result>();
            results.Add(new Result() { Num1=1});
            results.Add(new Result() { Num1 = 2 });
            results.Add(new Result() { Num1 = 3 });
            students.Add(new Students()
            {
                Name = "张三",
                Age = "28",
                Results = results
            });
          //  dataGrid1.ItemsSource = students;
        }
    }
    public class Students
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public List<Result> Results { get; set; }
    }
    public class Result
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }

    }

    public class ObjForTest : INotifyPropertyChanged
    {
        public ObjForTest(string title, string name, int age, string sex, int level)
        {
            this._jobTitle = title;
            this._sex = sex;
            this._age = age;
            this._name = name;
            this._level = level;
        }
        private string _name;
        private int _age;
        private string _sex;
        private int _level;
        private string _jobTitle;

        public string Sex { get { return this._sex; } set { this._sex = value; } }
        public int Age { get { return this._age; } set { this._age = value; } }
        public int Level
        {
            get
            {
                return this._level;
            }
            set
            {
                _level = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Level"));
            }
        }
        public string JobTitle
        {
            get { return _jobTitle; }
            set
            {
                _jobTitle = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("JobTitle"));
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private ObservableCollection<ObjForTest> _children = new ObservableCollection<ObjForTest>();
        public ObservableCollection<ObjForTest> Children
        {
            get { return _children; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
 
}
