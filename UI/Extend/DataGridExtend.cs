using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
namespace UI.Extend
{
    public class DataGridExtend : DataGrid
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
                                                typeof(DataGridExtend),
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
                // grid.UnloadingRow += OnGridUnloadingRow;
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
                row.Header = row.GetIndex() + 1;
            }
        }

        private static void OnGridUnloadingRow(object sender, DataGridRowEventArgs e)
        {
            gtdadjDel_LoadingRow(sender, e);
        }

        private static void OnGridLoadingRow(object sender, DataGridRowEventArgs e)
        {
            // RefreshDataGridRowNumber(sender);
            gtdadjDel_LoadingRow(sender, e);
        }

        private static void gtdadjDel_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var index = e.Row.GetIndex();
            e.Row.Header = (index + 1).ToString();
        }
        #endregion

        #region 截取本身的滑动事件



        public static bool GetIsSlide(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsSlideProperty);
        }

        public static void SetIsSlide(DependencyObject obj, bool value)
        {
            obj.SetValue(IsSlideProperty, value);
        }
        /// <summary>
        /// ture 将自身的滑动事件给父级，使用时父级为grid 
        /// </summary>
        // Using a DependencyProperty as the backing store for IsSlide.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSlideProperty =
            DependencyProperty.RegisterAttached("IsSlide", typeof(bool), typeof(DataGridExtend), new PropertyMetadata(false, SlideChange));

        private static void SlideChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DataGrid grid = d as DataGrid;
            if (grid == null)
            {
                return;
            }
            if ((bool)e.NewValue)
            {
                grid.SelectionMode = DataGridSelectionMode.Single;
                grid.PreviewMouseWheel += DataGrid_PreviewMouseWheel;
            }
            else
            {
                grid.SelectionMode = DataGridSelectionMode.Extended;
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
                var parent = ((System.Windows.Controls.Control)sender).Parent as UIElement;
                if (parent != null) parent.RaiseEvent(eventArg);
            }
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
            DependencyProperty.RegisterAttached("DataGridRange", typeof(bool), typeof(DataGridExtend), new PropertyMetadata(false, OnRangeChange));

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
    }
    internal class IsDatagridDouble
    {
        public bool IsPostion(DataGrid dtg, System.Windows.Input.MouseButtonEventArgs e)
        {
            Point aP = e.GetPosition(dtg);
            IInputElement obj = dtg.InputHitTest(aP);
            DependencyObject target = obj as DependencyObject;
            bool rowhit = false;
            while (target != null)
            {
                if (target is DataGridRow)
                {
                    rowhit = true;
                    break;
                }
                target = VisualTreeHelper.GetParent(target);
            }
            return rowhit;
        }
    }
}
