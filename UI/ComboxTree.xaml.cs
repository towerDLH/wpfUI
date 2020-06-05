using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// ComboxTree.xaml 的交互逻辑
    /// </summary>
    public partial class ComboxTree : UserControl
    {
        private ObservableCollection<PmCategoryTreeModel> DataSource = new ObservableCollection<PmCategoryTreeModel>();
        private PmCategoryTreeModel CurrentTreeModel = new PmCategoryTreeModel();
        private List<PmCategoryTreeModel> GetTree(Guid id, List<PmCategoryTreeModel> nodes)
        {
            var mainNodes = nodes.Where(x => x.fatherId == id).ToList<PmCategoryTreeModel>();
            var otherNodes = nodes.Where(x => x.fatherId != id).ToList<PmCategoryTreeModel>();
            foreach (PmCategoryTreeModel dpt in mainNodes)
            {
                dpt.Nodes = new ObservableCollection<PmCategoryTreeModel>(GetTree(dpt.id, otherNodes));
            }
            return mainNodes;
        }
        public ComboxTree()
        {
            InitializeComponent();
        }
        private bool IsInDesignMode
        {
            get { return DesignerProperties.GetIsInDesignMode(this); }
        }

        private PmCategoryTreeModel _selectItemed;
        
        public Guid SelctConbox
        {
            get { return (Guid)GetValue(SelctConboxProperty); }
            set
            {
                SetValue(SelctConboxProperty, value);
                // var q=   pmcateComboBox.Items
                //利用递归找到显示的值
                // 然后然其展开
                var tritem = Getid(DataSource, value);
                if (tritem != null)
                {
                    pmcateComboBox.Items[0] = tritem.nodeName;
                    pmcateComboBox.SelectedItem = pmcateComboBox.Items[0];
                }
               // pmcateComboBox.DataContext = GetTree(Guid.Empty, LoadAllMd());
            }
        }

        public PmCategoryTreeModel seleItem;
        public PmCategoryTreeModel Getid(ObservableCollection<PmCategoryTreeModel> Tree, Guid gid)
        {

            foreach (PmCategoryTreeModel item in Tree)
            {
                if (item.id == gid)
                {
                    seleItem = item;
                    return item;
                }
                else
                {
                    if (item.Nodes.Count > 0)
                    {
                        Getid(item.Nodes, gid);
                    }
                }
            }
            return seleItem;
        }
        // Using a DependencyProperty as the backing store for SelctConbox.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelctConboxProperty =
            DependencyProperty.Register("SelctConbox", typeof(Guid), typeof(ComboxTree), new PropertyMetadata(Guid.Empty, SelectOnchange));

        private static void SelectOnchange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ComboxTree combox = d as ComboxTree;
            combox.SelctConbox = (Guid)e.NewValue;
        }


        /// <summary>
        /// 加载树的数据源
        /// </summary>
        /// <returns></returns>
        //private List<PmCategoryTreeModel> LoadAllMd()
        //{
        //    //var list = bs.LoadAllMd();
        //    //var result = new List<PmCategoryTreeModel>();
        //    //result.Add(new PmCategoryTreeModel() { Nodes = new ObservableCollection<PmCategoryTreeModel>(), fatherId = Guid.Empty, nodeName = "请选择" });
        //    //if (list != null && list.Any())
        //    //{
        //    //    foreach (var model in list)
        //    //    {
        //    //        var treeModel = new PmCategoryTreeModel()
        //    //        {
        //    //            fatherId = model.fatherid,
        //    //            nodeName = model.categoryname,
        //    //            id = model.pmcategoryid,
        //    //            Nodes = new ObservableCollection<PmCategoryTreeModel>(),
        //    //            IsSelected = SelctConbox == model.pmcategoryid,
        //    //            IsExpanded = SelctConbox == model.pmcategoryid,
        //    //        };
        //    //        result.Add(treeModel);
        //    //        //   AllDataSource.Add(treeModel);
        //    //    }
        //    //}
        //    //return result;
        //}
        private void lftTree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                var a = e.NewValue as PmCategoryTreeModel;
                CurrentTreeModel = a;
            }
            catch (Exception ex)
            {

            }
        }
        private void OrgaComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (CurrentTreeModel == null) return;
            pmcateComboBox.Items[0] = CurrentTreeModel.nodeName;
            pmcateComboBox.SelectedItem = pmcateComboBox.Items[0];
            //  SelectItemed = CurrentTreeModel;
            SelctConbox = CurrentTreeModel?.id ?? Guid.Empty;
            //if (ComboSelected != null)
            //{
            //    ComboSelected.Invoke(sender);
            //}
        }


        private void PmcateComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (SelectionSelected != null)
            //{
            //    SelectionSelected.Invoke(sender);
            //}
        }

        public IEnumerable<object> Items
        {
            get { return (IEnumerable<object>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(IEnumerable<object>), typeof(ComboxTree), new PropertyMetadata(null, Itemschange));

        private static void Itemschange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ComboxTree tobj = d as ComboxTree;
            tobj.Items = (IEnumerable<object>)e.NewValue;
        }

         

        private void txt_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }
    }
    public class PmCategoryTreeModel : INotifyPropertyChanged
    {

        private ObservableCollection<PmCategoryTreeModel> _nodes;
        /// <summary>
        /// 子节点
        /// </summary>
        public ObservableCollection<PmCategoryTreeModel> Nodes
        {
            get
            {
                return _nodes;
            }
            set
            {
                if (_nodes != value)
                {
                    _nodes = value;
                    startEvent("Nodes");
                }
            }
        }

        public PmCategoryTreeModel()
        {
            this.Nodes = new ObservableCollection<PmCategoryTreeModel>();
            this.fatherId = Guid.Empty;//主节点的父id默认为0
        }

        private Guid _id;

        /// <summary>
        /// id
        /// </summary>
        public Guid id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    startEvent("id");
                }
            }
        }


        private string _nodeName = "";
        /// <summary>
        /// 物料名称
        /// </summary>
        public string nodeName
        {
            get
            {
                return _nodeName;
            }
            set
            {
                if (_nodeName != value)
                {
                    _nodeName = value;
                    startEvent("nodeName");
                }
            }
        }

        /// <summary>
        /// 序号
        /// </summary>
        public int sort { get; set; }

        private Guid _fatherId;

        /// <summary>
        /// 父类id
        /// </summary>
        public Guid fatherId
        {

            get
            {
                return _fatherId;
            }
            set
            {
                if (_fatherId != value)
                {
                    _fatherId = value;
                    startEvent("fatherId");
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void startEvent(string eventname)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(eventname));
            }
        }

        public bool IsExpanded { get; set; } // 节点是否展开
        public bool IsSelected { get; set; } // 节点是否选中

    }
}
