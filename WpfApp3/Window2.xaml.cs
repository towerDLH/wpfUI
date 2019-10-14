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

namespace WpfApp3
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            Loaded();
        }

        private void Loaded()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Number = 0, Text = "张三" });
            students.Add(new Student() { Number = 2, Text = "李四" });
            students.Add(new Student() { Number = 3, Text = "王五" });
            students.Add(new Student() { Number = 4, Text = "赵六" });
            A.ItemsSource = students;
            A.DisplayMemberPath = "Text";
            A.SelectedValuePath = "Text";
            A.SelectedIndex = 1;
            //  A.SelectedItem=
            InsStateCombox.ItemsSource = System.Enum.GetValues(typeof(SelectInsSubEnumResult));
        }
    }
    public enum SelectInsSubEnumResult
    {
        /// <summary>
        /// 请选择
        /// </summary>
        请选择 = 1245,
        /// <summary>
        /// 
        /// </summary>
        合格 =10010,
        /// <summary>
        /// 
        /// </summary>
        不合格 = 10011,


    }
}
