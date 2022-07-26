using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UI.Base;

namespace WpfUI.ViewModel
{
    public class DtChildrenViewModel : ViewModelBase
    {
        #region 属性
        private ObservableCollection<ReportSaleSend> salesendlist = new ObservableCollection<ReportSaleSend>();

        public ObservableCollection<ReportSaleSend> SaleSendlist
        {
            get { return salesendlist; }
            set { salesendlist = value; RaisePropertyChanged(() => SaleSendlist); }
        }

        #endregion
        public DtChildrenViewModel()
        {
            if (IsInDesignMode)
            {
                GetList();
            }
            else
            {
                GetList();
                // Code runs "for real"
            }
        }
        #region 命令
        private RelayCommand<object> expandedcommand;

        public RelayCommand<object> ExpandedCommand
        {
            get
            {
                if (expandedcommand == null)
                    expandedcommand = new RelayCommand<object>((sender) => ExpandedMD(sender));
                return expandedcommand;
            }
            set { expandedcommand = value; }
        }

        private RelayCommand<object> collapsedcommand;

        public RelayCommand<object> CollapsedCommand
        {
            get
            {
                if (collapsedcommand == null)
                    collapsedcommand = new RelayCommand<object>((sender) => CollapsedMD(sender));
                return collapsedcommand;
            }
            set { collapsedcommand = value; }
        }
        #endregion
        #region 方法
        public void ExpandedMD(object sender)
        {
            var a = this;
            DataGridRow row = BaseMethod.FindVisualParent<DataGridRow>(sender as Expander);
            row.DetailsVisibility = System.Windows.Visibility.Visible;
        }

        public void CollapsedMD(object sender)
        {
            DataGridRow row = BaseMethod.FindVisualParent<DataGridRow>(sender as Expander);
            row.DetailsVisibility = System.Windows.Visibility.Collapsed;
        }
        #endregion

        public void GetList()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                ObservableCollection<DtlModel> dtlList = new ObservableCollection<DtlModel>();
                for (int dt = 0; dt < 5; dt++)
                {
                    DtlModel dtl = new DtlModel($"明细{dt}", dt, dt);
                    dtlList.Add(dtl);
                }
                ReportSaleSend reportSaleSend = new ReportSaleSend();
                reportSaleSend.saleSend_code = $"Sale{i}";
                reportSaleSend.item_desc = $"物料{i}";
                reportSaleSend.OrderTime = DateTime.Now;
                reportSaleSend.Qty = random.Next(1, 100) + i;
                reportSaleSend.OutQty = i;
                reportSaleSend.customer_desc = $"客戶{i}";
                reportSaleSend.emp_desc = $"銷售人員{i}";
                reportSaleSend.DtlList = dtlList;
                SaleSendlist.Add(reportSaleSend);

            }
        }
    }
    #region 临时变量类

    public class ReportSaleSend
    {
        private string _saleSend_code;

        public string saleSend_code
        {
            get { return _saleSend_code; }
            set { _saleSend_code = value; }
        }
        private string _item_desc;

        public string item_desc
        {
            get { return _item_desc; }
            set { _item_desc = value; }
        }



        private DateTime ordertime;

        public DateTime OrderTime
        {
            get { return ordertime; }
            set { ordertime = value; }
        }
        private decimal qty;

        public decimal Qty
        {
            get { return qty; }
            set { qty = value; }
        }


        private decimal outqty;

        public decimal OutQty
        {
            get { return outqty; }
            set { outqty = value; }
        }


        private decimal _con_amt;

        public decimal con_amt
        {
            get { return _con_amt; }
            set { _con_amt = value; }
        }

        private string _customer_desc;

        public string customer_desc
        {
            get { return _customer_desc; }
            set { _customer_desc = value; }
        }
        private string _emp_desc;

        public string emp_desc
        {
            get { return _emp_desc; }
            set { _emp_desc = value; }
        }
        private ObservableCollection<DtlModel> dtlList = new ObservableCollection<DtlModel>();

        public ObservableCollection<DtlModel> DtlList
        {
            get { return dtlList; }
            set { dtlList = value; }
        }
    }
    public class DtlModel
    {
        public DtlModel(string barcore, decimal curbasenum, decimal qty)
        {
            BarCode = barcore;
            CurBaseNum = curbasenum;
            Qty = qty;
        }
        private string barcode;

        public string BarCode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private decimal curbasenum;

        public decimal CurBaseNum
        {
            get { return curbasenum; }
            set { curbasenum = value; }
        }
        private decimal qty;

        public decimal Qty
        {
            get { return qty; }
            set { qty = value; }
        }

    }
    #endregion
}
