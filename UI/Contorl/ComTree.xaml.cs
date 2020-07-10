using System;
using System.Collections;
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
using System.Collections.ObjectModel;
using UI.Model;
using System.Reflection;

namespace UI.Contorl
{
    /// <summary>
    /// ComTree.xaml 的交互逻辑
    /// </summary>
    public partial class ComTree : UserControl
    {
        public ComTree()
        {
            InitializeComponent();
        }
        private ObservableCollection<CbTree> cbtreelist = new ObservableCollection<CbTree>();

        public ObservableCollection<CbTree> CbTreeList
        {
            get { return cbtreelist; }
            set { cbtreelist = value; }
        }

        /// <summary>
        /// 父级集合
        /// </summary>

        public IEnumerable<object> ParList
        {
            get { return (IEnumerable<object>)GetValue(ParListProperty); }
            set { SetValue(ParListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ParList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ParListProperty =
            DependencyProperty.Register("ParList", typeof(IEnumerable<object>), typeof(ComTree), new PropertyMetadata(0));
        /// <summary>
        /// 子集集合
        /// </summary>
        public IEnumerable<object> ChildrenList
        {
            get { return (IEnumerable<object>)GetValue(ChildrenListProperty); }
            set { SetValue(ChildrenListProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ChildrenList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChildrenListProperty =
            DependencyProperty.Register("ChildrenList", typeof(IEnumerable<object>), typeof(ComTree), new PropertyMetadata(0));

        /// <summary>
        /// 选中的集合，选中的集合要和子集的类型一样
        /// </summary>
        public IEnumerable<object> SelectList
        {
            get { return (IEnumerable<object>)GetValue(SelectListProperty); }
            set { SetValue(SelectListProperty, value); }
        }
        // Using a DependencyProperty as the backing store for SelectList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectListProperty =
            DependencyProperty.Register("SelectList", typeof(IEnumerable<object>), typeof(ComTree), new PropertyMetadata(0));


        /// <summary>
        /// 显示的字段
        /// </summary>
        public string ViewName
        {
            get { return (string)GetValue(ViewNameProperty); }
            set { SetValue(ViewNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ViewName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewNameProperty =
            DependencyProperty.Register("ViewName", typeof(string), typeof(ComTree), new PropertyMetadata(0));




        public string Relationkey
        {
            get { return (string)GetValue(RelationkeyProperty); }
            set { SetValue(RelationkeyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Relationkey.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RelationkeyProperty =
            DependencyProperty.Register("Relationkey", typeof(string), typeof(CbTree), new PropertyMetadata(0));


        public void GetTreeListMD(IEnumerable<object> preantlist, IEnumerable<object> childernlist, IEnumerable<object> selectlist, string viewname, string relationkey)
        {
            //if (preantlist.Count() <= 0 || childernlist.Count() <= 0 || string.IsNullOrEmpty(viewname) || string.IsNullOrEmpty(relationkey)) return;
            //Type itemType = ChildrenList.GetType();
            //foreach (var item in preantlist)
            //{
            //    PropertyInfo[] ps = itemType.GetProperties();
            //    foreach (PropertyInfo property in ps)
            //    {
            //        object tmpValue = property.GetValue(item, null);
            //        object totalValue = property.GetValue(obj, null);

            //        if (property.PropertyType == typeof(int))
            //        {
            //            totalValue = (int)tmpValue + (int)totalValue;
            //            property.SetValue(obj, totalValue, null);
            //        }
            //        else if (property.PropertyType == typeof(double))
            //        {
            //            totalValue = (double)tmpValue + (double)totalValue;
            //            property.SetValue(obj, totalValue, null);
            //        }
            //    }
            //}
        }

        private void cxb_Node_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cbx = sender as CheckBox;
            var node = (sender as CheckBox).Tag as CbTree;
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
        private void CheckChild(CbTree node, bool isCheck)
        {
            if (node.Childen.Count > 0)
            {
                if (isCheck)
                {
                    foreach (CbTree item in node.Childen)
                    {
                        item.IsChecked = true;
                        CheckChild(item, true);
                    }
                }
                else
                {
                    foreach (CbTree item in node.Childen)
                    {
                        item.IsChecked = false;
                        CheckChild(item, false);
                    }
                }
            }
        }
        private void CheckParent(CbTree node)
        {
            if (node.Parent != null)
            {
                bool isCheck = true;
                foreach (CbTree item in node.Parent.Childen)
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


    public class CbTree : ObservableObject
    {
        private int id;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private ObservableCollection<CbTree> childen = new ObservableCollection<CbTree>();

        public ObservableCollection<CbTree> Childen
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
        private CbTree parent;

        public CbTree Parent
        {
            get { return parent; }
            set { parent = value; SetPerty("Parent"); }
        }

    }
}