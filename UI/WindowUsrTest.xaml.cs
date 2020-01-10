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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// WindowUsrTest.xaml 的交互逻辑
    /// </summary>
    public partial class WindowUsrTest : UserControl
    {
        public WindowUsrTest()
        {
            InitializeComponent();
            List<Subject> sublist = new List<Subject>();
            for (int i = 0; i < 10; i++)
            {
                sublist.Add(new Subject()
                {
                    Subid = i,
                    Selectid = 3,
                    SubName = i + "a",
                });
            }
            gtdRegistNum.ItemsSource = sublist;
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
