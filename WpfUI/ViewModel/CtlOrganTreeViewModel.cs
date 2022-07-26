using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI.ViewModel
{
    public class CtlOrganTreeViewModel : ViewModelBase
    {
        private ObservableCollection<MeunTree> treelist = new ObservableCollection<MeunTree>();

        public ObservableCollection<MeunTree> Treelist
        {
            get { return treelist; }
            set { treelist = value; RaisePropertyChanged(() => Treelist); }
        }
        public CtlOrganTreeViewModel()
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
            //MeunTree waitmenu = new MeunTree();
            //waitmenu.Name = "待办的任务";
            //waitmenu.Nodes.Add(new MeunTree { Name = "111" });
            //Treelist.Add(waitmenu);
            MeunTree hismenu = new MeunTree();
            ObservableCollection<MeunTree> hismeunTrees = new ObservableCollection<MeunTree>();
            hismenu.Name = "历史任务";
            MeunTree hismenuitem1 = new MeunTree();
            hismenuitem1.Name = "我发起的任务";
            hismeunTrees.Add(hismenuitem1);
            MeunTree hismenuitem2 = new MeunTree();
            hismenuitem2.Name = "我参与的任务";
            MeunTree hismenuitem3 = new MeunTree();
            hismenuitem3.Name = "我参与的任务33";
            hismenuitem2.Nodes.Add(hismenuitem3);
            hismeunTrees.Add(hismenuitem2);
            hismenu.Nodes = hismeunTrees;
            Treelist.Add(hismenu);
        }
    }
}
