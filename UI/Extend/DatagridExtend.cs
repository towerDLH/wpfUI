using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using UI.DaTa;

namespace UI.Extend
{
    public class DatagridExtend : DataGrid
    {
        #region datagrid 序号扩展

        public static bool GetDisplayRowNumber(DependencyObject obj)
        {
            return (bool)obj.GetValue(DisplayRowNumberProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static void SetDisplayRowNumber(DependencyObject obj, bool value)
        {
            obj.SetValue(DisplayRowNumberProperty, value);
        }

        /// <summary>
        /// 设置是否显示行号
        /// </summary>
        public static readonly DependencyProperty DisplayRowNumberProperty =
            DependencyProperty.RegisterAttached("DisplayRowNumber",
                                                typeof(bool),
                                                typeof(DatagridExtend),
                                                new PropertyMetadata(false, OnDisplayRowNumberChanged));


        private static void OnDisplayRowNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DataGrid grid = d as DataGrid;
            if (grid == null)
            {
                return;
            }
            grid.HeadersVisibility = DataGridHeadersVisibility.Column;
            if ((bool)e.NewValue)
            {
                grid.LoadingRow += OnGridLoadingRow;
                //grid.UnloadingRow += OnGridUnloadingRow;
            }
            else
            {
                grid.LoadingRow -= OnGridLoadingRow;
                // grid.UnloadingRow -= OnGridUnloadingRow;
            }
        }

        private static void RefreshDataGridRowNumber(object sender)
        {
            DataGrid grid = sender as DataGrid;
            if (grid == null)
            {
                return;
            }

            foreach (var item in grid.Items)
            {
                var row = (DataGridRow)grid.ItemContainerGenerator.ContainerFromItem(item);
                if (row == null)
                {
                    return;
                }
            }
        }
        private static void OnGridUnloadingRow(object sender, DataGridRowEventArgs e)
        {
            RefreshDataGridRowNumber(sender);
        }

        private static void OnGridLoadingRow(object sender, DataGridRowEventArgs e)
        {
            gtdadjDel_LoadingRow(sender, e);
        }

        private static void gtdadjDel_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var index = e.Row.GetIndex();
            e.Row.Header = (index + 1).ToString();
        }
        #endregion

        #region datagrid 双击范围限定防止超出


        public static bool GetDataGridRange(DependencyObject obj)
        {
            return (bool)obj.GetValue(DataGridRangeProperty);
        }

        public static void SetDataGridRange(DependencyObject obj, bool value)
        {
            obj.SetValue(DataGridRangeProperty, value);
        }

        // Using a DependencyProperty as the backing store for DataGridRange.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DataGridRangeProperty =
            DependencyProperty.RegisterAttached("DataGridRange", typeof(bool), typeof(DatagridExtend), new PropertyMetadata(false, OnRangeChange));

        private static void OnRangeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DataGrid grid = d as DataGrid;
            if (grid == null)
            {
                return;
            }
            if ((bool)e.NewValue)
            {
                grid.MouseDoubleClick += OngrdMouseDoubleClick;
            }
            else
            {
                grid.MouseDoubleClick -= OngrdMouseDoubleClick;
            }
        }

        private static void OngrdMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid dtg = sender as DataGrid;
            if (dtg == null)
            {
                return;
            }
            IsDatagridDouble data = new IsDatagridDouble();
            if (!data.IsPostion(dtg, e) || dtg.SelectedItem == null) return;
        }


        #endregion

        #region 截取本身的滑动事件
        //todo 使用时datagrid 必须要有一个父级是grid 

        public static bool GetIsSlide(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsSlideProperty);
        }

        public static void SetIsSlide(DependencyObject obj, bool value)
        {
            obj.SetValue(IsSlideProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsSlide.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSlideProperty =
            DependencyProperty.RegisterAttached("IsSlide", typeof(bool), typeof(DatagridExtend), new PropertyMetadata(false, SlideChange));

        private static void SlideChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DataGrid grid = d as DataGrid;
            if (grid == null)
            {
                return;
            }
            if ((bool)e.NewValue)
            {
                grid.PreviewMouseWheel += DataGrid_PreviewMouseWheel;
            }
            else
            {
                grid.PreviewMouseWheel -= DataGrid_PreviewMouseWheel;
            }
        }


        private static void DataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (!e.Handled)
            {
                // 内层ListBox拦截鼠标滚轮事件
                e.Handled = true;
                // 激发一个鼠标滚轮事件，冒泡给外层ListBox接收到
                var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
                eventArg.RoutedEvent = UIElement.MouseWheelEvent;
                eventArg.Source = sender;
                var parent = ((Control)sender).Parent as UIElement;
                parent.RaiseEvent(eventArg);
            }
        }

        #endregion
    }
}
