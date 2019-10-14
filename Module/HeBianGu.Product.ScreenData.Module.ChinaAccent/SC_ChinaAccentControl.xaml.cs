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

namespace HeBianGu.Product.ScreenData.Module.ChinaAccent
{
    /// <summary>
    /// SC_ChinaAccentControl.xaml 的交互逻辑
    /// </summary>
    public partial class SC_ChinaAccentControl : UserControl
    {
        public Demodel Model;
        public SC_ChinaAccentControl()
        {
            InitializeComponent();
            Model = new Demodel();
            grd.DataContext = Model;
            Model.CurRadis = 23;
            Model.CurRadis1 = 63;
            Model.CurRadis2 = 83;
            Model.CurRadis3 = 43;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.OnCloseClick();
        }


        //声明和注册路由事件
        public static readonly RoutedEvent CloseClickRoutedEvent =
            EventManager.RegisterRoutedEvent("CloseClick", RoutingStrategy.Bubble, typeof(EventHandler<RoutedEventArgs>), typeof(SC_ChinaAccentControl));
        //CLR事件包装
        public event RoutedEventHandler CloseClick
        {
            add { this.AddHandler(CloseClickRoutedEvent, value); }
            remove { this.RemoveHandler(CloseClickRoutedEvent, value); }
        }

        //激发路由事件,借用Click事件的激发方法

        protected void OnCloseClick()
        {
            RoutedEventArgs args = new RoutedEventArgs(CloseClickRoutedEvent, this);
            this.RaiseEvent(args);
        }

    }
    public class Demodel
    {
        private int curRadis;

        public int CurRadis
        {
            get { return curRadis; }
            set { curRadis = value; }
        }
        private int curRadis1;

        public int CurRadis1
        {
            get { return curRadis1; }
            set { curRadis1 = value; }
        }
        private int curRadis2;

        public int CurRadis2
        {
            get { return curRadis2; }
            set { curRadis2 = value; }
        }
        private int curRadis3;

        public int CurRadis3
        {
            get { return curRadis3; }
            set { curRadis3 = value; }
        }

    }
}
