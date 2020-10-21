using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visifire.Charts;

namespace WpfUI.ViewModel
{
    public class CtlCharViewModel : ViewModelBase
    {

        public CtlCharViewModel()
        {
            if (IsInDesignMode)
            {
                GetChar();
            }
            else
            {
                GetChar();
                // Code runs "for real"
            }
        }

        public void GetChar()
        {
            CharTitName = "XXX物料统计图表";
            YCharTitName = "数量/个";
            XCharTitName = "物料";
            DataPointCollection salist = new DataPointCollection();
            DataTable table = new DataTable();
            table.Columns.Add("Name", Type.GetType("System.String"));//添加Name列，存储数据类型为string
            table.Columns.Add("Id", Type.GetType("System.Int32"));//添加Id列，存储数据类型为Int
            table.Columns.Add("Number", Type.GetType("System.Int32"));//添加Id列，存储数据类型为Int
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int number = random.Next(10, 100);
                DataRow newRow = table.NewRow();
                newRow["Name"] = $"物料{i}";
                newRow["Id"] = i;
                newRow["Number"] = i+ number;
                table.Rows.Add(newRow);
            }
            foreach (DataRow item in table.Rows)
            {
                var datapoint = new DataPoint
                {
                    AxisXLabel = item["Name"].ToString(),
                    YValue = double.Parse(item["Number"].ToString())
                };
                salist.Add(datapoint);
            }
            Chardatas = salist;
        }
        #region 属性

        private string chartitname;
        /// <summary>
        /// 图标标题
        /// </summary>
        public string CharTitName
        {
            get { return chartitname; }
            set { chartitname = value; RaisePropertyChanged(() => CharTitName); }
        }
        private string xchartitname;
        /// <summary>
        /// X轴标题
        /// </summary>
        public string XCharTitName
        {
            get { return xchartitname; }
            set { xchartitname = value; RaisePropertyChanged(() => XCharTitName); }
        }
        private string ychartitname;
        /// <summary>
        /// Y轴标题
        /// </summary>
        public string YCharTitName
        {
            get { return ychartitname; }
            set { ychartitname = value; RaisePropertyChanged(() => YCharTitName); }
        }
        // DataSeriesCollection
        private DataPointCollection chardatas;

        public DataPointCollection Chardatas
        {
            get { return chardatas; }
            set { chardatas = value; RaisePropertyChanged(() => Chardatas); }
        }

        private RenderAs chartype;

        public RenderAs CharType
        {
            get { return chartype; }
            set { chartype = value; RaisePropertyChanged(() => CharType); }
        }

        #endregion

        #region 命令
        private RelayCommand loadcommand;
        /// <summary>
        /// 取消
        /// </summary>
        public RelayCommand LoadCommand
        {
            get
            {
                if (loadcommand == null)
                    loadcommand = new RelayCommand(() => LoadMD());
                return loadcommand;

            }
            set { loadcommand = value; }
        }


        #endregion

        #region 方法
        private void LoadMD()
        {
            GetChar();
        }
        #endregion
    }
}
