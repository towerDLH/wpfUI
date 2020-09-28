using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UI.Common
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

            ObservableCollection<ModuleGroup> menumlist = new ObservableCollection<ModuleGroup>();
            ObservableCollection<Module> baseMuumList = new ObservableCollection<Module>();
            baseMuumList.Add(new Module("公司", "CtlCompanyListDlg", 1, "\xe639"));
            baseMuumList.Add(new Module("包装单位", "CtlUnitGradeListDlg", 1, "\xe604"));
            baseMuumList.Add(new Module("商品列表", "CtlPmListDlg", 1, "\xe606"));
            baseMuumList.Add(new Module("应用标识符", "CtlBarCodeAplicationListDlg", 1, "\xe614"));
            baseMuumList.Add(new Module("UDI生成规则", "CtlBarCodeRoleListDlg", 1, "\xe604"));
            baseMuumList.Add(new Module("模板管理", "PrintSetViewListDlg", 1, "\xe604"));
            ObservableCollection<Module> PIMuumList = new ObservableCollection<Module>();
            PIMuumList.Add(new Module("UDI-PI码管理", "CtlCommodityPIListDlg", 1, "\xe604"));
            PIMuumList.Add(new Module("UDI-PI码历史记录", "CtlCommodityPIhistroyListDlg", 1, "\xe604"));
            ObservableCollection<Module> setMuumList = new ObservableCollection<Module>();
            setMuumList.Add(new Module("退出登录", "OutDlg", 1, "\xe600"));
            menumlist.Add(new ModuleGroup()
            {
                GroupName = "基础信息",
                Modules = baseMuumList
            });
            menumlist.Add(new ModuleGroup()
            {
                GroupName = "PI管理",
                Modules = PIMuumList
            });
            //menumlist.Add(new ModuleGroup()
            //{
            //    GroupName = "退出登录",
            //    Modules = setMuumList
            //});
            _ModuleGroups = menumlist;

            //Array array = System.Enum.GetValues(typeof(ModuleType));

            //foreach (var m in array)
            //{
            //    ModuleType t = (ModuleType)m;
            //    var attr = GetEnumAttrbute.GetDescription(t);
            //    if (attr != null)
            //        _ModuleGroups.Add(new ModuleGroup() { ModuleType = t, GroupName = attr.Caption, GroupIcon = attr.Remark });
            //}
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
