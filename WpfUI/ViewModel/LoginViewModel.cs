using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UI.Model;
using UI.Base;
using UI.Interface;
using UI.Common;

namespace WpfUI.ViewModel
{

    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
            if (IsInDesignMode)
            {
                UserName = "admin";
            }
            else
            {
                UserName = "admin";
                // Code runs "for real"
            }
        }


        /// <summary>
        /// 读取本地配置信息
        /// </summary>
        public void ReadConfigInfo()
        {
            //string cfgINI = AppDomain.CurrentDomain.BaseDirectory + SerivceFiguration.INI_CFG;
            //if (File.Exists(cfgINI))
            //{
            //    IniFile ini = new IniFile(cfgINI);
            //    UserName = ini.IniReadValue("Login", "User");
            //    Password = CEncoder.Decode(ini.IniReadValue("Login", "Password"));
            //    UserChecked = ini.IniReadValue("Login", "SaveInfo") == "Y";
            //    SkinName = ini.IniReadValue("Skin", "Skin");
            //    ServerType = ini.IniReadValue("Server", "Bridge");
            //}
        }
        /// <summary>
        /// 关闭系统
        /// </summary>
        public void ApplicationShutdown()
        {
            Messenger.Default.Send("", "ApplicationShutdown");
        }
        #region 属性

        private String username;
        //目标参数
        public String UserName
        {
            get { return username; }
            set { username = value; RaisePropertyChanged(() => UserName); }
        }
        private Window loginwin;
        //窗体
        public Window Loginwin
        {
            get { return loginwin; }
            set { loginwin = value; RaisePropertyChanged(() => Loginwin); }
        }
        private String pwd;
        //目标参数
        public String Pwd
        {
            get { return pwd; }
            set { pwd = value; RaisePropertyChanged(() => Pwd); }
        }

        #endregion

        #region 命令



        private RelayCommand<string> sendCommand;
        /// <summary>
        /// 登录
        /// </summary>
        public RelayCommand<string> SendCommand
        {
            get
            {
                if (sendCommand == null)
                    sendCommand = new RelayCommand<string>((pwd) => ExcuteSendCommand(pwd));
                return sendCommand;

            }
            set { sendCommand = value; }
        }


        private async void ExcuteSendCommand(string pwd)
        {

            if (UserName == "admin" && pwd == "123")
            {
                Loginer.LoginerUser.UserName = UserName;
                //  var dialog = ServiceProvider.Instance.Get<IModelDialog>("MainViewDlg");
                //var dialog = ServiceProvider.Instance.Get<IModel>("MainViewDlg");
                //dialog.BindDefaultModel();
                //Messenger.Default.Send(string.Empty, "ApplicationHiding");
                //bool taskResult = await dialog.ShowDialog();
                //UserInfo user = JsonConvert.DeserializeObject<UserInfo>(relst.Obj.ToString());
                //Loginer.LoginerUser.Account = user.username;
                //Loginer.LoginerUser.ID = user.userid;
                //Loginer.LoginerUser.UserName = user.username;
                //Loginer.LoginerUser.IsAdmin = user.username == "admin" ? true : false;
                ////  Loginer.LoginerUser.Email = user.email;
                //Loginer.LoginerUser.netpointcode = user.netpointcode;
                // this.Report = "加载用户信息 . . .";
                //this.ConfigureServices();
                var dialog = ServiceProvider.Instance.Get<IModelDialog>("MainViewDlg");
                dialog.BindDefaultViewModel();
                Messenger.Default.Send(string.Empty, "ApplicationHiding");
                bool taskResult = await dialog.ShowDialog();
                this.ApplicationShutdown();
            }
        }
         
        private RelayCommand<Window> cancelcommand;
        /// <summary>
        /// 取消
        /// </summary>
        public RelayCommand<Window> CancelCommand
        {
            get
            {
                if (cancelcommand == null)
                    cancelcommand = new RelayCommand<Window>((win) => CancelMD(win));
                return cancelcommand;

            }
            set { cancelcommand = value; }
        }

        private void CancelMD(Window win)
        {
            if (MessageBox.Show("是否退出UDI系统？", "提示信息", System.Windows.MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                win.Close();
            }
        }
        #endregion
    }
}
