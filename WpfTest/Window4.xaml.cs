using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfTest
{
    /// <summary>
    /// Window4.xaml 的交互逻辑
    /// </summary>
    public partial class Window4 : Window
    {
        private WiondModel Model;
        public Window4()
        {
            InitializeComponent();
            Model = new WiondModel();
            Load();
            Grd.DataContext = Model;
        }

        private void Load()
        {
            DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("Address", typeof(string));

            DataRow row = dt.NewRow();
            row["ID"] = 1;
            row["Name"] = "张三";
            row["PhoneNumber"] = "123456";
            row["Address"] = "北京";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["ID"] = 2;
            row["Name"] = "李四";
            row["PhoneNumber"] = "789001";
            row["Address"] = "上海";
            dt.Rows.Add(row);
            Model.Itemlist = dt;
            index = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("Address", typeof(string));

            DataRow row = dt.NewRow();
            row["ID"] = 1;
            row["Name"] = "张三";
            row["PhoneNumber"] = "123456";
            row["Address"] = "北京";
            dt.Rows.Add(row);

            Model.Itemlist = dt;
            dataGrid1.ItemsSource = dt.DefaultView;
        }
        public int index { get; set; }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            index = 12;
        }
    }
    public class WiondModel
    {
        public DataTable Itemlist { get; set; }

    }
}
