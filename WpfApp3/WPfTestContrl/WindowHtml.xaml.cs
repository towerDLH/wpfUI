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
using System.Reflection;
using UI.Contorl;
using UI;
using System.ComponentModel;
using System.Windows.Media.Animation;

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// WindowHtml.xaml 的交互逻辑
    /// </summary>
    public partial class WindowHtml : WindowsBase
    {
        public List<Phone> _selectedOrgs = new List<Phone>();
        public WindowHtml()
        {
            InitializeComponent();
            DoubleAnimation widction = new DoubleAnimation();
            widction.To = 50;
            widction.From = 120;
            widction.Duration = TimeSpan.FromSeconds(5);
            widction.RepeatBehavior = RepeatBehavior.Forever;
            cmd.BeginAnimation(Button.WidthProperty, widction);

            DoubleAnimation hightction = new DoubleAnimation();
            hightction.To = 50;
            hightction.From = 120;
            hightction.Duration = TimeSpan.FromSeconds(5);
            hightction.RepeatBehavior = RepeatBehavior.Forever;
            cmd.BeginAnimation(Button.HeightProperty, hightction);
            // this.Closed += WinClosee;
            // Load();
        }

        private void WinClosee(object sender, EventArgs e)
        {

        }

        public void Load()
        {
            List<Game> games = new List<Game>();
            List<Banji> banjis = new List<Banji>();
            ObservableCollection<Treemodel> trees = new ObservableCollection<Treemodel>();
            ObservableCollection<Treemodel> childs = new ObservableCollection<Treemodel>();
            childs.Add(new Treemodel { ID = Guid.NewGuid(), Name = "子集1", IsParent = true });
            childs.Add(new Treemodel { ID = Guid.NewGuid(), Name = "子集2", IsParent = true });
            childs.Add(new Treemodel { ID = Guid.NewGuid(), Name = "子集3", IsParent = true });
            for (int i = 0; i < 8; i++)
            {
                var phoneitem = new Treemodel() { ID = Guid.Empty, Name = $"张三1{i}" };
                phoneitem.Childen = new ObservableCollection<Treemodel>()
                {
                    new Treemodel { ID = Guid.NewGuid(), Name = "子集1" ,Parent=phoneitem},
                    new Treemodel { ID = Guid.NewGuid(), Name = "子集2" ,Parent=phoneitem}
                };
                trees.Add(phoneitem);
                banjis.Add(new Banji() { BanjiHao = i, BanjiName = $"班级{i}", Temperature = 20 + i, Humidity = 21 + i });
                games.Add(new Game(20 + i, 22 + i));
            }
            // banjis.Add(new Banji() { BanjiHao = 1, BanjiName = $"班级1", BanjiName1 = "2323" });
            CbTest.ItemsSource = banjis;
            cTree.Threes = trees;
            // LoaCr(childs);

            ObservableCollection<Banji> listbanji = new ObservableCollection<Banji>(banjis);
            // ListRoce.ItemsSource = games;
        }

        public void LoaCr(ObservableCollection<Phone> cbItemSource)
        {
            foreach (var item in cbItemSource)
            {

                PropertyInfo[] ps = item.GetType().GetProperties();
                foreach (PropertyInfo property in ps)
                {
                    object tmpValue = property.GetValue(item, null);
                    //object totalValue = property.GetValue(obj, null);
                    if (property.Name == "Child")
                    {
                        //递归取值
                    }

                }
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox cb = sender as ComboBox;
            var a = cb.SelectedItem;
        }

        private void CbTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            var a = cb.SelectedItem;
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

    public class Banji : INotifyPropertyChanged
    {
        private int banjiHao;

        public int BanjiHao
        {
            get { return banjiHao; }
            set { banjiHao = value; }
        }

        private double temperature;

        public double Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Temperature"));
                }
            }
        }
        private int humidity;

        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        private string banjiName;

        public string BanjiName
        {
            get { return banjiName; }
            set { banjiName = value; }
        }
        private string banjiName1;

        public string BanjiName1
        {
            get { return banjiName1; }
            set { banjiName1 = value; }
        }
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
    public class Game : INotifyPropertyChanged
    {
        private double score;

        public double Score
        {
            get { return score; }
            set
            {
                score = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Score"));
                }
            }
        }
        private int humidity;

        public int Humidity
        {
            get { return humidity; }
            set
            {
                humidity = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Humidity"));
                }
            }
        }

        public Game(double scr, int humty)
        {
            this.Score = scr;
            this.Humidity = humty;
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}