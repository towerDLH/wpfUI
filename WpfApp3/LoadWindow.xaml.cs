using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
    /// LoadWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoadWindow : Window
    {
        public LoadWindow()
        {
            InitializeComponent();
          //  Load();
        }

        //private void Load()
        //{

        //    User user = new User();
        //    // 登录时 如果没有Data.bin文件就创建、有就打开
        //    FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate);

        //    if (fs.Length > 0)
        //    {
        //        BinaryFormatter bf1 = new BinaryFormatter();
        //        //读出存在Data.bin 里的用户信息
        //        var users = bf1.Deserialize(fs) as Dictionary<string, User>;
        //        //循环添加到Combox1
        //        foreach (User item in users.Values)
        //        {
        //            if (item.IsCheck)
        //            {

        //            }
        //            comboBoxEx1.Items.Add(user.LoginID);
        //        }

        //        //combox1 用户名默认选中第一个
        //        if (comboBoxEx1.Items.Count > 0)
        //            comboBoxEx1.SelectedIndex = comboBoxEx1.Items.Count - 1;
        //    }
        //    fs.Close();

        //    BinaryFormatter bf = new BinaryFormatter();
        //    // 保存在实体类属性中
        //    user.LoginID = UserName.Text.Trim();
        //    //保存密码选中状态
        //    if (checkBoxXUser?.IsChecked ?? false)
        //        user.Pwd = passWordtext.Text.Trim();
        //    else
        //        user.Pwd = "";
        //    //选在集合中是否存在用户名 
        //    if (users.ContainsKey(user.LoginID))
        //    {
        //        //如果有清掉
        //        users.Remove(user.LoginID);
        //    }
        //    //添加用户信息到集合
        //    users.Add(user.LoginID, user);
        //    //写入文件
        //    bf.Serialize(fs, users);
        //    //关闭
        //    fs.Close();
        //}

        /// <summary>
        /// 记住密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }

    public class User
    {
        //记住密码
        private string loginID;
        public string LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }

        private string pwd;
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        private bool isCheck;
        public bool IsCheck
        {
            get { return isCheck; }
            set { isCheck = value; }
        }
    }
}
