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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// MouseTree.xaml 的交互逻辑
    /// </summary>
    public partial class MouseTree : Window
    {
        private bool IsDrop = false;

        private ObservableCollection<TreeItem> list = new ObservableCollection<TreeItem>();
        public MouseTree()
        {
            InitializeComponent();
            InitTree();
        }

        /// <summary>
        /// 树控件数据初始化
        /// </summary>
        public void InitTree()
        {
            BitmapImage    folder=null;
            BitmapImage   file = null;

            // 根节点
            var root = new TreeItem()
            {
                Name = "root",
                Childern = list
            };

            var ti = new TreeItem()
            {
                BI = folder,
                Name = "文件夹1",
                Parent = root,
                Childern = new ObservableCollection<TreeItem>()
            };

            var tmp11 = new TreeItem()
            {
                BI = folder,
                Name = "文件夹11",
                Parent = ti,
                Childern = new ObservableCollection<TreeItem>()
            };

            var tmp111 = new TreeItem()
            {
                BI = file,
                Name = "文件111",
                Parent = tmp11,
                Childern = new ObservableCollection<TreeItem>()
            };
            tmp11.Childern.Add(tmp111);
            var tmp112 = new TreeItem()
            {
                BI = file,
                Name = "文件112",
                Parent = tmp11,
                Childern = new ObservableCollection<TreeItem>()
            };
            tmp11.Childern.Add(tmp112);
            var tmp113 = new TreeItem()
            {
                BI = file,
                Name = "文件113",
                Parent = tmp11,
                Childern = new ObservableCollection<TreeItem>()
            };
            tmp11.Childern.Add(tmp113);

            ti.Childern.Add(tmp11);

            var tmp12 = new TreeItem()
            {
                BI = folder,
                Name = "文件夹12",
                Parent = ti,
                Childern = new ObservableCollection<TreeItem>()
            };
            ti.Childern.Add(tmp12);

            var tmp13 = new TreeItem()
            {
                BI = folder,
                Name = "文件夹13",
                Parent = ti,
                Childern = new ObservableCollection<TreeItem>()
            };
            ti.Childern.Add(tmp13);

            list.Add(ti);

            this.treeView.ItemsSource = list;
        }
        #region 事件
        private Point _lastMouseDown;
        private void tvRequire_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var ele = e.OriginalSource as FrameworkElement;
                if (ele != null)
                {
                    _lastMouseDown = e.GetPosition(treeView);
                    moveTreeItem = (TreeItem)ele.DataContext;
                }
            }
        }

        private TreeItem moveTreeItem;
        private void tvRequire_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point currentPosition = e.GetPosition(treeView);
                if ((Math.Abs(currentPosition.X - _lastMouseDown.X) > 2.0) || (Math.Abs(currentPosition.Y - _lastMouseDown.Y) > 2.0))
                {
                    if (!IsDrop)
                    {
                        if (moveTreeItem != null)
                        {
                            IsDrop = true;
                            this.treeView.Cursor = Cursors.Hand;
                        }
                    }
                }
            }
        }

        private void tvRequire_MouseUp(object sender, MouseEventArgs e)
        {
            if (moveTreeItem == null)
            {
                return;
            }
            var ele = e.OriginalSource as FrameworkElement;
            if (ele != null)
            {
                var targetTreeItem = (TreeItem)ele.DataContext;
                if (targetTreeItem == null)
                {
                    ClearTreeDrop();
                    return;
                }
                if (targetTreeItem.Name != moveTreeItem.Name)
                {
                    if (targetTreeItem.IsAddIn)
                    {
                        #region 移动到目标子集
                        var tmp = targetTreeItem.Childern.SingleOrDefault(l => l.Name == moveTreeItem.Name);
                        if (tmp == null)
                        {
                            moveTreeItem.Parent.Childern.Remove(moveTreeItem);
                            moveTreeItem.Parent = targetTreeItem;
                            AddIn(targetTreeItem, moveTreeItem);
                        }
                        targetTreeItem.IsAddIn = false;
                        #endregion
                    }
                    else if (targetTreeItem.IsAdd)
                    {
                        #region 移动到目标同级
                        moveTreeItem.Parent.Childern.Remove(moveTreeItem);
                        Add(targetTreeItem.Parent, targetTreeItem, moveTreeItem);
                        targetTreeItem.IsAdd = false;
                        #endregion
                    }
                }
            }
            ClearTreeDrop();
        }

        private void AddIn(TreeItem argTarget, TreeItem argMove)
        {
            if (argTarget != null)
            {
                var sortList = new List<TreeItem>();
                sortList.Add(argMove);
                foreach (var item in argTarget.Childern)
                {
                    sortList.Add(item);
                }
                argTarget.Childern.Clear();
                foreach (var item in sortList)
                {
                    argTarget.Childern.Add(item);
                }
            }
        }

        private void Add(TreeItem argParent, TreeItem argTarget, TreeItem argMove)
        {
            if (argParent != null)
            {
                var sortList = new List<TreeItem>();
                foreach (var item in argParent.Childern)
                {
                    sortList.Add(item);

                    if (item.Name == argTarget.Name)
                    {
                        argMove.Parent = item.Parent;
                        sortList.Add(argMove);
                    }
                }
                argParent.Childern.Clear();
                foreach (var item in sortList)
                {
                    argParent.Childern.Add(item);
                }
            }
        }

        private void tvRequire_MouseLeave(object sender, MouseEventArgs e)
        {
            ClearTreeDrop();
        }

        private void ClearTreeDrop()
        {
            moveTreeItem = null;
            IsDrop = false;
            this.treeView.Cursor = Cursors.Arrow;
        }

        public BitmapImage GetBitmapImage(string argName, string argCatalog = null)
        {
            try
            {
                string path = string.Empty;
                if (string.IsNullOrEmpty(argCatalog))
                {
                    path = @"pack://application:,,,/Image/" + argName;
                }
                else
                {
                    path = @"pack://application:,,,/Image/" + argCatalog + "/" + argName;
                }
                var bi = new BitmapImage();
                bi.BeginInit();
                // 创建 BitmapImage 后关闭流，请将 CacheOption 属性设置为 BitmapCacheOption.OnLoad。 
                // 默认 OnDemand 缓存选项保留对流的访问，直至需要位图并且垃圾回收器执行清理为止。
                bi.CacheOption = BitmapCacheOption.OnLoad;
                bi.UriSource = new Uri(path);
                bi.EndInit();
                bi.Freeze();
                return bi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            var ele = e.OriginalSource as Image;
            if (ele != null)
            {
                Console.WriteLine("Image_MouseEnter");
                var ti = (TreeItem)ele.DataContext;
                if (ti != null)
                {
                    if (IsDrop)
                    {
                        ti.IsAdd = true;
                    }
                }
            }
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            var ele = e.OriginalSource as Image;
            if (ele != null)
            {
                Console.WriteLine("Image_MouseLeave");
                var ti = ele.DataContext as TreeItem;
                if (ti != null)
                {
                    ti.IsAdd = false;
                }
            }
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            var ele = e.OriginalSource as TextBlock;
            if (ele != null)
            {
                Console.WriteLine("TextBlock_MouseEnter");
                var ti = (TreeItem)ele.DataContext;
                if (ti != null)
                {
                    if (IsDrop)
                    {
                        ti.IsAddIn = true;
                    }
                }
            }
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            var ele = e.OriginalSource as TextBlock;
            if (ele != null)
            {
                Console.WriteLine("TextBlock_MouseLeave");
                var ti = (TreeItem)ele.DataContext;
                if (ti != null)
                {
                    ti.IsAddIn = false;
                }
            }
        }

        #endregion

        
    }
    public class TreeItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 节点显示的图片
        /// </summary>
        public BitmapImage BI { get; set; }

        /// <summary>
        /// 节点显示的文本
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 父节点
        /// </summary>
        public TreeItem Parent { get; set; }

        /// <summary>
        /// 子节点集合
        /// </summary>
        public ObservableCollection<TreeItem> Childern { get; set; }

        private bool m_isAdd = false;
        /// <summary>
        /// 拖动到目标节点时增加到同级目录标志
        /// </summary>
        public bool IsAdd
        {
            get { return m_isAdd; }
            set
            {
                if (m_isAdd != value)
                {
                    m_isAdd = value;
                    if (m_isAdd)
                    {
                        IsAddIn = false;
                    }
                    if (PropertyChanged != null)
                    {
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IsAdd"));
                    }
                }
            }
        }

        private bool m_isAddin = false;
        /// <summary>
        /// 拖动到目标节点时增加到子目录标志
        /// </summary>
        public bool IsAddIn
        {
            get { return m_isAddin; }
            set
            {
                if (m_isAddin != value)
                {
                    m_isAddin = value;
                    if (m_isAddin)
                    {
                        m_isAdd = false;
                    }
                    //触发事件
                    if (PropertyChanged != null)
                    {
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IsAddIn"));
                    }
                }
            }
        }
    }
 
}
