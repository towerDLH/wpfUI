using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.Contorl;

namespace UI
{
    [TemplatePart(Name = "ColorPup", Type = typeof(Popup))]
    public class WindowsBase : Window
    {
        private const string ColorPup = "ColorPup";
        Popup WinColorPup;
        static WindowsBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowsBase), new FrameworkPropertyMetadata(typeof(WindowsBase)));
        }


        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            WinExtend = new UserExtendContent();
        }


        public object WinExtend
        {
            get { return (Window)GetValue(WinExtendProperty); }
            set { SetValue(WinExtendProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WinExtend.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WinExtendProperty =
            DependencyProperty.Register("WinExtend", typeof(Window), typeof(WindowsBase), new PropertyMetadata(default(object)));



        public ICommand SetColoreCommand
        {
            get { return (ICommand)GetValue(SetColoreCommandProperty); }
            set { SetValue(SetColoreCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SetColoreCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SetColoreCommandProperty =
            DependencyProperty.Register("SetColoreCommand", typeof(ICommand), typeof(WindowsBase), new PropertyMetadata(null, SetColoreback));

        private static void SetColoreback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        public ICommand ColorWindowCommand { get; protected set; }
        public ICommand ColorSetCommand { get; protected set; }
        private Button ColorBtn;
        private Button SetColorBtn;
        private Button SetColorBtn1;
        public WindowsBase()
        {
            Loaded += (s, e) => OnLoaded(e);
        }

        private void ColorCommand_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(int), typeof(WindowsBase), new PropertyMetadata(0));


        public int HeaderHeight
        {
            get { return (int)GetValue(HeaderHeightProperty); }
            set { SetValue(HeaderHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.Register("HeaderHeight", typeof(int), typeof(WindowsBase), new PropertyMetadata(0));


        public override void OnApplyTemplate()
        {
            WinColorPup = GetTemplateChild(ColorPup) as Popup;
            ColorBtn = (Button)Template.FindName("BtnColor", this);
            ColorBtn.Click += ColorBtn_Click;
            SetColorBtn = (Button)Template.FindName("SetColorBtn", this);
            SetColorBtn.Click += SetColorseMD;
            SetColorBtn1 = (Button)Template.FindName("SetColorBtn1", this);
            SetColorBtn1.Click += SetColorseMD;
        }

        private void ColorBtn_Click(object sender, RoutedEventArgs e)
        {
            WinColorPup.IsOpen = true;
        }

        public object CustomizedAreaContent
        {
            get { return (object)GetValue(CustomizedAreaContentProperty); }
            set { SetValue(CustomizedAreaContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomizedAreaContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomizedAreaContentProperty =
            DependencyProperty.Register("CustomizedAreaContent", typeof(object), typeof(WindowsBase), new PropertyMetadata(default(object)));


        public void OnLoaded(RoutedEventArgs args)
        {
            CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand,
                      (s, e) => WindowState = WindowState.Minimized));
            CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand,
                (s, e) => WindowState = WindowState.Maximized));
            CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand,
                (s, e) => WindowState = WindowState.Normal));
            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, (s, e) => Close()));
            // this.ColorWindowCommand = new RoutedCommand();
            // this.ColorSetCommand = new RoutedCommand();
            // CommandBindings.Add(new CommandBinding(this.ColorWindowCommand, (s, e) => ColorseMD(s, e)));
            // CommandBindings.Add(new CommandBinding(this.ColorSetCommand, SetColorseMD));
            //CommandBindings.Add(new CommandBinding(this.ColorSetCommand, SetColorseMD(o, e)));
        }
        private void SetColorseMD(object sender, RoutedEventArgs e)
        {
            var clor = (sender as Button).Tag.ToString();
            if (clor == "skin_Blue")
            {
                this.Style = (Style)Application.Current.Resources["skin_Blue"];
            }
            else if (clor == "skin_Green")
            {
                this.Style = (Style)Application.Current.Resources["skin_Green"];
            }
        }
        private void SetColorseMD(object sender, ExecutedRoutedEventArgs e)
        {
            var clor = (sender as Button).Tag.ToString();
            if (clor == "skin_Blue")
            {
                this.Style = (Style)Application.Current.Resources["skin_Blue"];
            }
            else if (clor == "skin_Green")
            {
                this.Style = (Style)Application.Current.Resources["skin_Green"];
            }
        }
    }
}
