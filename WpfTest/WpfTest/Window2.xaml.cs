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

namespace WpfTest
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            Guid a = Guid.NewGuid();
            Guid b = Guid.NewGuid();
            Guid c = Guid.NewGuid();
            Guid d = Guid.NewGuid();
            List<student> students = new List<student>() { };
            students.Add(new student() { gid = a, NameAge = "张三" });
            students.Add(new student() { gid = b, NameAge = "里斯" });
            students.Add(new student() { gid = c, NameAge = "王五" });
            students.Add(new student() { gid = d, NameAge = "赵六" });
            students.Add(new student() { gid = a, NameAge = "张三" });
            students.Add(new student() { gid = b, NameAge = "里斯" });
            students.Add(new student() { gid = c, NameAge = "王五" });
            students.Add(new student() { gid = d, NameAge = "赵六" });
            students.Add(new student() { gid = a, NameAge = "张三" });
            students.Add(new student() { gid = b, NameAge = "里斯" });
            students.Add(new student() { gid = c, NameAge = "王五" });
            students.Add(new student() { gid = d, NameAge = "赵六" });
            students.Add(new student() { gid = a, NameAge = "张三" });
            students.Add(new student() { gid = b, NameAge = "里斯" });
            students.Add(new student() { gid = c, NameAge = "王五" });
            students.Add(new student() { gid = d, NameAge = "赵六" });
            students.Add(new student() { gid = a, NameAge = "张三" });
            students.Add(new student() { gid = b, NameAge = "里斯" });
            students.Add(new student() { gid = c, NameAge = "王五" });
            students.Add(new student() { gid = d, NameAge = "赵六" });
            students.Add(new student() { gid = a, NameAge = "张三" });
            students.Add(new student() { gid = b, NameAge = "里斯" });
            students.Add(new student() { gid = c, NameAge = "王五" });
            students.Add(new student() { gid = d, NameAge = "赵六" });
            students.Add(new student() { gid = a, NameAge = "张三" });
            students.Add(new student() { gid = b, NameAge = "里斯" });
            students.Add(new student() { gid = c, NameAge = "王五" });
            students.Add(new student() { gid = d, NameAge = "赵六" });

            grd.DataContext = students;
            ObjForTest root = new ObjForTest() { MD = new tStudent("root", "root", 0, "a", 0) };
            ObjForTest c1 = new ObjForTest() { MD = new tStudent("CEO", "Leo", 45, "M", 1) };
            ObjForTest c2 = new ObjForTest() { MD = new tStudent("CFO", "Tami", 46, "FM", 1) };
            ObjForTest c3 = new ObjForTest() { MD = new tStudent("COO", "Jack", 47, "M", 1) };
            ObjForTest cc1 = new ObjForTest() { MD = new tStudent("Manager", "John", 30, "M", 2) };
            ObjForTest cc2 = new ObjForTest() { MD = new tStudent("Manager", "Lee", 31, "FM", 2) };
            ObjForTest cc3 = new ObjForTest() { MD = new tStudent("Manager", "Chris", 32, "M", 2) };
            ObjForTest ccc1 = new ObjForTest() { MD = new tStudent("Worker", "Evan", 25, "FM", 3) };
            ObjForTest ccc2 = new ObjForTest() { MD = new tStudent("Worker1", "Evan", 25, "FM", 3) };
            ObjForTest ccc3= new ObjForTest() { MD = new tStudent("Worker1", "Evan", 25, "FM", 3) };
            ObjForTest ccc4 = new ObjForTest() { MD = new tStudent("Worker1", "Evan", 25, "FM", 3) };
            ObjForTest ccc5 = new ObjForTest() { MD = new tStudent("Worker1", "Evan", 25, "FM", 3) };
            ObjForTest ccc6 = new ObjForTest() { MD = new tStudent("Worker1", "Evan", 25, "FM", 3) };
            ObjForTest ccc7 = new ObjForTest() { MD = new tStudent("Worker1", "Evan", 25, "FM", 3) };
            ObjForTest ccc8 = new ObjForTest() { MD = new tStudent("Worker1", "Evan", 25, "FM", 3) };
            ObjForTest ccc9 = new ObjForTest() { MD = new tStudent("Worker1", "Evan", 25, "FM", 3) };
            root.ChildNodes.Add(c1);
            root.ChildNodes.Add(c2);
            root.ChildNodes.Add(c3);
            c1.ChildNodes.Add(cc1);
            c2.ChildNodes.Add(cc2);
            c3.ChildNodes.Add(cc3);
            ccc1.ChildNodes.Add(ccc2);
            ccc2.ChildNodes.Add(ccc3);
            ccc3.ChildNodes.Add(ccc4);
            ccc4.ChildNodes.Add(ccc5);
            ccc5.ChildNodes.Add(ccc6);
            // cc1.Children.Add(ccc1);
            List<ObjForTest> a1 = new List<ObjForTest>();
            a1.Add(root);
            AA.Items = a1;
            //Text.Focus();
            foreach (var item in a1)
            {
                Index.Items.Add(new ComboBoxItem { Content = 1 });
            }
          
            Index.Items.Add(new ComboBoxItem { Content = 2});
          //  this.ActiveControl = ASD;
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox obj = sender as ComboBox;
            if ((obj.SelectedItem as ComboBoxItem).Content.ToString() == "全部展开")
            {
                AA.IsExpent = true;
            }
            if ((obj.SelectedItem as ComboBoxItem).Content.ToString() == "收起")
            {
                AA.IsExpent = false;
            }
        }

        private void TreeViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void AddPm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        private void TextBoxGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox source = e.Source as TextBox;

            if (source != null)
            {
                // Change the TextBox color when it obtains focus.
                source.Background = Brushes.LightBlue;

                // Clear the TextBox.
                source.Clear();
            }
        }

        private void TextBoxLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox source = e.Source as TextBox;

            if (source != null)
            {
                // Change the TextBox color when it loses focus.
                source.Background = Brushes.White;

                // Set the  hit counter back to zero and updates the display.
               // this.ResetCounter();
            }
        }

        private void _base_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("确定退出程序？", "提示", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }

    public class Sex {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
