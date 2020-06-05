using System;
using System.Collections.Generic;
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

namespace UI
{
    /// <summary>
    /// SearTextBox.xaml 的交互逻辑
    /// </summary>
    public partial class SearTextBox : UserControl
    {
        public SearTextBox()
        {
            InitializeComponent();
        }

        public event EventHandler<SearchEventArgs> OnSearch;
        private void BtnSearch_OnClick(object sender, RoutedEventArgs e)
        {
            ExeccuteSearch();
        }

        private void TbxInput_OnKeyDown(object sender, KeyEventArgs e)
        {
            ExeccuteSearch();
        }

        private void ExeccuteSearch()
        {
            if (OnSearch != null)
            {
                var args = new SearchEventArgs();
                args.SearchText = TbxInput.Text;
                OnSearch(this, args);
            }
        }
    }
    public class SearchEventArgs : EventArgs
    {
        public string SearchText { get; set; }
    }
}

