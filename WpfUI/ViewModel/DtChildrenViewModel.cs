using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI.ViewModel
{
    public class DtChildrenViewModel : ViewModelBase
    {
        #region 属性
        private ObservableCollection<ReportSaleSend> salesendlist=new ObservableCollection<ReportSaleSend>();

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
        private RelayCommand expandedcommand;

        public RelayCommand ExpandedCommand
        {
            get
            {
                if (expandedcommand == null)
                    expandedcommand = new RelayCommand(() => ExpandedMD());
                return expandedcommand;
            }
            set { expandedcommand = value; }
        }

        private RelayCommand collapsedcommand;

        public RelayCommand CollapsedCommand
        {
            get
            {
                if (collapsedcommand == null)
                    collapsedcommand = new RelayCommand(() => CollapsedMD());
                return collapsedcommand;
            }
            set { collapsedcommand = value; }
        }
        #endregion
        #region 方法
        public void ExpandedMD()
        {

        }

        public void CollapsedMD()
        {

        }
        #endregion

        public void GetList()
        {

        }
    }
    public class ReportSaleSend
    {
        private string statustr;

        public string StatuStr
        {
            get { return statustr; }
            set { statustr = value; }
        }


        private Guid _saleSend_id;

        public Guid saleSend_id
        {
            get { return _saleSend_id; }
            set { _saleSend_id = value; }
        }

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
        private decimal _acp_up;

        public decimal acp_up
        {
            get { return _acp_up; }
            set { _acp_up = value; }
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
        private decimal _notacpmoney;

        public decimal notacpmoney
        {
            get { return _notacpmoney; }
            set { _notacpmoney = value; }
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

    }
}
