using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using UI.Base;
using UI.BaseModel;
using UI.Common;
using UI.Enums;
using UI.Interface;
using WpfUI.Common;
using WpfUI.View;

namespace WpfUI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private object _CurrentPage;
        private IModel _Imodel;

        /// <summary>
        /// 当前选择页
        /// </summary>
        public object CurrentPage
        {
            get { return _CurrentPage; }
            set { _CurrentPage = value; RaisePropertyChanged(); }
        }
        #region 工具栏

        private PopBoxViewModel _PopBoxView;

        /// <summary>
        /// 辅助窗口
        /// </summary>
        public PopBoxViewModel PopBoxView
        {
            get { return _PopBoxView; }
        }

        private NoticeViewModel _NoticeView;

        /// <summary>
        /// 通知模块
        /// </summary>
        public NoticeViewModel NoticeView
        {
            get { return _NoticeView; }
        }

        #endregion
        /// <summary>
        /// 当前IModel
        /// </summary>
        public IModel IModel
        {
            get { return _Imodel; }
            set { _Imodel = value; RaisePropertyChanged(); }
        }
        private ModuleManager _ModuleManager;


        /// <summary>
        /// 模块管理器
        /// </summary>
        public ModuleManager ModuleManager
        {
            get { return _ModuleManager; }
        }
        public ObservableCollection<PageInfo> OpenPageCollection { get; set; } = new ObservableCollection<PageInfo>();

        public MainViewModel()
        {
            PageChangeCmd = new RelayCommand<MeumModel>(PageChange);
        }

        public async void InitDefaultView()
        {
            //初始化工具栏,通知窗口
            _PopBoxView = new PopBoxViewModel();
            _NoticeView = new NoticeViewModel();
            //加载窗体模块
            _ModuleManager = new ModuleManager();
            //await _ModuleManager.LoadModules();
            //设置系统默认首页
            var page = OpenPageCollection.FirstOrDefault(t => t.HeaderName.Equals("系统首页"));
            if (page == null)
            {
                //演示Demo加载默认首页,较消耗性能。 实际开发务移除患者更新开发部件。
                HomePage about = new HomePage();
                OpenPageCollection.Add(new PageInfo() { HeaderName = "系统首页", Body = about });
                CurrentPage = OpenPageCollection[OpenPageCollection.Count - 1];
            }
        }
        private RelayCommand<Module> _ExcuteCommand;
        public RelayCommand<Module> ExcuteCommand
        {
            get
            {
                if (_ExcuteCommand == null)
                {
                    _ExcuteCommand = new RelayCommand<Module>(t => Excute(t));
                }
                return _ExcuteCommand;
            }
            set { _ExcuteCommand = value; RaisePropertyChanged(); }
        }
        public void ApplicationShutdown()
        {
            Messenger.Default.Send("", "ApplicationShutdown");
        }

        /// <summary>
        /// 执行模块
        /// </summary>
        /// <param name="module"></param>
        private async void Excute(Module module)
        {
            try
            {
                if (module == null) return;
                if (module.Code == "OutDlg")
                {
                    var relst = MessageBox.Show("是否要退出程序", "提示信息", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (relst == MessageBoxResult.Yes)
                    {
                        this.ApplicationShutdown();
                    }
                }
                var page = OpenPageCollection.FirstOrDefault(t => t.HeaderName.Equals(module.Name));
                if (page != null) { CurrentPage = page; return; }
                if (string.IsNullOrWhiteSpace(module.Code))
                {
                    //404页面
                    //DefaultViewPage defaultViewPage = new DefaultViewPage();
                    //OpenPageCollection.Add(new PageInfo() { HeaderName = module.Name, Body = defaultViewPage });
                    //CurrentPage = defaultViewPage;
                }
                else
                {
                    await Task.Factory.StartNew(() =>
                    {
                        var dialog = ServiceProvider.Instance.Get<IModel>(module.Code);
                        dialog.BindDefaultModel();
                        OpenPageCollection.Add(new PageInfo() { HeaderName = module.Name, Body = dialog.GetView() });
                    }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
                }
                CurrentPage = OpenPageCollection[OpenPageCollection.Count - 1];
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message);
            }
            finally
            {
                //Messenger.Default.Send(false, "PackUp");
                GC.Collect();
            }
        }


        /// <summary>
        /// 页面切换命令
        /// </summary>
        public RelayCommand<MeumModel> PageChangeCmd { get; set; }
        private async void PageChange(MeumModel module)
        {
            var page = OpenPageCollection.FirstOrDefault(t => t.HeaderName.Equals(module.Name));
            if (page != null) { CurrentPage = page; return; }
            else
            {
                await Task.Factory.StartNew(() =>
                {
                    var dialog = ServiceProvider.Instance.Get<IModel>(module.Code);
                    dialog.BindDefaultModel();
                    OpenPageCollection.Add(new PageInfo() { HeaderName = module.Name, Body = dialog.GetView() });
                }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
                CurrentPage = OpenPageCollection[OpenPageCollection.Count - 1];
            }
        }
        #region 命令
        /// <summary>
        /// 登录
        /// </summary>
        public RelayCommand<PageInfo> ExitCurrentPageCommand { get; set; }
       

        public RelayCommand<PageInfo> ExitAllPageCommand { get; set; }
        

        public RelayCommand<PageInfo> ExitAllExceptCommand { get; set; }

        #endregion
 

        private void ExitCommand(MenuBehaviorType type, string pageName)
        {
            var obj = this ;
            if (obj == null) return;
            switch (type)
            {
                case MenuBehaviorType.ExitCurrentPage:
                    obj.ExitPage(MenuBehaviorType.ExitCurrentPage, pageName);
                    break;
                case MenuBehaviorType.ExitAllPage:
                    obj.ExitPage(MenuBehaviorType.ExitAllPage, pageName);
                    break;
                case MenuBehaviorType.ExitAllExcept:
                    obj.ExitPage(MenuBehaviorType.ExitAllExcept, pageName);
                    break;
            }
        }

        public void ExitPage(MenuBehaviorType behaviorType, string pageName)
        {
            switch (behaviorType)
            {
                case MenuBehaviorType.ExitCurrentPage:
                    var page = OpenPageCollection.FirstOrDefault(t => t.HeaderName.Equals(pageName));
                    if (page.HeaderName != "系统首页") OpenPageCollection.Remove(page);
                    break;
                case MenuBehaviorType.ExitAllPage:
                    var pageList = OpenPageCollection.Where(t => t.HeaderName != "系统首页").ToList();
                    if (pageList != null)
                    {
                        pageList.ForEach(t =>
                        {
                            OpenPageCollection.Remove(t);
                        });
                    }
                    break; 
                case MenuBehaviorType.ExitAllExcept:
                    var pageListExcept = OpenPageCollection.Where(t => t.HeaderName != pageName && t.HeaderName != "系统首页").ToList();
                    if (pageListExcept != null)
                    {
                        pageListExcept.ForEach(t =>
                        {
                            OpenPageCollection.Remove(t);
                        });
                    }
                    break;
            }
        }
        private void ExitCurrentPage_Click(PageInfo module)
        {
            var pageInfo = module;
            ExitCommand(MenuBehaviorType.ExitCurrentPage, pageInfo.HeaderName);
        }

        private void ExitAllPage_Click(PageInfo module)
        {
            var pageInfo = module;
            ExitCommand(MenuBehaviorType.ExitAllPage, pageInfo.HeaderName);
        }

        private void ExitAllExcept_Click(PageInfo module)
        {
            var pageInfo = module;
            ExitCommand(MenuBehaviorType.ExitAllExcept, pageInfo.HeaderName);
        }
    }
}