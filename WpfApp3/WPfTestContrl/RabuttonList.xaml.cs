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
            var a = System.Enum.GetValues(typeof(Large.Subject));
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
