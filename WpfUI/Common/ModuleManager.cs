using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Common;

namespace WpfUI.Common
{
    /// <summary>
    /// 模块组
    /// </summary>
    public class ModuleManager : ViewModelBase
    {
        public ModuleManager()
        {
            InitModuleGroups();
        }

        private void InitModuleGroups()
        {
            ObservableCollection<Module> menumlist = new ObservableCollection<Module>();
            ObservableCollection<Module> baseMuumList = new ObservableCollection<Module>();
         baseMuumList.Add(new Module("图表", "CharViewDlg", 1, "\xe633"));
            baseMuumList.Add(new Module("流程图", "CtlFlowDlg", 1, "\xe61a"));
            baseMuumList.Add(new Module("主子表", "DtChildrenDlg", 1, "\xe609"));
            baseMuumList.Add(new Module("甘特图", "GantCharDlg", 1, "\xe671"));
            baseMuumList.Add(new Module("下拉树", "CtlTreeDlg", 1, "\xe643"));
            baseMuumList.Add(new Module("组织架构", "CtlOrganTreeDlg", 1, "\xe643"));
            //  baseMuumList.Add(new Module("聊天室", "CtlCharRoomDlg", 1, "\xe643"));
            //ObservableCollection<Module> PIMuumList = new ObservableCollection<Module>();
            //PIMuumList.Add(new Module("UDI-PI码管理", "CtlCommodityPIListDlg", 1, "\xe604"));
            //PIMuumList.Add(new Module("UDI-PI码历史记录", "CtlCommodityPIhistroyListDlg", 1, "\xe604"));
            menumlist.Add(new Module()
            {
                Name = "基础信息",
                Modules = baseMuumList
            });
            //menumlist.Add(new ModuleGroup()
            //{
            //    GroupName = "PI管理",
            //    Modules = PIMuumList
            //});

            Modules = menumlist;

            //Modules
        }

        private ObservableCollection<Module> _Modules = new ObservableCollection<Module>();
        private ObservableCollection<ModuleGroup> _ModuleGroups = new ObservableCollection<ModuleGroup>();

        /// <summary>
        /// 已加载模块<含分组>
        /// </summary>
        public ObservableCollection<ModuleGroup> ModuleGroups
        {
            get { return _ModuleGroups; }
            set { _ModuleGroups = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 已加载模块
        /// </summary>
        public ObservableCollection<Module> Modules
        {
            get { return _Modules; }
            set { _Modules = value; RaisePropertyChanged(); }
        }

    }
}
