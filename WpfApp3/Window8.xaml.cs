using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Window8.xaml 的交互逻辑
    /// </summary>
    public partial class Window8 : Window
    {
        private NodeX CurrentModel = new NodeX();
        private NodeX _delTreeView = new NodeX();
        private ObservableCollection<NodeX> DataSource = new ObservableCollection<NodeX>();
        Window win = new Window();
        /// <summary>
        /// 标识是最开始的新增还是节点上的新增
        /// </summary>
        private string opot = "";
        public Window8()
        {
            InitializeComponent();
            List<NodeX> nodexlist = new List<NodeX>();
            nodexlist.Add(new NodeX()
            {
                Name = "一级",
                Icon = "/WpfApp3;component/Image/timg.jpg",
                Nodes = new ObservableCollection<NodeX>() {
                   new NodeX(){
                       Name = "二级",
                       Icon = "/WpfApp3;component/Image/timg.jpg",
                       Nodes=  new ObservableCollection<NodeX>(){
                           new NodeX(){
                       Name = "三级",
                       Icon = "/WpfApp3;component/Image/timg.jpg"}
                       }

                   }
               }
            });
            nodexlist.Add(new NodeX()
            {
                Name = "一级",
                Icon = "/WpfApp3;component/Image/timg.jpg",
                Nodes = new ObservableCollection<NodeX>() {
                   new NodeX(){
                   }
               }
            });
            //for (int a = 0; a < 30; a++)
            //{
            //    var n3 = new NodeX();
            //    n3.Name = a.ToString();
            //    n3.Icon = "/WpfApp3;component/Image/timg.jpg";
            //    nodexlist.Add(n3);
            //}
            system_tree.ItemsSource = nodexlist;
        }

        private void Afteradding_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Adder_Click(object sender, RoutedEventArgs e)
        {
            NodeX treeViewItem = system_tree.SelectedItem as NodeX;
            if (treeViewItem == null)
            {
                MessageBox.Show("请选择一个目录节点或根节点");
                return;
            }
            NodeX mtrNode = new NodeX();
            mtrNode.Name = "新材料库";
            treeViewItem.Nodes.Add(mtrNode);
        }

        private void AddPm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                opot = "node0";
                win = new Window();
                var temp = new NodeX()
                {
                    Id = CurrentModel.Id,
                    Name = CurrentModel.Name,
                    FatherId = CurrentModel.FatherId,
                };
                PmCategoryDtl form = new PmCategoryDtl(temp, true);
                form.SaveEvent += Form_AddEvent;
                win.Width = 400;
                win.Height = 300;
                win.Content = form;
                win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                win.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示信息");
            }
        }
        private void Form_AddEvent(object sender, NodeX e)
        {

        }

        private void ModifyPmClick(object sender, RoutedEventArgs e)
        {

        }

        private void DelPm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class NodeX : INotifyPropertyChanged
    {
        #region Property

        private string _Text;
        /// <summary>
        /// 显示的文本值
        /// </summary>
        public string Name
        {
            get { return this._Text; }
            // set { this._Text = value; }
            set
            {
                if (_Text != value)
                {
                    _Text = value;
                    startEvent("Name");
                }
            }
        }
        private Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
        private Guid fatherId;

        public Guid FatherId
        {
            get { return fatherId; }
            set { fatherId = value; }
        }

        private bool? _Checked;
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool? Checked
        {
            get { return this._Checked; }
            set { this._Checked = value; }
        }

        private bool _IsExpand;
        /// <summary>
        /// 是否展开
        /// </summary>
        public bool IsExpand
        {
            get { return this._IsExpand; }
            set { this._IsExpand = value; }
        }

        /// <summary>
        /// 节点图标：相对路径
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 子节点，默认null
        /// </summary>

        private ObservableCollection<NodeX> nodes = new ObservableCollection<NodeX>();

        public ObservableCollection<NodeX> Nodes
        {
            get { return nodes; }
            //set { nodes = value; }
            set
            {
                if (nodes != value)
                {
                    nodes = value;
                    startEvent("Nodes");
                }
            }
        }

        /// <summary>
        /// 该节点数据项，默认null
        /// </summary>
        public virtual IList ItemSource { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void startEvent(string eventname)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(eventname));
            }
        }
        /// <summary>
        /// 视图控件，只有当ViewType=UserControl时才有效
        /// </summary>
        public string ViewControl { get; set; }

        #endregion

        #region NodeX-构造函数（初始化）

        /// <summary>
        ///  NodeX-构造函数（初始化）
        /// </summary>
        public NodeX()
        {
            this.Name = string.Empty;
            this.Icon = string.Empty;
            this.Checked = false;
        }

        #endregion
    }
}
