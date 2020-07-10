using DiagramDesigner.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Collections.ObjectModel;
using Brushes = System.Windows.Media.Brushes;

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// WindowHtml.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHtml : Window
    {
        public List<Phone> _selectedOrgs = new List<Phone>();
        public WindowHtml()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            ObservableCollection<Phone> childs = new ObservableCollection<Phone>();
            childs.Add(new Phone { ID = 1, Name = "子集1" });
            childs.Add(new Phone { ID = 2, Name = "子集2" });
            childs.Add(new Phone { ID = 3, Name = "子集3" });
            for (int i = 0; i < 8; i++)
            {
                var phoneitem = new Phone() { ID = i, Name = $"张三1{i}" };
                phoneitem.Childen = new ObservableCollection<Phone>()
                {
                    new Phone { ID = 1, Name = "子集1" ,Parent=phoneitem},
                    new Phone { ID = 2, Name = "子集2" ,Parent=phoneitem}
                };
                 Phones.Add(phoneitem);
            }
        }
        private ObservableCollection<Phone> phones = new ObservableCollection<Phone>();

        public ObservableCollection<Phone> Phones
        {
            get { return phones; }
            set { phones = value; }
        }




        private DateTime seleDate;

        public DateTime SeleDate
        {
            get { return seleDate; }
            set { seleDate = value; }
        }

        private async void BtnAsay_Click(object sender, RoutedEventArgs e)
        {
            var task = Task.Delay(2000);
            await task;
            this.rect.Fill = Brushes.Black;
        }
        private void CheckChild(Phone node, bool isCheck)
        {
            if (node.Childen.Count > 0)
            {
                if (isCheck)
                {
                    foreach (Phone item in node.Childen)
                    {
                        item.IsChecked = true;
                        CheckChild(item, true);
                    }
                }
                else
                {
                    foreach (Phone item in node.Childen)
                    {
                        item.IsChecked = false;
                        CheckChild(item, false);
                    }
                }
            }
        }

        private void cxb_Node_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cbx = sender as CheckBox;
            var node = (sender as CheckBox).Tag as Phone;
            if (node != null && cbx.IsChecked != null)
            {
                if (cbx.IsChecked.Value)
                {
                    CheckChild(node, true);
                }
                else
                {
                    CheckChild(node, false);
                }
                CheckParent(node);
                //btnSelected.Tag = string.Join(",", _selectedOrgs.ToList().ConvertAll(a => a.ORG_NAME));
            }
        }
        private void CheckParent(Phone node)
        {
            if (node.Parent != null)
            {
                bool isCheck = true;
                foreach (Phone item in node.Parent.Childen)
                {
                    if (!item.IsChecked)
                    {
                        isCheck = false;
                    }
                }
                if (isCheck)
                {
                    node.Parent.IsChecked = true;
                }
                else
                {
                    node.Parent.IsChecked = false;
                }
                if (node.Parent.Parent != null)
                {
                    CheckParent(node.Parent);
                }
            }
        }
    }
    public class Phone : ObservableObject
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private ObservableCollection<Phone> childen = new ObservableCollection<Phone>();

        public ObservableCollection<Phone> Childen
        {
            get { return childen; }
            set { childen = value; SetPerty("Childen"); }
        }
        private Visibility checkvisiable = Visibility.Visible;

        public Visibility CheckVisiable
        {
            get { return checkvisiable = Visibility.Visible; }
            set { checkvisiable = value; SetPerty("CheckVisiable"); }
        }

        private bool ischecked;

        public bool IsChecked
        {
            get { return ischecked; }
            set
            {
                ischecked = value;
                SetPerty("IsChecked");
            }
        }
        private Phone parent;

        public Phone Parent
        {
            get { return parent; }
            set { parent = value; SetPerty("Parent"); }
        }

    }
}