using DiagramDesigner.Model;
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
using System.Windows.Shapes;
using System.ComponentModel;
using System.IO;

namespace WpfApp3.WPfTestContrl
{
    /// <summary>
    /// FlowCharUpdate.xaml 的交互逻辑
    /// </summary>
    public partial class FlowCharUpdate : Window
    {
        FlowCharModel Model;
        public FlowCharUpdate()
        {
            InitializeComponent();
            Model = new FlowCharModel();
            Model.Tumodel.Flowtype = 1;
            grd.DataContext = Model;
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
        /// 图片上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImage_Click(object sender, RoutedEventArgs e)
        {
            //创建＂打开文件＂对话框
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            //设置文件类型过滤
            dlg.Filter = "图片|*.jpg;*.png;*.gif;*.bmp;*.jpeg";

            // 调用ShowDialog方法显示＂打开文件＂对话框
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                Stream phop;
                int length = 0;
                ////获取所选文件名并在FileNameTextBox中显示完整路径
                //string filename = dlg.FileName;
                //Model.Tumodel.IcoImage = filename;
                //Model.ImgPath  = filename;
                //将选择的文件上传本项目特定的文件目录下
                phop = dlg.OpenFile();
                if (phop != null)
                {
                    length = (int)phop.Length;
                    byte[] bytes = new byte[length];
                    phop.Read(bytes, 0, length);
                    var reslt = CreateImageByPath(bytes, "Image");
                    if (reslt != "")
                    {
                        Model.Tumodel.IcoImage = reslt;
                    }
                }
            }
        }
        /// <summary>
        /// 将图片文件流写入本项目指定的文件中
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public string CreateImageByPath(byte[] bytes, string FileName)
        {
            try
            {
                string str1 = Directory.GetCurrentDirectory();
                string Enclosure_Path = str1 + $"\\{FileName}";
                if (!Directory.Exists(Enclosure_Path))     // 返回bool类型，存在返回true，不存在返回false
                {
                    Directory.CreateDirectory(Enclosure_Path);      //不存在则创建路径
                }
                string imgename = DateTime.Now.ToString("yyyyMMddhhmmssMM");
                string imagepath = Enclosure_Path + $"\\{imgename}" + ".png";
                FileInfo file = new FileInfo(imagepath);
                FileStream fs = file.OpenWrite();
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                return imagepath;
            }
            catch (Exception e)
            {

                return "";
            }

        }
    }



    public class FlowCharModel : INotifyPropertyChanged
    {
        private FlowChar tumodel = new FlowChar();

        public FlowChar Tumodel
        {
            get { return tumodel; }
            set { tumodel = value; SetName("Tumodel"); }
        }

        private string imgpath;

        public string ImgPath
        {
            get { return imgpath; }
            set { imgpath = value; SetName("ImgPath"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void SetName(string Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }
    }
}
