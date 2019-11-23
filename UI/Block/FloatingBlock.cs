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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.classMD;
using UI.DaTa;

namespace UI.Block
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:UI.Block"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:UI.Block;assembly=UI.Block"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误:
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:FloatingBlock/>
    ///
    /// </summary>
    public class FloatingBlock : Control
    {
        public static readonly DependencyProperty ToXProperty = DependencyProperty.RegisterAttached(
            "ToX", typeof(double), typeof(FloatingBlock), new PropertyMetadata(ValueBoxes.Double0Box));

        public static void SetToX(DependencyObject element, double value)
            => element.SetValue(ToXProperty, value);

        public static double GetToX(DependencyObject element)
            => (double)element.GetValue(ToXProperty);

        public static readonly DependencyProperty ToYProperty = DependencyProperty.RegisterAttached(
            "ToY", typeof(double), typeof(FloatingBlock), new PropertyMetadata(-100.0));

        public static void SetToY(DependencyObject element, double value)
            => element.SetValue(ToYProperty, value);

        public static double GetToY(DependencyObject element)
            => (double)element.GetValue(ToYProperty);

        public static readonly DependencyProperty DurationProperty = DependencyProperty.RegisterAttached(
            "Duration", typeof(Duration), typeof(FloatingBlock), new PropertyMetadata(new Duration(TimeSpan.FromSeconds(2))));

        public static void SetDuration(DependencyObject element, Duration value)
            => element.SetValue(DurationProperty, value);

        public static Duration GetDuration(DependencyObject element)
            => (Duration)element.GetValue(DurationProperty);

        public static readonly DependencyProperty HorizontalOffsetProperty = DependencyProperty.RegisterAttached(
            "HorizontalOffset", typeof(double), typeof(FloatingBlock), new PropertyMetadata(ValueBoxes.Double0Box));

        public static void SetHorizontalOffset(DependencyObject element, double value)
            => element.SetValue(HorizontalOffsetProperty, value);

        public static double GetHorizontalOffset(DependencyObject element)
            => (double)element.GetValue(HorizontalOffsetProperty);

        public static readonly DependencyProperty VerticalOffsetProperty = DependencyProperty.RegisterAttached(
            "VerticalOffset", typeof(double), typeof(FloatingBlock), new PropertyMetadata(ValueBoxes.Double0Box));

        public static void SetVerticalOffset(DependencyObject element, double value)
            => element.SetValue(VerticalOffsetProperty, value);

        public static double GetVerticalOffset(DependencyObject element)
            => (double)element.GetValue(VerticalOffsetProperty);

        public static readonly DependencyProperty ContentTemplateProperty = DependencyProperty.RegisterAttached(
            "ContentTemplate", typeof(DataTemplate), typeof(FloatingBlock), new PropertyMetadata(default(DataTemplate), OnDataChanged));

        public static void SetContentTemplate(DependencyObject element, DataTemplate value)
            => element.SetValue(ContentTemplateProperty, value);

        public static DataTemplate GetContentTemplate(DependencyObject element)
            => (DataTemplate)element.GetValue(ContentTemplateProperty);

        public DataTemplate ContentTemplate
        {
            get => (DataTemplate)GetValue(ContentTemplateProperty);
            set => SetValue(ContentTemplateProperty, value);
        }

        private static readonly DependencyProperty ReadyToFloatProperty = DependencyProperty.RegisterAttached(
            "ReadyToFloat", typeof(bool), typeof(FloatingBlock), new PropertyMetadata(ValueBoxes.FalseBox));

        private static void SetReadyToFloat(DependencyObject element, bool value)
            => element.SetValue(ReadyToFloatProperty, value);

        private static bool GetReadyToFloat(DependencyObject element)
            => (bool)element.GetValue(ReadyToFloatProperty);

        public static readonly DependencyProperty ContentProperty = DependencyProperty.RegisterAttached(
            "Content", typeof(object), typeof(FloatingBlock), new PropertyMetadata(default, OnDataChanged));

        public static void SetContent(DependencyObject element, object value)
            => element.SetValue(ContentProperty, value);

        public static object GetContent(DependencyObject element)
            => element.GetValue(ContentProperty);

        public object Content
        {
            get => GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        private static void OnDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is UIElement target)) return;

            target.PreviewMouseLeftButtonDown -= Target_PreviewMouseLeftButtonDown;
            target.PreviewMouseLeftButtonUp -= Target_PreviewMouseLeftButtonUp;

            if (e.NewValue != null)
            {
                target.PreviewMouseLeftButtonDown += Target_PreviewMouseLeftButtonDown;
                target.PreviewMouseLeftButtonUp += Target_PreviewMouseLeftButtonUp;
            }
        }

        private static void Target_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) => SetReadyToFloat(sender as DependencyObject, true);

        private static void Target_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is UIElement element && GetReadyToFloat(element))
            {
                var layer = AdornerLayer.GetAdornerLayer(element);
                if (layer != null)
                {
                    var adorner = new AdornerContainer(layer)
                    {
                        IsHitTestVisible = false
                    };
                    var child = CreateBlock(element, adorner);
                    adorner.Child = child;

                    layer.Add(adorner);
                }
                SetReadyToFloat(element, false);
            }
        }

        private static FloatingBlock CreateBlock(Visual element, AdornerContainer adorner)
        {
            var p = Mouse.GetPosition(adorner.AdornedElement);
            var transform = new TranslateTransform
            {
                X = p.X + GetHorizontalOffset(element),
                Y = p.Y + GetVerticalOffset(element)
            };

            var block = new FloatingBlock
            {
                Content = GetContent(element),
                ContentTemplate = GetContentTemplate(element),
                RenderTransform = new TransformGroup
                {
                    Children =
                    {
                        transform
                    }
                }
            };

            var milliseconds = GetDuration(element).TimeSpan.TotalMilliseconds;

            var animationX = AnimationHelper.CreateAnimation(GetToX(element) + transform.X, milliseconds);
            Storyboard.SetTargetProperty(animationX, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(TranslateTransform.X)"));
            Storyboard.SetTarget(animationX, block);

            var animationY = AnimationHelper.CreateAnimation(GetToY(element) + transform.Y, milliseconds);
            Storyboard.SetTargetProperty(animationY, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(TranslateTransform.Y)"));
            Storyboard.SetTarget(animationY, block);

            var animationOpacity = AnimationHelper.CreateAnimation(0, milliseconds);
            Storyboard.SetTargetProperty(animationOpacity, new PropertyPath("Opacity"));
            Storyboard.SetTarget(animationOpacity, block);

            var storyboard = new Storyboard();
            storyboard.Completed += (s, e) =>
            {
                var layer = AdornerLayer.GetAdornerLayer(element);
                if (layer == null) return;
                adorner.Child = null;
                layer.Remove(adorner);
            };
            storyboard.Children.Add(animationX);
            storyboard.Children.Add(animationY);
            storyboard.Children.Add(animationOpacity);
            storyboard.Begin();

            return block;
        }
    }
}
