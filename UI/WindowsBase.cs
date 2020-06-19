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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    public class WindowsBase : Window
    {
        static WindowsBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowsBase), new FrameworkPropertyMetadata(typeof(WindowsBase)));
        }
        public WindowsBase()
        {
            Loaded += (s, e) => OnLoaded(e);
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
            // CommandBindings.Add(new CommandBinding(SystemCommands.ShowSystemMenuCommand, ShowSystemMenu));
        }
    }
}
