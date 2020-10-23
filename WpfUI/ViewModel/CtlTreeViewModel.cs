using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI.ViewModel
{
    public class CtlTreeViewModel : ViewModelBase
    {
        #region 属性
        private ObservableCollection<MeunTree> treelist=new ObservableCollection<MeunTree>();

        public ObservableCollection<MeunTree> Treelist
        {
            get { return treelist; }
            set { treelist = value; RaisePropertyChanged(() => Treelist); }
        }

        #endregion
        public CtlTreeViewModel()
        {
            if (IsInDesignMode)
            {
                GetTree();
            }
            else
            {
                GetTree();
                // Code runs "for real"
            }
        }
        public void GetTree()
        {
            List<MeunTree> meunTrees = new List<MeunTree>();
            MeunTree waitmenu = new MeunTree();
            waitmenu.Name = "待办的任务";
            Treelist.Add(waitmenu);
            MeunTree hismenu = new MeunTree();
            ObservableCollection<MeunTree> hismeunTrees = new ObservableCollection<MeunTree>();
            hismenu.Name = "历史任务";
            MeunTree hismenuitem1 = new MeunTree();
            hismenuitem1.Name = "我发起的任务";
            hismeunTrees.Add(hismenuitem1);
            MeunTree hismenuitem2 = new MeunTree();
            hismenuitem2.Name = "我参与的任务";
            hismeunTrees.Add(hismenuitem2);
            hismenu.Nodes = hismeunTrees;
            Treelist.Add(hismenu);
        }
    }
    public class MeunTree : INotifyPropertyChanged
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

        private ObservableCollection<MeunTree> nodes = new ObservableCollection<MeunTree>();

        public ObservableCollection<MeunTree> Nodes
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
        public MeunTree()
        {
            this.Name = string.Empty;
            this.Icon = string.Empty;
            this.Checked = false;
        }

        #endregion
    }
}
