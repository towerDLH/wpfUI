using BOCO.OssView.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp3
{
    public interface ICreateCtlPanelFactory
    {
        ChartControl Chartctl
        { get; set; }
        string StatusInfo { get; set; }
        StackPanel CreateChartContainer();
    }
    public class BaseFactory : ICreateCtlPanelFactory
    {
        protected ChartControl mChartctl = null;
        protected string sDemoInfo = null;

        public BaseFactory(ChartControl cc)
        {
            this.mChartctl = cc;
            InitChart(cc);
        }
        public ChartControl Chartctl
        {
            get
            {
                this.mChartctl.Width = 600;
                this.mChartctl.Height = 400;
                return mChartctl;
            }
            set { mChartctl = value; }
        }
        public string StatusInfo
        {
            get { return sDemoInfo; }
            set { sDemoInfo = value; }
        }
        public virtual void InitData()
        {
            if (this.mChartctl != null)
            {
                this.mChartctl.SeriesNames.Clear();
                this.mChartctl.SeriesValues.Clear();
            }
            int count = 10;

            //存储X轴值
            string[] xvalues = { "潮州", "东莞", "佛山", "广州", "惠州", "江门", "深圳", "湛江", "中山", "珠海" };

            //存储系列一的项
            double[] values1 = new double[count];

            //存储系列二的项
            double[] values2 = new double[count];

            //成生数据
            for (int i = 0; i < count; i++)
            {
                // xvalues[i] = i.ToString();
                values1[i] = Math.Sin((double)i * Math.PI / 15.0) * 16.0;
                //values2[i] = values1[i] * 3.5;
            }
            //添加系列名
            //mChartctl.SeriesNames.Add("掉话率");
            //mChartctl.SeriesNames.Add("寻呼成功率");

            //添加系列项
            mChartctl.SeriesValues.Add(values1);
            //mChartctl.SeriesValues.Add(values2);

            //添加X轴值
            mChartctl.XAxisValues = xvalues;

            mChartctl.ToolsBackground = Brushes.Transparent;
        }


        public virtual StackPanel CreateChartContainer()
        {
            return null;
        }
        private void InitChart(ChartControl cc)
        {
            this.mChartctl = cc;
            //初始化模型数据
            InitData();
            //this.mChartctl.Title.Background = Brushes.Transparent;
            //this.mChartctl.Title.Text = "ChartControl Demo";

            //mChartctl.Background = Brushes.Red;
            //this.mChartctl.ChartBackground = Brushes.Transparent;

            //工具栏画线颜色
            this.mChartctl.ToolLineBrush = Brushes.Yellow;

            //工具栏写文字颜色
            this.mChartctl.ToolTextBrush = Brushes.LightBlue;

            //提示的类型            
            //this.mChartctl.TooltipType = enumTooltipType.DataAndCoordinate;
            //this.mChartctl.Height = mChartctl.Width = 0;
            //this.mChartctl.VerticalAlignment = VerticalAlignment.Stretch;

            this.mChartctl.GetModel();
            // this.panelTopoContainer.Children.Add(this.mChartctl);
        }
    }


    #region 基本配置面板
    #region 基本配置
    public class CreateBaseFactory : BaseFactory
    {
        /// <summary>
        /// 图例的位置设置
        /// </summary>
        ComboBox _CutlinePlaceComboBox = null;
        /// <summary>
        /// 是否显示网格线
        /// </summary>
        CheckBox ShowLineCheckBox = new CheckBox();

        /// <summary>
        /// Tooltip设置下拉列表
        /// </summary>
        ComboBox _tooltipBox = new ComboBox();
        public CreateBaseFactory(ChartControl cc)
            : base(cc)
        { }
        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            mChartctl.Type = ChartType.Histogram;
            base.StatusInfo = "ChartControl的一些基本属性设置";

            //创建控制面板
            StackPanel panel = new StackPanel();

            Grid grid = new Grid();
            grid.Background = Brushes.Transparent;
            ColumnDefinition col1 = new ColumnDefinition();
            col1.Width = new GridLength(100);
            grid.ColumnDefinitions.Add(col1);

            ColumnDefinition col2 = new ColumnDefinition();
            col2.Width = new GridLength(150);
            grid.ColumnDefinitions.Add(col2);

            //该变图例位置选择框
            RowDefinition row1 = new RowDefinition();
            grid.RowDefinitions.Add(row1);

            Label lbl1 = new Label();
            lbl1.Content = "调整图例的位置";
            Grid.SetColumn(lbl1, 0);
            Grid.SetRow(lbl1, 0);
            grid.Children.Add(lbl1);

            _CutlinePlaceComboBox = new ComboBox();
            foreach (enumCutlinePlace value in Enum.GetValues(typeof(enumCutlinePlace)))
            {
                ComboBoxItem oItem = new ComboBoxItem();
                oItem.Content = value.ToString();
                oItem.Tag = value;

                _CutlinePlaceComboBox.Items.Add(oItem);

                if (value == mChartctl.CutlinePlace)
                {
                    _CutlinePlaceComboBox.SelectedItem = oItem;
                }
            }

            _CutlinePlaceComboBox.SelectionChanged += new SelectionChangedEventHandler(_CutlinePlaceComboBox_SelectionChanged);

            Grid.SetRow(_CutlinePlaceComboBox, 0);
            Grid.SetColumn(_CutlinePlaceComboBox, 1);
            grid.Children.Add(_CutlinePlaceComboBox);

            //是否显示网格线
            RowDefinition row2 = new RowDefinition();
            grid.RowDefinitions.Add(row2);

            Label lbl3 = new Label();
            lbl3.Content = "网格线设置";
            Grid.SetColumn(lbl3, 0);
            Grid.SetRow(lbl3, 1);
            grid.Children.Add(lbl3);

            ShowLineCheckBox.Content = "不显示网格线";
            ShowLineCheckBox.Click += new RoutedEventHandler(ShowLineCheckBox_Click);
            Grid.SetColumn(ShowLineCheckBox, 1);
            Grid.SetRow(ShowLineCheckBox, 1);
            grid.Children.Add(ShowLineCheckBox);

            ShowLineCheckBox.IsChecked = !mChartctl.ShowGrid;


            //ToolTip设置
            RowDefinition row3 = new RowDefinition();
            grid.RowDefinitions.Add(row3);

            Label lbl2 = new Label();
            lbl2.Content = "ToolTip设置";
            Grid.SetColumn(lbl2, 0);
            Grid.SetRow(lbl2, 2);
            grid.Children.Add(lbl2);

            _tooltipBox = new ComboBox();
            _tooltipBox.SelectionChanged += new SelectionChangedEventHandler(_tooltipBox_SelectionChanged);
            foreach (enumTooltipType type in Enum.GetValues(typeof(enumTooltipType)))
            {
                ComboBoxItem oItem = new ComboBoxItem();
                oItem.Content = DemoChartUtil.GetToolTipFmtString(type);
                oItem.Tag = type;
                _tooltipBox.Items.Add(oItem);

                if (type == mChartctl.TooltipType)
                {
                    _tooltipBox.SelectedItem = oItem;
                }
            }
            Grid.SetColumn(_tooltipBox, 1);
            Grid.SetRow(_tooltipBox, 2);
            grid.Children.Add(_tooltipBox);
            panel.Children.Add(grid);

            return panel;
        }

        void _tooltipBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_tooltipBox.SelectedItem != null)
            {
                mChartctl.TooltipType = (enumTooltipType)((ComboBoxItem)_tooltipBox.SelectedItem).Tag;
                mChartctl.Refresh();
            }
        }

        void ShowLineCheckBox_Click(object sender, RoutedEventArgs e)
        {
            //是否显示网格线
            if ((bool)ShowLineCheckBox.IsChecked)
            {
                mChartctl.ShowGrid = false;
            }
            else
            {
                mChartctl.ShowGrid = true;
            }
            mChartctl.Refresh();
        }

        void _CutlinePlaceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //调整图例位置
            if (_CutlinePlaceComboBox.SelectedItem != null)
            {
                ComboBoxItem oItem = (ComboBoxItem)_CutlinePlaceComboBox.SelectedItem;
                mChartctl.CutlinePlace = (enumCutlinePlace)oItem.Tag;

            }
            mChartctl.Refresh();
        }
    }
    #endregion

    #region 颜色配置
    public class CreateBaseColorFactory : BaseFactory
    {
        //背景颜色设置下拉列表
        private ComboBox _colorbox = null;
        //工具栏画线颜色设置
        private ComboBox _colorToolLineBox = null;
        //工具栏文字颜色设置
        private ComboBox _colorTextBox = null;
        //分段颜色设置
        private ComboBox _colorAreaBox = null;

        //图表图形背景色设置
        private ComboBox _colorbgBox = null;
        public CreateBaseColorFactory(ChartControl cc)
            : base(cc)
        { }
        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "ChartControl的背景颜色,工具栏画线颜色,工具栏文字颜色,分段颜色,图表背景色设置";
            mChartctl.Type = ChartType.Histogram;

            //设置颜色设置控制面板
            StackPanel panel = new StackPanel();

            Grid grid = new Grid();
            grid.Background = Brushes.Transparent;
            ColumnDefinition col1 = new ColumnDefinition();
            col1.Width = new GridLength(150);
            grid.ColumnDefinitions.Add(col1);

            ColumnDefinition col2 = new ColumnDefinition();
            col2.Width = new GridLength(150);
            grid.ColumnDefinitions.Add(col2);



            //设置背景颜色
            RowDefinition row1 = new RowDefinition();
            grid.RowDefinitions.Add(row1);
            Label bglabel = new Label();
            bglabel.Background = Brushes.Transparent;
            bglabel.Content = "设置Chart背景颜色";
            Grid.SetColumn(bglabel, 0);
            Grid.SetRow(bglabel, 0);
            grid.Children.Add(bglabel);

            _colorbox = DemoChartUtil.CreateColorComboBox(mChartctl.Background);
            _colorbox.SelectionChanged += new SelectionChangedEventHandler(_colorbox_SelectionChanged);
            Grid.SetColumn(_colorbox, 1);
            Grid.SetRow(_colorbox, 0);
            grid.Children.Add(_colorbox);

            //工具栏画线颜色设置
            RowDefinition row2 = new RowDefinition();
            grid.RowDefinitions.Add(row2);

            Label label2 = new Label();
            label2.Background = Brushes.Transparent;
            label2.Content = "工具栏画线颜色";
            Grid.SetColumn(label2, 0);
            Grid.SetRow(label2, 1);
            grid.Children.Add(label2);

            _colorToolLineBox = DemoChartUtil.CreateColorComboBox(mChartctl.ToolLineBrush);
            _colorToolLineBox.SelectionChanged += new SelectionChangedEventHandler(_colorToolLineBox_SelectionChanged);
            Grid.SetColumn(_colorToolLineBox, 1);
            Grid.SetRow(_colorToolLineBox, 1);
            grid.Children.Add(_colorToolLineBox);


            //工具栏文字颜色设置
            RowDefinition row3 = new RowDefinition();
            grid.RowDefinitions.Add(row3);

            Label label3 = new Label();
            label3.Background = Brushes.Transparent;
            label3.Content = "工具栏文字颜色";
            Grid.SetColumn(label3, 0);
            Grid.SetRow(label3, 2);
            grid.Children.Add(label3);

            _colorTextBox = DemoChartUtil.CreateColorComboBox(mChartctl.ToolTextBrush);
            _colorTextBox.SelectionChanged += new SelectionChangedEventHandler(_colorTextBox_SelectionChanged);
            Grid.SetColumn(_colorTextBox, 1);
            Grid.SetRow(_colorTextBox, 2);
            grid.Children.Add(_colorTextBox);

            //分段颜色设置
            RowDefinition row4 = new RowDefinition();
            grid.RowDefinitions.Add(row4);

            Label label4 = new Label();
            label4.Background = Brushes.Transparent;
            label4.Content = "分段颜色设置";
            Grid.SetColumn(label4, 0);
            Grid.SetRow(label4, 3);
            grid.Children.Add(label4);

            _colorAreaBox = DemoChartUtil.CreateColorComboBox(mChartctl.Background);
            _colorAreaBox.SelectionChanged += new SelectionChangedEventHandler(_colorAreaBox_SelectionChanged);
            Grid.SetColumn(_colorAreaBox, 1);
            Grid.SetRow(_colorAreaBox, 3);
            grid.Children.Add(_colorAreaBox);

            //图表图形背景色设置
            RowDefinition row5 = new RowDefinition();
            grid.RowDefinitions.Add(row5);
            Label label5 = new Label();
            label5.Background = Brushes.Transparent;
            label5.Content = "图表图形背景色";
            Grid.SetColumn(label5, 0);
            Grid.SetRow(label5, 4);
            grid.Children.Add(label5);


            _colorbgBox = DemoChartUtil.CreateColorComboBox(mChartctl.ChartBackground);
            _colorbgBox.SelectionChanged += new SelectionChangedEventHandler(_colorbgBox_SelectionChanged);
            Grid.SetColumn(_colorbgBox, 1);
            Grid.SetRow(_colorbgBox, 4);
            grid.Children.Add(_colorbgBox);

            panel.Children.Add(grid);

            return panel;
        }

        void _colorbgBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_colorbgBox.SelectedItem != null)
            {
                mChartctl.ChartBackground = ((ComboBoxItem)_colorbgBox.SelectedItem).Background;
                mChartctl.Refresh();
            }
        }

        void _colorAreaBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_colorAreaBox.SelectedItem != null)
            {
                mChartctl.SetAreaColor("2", "4", ((ComboBoxItem)_colorbgBox.SelectedItem).Background);
                mChartctl.SetAreaColor("1", ((ComboBoxItem)_colorbgBox.SelectedItem).Background);
                mChartctl.SetAreaColor("5", SetAreaColorType.Back, ((ComboBoxItem)_colorbgBox.SelectedItem).Background);
                mChartctl.Refresh();
            }

        }

        void _colorTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_colorTextBox.SelectedItem != null)
            {
                mChartctl.ToolTextBrush = ((ComboBoxItem)_colorTextBox.SelectedItem).Background;
                mChartctl.Refresh();
            }
        }

        void _colorToolLineBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_colorToolLineBox.SelectedItem != null)
            {
                mChartctl.ToolLineBrush = ((ComboBoxItem)_colorToolLineBox.SelectedItem).Background;
                mChartctl.Refresh();
            }
        }

        void _colorbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_colorbox.SelectedItem != null)
            {
                mChartctl.Background = ((ComboBoxItem)_colorbox.SelectedItem).Background;
                mChartctl.Refresh();
            }
        }
    }

    #endregion

    #region 视图转换
    public class CreateChangedFactory : BaseFactory
    {
        ComboBox _ChartTypeComboBox = null;
        public CreateChangedFactory(ChartControl cc)
            : base(cc)
        { }
        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "ChartControl组件采用MVC模式开发,可以基于同一组数据进行各种形式的表现";
            mChartctl.Type = ChartType.Histogram;
            StackPanel panel = new StackPanel();

            Grid grid = new Grid();
            grid.Background = Brushes.Transparent;
            ColumnDefinition col1 = new ColumnDefinition();
            col1.Width = new GridLength(100);
            grid.ColumnDefinitions.Add(col1);

            ColumnDefinition col2 = new ColumnDefinition();
            col2.Width = new GridLength(150);
            grid.ColumnDefinitions.Add(col2);

            //该变图例类型选择框
            RowDefinition row1 = new RowDefinition();
            grid.RowDefinitions.Add(row1);

            Label lbl1 = new Label();
            lbl1.Content = "改变图例的类型";
            Grid.SetColumn(lbl1, 0);
            Grid.SetRow(lbl1, 0);
            grid.Children.Add(lbl1);



            //视图切换
            _ChartTypeComboBox = new ComboBox();
            foreach (ChartType type in Enum.GetValues(typeof(ChartType)))
            {
                ComboBoxItem oItem = new ComboBoxItem();
                oItem.Content = DemoChartUtil.GetTypeFmtString(type);
                oItem.Tag = type;
                _ChartTypeComboBox.Items.Add(oItem);
            }

            foreach (ComboBoxItem oItem in _ChartTypeComboBox.Items)
            {
                if ((ChartType)oItem.Tag == mChartctl.Type)
                {
                    _ChartTypeComboBox.SelectedItem = oItem;
                }
            }

            _ChartTypeComboBox.SelectionChanged += new SelectionChangedEventHandler(_ChartTypeComboBox_SelectionChanged);

            Grid.SetRow(_ChartTypeComboBox, 0);
            Grid.SetColumn(_ChartTypeComboBox, 1);
            grid.Children.Add(_ChartTypeComboBox);

            panel.Children.Add(grid);

            return panel;

        }

        void _ChartTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_ChartTypeComboBox.SelectedItem != null)
            {
                mChartctl.Type = (ChartType)((ComboBoxItem)_ChartTypeComboBox.SelectedItem).Tag;
                mChartctl.Refresh();
            }
        }
    }

    #endregion

    #region 事件
    public class CreateEventFactory : BaseFactory
    {
        private TextBox _tbMouseLeftDown = null;
        private TextBox _tbMouseleftUp = null;
        private TextBox _tbMouseRightDown = null;
        private TextBox _tbMouseRightUp = null;
        private TextBox _tbMouseDoubleClick = null;
        public CreateEventFactory(ChartControl cc)
            : base(cc)
        { }
        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "ChartControl的一些事件响应处理";

            //为了能够显示鼠标消息，首先屏蔽组件的右键菜单弹出功能
            mChartctl.ShowRightUserDefinedMenu = false;

            StackPanel panel = new StackPanel();

            Grid grid = new Grid();
            grid.Background = Brushes.Transparent;
            ColumnDefinition col1 = new ColumnDefinition();
            col1.Width = new GridLength(150);
            grid.ColumnDefinitions.Add(col1);

            ColumnDefinition col2 = new ColumnDefinition();
            col2.Width = new GridLength(200);
            grid.ColumnDefinitions.Add(col2);

            //响应左键按下
            RowDefinition row1 = new RowDefinition();
            grid.RowDefinitions.Add(row1);

            Label lbl1 = new Label();
            lbl1.Content = "鼠标左键按下提示的文本";
            Grid.SetColumn(lbl1, 0);
            Grid.SetRow(lbl1, 0);
            grid.Children.Add(lbl1);

            _tbMouseLeftDown = new TextBox();

            Grid.SetRow(_tbMouseLeftDown, 0);
            Grid.SetColumn(_tbMouseLeftDown, 1);
            grid.Children.Add(_tbMouseLeftDown);

            //响应左键抬起
            RowDefinition row2 = new RowDefinition();
            grid.RowDefinitions.Add(row2);

            Label lbl2 = new Label();
            lbl2.Content = "鼠标左键抬起提示的文本";
            Grid.SetColumn(lbl2, 0);
            Grid.SetRow(lbl2, 1);
            grid.Children.Add(lbl2);

            _tbMouseleftUp = new TextBox();

            Grid.SetRow(_tbMouseleftUp, 1);
            Grid.SetColumn(_tbMouseleftUp, 1);
            grid.Children.Add(_tbMouseleftUp);

            //响应右键按下
            RowDefinition row3 = new RowDefinition();
            grid.RowDefinitions.Add(row3);

            Label lbl3 = new Label();
            lbl3.Content = "鼠标右键按下提示的文本";
            Grid.SetColumn(lbl3, 0);
            Grid.SetRow(lbl3, 2);
            grid.Children.Add(lbl3);

            _tbMouseRightDown = new TextBox();

            Grid.SetRow(_tbMouseRightDown, 2);
            Grid.SetColumn(_tbMouseRightDown, 1);
            grid.Children.Add(_tbMouseRightDown);

            //响应右键抬起
            RowDefinition row4 = new RowDefinition();
            grid.RowDefinitions.Add(row4);

            Label lbl4 = new Label();
            lbl4.Content = "鼠标右键抬起提示的文本";
            Grid.SetColumn(lbl2, 0);
            Grid.SetRow(lbl4, 3);
            grid.Children.Add(lbl4);

            _tbMouseRightUp = new TextBox();

            Grid.SetRow(_tbMouseRightUp, 3);
            Grid.SetColumn(_tbMouseRightUp, 1);
            grid.Children.Add(_tbMouseRightUp);

            //响应双击事件
            RowDefinition row5 = new RowDefinition();
            grid.RowDefinitions.Add(row5);

            Label lbl5 = new Label();
            lbl5.Content = "鼠标双击事件提示的文本";
            Grid.SetColumn(lbl5, 0);
            Grid.SetRow(lbl5, 4);
            grid.Children.Add(lbl5);

            _tbMouseDoubleClick = new TextBox();

            Grid.SetRow(_tbMouseDoubleClick, 4);
            Grid.SetColumn(_tbMouseDoubleClick, 1);
            grid.Children.Add(_tbMouseDoubleClick);

            panel.Children.Add(grid);

            //响应ChartControl事件
            mChartctl.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(mChartctl_MouseLeftButtonUp);
            mChartctl.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(mChartctl_MouseLeftButtonDown);
            mChartctl.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(mChartctl_MouseRightButtonDown);
            mChartctl.MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(mChartctl_MouseRightButtonUp);
            mChartctl.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(mChartctl_MouseDoubleClick);


            return panel;
        }


        void mChartctl_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.StatusInfo = string.Format("发生鼠标双击事件,提示文本为{0}", _tbMouseDoubleClick.Text);
        }

        void mChartctl_MouseRightButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.StatusInfo = string.Format("发生鼠标右键抬起事件,提示文本为{0}", _tbMouseRightUp.Text);
        }

        void mChartctl_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.StatusInfo = string.Format("发生鼠标右键按下事件,提示文本为{0}", _tbMouseRightDown.Text);
        }

        void mChartctl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.StatusInfo = string.Format("发生鼠标左键按下事件,提示文本为{0}", _tbMouseLeftDown.Text);
        }

        void mChartctl_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.StatusInfo = string.Format("发生鼠标左键抬起事件,提示文本为{0}", _tbMouseleftUp.Text);
        }
    }
    #endregion

    #region 右键菜单
    public class CreateMenuFactory : BaseFactory
    {
        CheckBox _cbShowMenu = null;
        private TextBox _tbRightMenu = null;
        public CreateMenuFactory(ChartControl cc)
            : base(cc)
        { }
        public override StackPanel CreateChartContainer()
        {

            base.StatusInfo = "右键菜单的设置";
            mChartctl.Type = ChartType.Histogram;
            StackPanel panel = new StackPanel();

            Grid grid = new Grid();
            grid.Background = Brushes.Transparent;
            ColumnDefinition col1 = new ColumnDefinition();
            col1.Width = new GridLength(100);
            grid.ColumnDefinitions.Add(col1);

            ColumnDefinition col2 = new ColumnDefinition();
            col2.Width = new GridLength(200);
            grid.ColumnDefinitions.Add(col2);


            //添加右键菜单
            RowDefinition row1 = new RowDefinition();
            grid.RowDefinitions.Add(row1);

            Label lbl1 = new Label();
            lbl1.Content = "添加右键菜单";
            Grid.SetColumn(lbl1, 0);
            Grid.SetRow(lbl1, 0);
            grid.Children.Add(lbl1);

            _tbRightMenu = new TextBox();
            Button bn = new Button();
            bn.Width = 80;
            bn.Content = "添加";
            bn.Click += new RoutedEventHandler(bn_Click);
            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;

            sp.Children.Add(_tbRightMenu);
            sp.Children.Add(bn);

            Grid.SetRow(sp, 0);
            Grid.SetColumn(sp, 1);
            grid.Children.Add(sp);

            //是否显示右键菜单
            RowDefinition row2 = new RowDefinition();
            grid.RowDefinitions.Add(row2);

            Label lbl2 = new Label();
            lbl2.Content = "显示右键菜单";
            Grid.SetColumn(lbl2, 0);
            Grid.SetRow(lbl2, 1);
            grid.Children.Add(lbl2);

            mChartctl.ShowRightUserDefinedMenu = true;
            _cbShowMenu = new CheckBox();
            _cbShowMenu.Content = "不显示右键菜单";
            _cbShowMenu.Click += new RoutedEventHandler(_cbShowMenu_Click);
            _cbShowMenu.IsChecked = !mChartctl.ShowRightUserDefinedMenu;

            Grid.SetColumn(_cbShowMenu, 1);
            Grid.SetRow(_cbShowMenu, 1);
            grid.Children.Add(_cbShowMenu);

            panel.Children.Add(grid);

            return panel;

        }

        void _cbShowMenu_Click(object sender, RoutedEventArgs e)
        {
            mChartctl.ShowRightUserDefinedMenu = !((bool)_cbShowMenu.IsChecked);

        }

        void bn_Click(object sender, RoutedEventArgs e)
        {
            if (_tbRightMenu.Text.Trim() == "")
            {
                MessageBox.Show("右键菜单文本不能为空", "错误", MessageBoxButton.OK);

                return;
            }

            MenuItem it = new MenuItem();
            it.Header = _tbRightMenu.Text.Trim();
            mChartctl.RightUserDefinedMenu.Items.Add(it);

            base.StatusInfo = string.Format("添加右键菜单成功，菜单名为{0}", it.Header);

        }

    }
    #endregion

    #endregion

    #region 折线图配置面板
    public class CreateLineFactory : BaseFactory
    {
        /// <summary>
        /// 开启多纵轴
        /// </summary>
        CheckBox SeriesAdscriptionAxisCheckBox = new CheckBox();
        public CreateLineFactory(ChartControl cc)
            : base(cc)
        { }
        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "折线图";

            StackPanel panel = new StackPanel();

            SeriesAdscriptionAxisCheckBox.Content = "开启多纵轴";
            SeriesAdscriptionAxisCheckBox.Click += new RoutedEventHandler(SeriesAdscriptionAxisCheckBox_Click);
            panel.Children.Add(SeriesAdscriptionAxisCheckBox);

            mChartctl.Type = ChartType.Line;
            mChartctl.GetModel();

            mChartctl.Refresh();
            return panel;
        }

        void SeriesAdscriptionAxisCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (SeriesAdscriptionAxisCheckBox.IsChecked.HasValue)
            {
                if (SeriesAdscriptionAxisCheckBox.IsChecked.Value)
                {
                    mChartctl.Histogram.SeriesList[0].SeriesAdscriptionAxis = enumSeriesAdscriptionAxis.Right;
                }
                else
                {
                    mChartctl.Histogram.SeriesList[0].SeriesAdscriptionAxis = enumSeriesAdscriptionAxis.Left;
                }
                mChartctl.Refresh();
            }
        }

    }
    #endregion

    #region 散点图配置面板
    public class CreateSpotFactory : BaseFactory
    {
        public CreateSpotFactory(ChartControl cc)
            : base(cc)
        { }
        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "散点图";

            mChartctl.Type = ChartType.Quadrant;
            mChartctl.GetModel();
            mChartctl.Refresh();
            return null;
        }

    }
    #endregion

    #region 柱状图和折线图配置面板
    public class CreateHistogramLineFactory : BaseFactory
    {
        /// <summary>
        /// 开启多纵轴
        /// </summary>
        CheckBox SeriesAdscriptionAxisCheckBox = new CheckBox();
        public CreateHistogramLineFactory(ChartControl cc)
            : base(cc)
        { }
        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "柱状折线图";

            //创建控制面板
            StackPanel panel = new StackPanel();
            SeriesAdscriptionAxisCheckBox.Content = "开启多纵轴";
            SeriesAdscriptionAxisCheckBox.Click += new RoutedEventHandler(SeriesAdscriptionAxisCheckBox_Click);
            panel.Children.Add(SeriesAdscriptionAxisCheckBox);


            mChartctl.Type = ChartType.HistogramAndLine;
            mChartctl.GetModel();



            mChartctl.Refresh();
            return panel;
        }

        void SeriesAdscriptionAxisCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (SeriesAdscriptionAxisCheckBox.IsChecked.HasValue)
            {
                if (SeriesAdscriptionAxisCheckBox.IsChecked.Value)
                {
                    mChartctl.Histogram.SeriesList[0].SeriesAdscriptionAxis = enumSeriesAdscriptionAxis.Right;
                }
                else
                {
                    mChartctl.Histogram.SeriesList[0].SeriesAdscriptionAxis = enumSeriesAdscriptionAxis.Left;
                }
                mChartctl.Refresh();
            }
        }

    }
    #endregion

    #region 住状图配置面版
    public class CreateHistogramFactory : BaseFactory
    {
        /// <summary>
        /// 柱图类型
        /// </summary>
        ComboBox HistogramType = new ComboBox();

        /// <summary>
        /// 开启多纵轴
        /// </summary>
        CheckBox SeriesAdscriptionAxisCheckBox = new CheckBox();
        public CreateHistogramFactory(ChartControl cc)
            : base(cc)
        { }

        /// <summary>
        /// 柱图显示类型
        /// </summary>
        CheckBox HistogramShowTypeCheckBox = new CheckBox();


        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "柱状图";

            mChartctl.Type = ChartType.Quadrant;
            mChartctl.GetModel();
            StackPanel panel = new StackPanel();



            foreach (Histogram.enumHistogramType type in Enum.GetValues(typeof(Histogram.enumHistogramType)))
            {
                ComboBoxItem oItem = new ComboBoxItem();
                oItem.Content = DemoChartUtil.GetHistogramTypeFmtString(type);
                oItem.Tag = type;
                HistogramType.Items.Add(oItem);
                if (type == mChartctl.Histogram.HistogramType)
                {
                    HistogramType.SelectedItem = oItem;
                }

            }

            HistogramType.SelectionChanged += new SelectionChangedEventHandler(HistogramType_SelectionChanged);
            panel.Children.Add(HistogramType);

            HistogramShowTypeCheckBox.Content = "仿3D";
            panel.Children.Add(HistogramShowTypeCheckBox);
            HistogramShowTypeCheckBox.Click += new RoutedEventHandler(HistogramShowTypeCheckBox_Click);


            SeriesAdscriptionAxisCheckBox.Content = "开启多纵轴";
            SeriesAdscriptionAxisCheckBox.Click += new RoutedEventHandler(SeriesAdscriptionAxisCheckBox_Click);
            panel.Children.Add(SeriesAdscriptionAxisCheckBox);

            mChartctl.Refresh();
            return panel;
        }

        void SeriesAdscriptionAxisCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (SeriesAdscriptionAxisCheckBox.IsChecked.HasValue)
            {
                if (SeriesAdscriptionAxisCheckBox.IsChecked.Value)
                {
                    mChartctl.Histogram.SeriesList[0].SeriesAdscriptionAxis = enumSeriesAdscriptionAxis.Right;
                }
                else
                {
                    mChartctl.Histogram.SeriesList[0].SeriesAdscriptionAxis = enumSeriesAdscriptionAxis.Left;
                }
                mChartctl.Refresh();
            }
        }

        void HistogramShowTypeCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (HistogramShowTypeCheckBox.IsChecked.HasValue)
            {
                if (HistogramShowTypeCheckBox.IsChecked.Value)
                {
                    mChartctl.Histogram.ShowType = enumShowType.TwoDImitateThreeD;
                }
                else
                {
                    mChartctl.Histogram.ShowType = enumShowType.TwoD;
                }

                mChartctl.Refresh();
            }
        }
        void HistogramType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HistogramType.SelectedItem != null)
            {
                mChartctl.Histogram.HistogramType = (Histogram.enumHistogramType)((ComboBoxItem)HistogramType.SelectedItem).Tag;
                mChartctl.Refresh();
            }
        }
        /*void HistogramButton_Click(object sender, RoutedEventArgs e)
        {
            
            mChartctl.Type = ChartType.Histogram;
            mChartctl.GetModel();

            switch (HistogramType.SelectedIndex)
            {
                //普通柱图
                case 0:
                    mChartctl.Histogram.HistogramType = Histogram.enumHistogramType.Common;

                    //开启多纵轴
                    mChartctl.Histogram.SeriesList[0].SeriesAdscriptionAxis = enumSeriesAdscriptionAxis.Right;
                    break;
                //百分比
                case 1:
                    mChartctl.Histogram.HistogramType = Histogram.enumHistogramType.Percent;
                    break;
                //叠加
                case 2:
                    mChartctl.Histogram.HistogramType = Histogram.enumHistogramType.Splice;
                    break;
            }
            //仿3D柱图
            if ((bool)HistogramShowTypeCheckBox.IsChecked)
            {
                mChartctl.Histogram.ShowType = enumShowType.TwoDImitateThreeD;
            }
            //2D柱图
            else
            {
                mChartctl.Histogram.ShowType = enumShowType.TwoD;
            }
            

            //刷新
            mChartctl.Refresh();

        }*/
    }
    #endregion

    #region 饼图配置面版
    public class CreatePieFactory : BaseFactory
    {
        /// <summary>
        /// 饼图的多饼同时显示时是横排，还是纵排
        /// </summary>
        CheckBox PieArrangeCheckBox = new CheckBox();

        /// <summary>
        /// 饼图按系列显示
        /// </summary>
        CheckBox PieSeriesCheckBox = new CheckBox();
        public CreatePieFactory(ChartControl cc)
            : base(cc)
        { }

        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "饼图";

            mChartctl.Type = ChartType.Quadrant;
            mChartctl.GetModel();

            StackPanel panel = new StackPanel();
            panel.Orientation = Orientation.Vertical;

            PieArrangeCheckBox.Content = "横排显示";
            PieArrangeCheckBox.Click += new RoutedEventHandler(PieArrangeCheckBox_Click);
            panel.Children.Add(PieArrangeCheckBox);

            PieSeriesCheckBox.Content = "按系列画饼";
            PieSeriesCheckBox.Click += new RoutedEventHandler(PieSeriesCheckBox_Click);
            panel.Children.Add(PieSeriesCheckBox);

            mChartctl.Refresh();

            return panel;
        }

        void PieSeriesCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (PieSeriesCheckBox.IsChecked.HasValue)
            {
                if (PieSeriesCheckBox.IsChecked.Value)
                {
                    mChartctl.Pie.ItemType = true;
                }
                else
                {
                    mChartctl.Pie.ItemType = false;
                }
                mChartctl.Refresh();
            }
        }

        void PieArrangeCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (PieArrangeCheckBox.IsChecked.HasValue)
            {
                if (PieArrangeCheckBox.IsChecked.Value)
                {
                    mChartctl.Pie.arrange = range.horizontal;
                }
                else
                {
                    mChartctl.Pie.arrange = range.vertical;
                }
                mChartctl.Refresh();
            }
        }

    }
    #endregion

    #region 象限图配置面版
    public class CreateQuadrantFactory : BaseFactory
    {
        public CreateQuadrantFactory(ChartControl cc)
            : base(cc)
        { }

        public override void InitData()
        {
            if (this.mChartctl != null)
            {
                this.mChartctl.SeriesNames.Clear();
                this.mChartctl.SeriesValues.Clear();
            }
            int count = 10;

            //存储X轴值
            //string[] xvalues = { "潮州", "东莞", "佛山", "广州", "惠州", "江门", "深圳", "湛江", "中山", "珠海" };
            string[] xvalues = new string[count];// { "潮州", "东莞", "佛山", "广州" };

            //存储系列一的项
            double[] values1 = new double[count];

            //存储系列二的项
            //double[] values2 = new double[count];
            //double[] values3 = new double[count];
            //double[] values4 = new double[count];

            //生成数据
            for (int i = 0; i < count; i++)
            {
                xvalues[i] = (i * 0.1).ToString();
                values1[i] = Math.Sin((double)i * Math.PI / 15.0) * 59960.36760;
                //values2[i] = values1[i] * 3.5;
                //values3[i] = values1[i] * 2;
                //values4[i] = values1[i] * 1.5;

            }
            //添加系列名
            mChartctl.SeriesNames.Add("地区");
            //添加系列项
            mChartctl.SeriesValues.Add(values1);
            //添加X轴值 
            mChartctl.XAxisValues = xvalues;
            mChartctl.ToolsBackground = Brushes.Transparent;
        }
        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "象限图";

            //设置图表类型
            mChartctl.Type = ChartType.Line;

            mChartctl.GetModel();
            //mChartctl.Quadrant.xlineTitle = "无线接通率";
            //mChartctl.Quadrant.ylineTitle = "话务量";
            //设置象限图点的表现形式
            //mChartctl.Quadrant.SeriesList[0].ItemList[0].cutlineType = enumSymbolType.Diamond;
            //mChartctl.Quadrant.SeriesList[0].ItemList[1].cutlineType = enumSymbolType.ellipse;
            //mChartctl.Quadrant.SeriesList[0].ItemList[2].cutlineType = enumSymbolType.rectangle;

            ////设置象限线
            //mChartctl.Quadrant.QuadrantAxis.XQuadrantAxisList.Add(new QuadrantAxis.QuadrantAxisItem(0.35, enumDrowLineType.Normal));
            //mChartctl.Quadrant.QuadrantAxis.XQuadrantAxisList.Add(new QuadrantAxis.QuadrantAxisItem(0.8, enumDrowLineType.Broken));
            //mChartctl.Quadrant.QuadrantAxis.YQuadrantAxisList.Add(new QuadrantAxis.QuadrantAxisItem(19487.34, enumDrowLineType.Normal));
            //mChartctl.Quadrant.QuadrantAxis.YQuadrantAxisList.Add(new QuadrantAxis.QuadrantAxisItem(100, enumDrowLineType.Broken));

            ////设置象限名

            //mChartctl.Quadrant.QuadrantAxis.QuadrantText.Add("首要勿急");
            //mChartctl.Quadrant.QuadrantAxis.QuadrantText.Add("优先告警");
            ////mChartctl.Quadrant.QuadrantAxis.QuadrantText.Add("务必保持");
            //mChartctl.Quadrant.QuadrantAxis.QuadrantText.Add("优先告警");
            ////mChartctl.Quadrant.QuadrantAxis.QuadrantText.Add("务必保持");
            //mChartctl.Quadrant.QuadrantAxis.QuadrantText.Add("保持现状");

            //刷新
            //mChartctl.Refresh();
            return null;
        }
    }
    #endregion

    #region 雷达图配置面版
    public class CreateRadarFactory : BaseFactory
    {
        /// <summary>
        /// 雷达图的是否显示网格线
        /// </summary>
        CheckBox ShowGriddingLineCheckBox = new CheckBox();

        /// <summary>
        /// 雷达图的是否自定义网格线
        /// </summary>
        CheckBox RadarAxisCheckBox = new CheckBox();
        public CreateRadarFactory(ChartControl cc)
            : base(cc)
        { }

        public override void InitData()
        {
            if (this.mChartctl != null)
            {
                this.mChartctl.SeriesNames.Clear();
                this.mChartctl.SeriesValues.Clear();
            }
            int count = 4;

            //存储X轴值
            //string[] xvalues = { "潮州", "东莞", "佛山", "广州", "惠州", "江门", "深圳", "湛江", "中山", "珠海" };
            string[] xvalues = { "潮州", "东莞", "佛山", "广州" };

            //存储系列一的项
            double[] values1 = new double[count];

            //存储系列二的项
            double[] values2 = new double[count];
            double[] values3 = new double[count];
            double[] values4 = new double[count];

            //成生数据
            for (int i = 0; i < count; i++)
            {
                // xvalues[i] = i.ToString();
                values1[i] = Math.Sin((double)i * Math.PI / 15.0) * 16.0;
                values2[i] = values1[i] * 3.5;
                values3[i] = values1[i] * 2;
                values4[i] = values1[i] * 1.5;

            }
            //添加系列名
            mChartctl.SeriesNames.Add("潮州");
            mChartctl.SeriesNames.Add("东莞");
            mChartctl.SeriesNames.Add("佛山");
            mChartctl.SeriesNames.Add("广州");

            //添加系列项
            mChartctl.SeriesValues.Add(values1);
            mChartctl.SeriesValues.Add(values2);
            mChartctl.SeriesValues.Add(values3);
            mChartctl.SeriesValues.Add(values4);


            //添加X轴值
            mChartctl.XAxisValues = xvalues;
            mChartctl.ToolsBackground = Brushes.Transparent;
        }
        public override StackPanel CreateChartContainer()
        {
            base.CreateChartContainer();
            base.StatusInfo = "雷达图";

            //初始化配置面板
            StackPanel panel = new StackPanel();
            panel.Orientation = Orientation.Vertical;

            ShowGriddingLineCheckBox.Content = "不显示雷达线";
            ShowGriddingLineCheckBox.Click += new RoutedEventHandler(ShowGriddingLineCheckBox_Click);
            panel.Children.Add(ShowGriddingLineCheckBox);


            RadarAxisCheckBox.Content = "自定义网格线";
            RadarAxisCheckBox.Click += new RoutedEventHandler(RadarAxisCheckBox_Click);
            panel.Children.Add(RadarAxisCheckBox);

            //设置图表类型
            //mChartctl.Type = ChartType.Radar;




            //自定义设置
            mChartctl.GetModel();

            if ((bool)RadarAxisCheckBox.IsChecked)
            {
                //自定义雷达线
                RadarAxis radarAxis = new RadarAxis();

                //哪一项的雷达线
                radarAxis.ItemIndex = 1;

                //雷达线颜色
                radarAxis.ScaleColor = Brushes.Black;


                //雷达线最大值
                radarAxis.ScaleMax = 100;

                //雷达线最小值
                radarAxis.ScaleMin = -100;

                //雷达线段数
                radarAxis.ScaleStep = 5;

                //添加
                mChartctl.Radar.RadarAxisList.Add(radarAxis);
            }

            //是否显示雷达线
            mChartctl.Radar.ShowGriddingLine = !(bool)ShowGriddingLineCheckBox.IsChecked;

            //刷新
            mChartctl.Refresh();

            return panel;
        }

        void RadarAxisCheckBox_Click(object sender, RoutedEventArgs e)
        {

            mChartctl.SeriesSetting[1] = ChartType.Histogram;
            mChartctl.SeriesSetting[2] = ChartType.Line;
            mChartctl.SeriesSetting[3] = ChartType.Spot;
            mChartctl.SeriesSetting[4] = ChartType.Line;

            if ((bool)RadarAxisCheckBox.IsChecked)
            {
                //自定义雷达线
                RadarAxis radarAxis = new RadarAxis();

                //哪一项的雷达线
                radarAxis.ItemIndex = 1;

                //雷达线颜色
                radarAxis.ScaleColor = Brushes.Black;


                //雷达线最大值
                radarAxis.ScaleMax = 100;

                //雷达线最小值
                radarAxis.ScaleMin = -100;

                //雷达线段数
                radarAxis.ScaleStep = 5;

                //添加
                mChartctl.Radar.RadarAxisList.Add(radarAxis);

                mChartctl.Refresh();
            }


        }

        void ShowGriddingLineCheckBox_Click(object sender, RoutedEventArgs e)
        {
            mChartctl.Radar.ShowGriddingLine = !(bool)ShowGriddingLineCheckBox.IsChecked;
            mChartctl.Refresh();
        }

    }
    #endregion

    public class DemoChartUtil
    {
        public static string GetToolTipFmtString(enumTooltipType type)
        {
            string sret = string.Empty;
            switch (type)
            {
                case enumTooltipType.Custom:
                    sret = "自定义tooltip";
                    break;
                case enumTooltipType.Data:
                    sret = "数值Tooltip";
                    break;
                case enumTooltipType.DataAndCoordinate:
                    sret = "全称Tooltip";
                    break;
                case enumTooltipType.None:
                    sret = "没有Tooltip";
                    break;
                default:
                    sret = "未知类型";
                    break;
            }
            return sret;
        }
        public static string GetHistogramTypeFmtString(Histogram.enumHistogramType type)
        {
            string sret = string.Empty;
            switch (type)
            {
                case Histogram.enumHistogramType.Common:
                    sret = "普通";
                    break;
                case Histogram.enumHistogramType.Percent:
                    sret = "百分比";
                    break;
                case Histogram.enumHistogramType.Splice:
                    sret = "叠加";
                    break;
                default:
                    sret = "未知类型";
                    break;
            }
            return sret;
        }

        public static string GetTypeFmtString(ChartType type)
        {
            string sret = String.Empty;
            switch (type)
            {
                case ChartType.Histogram:
                    sret = "柱状图";
                    break;
                case ChartType.HistogramAndLine:
                    sret = "柱状折线图";
                    break;
                case ChartType.Line:
                    sret = "折线图";
                    break;
                case ChartType.Pie:
                    sret = "饼图";
                    break;
                case ChartType.Quadrant:
                    sret = "象限图";
                    break;
                case ChartType.Radar:
                    sret = "雷达图";
                    break;
                case ChartType.Spot:
                    sret = "散点图";
                    break;
                default:
                    sret = "未知类型";
                    break;
            }
            return sret;
        }
        public static ComboBox CreateColorComboBox(Brush bh)
        {
            ComboBox colorbox = new ComboBox();
            colorbox.SelectionChanged += new SelectionChangedEventHandler(colorbox_SelectionChanged);

            Type type = typeof(Brushes);
            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo prop in props)
            {

                ComboBoxItem oItem = new ComboBoxItem();
                oItem.Content = prop.Name;
                oItem.Background = (Brush)prop.GetValue(null, new object[] { });
                if (oItem.Background == bh)
                {
                    colorbox.SelectedItem = oItem;
                }

                colorbox.Items.Add(oItem);
            }
            TextBox oBox = new TextBox();

            return colorbox;
        }

        static void colorbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox colorbox = (ComboBox)sender;
            if (colorbox.SelectedItem != null)
            {
                colorbox.Background = ((ComboBoxItem)colorbox.SelectedItem).Background;
            }
        }
    }

}
