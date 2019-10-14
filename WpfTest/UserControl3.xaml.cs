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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTest
{
    /// <summary>
    /// UserControl3.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();

        }
        public IEnumerable<ObjForTest> Items
        {
            get { return (IEnumerable<ObjForTest>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(IEnumerable<ObjForTest>), typeof(UserControl3), new PropertyMetadata(new List<ObjForTest>()));



        public int SelectExpent
        {
            get { return (int)GetValue(SelectExpentProperty); }
            set { SetValue(SelectExpentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectExpent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectExpentProperty =
            DependencyProperty.Register("SelectExpent", typeof(int), typeof(UserControl3), new PropertyMetadata(0));



        public bool IsExpent
        {
            get { return (bool)GetValue(IsExpentProperty); }
            set { SetValue(IsExpentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsExpent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsExpentProperty =
            DependencyProperty.Register("IsExpent", typeof(bool), typeof(UserControl3), new PropertyMetadata(false));


        private static void change(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            //_list.ItemsSource=
        }
        //取消
        private void UnChoice_Checked(object sender, RoutedEventArgs e)
        {

        }
        //全选
        private void Choice_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Choices_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _base_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
    }
    public class ObjForTest  
    {

        private tStudent mD;

        public tStudent MD
        {
            get { return mD; }
            set { mD = value; }
        }

        private ObservableCollection<ObjForTest> _children = new ObservableCollection<ObjForTest>();
        public ObservableCollection<ObjForTest> ChildNodes
        {
            get { return _children; }
        }
    }
    public class tStudent :INotifyPropertyChanged
    {
        public tStudent(string title, string name, int age, string sex, int level)
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
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
