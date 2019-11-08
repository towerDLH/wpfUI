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

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// RabuttonList.xaml 的交互逻辑
    /// </summary>
    public partial class RabuttonList : Window
    {
        public RabuttonList()
        {
            InitializeComponent();
            Loaded();
        }

        private void Loaded()
        {
            CbSex.Items.Insert(0, "请选择");
            var a = System.Enum.GetValues(typeof(Large.Subject));
            foreach (var item in a)
            {
                CbSex.Items.Add(item);
            }
            // CbSex.ItemsSource = a;
            //List<Subject> sublist = new List<Subject>();
            //foreach (var item in a)
            //{
            //    sublist.Add(new Subject()
            //    {
            //        Subid = (int)item,
            //        Selectid = 3,
            //        SubName = item.ToString(),
            //    });
            //}
            ListRad.ItemsSource = a;
            ListRad.SelectedItem = Large.Subject.数学;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = new Button();
            bt.Content = "张三";
            bt.Width = 100;
            bt.Height = 100;
            AA.Children.Add(bt);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (CbSex.SelectedItem.ToString() != "请选择")
            {
                int a = (int)(Large.Subject)CbSex.SelectedItem;
                MessageBox.Show(a.ToString());
            }
        }
    }
    public class Subject
    {
        private int subid;

        public int Subid
        {
            get { return subid; }
            set { subid = value; }
        }


        private int selectid;

        public int Selectid
        {
            get { return selectid; }
            set { selectid = value; }
        }


        private string subName;

        public string SubName
        {
            get { return subName; }
            set { subName = value; }
        }
    }
}
