﻿using System;
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


        /// <summary>
        /// todo 下拉树应该满足一下特点 是否选中 父子级
        /// </summary>

        public IEnumerable<CbTree> CbItemSource
        {
            get { return (IEnumerable<CbTree>)GetValue(CbItemSourceProperty); }
            set { SetValue(CbItemSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CbItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CbItemSourceProperty =
            DependencyProperty.Register("CbItemSource", typeof(IEnumerable<object>), typeof(ComTree), new PropertyMetadata(0));



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




        public string ChildName
        {
            get { return (string)GetValue(ChildNameProperty); }
            set { SetValue(ChildNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ChildName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChildNameProperty =
            DependencyProperty.Register("ChildName", typeof(string), typeof(ComTree), new PropertyMetadata(0));

        


        public string Relationkey
        {
            get { return (string)GetValue(RelationkeyProperty); }
            set { SetValue(RelationkeyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Relationkey.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RelationkeyProperty =
            DependencyProperty.Register("Relationkey", typeof(string), typeof(CbTree), new PropertyMetadata(0));


        //public void GetTreeListMD(IEnumerable<object> cbItemSource, IEnumerable<object> selectlist, string viewname,string Relationkey)
        //{
        //    if (cbItemSource.Count() <= 0 || string.IsNullOrEmpty(viewname) || string.IsNullOrEmpty(Relationkey) ) return;
        //    GetTreeSource(cbItemSource, selectlist, Relationkey, se);
        //    Type itemType = cbItemSource.GetType();
        //    //将拿到的类型转成树形下拉的类型
        //    foreach (var item in cbItemSource)
        //    {
        //        PropertyInfo[] ps = itemType.GetProperties();
        //        foreach (PropertyInfo property in ps)
        //        {
        //            object tmpValue = property.GetValue(item, null);
        //            //  object totalValue = property.GetValue(obj, null);
        //            if (property.Name == ChildName)
        //            {
        //                //递归取值
        //            }

        //        }
        //    }
        //}

        
        

        public void GetTreeSource(IEnumerable<object> sroucelis, string Relationkey, IEnumerable<object> selectlist)
        {
            foreach (var item in sroucelis)
            {
                PropertyInfo[] ps = item.GetType().GetProperties();
                foreach (PropertyInfo property in ps)
                {
                    object tmpValue = property.GetValue(item, null);
                    if (property.Name == Relationkey)
                    {
                        if (selectlist.Contains(property.GetValue(item, null)))
                        property.SetValue("IsChecked", true, null);
                    }
                    //  object totalValue = property.GetValue(obj, null);
                    if (property.Name == ChildName)
                    {
                        //递归取值
                          IEnumerable<object> childs= property.GetValue(item, null) as IEnumerable<object>;
                        if (childs.Count() > 0)
                        {
                            GetTreeSource(childs, Relationkey, selectlist);
                        }
                    }

                }
            }
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

        private bool ispart;

        public bool IsPart
        {
            get { return ispart; }
            set
            {
                ispart = value;
                SetPerty("IsPart");
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