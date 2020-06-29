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
        ObservableCollection<FlowChar> bars = new ObservableCollection<FlowChar>();
        private Dictionary<string, Uri> allViews = new Dictionary<string, Uri>(); //包含所有页面
        public Dictionary<string, FlowCharControl> dicflowcontrol = new Dictionary<string, FlowCharControl>();
        List<FlowCharControl> flowcharlist = new List<FlowCharControl>();
        RememberClass rememberClass;
        public FlowWindow()
        {
            InitializeComponent();
            rememberClass = new RememberClass();
            rememberClass.GetFlowChar();
            GetFlowChild();
        }

        public void GetFlowChild()
        {
            dicflowcontrol = rememberClass.GetDicCount();
            //如果长度>0,就把集合中的用户名加过来。
            if (dicflowcontrol.Count > 0)
            {
                //循环遍历RememberUserInfo对象。
                foreach (FlowCharControl item in dicflowcontrol.Values)
                {
                    flowcharlist.Add(item);
                }
            }
            string str1 = Directory.GetCurrentDirectory();
            string Enclosure_Path = str1 + "\\Page"+ "/111.xml";
            for (int i = 1; i < 5; i++)
            {
                bars.Add(new FlowChar() { Flowname = $"{i}", FlowcharPath = Enclosure_Path, IcoImage = $"/WpfApp3;component/Image/{i}.jpg" });
            }
            listBox1.ItemsSource = bars;
            // FlowChar.DataContext = flowcharlist;
        }
        /// <summary>
        /// 保存子节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveChild_Click(object sender, RoutedEventArgs e)
        {

            //IEnumerable<DesignerItem> designerItems = MyDesigner.Children.OfType<DesignerItem>();
            //IEnumerable<Connection> connections = MyDesigner.Children.OfType<Connection>();

            //XElement designerItemsXML = SerializeDesignerItems(designerItems);
            //XElement connectionsXML = SerializeConnections(connections);

            //XElement root = new XElement("Root");
            //root.Add(designerItemsXML);
            //root.Add(connectionsXML);

            //SaveFile(root);
        }

        private XElement SerializeConnections(IEnumerable<Connection> connections)
        {
            var serializedConnections = new XElement("Connections",
                           from connection in connections
                           select new XElement("Connection",
                                      new XElement("SourceID", connection.Source.ParentDesignerItem.ID),
                                      new XElement("SinkID", connection.Sink.ParentDesignerItem.ID),
                                      new XElement("SourceConnectorName", connection.Source.Name),
                                      new XElement("SinkConnectorName", connection.Sink.Name),
                                      new XElement("SourceArrowSymbol", connection.SourceArrowSymbol),
                                      new XElement("SinkArrowSymbol", connection.SinkArrowSymbol),
                                      new XElement("zIndex", Canvas.GetZIndex(connection))
                                     )
                                  );

            return serializedConnections;
        }

        private XElement SerializeDesignerItems(IEnumerable<DesignerItem> designerItems)
        {
            XElement serializedItems = new XElement("DesignerItems",
                                       from item in designerItems
                                       let contentXaml = XamlWriter.Save(((DesignerItem)item).Content)
                                       select new XElement("DesignerItem",
                                                  new XElement("Left", Canvas.GetLeft(item)),
                                                  new XElement("Top", Canvas.GetTop(item)),
                                                  new XElement("Width", item.Width),
                                                  new XElement("Height", item.Height),
                                                  new XElement("ID", item.ID),
                                                  new XElement("zIndex", Canvas.GetZIndex(item)),
                                                  new XElement("IsGroup", item.IsGroup),
                                                  new XElement("ParentID", item.ParentID),
                                                  new XElement("Content", contentXaml)
                                              )
                                   );

            return serializedItems;
        }

        void SaveFile(XElement xElement)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            string str1 = Directory.GetCurrentDirectory();
            string Enclosure_Path = str1 + "\\Page";
            if (!Directory.Exists(Enclosure_Path))     // 返回bool类型，存在返回true，不存在返回false
            {
                Directory.CreateDirectory(Enclosure_Path);      //不存在则创建路径
            }
            saveFile.InitialDirectory = Enclosure_Path;
            saveFile.Filter = "Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (saveFile.ShowDialog() == true)
            {
                try
                {
                    xElement.Save(saveFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            FlowCharControl flowcharcontrol = new FlowCharControl();
            flowcharcontrol.FileName = saveFile.SafeFileName;
            flowcharcontrol.FilePath = saveFile.FileName;
            flowcharlist.Add(flowcharcontrol);
            //  FlowChar.DataContext = flowcharlist;
            rememberClass.AddRemember(flowcharcontrol);
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
        }
    }
}
