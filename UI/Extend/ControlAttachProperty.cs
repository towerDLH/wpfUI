using Ay.Framework.WPF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace UI.Extend
{
    public static class ControlAttachProperty
    {
        static ControlAttachProperty()
        {
            /* ClearTextCommand */
            ClearTextCommand = new RoutedUICommand();
            ClearTextCommandBinding = new CommandBinding(ClearTextCommand);
            ClearTextCommandBinding.Executed += ClearButtonClick;
        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius),
                                                                                    typeof(ControlAttachProperty), new FrameworkPropertyMetadata(new CornerRadius(0, 0, 0, 0)));
        public static CornerRadius GetCornerRadius(DependencyObject d)
        {
            return (CornerRadius)d.GetValue(CornerRadiusProperty);
        }
        public static void SetCornerRadius(DependencyObject d, CornerRadius value)
        {
            d.SetValue(CornerRadiusProperty, value);
        }

        #region PlaceHolderProperty 占位符
        public static readonly DependencyProperty PlaceHolderProperty = DependencyProperty.RegisterAttached("PlaceHolder", typeof(string),
                                                            typeof(ControlAttachProperty), new FrameworkPropertyMetadata(""));
        public static string GetPlaceHolder(DependencyObject d)
        {
            return (string)d.GetValue(PlaceHolderProperty);
        }
        public static void SetPlaceHolder(DependencyObject obj, string value)
        {
            obj.SetValue(PlaceHolderProperty, value);
        }
        #endregion

        public static readonly DependencyProperty AttachContentProperty = DependencyProperty.RegisterAttached("AttachContent", typeof(ControlTemplate),
                                                                typeof(ControlAttachProperty), new FrameworkPropertyMetadata(null));
        public static ControlTemplate GetAttachContent(DependencyObject d)
        {
            return (ControlTemplate)d.GetValue(AttachContentProperty);
        }
        public static void SetAttachContent(DependencyObject obj, ControlTemplate value)
        {
            obj.SetValue(AttachContentProperty, value);
        }

        #region ClearTextCommand 清除输入框Text事件命令

        /// <summary>
        /// 清除输入框Text事件命令，需要使用IsClearTextButtonBehaviorEnabledChanged绑定命令
        /// </summary>
        public static RoutedUICommand ClearTextCommand { get; private set; }

        /// <summary>
        /// ClearTextCommand绑定事件
        /// </summary>
        private static readonly CommandBinding ClearTextCommandBinding;

        /// <summary>
        /// 清除输入框文本值
        /// </summary>
        private static void ClearButtonClick(object sender, ExecutedRoutedEventArgs e)
        {
            var tbox = e.Parameter as FrameworkElement;

            if (tbox == null)
            {
                return;
            }

            if (tbox is TextBox)
            {
                ((TextBox)tbox).Clear();
            }
            else if (tbox is PasswordBox)
            {
                ((PasswordBox)tbox).Clear();
            }
            else if (tbox is ComboBox)
            {
                var cb = tbox as ComboBox;
                cb.SelectedItem = null;
                cb.Text = string.Empty;
            }
            else if (tbox is DatePicker)
            {
                var dp = tbox as DatePicker;
                dp.SelectedDate = null;
                dp.Text = string.Empty;
            }

            tbox.Focus();
        }

        #endregion

        #region IsClearTextButtonBehaviorEnabledProperty 清除输入框Text值按钮行为开关（设为ture时才会绑定事件）
        /// <summary>
        /// 清除输入框Text值按钮行为开关
        /// </summary>
        public static readonly DependencyProperty IsClearButtonEnabledProperty = DependencyProperty.RegisterAttached("IsClearButtonEnabled", typeof(bool),
                        typeof(ControlAttachProperty), new FrameworkPropertyMetadata(false, IsClearButtonEnabledChanged));

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetIsClearButtonEnabled(DependencyObject d)
        {
            return (bool)d.GetValue(IsClearButtonEnabledProperty);
        }

        public static void SetIsClearButtonEnabled(DependencyObject obj, bool value)
        {
            obj.SetValue(IsClearButtonEnabledProperty, value);
        }

        /// <summary>
        /// 绑定清除Text操作的按钮事件
        /// </summary>
        private static void IsClearButtonEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = d as AyImageButton;
            if ((null != button) && (e.OldValue != e.NewValue))
            {
                button.CommandBindings.Add(ClearTextCommandBinding);
            }
        }

        #endregion
    }
}
