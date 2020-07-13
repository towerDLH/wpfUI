using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using UI.Model;

namespace UI.Contorl
{
    /// <summary>
    /// TreeCombox.xaml 的交互逻辑
    /// </summary>
    public partial class TreeCombox : UserControl
    {
        public TreeCombox()
        {
            InitializeComponent();
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            // _ListBoxH.ItemsSource = Threes;
            //_ListBoxV.SelectionChanged += _ListBoxV_SelectionChanged;
            // _ListBoxH.SelectionChanged += _ListBoxH_SelectionChanged;

            if (Threes != null)
            {
                GetTreeList(Threes, SeleComs);
            }
        }

        public void GetTreeList(ObservableCollection<Treemodel> trees, ObservableCollection<Treemodel> selects)
        {
            foreach (var item in trees)
            {
                Treemodel bdc = item as Treemodel;
                if (selects.FirstOrDefault(t => t.ID == item.ID && (!item.IsParent)) != null)
                {
                    item.IsChecked = true;
                }
                if (bdc.Childen.Count > 0)
                {
                    GetTreeList(bdc.Childen, selects);
                }
            }

        }


        public ObservableCollection<Treemodel> Threes
        {
            get { return (ObservableCollection<Treemodel>)GetValue(ThreesProperty); }
            set { SetValue(ThreesProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Threes.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThreesProperty =
            DependencyProperty.Register("Threes", typeof(IEnumerable<Treemodel>), typeof(TreeCombox), new PropertyMetadata(new ObservableCollection<Treemodel>()));



        public ObservableCollection<Treemodel> SeleComs
        {
            get { return (ObservableCollection<Treemodel>)GetValue(SeleComsProperty); }
            set { SetValue(SeleComsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SeleComs.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SeleComsProperty =
            DependencyProperty.Register("SeleComs", typeof(ObservableCollection<Treemodel>), typeof(TreeCombox), new PropertyMetadata(new ObservableCollection<Treemodel>()));


        private void cxb_Node_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cbx = sender as CheckBox;
            var node = (sender as CheckBox).Tag as Treemodel;
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
        private void CheckChild(Treemodel node, bool isCheck)
        {
            if (node.Childen.Count > 0)
            {
                if (isCheck)
                {
                    foreach (Treemodel item in node.Childen)
                    {
                        item.IsChecked = true;
                        if (!item.IsParent && SeleComs.FirstOrDefault(t => t.ID == item.ID) == null)
                        {
                            SeleComs.Add(item);
                        }
                        CheckChild(item, true);
                    }
                }
                else
                {
                    foreach (Treemodel item in node.Childen)
                    {
                        item.IsChecked = false;
                        var reveitem = SeleComs.FirstOrDefault(t => t.ID == item.ID);
                        if (reveitem != null)
                        {
                            SeleComs.Remove(reveitem);
                        }
                        CheckChild(item, false);
                    }
                }
            }
        }
        private void CheckParent(Treemodel node)
        {
            if (node.Parent != null)
            {
                var selectitem = SeleComs.FirstOrDefault(t => t.ID == node.ID);
                if (node.IsChecked && !node.IsParent)
                {
                    if (selectitem == null)
                    {
                        node.IsChecked = true;
                        SeleComs.Add(node);
                    }
                }
                else if (!node.IsChecked && !node.IsParent)
                {
                    if (selectitem != null)
                    {
                        SeleComs.Remove(selectitem);
                    }
                }
                bool isCheck = true;
                foreach (Treemodel item in node.Parent.Childen)
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

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cbx = sender as CheckBox;
            var node = (sender as CheckBox).Tag as Treemodel;
            if (node.Parent.Childen.FirstOrDefault(t => t.IsChecked == false) != null)
            {
                node.Parent.IsChecked = false;
            }
            var reveitem = SeleComs.FirstOrDefault(t => t.ID == node.ID);
            if (reveitem != null)
            {
                SeleComs.Remove(reveitem);
            }
        }
    }
    public class Treemodel : ObservableObject
    {
        private Guid id;

        public Guid ID
        {
            get { return id; }
            set { id = value; SetPerty("ID"); }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; SetPerty("Name"); }
        }
        private ObservableCollection<Treemodel> childen = new ObservableCollection<Treemodel>();

        public ObservableCollection<Treemodel> Childen
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
        private bool isParent;

        public bool IsParent
        {
            get { return isParent; }
            set { isParent = value; }
        }


        private Treemodel parent;

        public Treemodel Parent
        {
            get { return parent; }
            set { parent = value; SetPerty("Parent"); }
        }

    }
}
