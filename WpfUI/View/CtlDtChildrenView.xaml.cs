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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUI.View
{
    /// <summary>
    /// CtlDtChildrenView.xaml 的交互逻辑
    /// </summary>
    public partial class CtlDtChildrenView : UserControl
    {
        public CtlDtChildrenView()
        {
            InitializeComponent();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            var a = dt.DefaultView;

        }

        private void TextBox_LostFocus_1(object sender, RoutedEventArgs e)
        {
            var aa = (sender as TextBox).Text;
            if (aa == "asd")
            {
                ((sender as TextBox).Parent as DataGridCell).Foreground = Brushes.Blue;
            }

        }

        private void TxtSale_LostFocus(object sender, RoutedEventArgs e)
        {
            var aa = (sender as TextBox).Text;
            if (aa == "asd")
            {
                ((sender as TextBox).Parent as DataGridCell).Foreground = Brushes.Blue;
            }

        }

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var a = e.Column.Header;
            (dataGrid1.Columns[3].GetCellContent(dataGrid1.Items[0]) as TextBox).Text = "123";
            // var c    = (dataGrid1.Columns[1].GetCellContent(dataGrid1.Items[1])as TextBlock).Text.ToString();
            var SO = e.Row.DataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedItem != null)
            {
                DataRowView DRV = (DataRowView)dataGrid1.SelectedItem;
                DRV.Delete();//删除行
            }
        }
    }
}
