using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UI.Base;
using UI.Common;
using UI.Converter;
using UI.Interface;
using WpfUI.View;
using WpfUI.ViewModel;

namespace WpfUI.VIewDlg
{
    /// <summary>
    /// 登录窗口
    /// </summary>
    [Autofac(true)]
    public class LoginViewDlg : BaseViewDialog<CtlLoginView>, IModelDialog
    {
        public override void BindDefaultViewModel()
        {
            LoginViewModel viewModel = new LoginViewModel();
            viewModel.ReadConfigInfo();
            GetDialogWindow().DataContext = viewModel;
        }

        public override void BindViewModel<TViewModel>(TViewModel viewModel)
        {
            GetDialogWindow().DataContext = viewModel;
        }

        public override void Close()
        {
            GetDialogWindow().Close();
        }

        public override Task<bool> ShowDialog(DialogOpenedEventHandler openedEventHandler = null, DialogClosingEventHandler closingEventHandler = null)
        {
            GetDialogWindow().ShowDialog();
            return Task.FromResult(true);
        }

        public override void RegisterDefaultEvent()
        {
            GetDialogWindow().MouseDown += (sender, e) => { if (e.LeftButton == MouseButtonState.Pressed) { GetDialogWindow().DragMove(); } };
            Messenger.Default.Register<string>(GetDialogWindow(), "ApplicationHiding", new Action<string>((msg) => { GetDialogWindow().Hide(); }));
            Messenger.Default.Register<string>(GetDialogWindow(), "ApplicationShutdown", new Action<string>((arg) => { Application.Current.Shutdown(); }));
        }

        private Window GetDialogWindow()
        {
            return GetDialog() as Window;
        }
    }
}
