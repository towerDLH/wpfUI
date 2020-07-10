using DiagramDesigner.Controls;
using DiagramDesigner.Data;
using DiagramDesigner.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using WpfApp3.Model;

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// FlowWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FlowWindow : Window
    {
        FlowModel Model;
        ObservableCollection<FlowChar> bars = new ObservableCollection<FlowChar>();
        private Dictionary<string, Uri> allViews = new Dictionary<string, Uri>(); //包含所有页面
        public Dictionary<string, FlowChar> dicflowcontrol = new Dictionary<string, FlowChar>();
       
        public FlowWindow()
        {
            InitializeComponent();
            Model = new FlowModel();
            this.DataContext = Model;
           // rememberClass = new RememberClass();
            Model.RememberClass.LoadFlowChar += LoadFlowChar;
            Model.RememberClass.GetFlowChar();
            GetFlowChild();
            ObservableCollection<FlowChar> flowchar = new ObservableCollection<FlowChar>();
            flowchar.Add(new FlowChar() {FlowcharPath="1212",Flowname="主流程",Flowtype=1,IcoImage="" });
            Model.AllFlowlist = flowchar;
        }

        private void LoadFlowChar()
        {
            GetFlowChild();
        }

        public void GetFlowChild()
        {
            List<FlowChar> flowcharlist = new List<FlowChar>();
            dicflowcontrol = Model.RememberClass.GetDicCount();
            //如果长度>0,就把集合中的用户名加过来。
            if (dicflowcontrol!=null&& dicflowcontrol.Count > 0)
            {
                //循环遍历RememberUserInfo对象。
                foreach (FlowChar item in dicflowcontrol.Values)
                {
                    flowcharlist.Add(item);
                }
            }
            Model.Flowcharlist =new ObservableCollection<FlowChar>(flowcharlist) ;
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
        ListBox dragSource = null;
        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));
            if (data != null)
            {
                DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            }
        }
        #region GetDataFromListBox(ListBox,Point)
        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }

                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }

            return null;
        }

        #endregion
        /// <summary>
        /// 新建子流程控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            FlowCharUpdate flow = new FlowCharUpdate();
            flow.Closed += WinClose;
            flow.ShowDialog();
        }

        private void WinClose(object sender, EventArgs e)
        {
            //刷新子控件
            GetFlowChild();
        }

        private void BtnImage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class FlowModel : ObservableObject
    {
        private FlowChar flowMd = new FlowChar();

        public FlowChar FlowMd
        {
            get { return flowMd; }
            set { flowMd = value; SetPerty("FlowMd"); }
        }

        private ObservableCollection<FlowChar> flowcharlist;

        public ObservableCollection<FlowChar> Flowcharlist
        {
            get { return flowcharlist; }
            set { flowcharlist = value; SetPerty("Flowcharlist"); }
        }
        private ObservableCollection<FlowChar> allflowlist;

        public ObservableCollection<FlowChar> AllFlowlist
        {
            get { return allflowlist; }
            set { allflowlist = value; SetPerty("AllFlowlist"); }
        }
        private RememberClass rememberClass=new RememberClass();
        public RememberClass RememberClass
        {
            get { return rememberClass; }
            set { rememberClass = value; SetPerty("RememberClass"); }
        }
    }
}
