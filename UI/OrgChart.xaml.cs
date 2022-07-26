using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// OrgChart.xaml 的交互逻辑
    /// </summary>
    public partial class OrgChart : TreeView
    {
        #region 变量

        private const string PART_SCROLLVIEWER = "PART_Scrollviewer";
        private const string PART_BORDER = "PART_Border";

        private ScrollViewer _scrollViewer;
        private Pen _pen;

        #endregion

        #region 依赖属性

        #region 背景

        public static readonly new DependencyProperty BackgroundProperty = DependencyProperty.Register("Background", typeof(Brush), typeof(OrgChart), new PropertyMetadata(Brushes.White, ChangedBackgroundProperty));

        private static void ChangedBackgroundProperty(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var orgChart = obj as OrgChart;

            orgChart.InvalidateVisual();
        }

        /// <summary>
        /// 背景画刷
        /// </summary>
        public new Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        #endregion        

        #region 线性画刷

        /// <summary>
        /// 线性画刷
        /// </summary>
        public static readonly DependencyProperty LineBrushProperty = DependencyProperty.Register("LineBrush", typeof(Brush), typeof(OrgChart), new PropertyMetadata(Brushes.Gray, ChangedLineBrushProperty));

        private static void ChangedLineBrushProperty(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var orgChart = obj as OrgChart;

            orgChart._pen.Brush = e.NewValue as Brush;
            orgChart.InvalidateVisual();
        }

        /// <summary>
        /// 线性画刷
        /// </summary>
        public Brush LineBrush
        {
            get { return (Brush)GetValue(LineBrushProperty); }
            set { SetValue(LineBrushProperty, value); }
        }

        #endregion        

        #region 线条粗细

        public static readonly DependencyProperty LineThicknessProperty = DependencyProperty.Register("LineThickness", typeof(double), typeof(OrgChart), new PropertyMetadata(1d, ChangedLineThicknessProperty));

        private static void ChangedLineThicknessProperty(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var orgChart = obj as OrgChart;

            orgChart._pen.Thickness = (double)e.NewValue;
            orgChart.InvalidateVisual();
        }
        /// <summary>
        /// 线条粗细
        /// </summary>
        public double LineThickness
        {
            get { return (double)GetValue(LineThicknessProperty); }
            set { SetValue(LineThicknessProperty, value); }
        }

        #endregion

        #region 箭头大小

        /// <summary>
        /// 箭头大小
        /// </summary>
        public static readonly DependencyProperty ArrowSizeProperty = DependencyProperty.Register("ArrowSize", typeof(double), typeof(OrgChart), new PropertyMetadata(6d, ChangedArrowSizeProperty));

        private static void ChangedArrowSizeProperty(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var orgChart = obj as OrgChart;

            orgChart._pen.Thickness = (double)e.NewValue;
            orgChart.InvalidateVisual();
        }

        /// <summary>
        /// 箭头大小
        /// </summary>
        public double ArrowSize
        {
            get { return (double)GetValue(ArrowSizeProperty); }
            set { SetValue(ArrowSizeProperty, value); }
        }

        #endregion

        #region 垂直偏移量

        public static readonly DependencyProperty VerticalOffsetProperty = DependencyProperty.Register("VerticalOffset", typeof(double), typeof(OrgChart), new PropertyMetadata(50d, ChangedVerticalOffsetProperty));

        private static void ChangedVerticalOffsetProperty(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var orgChart = obj as OrgChart;

            orgChart.InvalidateVisual();
        }

        /// <summary>
        /// 垂直偏移量
        /// </summary>
        public double VerticalOffset
        {
            get { return (double)GetValue(VerticalOffsetProperty); }
            set { SetValue(VerticalOffsetProperty, value); }
        }

        #endregion

        #region 水平偏移量

        public static readonly DependencyProperty HorizontalOffsetProperty = DependencyProperty.Register("HorizontalOffset", typeof(double), typeof(OrgChart), new PropertyMetadata(20d, ChangedHorizontalOffsetProperty));

        private static void ChangedHorizontalOffsetProperty(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var orgChart = obj as OrgChart;

            orgChart.InvalidateVisual();
        }
        /// <summary>
        /// 水平偏移量
        /// </summary>
        public double HorizontalOffset
        {
            get { return (double)GetValue(HorizontalOffsetProperty); }
            set { SetValue(HorizontalOffsetProperty, value); }
        }

        #endregion

        #endregion

        #region 构造函数

        public OrgChart()
        {
            InitializeComponent();

            _pen = new Pen(LineBrush, LineThickness);

            BorderThickness = new Thickness(0);
            base.Background = Brushes.Transparent;
            ClipToBounds = true;

            AddHandler(TreeViewItem.ExpandedEvent, new RoutedEventHandler((s, e) => InvalidateVisualFromItem(e.OriginalSource)));
            AddHandler(TreeViewItem.CollapsedEvent, new RoutedEventHandler((s, e) => InvalidateVisualFromItem(e.OriginalSource)));
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 应用模板
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (DesignerProperties.GetIsInDesignMode(this))
            {
                return;
            }

            _scrollViewer = GetTemplateChild(PART_SCROLLVIEWER) as ScrollViewer;
            if (_scrollViewer == null)
            {
                throw new NotImplementedException(PART_SCROLLVIEWER + " 找不到。");
            }

            _scrollViewer.ScrollChanged += (s, e) => InvalidateVisual();
        }

        /// <summary>
        /// 渲染
        /// </summary>
        /// <param name="drawingContext"></param>
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (ItemContainerGenerator.Items.Count == 0)
            {
                return;
            }

            var item = ItemContainerGenerator.Items[0];

            drawingContext.DrawRectangle(Background, new Pen(), new Rect(0, 0, ActualWidth, ActualHeight));
            DrawLine(item, ItemContainerGenerator, drawingContext);
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 绘制线条
        /// </summary>
        /// <param name="item"></param>
        /// <param name="itemContainerGenerator"></param>
        /// <param name="drawingContext"></param>
        private void DrawLine(object item, ItemContainerGenerator itemContainerGenerator, DrawingContext drawingContext)
        {
            //根节点项
            var rootItem = itemContainerGenerator.ContainerFromItem(item) as TreeViewItem;
            if (rootItem == null || !rootItem.IsExpanded)
            {
                return;
            }

            var items = rootItem.ItemContainerGenerator.Items;
            if (items.Count < 1)
            {
                return;
            }

            //第一项
            var firstItem = rootItem.ItemContainerGenerator.ContainerFromIndex(0) as TreeViewItem;
            //最后一项
            var lastItem = rootItem.ItemContainerGenerator.ContainerFromIndex(items.Count - 1) as TreeViewItem;

            var firstItemRect = GetItemRect(firstItem);
            var rootItemRect = GetItemRect(rootItem);

            //行高
            var lineHeight = (firstItemRect.Top - rootItemRect.Bottom) / 2;

            DrawBottomLine(rootItem, lineHeight, drawingContext);
            DrawTopLine(firstItem, lineHeight, drawingContext);

            DrawLine(firstItem.Header, rootItem.ItemContainerGenerator, drawingContext);

            for (int i = 1; i < items.Count; i++)
            {
                var _item = items[i];
                //子项
                var subItem = rootItem.ItemContainerGenerator.ContainerFromItem(_item) as TreeViewItem;

                DrawTopLine(subItem, lineHeight, drawingContext);
                DrawLine(_item, rootItem.ItemContainerGenerator, drawingContext);
            }

            DrawHorizontalLine(firstItem, lastItem, lineHeight, drawingContext);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="lineHeight"></param>
        /// <param name="drawingContext"></param>
        private void DrawBottomLine(TreeViewItem item, double lineHeight, DrawingContext drawingContext)
        {
            var rect = GetItemRect(item);

            var point1 = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height);
            var point2 = new Point(point1.X, point1.Y + lineHeight);

            drawingContext.DrawLine(_pen, point1, point2);
        }

        /// <summary>
        /// 绘制顶部线条
        /// </summary>
        /// <param name="item"></param>
        /// <param name="lineHeight"></param>
        /// <param name="drawingContext"></param>
        private void DrawTopLine(TreeViewItem item, double lineHeight, DrawingContext drawingContext)
        {
            var rect = GetItemRect(item);

            var point1 = new Point(rect.X + rect.Width / 2, rect.Y);
            var point2 = new Point(point1.X, point1.Y - lineHeight);

            drawingContext.DrawLine(_pen, point1, point2);

            DrawTriangle(rect, lineHeight, drawingContext);
        }

        /// <summary>
        /// 绘制三角形
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="lineHeight"></param>
        /// <param name="drawingContext"></param>
        private void DrawTriangle(Rect rect, double lineHeight, DrawingContext drawingContext)
        {
            //箭头尺寸
            var arrowHalfSize = ArrowSize / 2;
            var point1 = new Point(rect.X + rect.Width / 2 - arrowHalfSize, rect.Y - arrowHalfSize);
            var point2 = new Point(point1.X + ArrowSize, point1.Y);
            var point3 = new Point(point2.X - arrowHalfSize, point2.Y + arrowHalfSize);

            //几何流
            var streamGeometry = new StreamGeometry();

            using (var geometryContext = streamGeometry.Open())
            {
                geometryContext.BeginFigure(point1, true, true);
                var points = new PointCollection { point2, point3 };
                geometryContext.PolyLineTo(points, true, true);
            }

            streamGeometry.Freeze();
            drawingContext.DrawGeometry(_pen.Brush, _pen, streamGeometry);
        }

        /// <summary>
        /// 绘制水平线
        /// </summary>
        /// <param name="firstItem"></param>
        /// <param name="lastItem"></param>
        /// <param name="lineHeight">行高</param>
        /// <param name="drawingContext"></param>
        private void DrawHorizontalLine(TreeViewItem firstItem, TreeViewItem lastItem, double lineHeight, DrawingContext drawingContext)
        {
            var rect1 = GetItemRect(firstItem);
            var rect2 = GetItemRect(lastItem);

            var point1 = new Point(rect1.X + rect1.Width / 2, rect1.Y - lineHeight);
            var point2 = new Point(rect2.X + rect2.Width / 2, rect2.Y - lineHeight);

            drawingContext.DrawLine(_pen, point1, point2);
        }

        /// <summary>
        /// 获取项目矩形
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private Rect GetItemRect(TreeViewItem item)
        {
            var content = item.Template.FindName(PART_BORDER, item) as FrameworkElement;
            if (content == null)
            {
                throw new NotImplementedException(PART_BORDER + " 找不到.");
            }

            content.Margin = new Thickness(HorizontalOffset, 0, HorizontalOffset, VerticalOffset);

            return content.TransformToAncestor(this).TransformBounds(new Rect(0, 0, content.ActualWidth, content.ActualHeight));
        }

        /// <summary>
        /// 使可视项无效
        /// </summary>
        /// <param name="obj"></param>
        private void InvalidateVisualFromItem(object obj)
        {
            var item = obj as TreeViewItem;
            if (item?.Items.Count == 1)
            {
                InvalidateVisual();
            }
        }

        #endregion
    }
}
