using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Text;
using System.Windows;
using NPOI.HSSF.UserModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Application = System.Windows.Application;
using System.Windows.Threading;
using System.Linq;
using log4net;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Data;
using System.Collections;
using UI;
using UI.DaTa;
using System.Windows.Input;
using System.Collections.ObjectModel;
using WpfApp3.Model;

namespace WpfApp3
{
    /// <summary>
    /// Window9.xaml 的交互逻辑
    /// </summary>
    public partial class Window9 : Window
    {
        private int skinstyle = 1;
        private string yuWen = ((int)Large.Subject.语文1111111).ToString();

        public string YuWen
        {
            get { return yuWen; }
            set { yuWen = value; }
        }

        public static int ShuXue = (int)Large.Subject.语文1111111;
        ILog log = LogManager.GetLogger(typeof(Window9));
        List<Student> liststudes = new List<Student>();
        public ObservableCollection<string> KeysCollection { get; set; } = new ObservableCollection<string>();

        DataTable dt = new DataTable();
        public Test Model;
        public Window9()
        {
            InitializeComponent();
            Load();
            Model = new Test();
            this.DataContext = Model;
            // GetDatableToModel();
            //SaveDatableToExecel();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(decimal));
            dt.Columns.Add("Sex", typeof(decimal));
            for (int i = 0; i < 8; i++)
            {
                DataRow newRow = dt.NewRow();
                newRow["id"] = i;
                newRow["Name"] = "张三" + i;
                newRow["Age"] = Math.Round((i + 0.10003), 6);
                newRow["Sex"] = i + 0.21231000;
                dt.Rows.Add(newRow);

            }
            gtdpurorder.ItemsSource = dt.DefaultView;
            gtdpurorder2.ItemsSource = dt.DefaultView;
            GetDatableToModel();
            //SaveDatableToExecel2();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN");
            Thread.CurrentThread.CurrentCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy";
            //Storyboard sbd = Resources["sbCloud"]as Storyboard;
            //sbd.Begin();

            liststudes.Add(new Student() { Number = 1, Text = "张三" });
            liststudes.Add(new Student() { Number = 2, Text = "李四" });
            liststudes.Add(new Student() { Number = 3, Text = "王五" });
            liststudes.Add(new Student() { Number = 4, Text = "赵六" });
            //mcom.ItemsSource = liststudes;
            //mcom.DisplayMemberPath = "Number";
            //mcom.SelectedValuePath = "Text";
            CoverFlowMain.AddRange(new[]
            {
                new Uri(@"pack://application:,,,/Image/timg.jpg"),
                new Uri(@"pack://application:,,,/Image/2.jpg"),
                new Uri(@"pack://application:,,,/Image/3.jpg"),
                new Uri(@"pack://application:,,,/Image/4.jpg"),
                new Uri(@"pack://application:,,,/Image/5.jpg"),
                new Uri(@"pack://application:,,,/Image/6.jpg"),
                new Uri(@"pack://application:,,,/Image/7.jpg"),
                new Uri(@"pack://application:,,,/Image/8.jpg"),
                new Uri(@"pack://application:,,,/Image/9.jpg"),
                new Uri(@"pack://application:,,,/Image/10.jpg")
            });
            CoverFlowMain.JumpTo(2);

            // mcom.ItemsSource = System.Enum.GetValues(typeof(SelectInsSubResult));
            new Thread(p => { DataBinding(); }).Start();
        }
        public void Load()
        {
            KeysCollection.Add("23");
            KeysCollection.Add("张三");
            KeysCollection.Add("李四");
            KeysCollection.Add("王五");
            KeysCollection.Add("赵六");
            MailConfigSelection.ItemsSource = KeysCollection;
            //  Intxt.IntellList = KeysCollection;
        }

        private string Tname;

        public string TName
        {
            get { return Tname; }
            set { Tname = value; }
        }

        private void DataBinding()
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {

            }));
        }



        //private void SaveDatableToExecel2()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("id", typeof(int));
        //    dt.Columns.Add("Name", typeof(bool));
        //    dt.Columns.Add("Age", typeof(int));
        //    dt.Columns.Add("Sex", typeof(int));
        //    for (int i = 0; i < 8; i++)
        //    {
        //        foreach (DataRow item in dt.Rows)
        //        {
        //            item["id"] = i;
        //            item["Name"] = "张三" + i;
        //            item["Age"] = i;
        //            item["Sex"] = i;
        //        }
        //    }
        //    //创建工作簿
        //    HSSFWorkbook excelBook = new HSSFWorkbook();
        //    //为工作簿创建工作表并命名
        //    NPOI.SS.UserModel.ISheet sheet1 = excelBook.CreateSheet("LOL英雄数据");
        //    //创建表头
        //    NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);//先创建一行用来放表头
        //    //创建7列并赋值
        //    row1.CreateCell(0).SetCellValue("英雄昵称");//第0行，第0列
        //                                            //创建数据行
        //    for (int i= 0;i < dt.Rows.Count;i++)
        //    {
        //        NPOI.SS.UserModel.IRow rowTemp = sheet1.CreateRow(i + 1);//因为第一行已经被表头占用了，所以要+1        //        rowTemp.CreateCell(i).SetCellValue(dt.Rows[i]["id"].ToString());
        //        rowTemp.CreateCell(i).SetCellValue(dt.Rows[i]["Name"].ToString());
        //        rowTemp.CreateCell(i).SetCellValue(dt.Rows[i]["Age"].ToString());
        //        rowTemp.CreateCell(i).SetCellValue(dt.Rows[i]["Sex"].ToString());

        //    }
        //    //命名文件名
        //    var fileName = "LOL英雄数据" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ffff") + ".xls";
        //    //将Excel表格转化为流，输出
        //    //创建文件流
        //    MemoryStream bookStream = new MemoryStream();
        //    //文件写入流（向流中写入字节序列）
        //    excelBook.Write(bookStream);
        //    //输出之前调用Seek（偏移量，游标位置) 把0位置指定为开始位置
        //    using (FileStream fs = new FileStream(localFilePath, FileMode.Create, FileAccess.Write))
        //    {
        //        fs.Write(buf, 0, buf.Length);
        //        fs.Flush();
        //        fs.Close();
        //    }
        //    bookStream.Seek(0, SeekOrigin.Begin);
        //    //  return File(bookStream, "application/vnd.ms-excel", fileName);

        //}

        /// <summary>
        /// Execel 导出
        /// </summary>
        /// <param name="dt">数据源</param>
        /// <param name="PrintList">要打印的数据</param>
        /// <param name="fileName">保存的文件名，也可以是路径</param>
        private async void SaveDatableToExecel(DataTable dt, Dictionary<string, string> PrintList, string fileName, bool IsSelect)
        {
            int colIndex = 0;
            int rowNumber = dt.Rows.Count;
            int columnNumber = PrintList.Count;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //excel.Application.Workbooks.Add(true);
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            excel.Visible = IsSelect;
            // Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range range;
            int rowIndex = 1;
            foreach (var item in PrintList.Keys)
            {
                colIndex++;
                excel.Cells[1, colIndex] = PrintList[item];
                //Console.WriteLine("键为：{0}，值为：{1}", item, dic[item]);
            }
            colIndex = 0;
            foreach (var item in PrintList.Keys)
            {
                for (int c = 0; c < rowNumber; c++)
                {
                    excel.Cells[c + 2, colIndex + 1] = dt.Rows[c][item];
                }
                colIndex++;
            }
            //workbook.SaveAs(fileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);

            try
            {
                workbook.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges, Missing.Value, Missing.Value);
                excel.Quit();
            }
            catch (Exception)
            {

            }

        }


        private void SaveDatableToExecel()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Sex", typeof(int));
            for (int i = 0; i < 100000; i++)
            {
                DataRow newRow = dt.NewRow();
                newRow["id"] = i;
                newRow["Name"] = "张三" + i;
                newRow["Age"] = i + 0.10003;
                newRow["Sex"] = i + 0.21231000;
                dt.Rows.Add(newRow);

            }
            gtdpurorder.ItemsSource = dt.DefaultView;
            int colIndex = 0;
            int rowNumber = dt.Rows.Count;
            int columnNumber = dt.Columns.Count;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //excel.Application.Workbooks.Add(true);
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            excel.Visible = true;
            //Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range range;
            int rowIndex = 1;
            foreach (DataColumn col in dt.Columns)
            {
                colIndex++;
                excel.Cells[1, colIndex] = col.ColumnName;
            }

            object[,] objData = new object[rowNumber, columnNumber];

            for (int r = 0; r < rowNumber; r++)
            {
                for (int c = 0; c < columnNumber; c++)
                {
                    objData[r, c] = dt.Rows[r][c];
                }
                //Application.DoEvents();
            }

            range = worksheet.get_Range(excel.Cells[2, 1], excel.Cells[rowNumber + 1, columnNumber]);
            //range.NumberFormat = "@";//设置单元格为文本格式
            range.Value2 = objData;
            worksheet.get_Range(excel.Cells[2, 1], excel.Cells[rowNumber + 1, 1]).NumberFormat = "yyyy-m-d h:mm";

            // 写入Excel 
            for (int c = 0; c < rowNumber; c++)
            {
                for (int j = 0; j < columnNumber; j++)
                {
                    excel.Cells[c + 1, j + 1] = dt.Rows[c].ItemArray[j];
                }
            }
            Guid id = Guid.NewGuid();
            string fileName = (@System.IO.Directory.GetCurrentDirectory() + "\\Resouse" + "\\" + id);
            // workbook.ExportAsFixedFormat(targetType, target, Excel.XlFixedFormatQuality.xlQualityStandard, true, false, missing, missing, missing, missing);
            workbook.SaveAs(fileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            // workbook.SaveAs(fileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            // return true;
            //DataRow row = dt.NewRow();
            //dt.Rows.Add()
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string a = "\\\\192.168.0.114\\File\\7eadbf4a-6828-41b5-bbdf-6e7475dc64ae.docx";
            var b = a.Replace("/", "/");
            //  Regex.Unescape();
            //  MessageBox.Show(b);
            if (YearRa?.IsChecked ?? false)
            {
                //    MessageBox.Show("年");

            }
            if (YueRa?.IsChecked ?? false)
            {
                //     MessageBox.Show("月");
            }
            ad.Text = "\xe6b1";
        }

        public void GetDatableToModel()
        {
            var a = "a28e46cf-4992-41af-ad5d-776c5149be23";
            var b = "张三";
            var c = 2;
            Student s = new Student();
            var subClassEn = s.GetType().GetProperty("Text").GetValue(s, null);
            Student d = Activator.CreateInstance<Student>();
            var Types = d.GetType();//获得类型
            foreach (PropertyInfo sp in Types.GetProperties())//获得类型的属性字段
            {
                if (sp.Name == "Id")//判断属性名是否相同
                {
                    if (c == 1) //假设为空的数据
                    {
                        // var g = TypeDescriptor.GetConverter(sp.PropertyType).ConvertFromString("");
                        sp.SetValue(s, null, null);
                    }
                    else
                    {
                        var g = TypeDescriptor.GetConverter(sp.PropertyType).ConvertFromString(a);
                        sp.SetValue(d, g, null);
                    }

                    //Type t = sp.GetType();
                    //TypeDescriptor.GetConverter(t).ConvertFromString(b);
                }
            }
            var s1 = d;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            BackgroundWorker worker = new BackgroundWorker();

            // worker 要做的事情 使用了匿名的事件响应函数
            worker.DoWork += (o, ea) =>
            {
                //WPF中线程只能控制自己创建的控件，
                //如果要修改主线程创建的MainWindow界面的内容,
                //可以委托主线程的Dispatcher处理。
                //在这里，委托内容为一个匿名的Action对象。
                this.Dispatcher.Invoke((Action)(() =>
                {
                    load.IsActive = true;
                    Dictionary<string, string> lista = new Dictionary<string, string>();
                    foreach (var item in gtdpurorder.Columns)
                    {
                        lista.Add(item.SortMemberPath, item.Header.ToString());
                    }
                    var a = (gtdpurorder.ItemsSource as DataView).ToTable();
                    SaveDatableToExecel(a, lista, "ggddg", true);
                }));
                Thread.Sleep(5000);
            };
            // worker 完成事件响应
            worker.RunWorkerCompleted += (o, ea) =>
            {
                this.Dispatcher.Invoke((Action)(() =>
                {
                    load.IsActive = false;
                }));
            };

            //注意：运行了下面这一行代码，worker才真正开始工作。上面都只是声明定义而已。
            worker.RunWorkerAsync();

            //Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
            //      new Action(() =>

            //      {
            //          load.IsActive = true;
            //      }));
            //Task t = new Task(() =>
            //{
            //    load.IsActive = true;

            //    //Console.WriteLine("任务开始工作……");
            //    ////模拟工作过程
            //    //Thread.Sleep(5000);
            //});
            // Thread.Sleep(5000);


            // load.IsActive = false;
        }



        private void gtdpurorder_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            var dt = sender as DataGrid;
            if (dt.SelectedIndex == -1 || dt.Name != "gtdpurorder")
            {
                return;
            }
            DataGridRow row = (DataGridRow)dt.ItemContainerGenerator.ContainerFromIndex(dt.SelectedIndex);
            var a = row.DetailsVisibility;
            if (a == Visibility.Visible)
            {
                row.DetailsVisibility = Visibility.Collapsed;
            }
            else { row.DetailsVisibility = Visibility.Visible; }
        }

        private void gtdpurorder_SelectedCellsChanged_1(object sender, System.Windows.Controls.SelectedCellsChangedEventArgs e)
        {
            //var dt = sender as DataGrid;
            //if (dt.SelectedIndex == -1)
            //{
            //    return;
            //}
            //DataGridRow row = (DataGridRow)dt.ItemContainerGenerator.ContainerFromIndex(dt.SelectedIndex);
            //var a = row.DetailsVisibility;
            //if (a == Visibility.Visible)
            //{
            //    row.DetailsVisibility = Visibility.Collapsed;
            //}
            //else { row.DetailsVisibility = Visibility.Visible; }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //List<Student> liststudes = new List<Student>();
            //liststudes.Add(new Student() { Number = 1, Text = "张三" });
            //liststudes.Add(new Student() { Number = 2, Text = "李四" });
            //liststudes.Add(new Student() { Number = 3, Text = "王五" });
            //liststudes.Add(new Student() { Number = 4, Text = "赵六" });
            //var delmd = liststudes.FirstOrDefault();
            //liststudes.Remove(delmd);
            //log.Debug("删除");

            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Sex", typeof(int));
            for (int i = 0; i < 100000; i++)
            {
                DataRow newRow = dt.NewRow();
                newRow["id"] = i;
                newRow["Name"] = "李四" + i;
                newRow["Age"] = i + 0.10003;
                newRow["Sex"] = i + 0.21231000;
                dt.Rows.Add(newRow);

            }
            gtdpurorder.ItemsSource = dt.DefaultView;
        }

        private void gtdpurorder_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            IsDatagridDouble data = new IsDatagridDouble();
            #region 判断是否在控件上 rowhit 为true 表示在文档上
            DataGrid dtg = sender as DataGrid;
            if (!data.IsPostion(dtg, e) || dtg.SelectedItem == null) return;
            #endregion
        }

        private void gtdpurorder_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            // e.Row.MouseEnter += Row_MouseEnter;
        }

        private void Row_MouseEnter(object sender, MouseEventArgs e)
        {
            DataGridRow row = (DataGridRow)sender;
            MessageBox.Show(row.GetIndex().ToString());
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("移入", "提示信息");
            NUmber.Text = "2";
            LinPop.IsOpen = false;
            LinPop.IsOpen = true;
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("离开","提示信息");
            NUmber.Text = "3";
            LinPop.IsOpen = false;
        }

        private void whenToolTipOpens(object sender, RoutedEventArgs e)
        {
            Model.Number = 23423333;
        }

        private void whenToolTipCloses(object sender, RoutedEventArgs e)
        {

        }

        private void Gtdpurorder_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Gtdpurorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var dg = sender as DataGrid;
            var name = dg.Name;
        }

        private void DtgLpnrs_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var dg = sender as DataGrid;
            var name = dg.Name;
        }

        private void Gtdpurorder_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void DtgLpnrs_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var dg = sender as DataGrid;
            var index = dg.SelectedIndex;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void MailConfigSelection_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ConfigPopup.IsOpen = false;
                System.Windows.Controls.ListBox lb = sender as System.Windows.Controls.ListBox;
                if (lb == null) return;

                string mailConfig = lb.SelectedItem.ToString();

                //Popup pp = (lb.Parent as Grid).Parent as Popup;
                TextBox tb = ConfigPopup.PlacementTarget as TextBox;
                int i = tb.CaretIndex;//获取呼出这个popup的textbox的当前光标位置
                tb.Text = mailConfig;//插入选择的字符串
                tb.CaretIndex = i + mailConfig.Length + 1;//移动光标
                tb.Focus();
            }
            else if (e.Key == Key.Escape)
            {
                ConfigPopup.IsOpen = false;
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Delete || e.Key == Key.Back) return;

            TextBox tbm = e.OriginalSource as TextBox;
            if (KeysCollection.Count != 0)//这里是这样的条件，可以根据需求来改变
            {
                ShowPopUp(tbm.GetRectFromCharacterIndex(tbm.CaretIndex), tbm);
            }
        }
        private void ShowPopUp(Rect placementRect, TextBox tb)
        {
            ConfigPopup.PlacementTarget = tb;
            ConfigPopup.PlacementRectangle = placementRect;
            ConfigPopup.IsOpen = true;
            MailConfigSelection.Focus();
            MailConfigSelection.SelectedIndex = 0;
            var listBoxItem = (ListBoxItem)MailConfigSelection.ItemContainerGenerator.ContainerFromItem(MailConfigSelection.SelectedItem);
            listBoxItem.Focus();
        }

        private void MailConfigSelection_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Intxt_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            DataGridRow row = FindVisualParent<DataGridRow>(sender as Expander);
            row.DetailsVisibility = System.Windows.Visibility.Visible;
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            DataGridRow row = FindVisualParent<DataGridRow>(sender as Expander);
            row.DetailsVisibility = System.Windows.Visibility.Collapsed;
        }
        public T FindVisualParent<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);
            if (parentObject == null) return null;
            T parent = parentObject as T;
            if (parent != null)
                return parent;
            else
                return FindVisualParent<T>(parentObject);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (App.Language.ToString() == "lanage-ZH")
            {
                App.Language = "Lanage-E";
            }
            else App.Language = "lanage-ZH";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (skinstyle == 1)
            {
                this.Style = (Style)Application.Current.Resources["skin_Blue"];
                skinstyle = 2;
            }
            else
            {
                this.Style = (Style)Application.Current.Resources["skin_Green"];
                skinstyle = 1;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void gtdpurorder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var dt = sender as DataGrid;
            if (dt.SelectedIndex == -1 || dt.Name != "gtdpurorder")
            {
                return;
            }
            DataGridRow row = (DataGridRow)dt.ItemContainerGenerator.ContainerFromIndex(dt.SelectedIndex);
            var a = row.DetailsVisibility;
            //if (a == Visibility.Visible)
            //{
            //    row.DetailsVisibility = Visibility.Collapsed;
            //}
            //else { row.DetailsVisibility = Visibility.Visible; }
        }

        private void DtgLpnrs_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var dt = sender as DataGrid;
            var indexnum = dt.SelectedIndex;
            DataGridRow dgr = (DataGridRow)gtdpurorder.ItemContainerGenerator.ContainerFromIndex(this.gtdpurorder.SelectedIndex);
            DataGrid dg = FindVisualChildByName<DataGrid>(dgr, "DtgLpnrs") as DataGrid;
            var q = dg.SelectedIndex;
        }

        //下面的方法曾让我教头烂额，感叹微软的控件封装的太牛逼了，处理起来有点变态    
        /// <summary>    
                /// 找到行明细中嵌套的控件名称    
                /// </summary>    
                /// <typeparam name="T"></typeparam>    
                /// <param name="parent"></param>    
                /// <param name="name"></param>    
                /// <returns></returns>    
        public T FindVisualChildByName<T>(DependencyObject parent, string name) where T : DependencyObject
        {
            if (parent != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
                {
                    var child = VisualTreeHelper.GetChild(parent, i) as DependencyObject;
                    string controlName = child.GetValue(Control.NameProperty) as string;
                    if (controlName == name)
                    {
                        return child as T;
                    }
                    else
                    {
                        T result = FindVisualChildByName<T>(child, name);
                        if (result != null)
                            return result;
                    }
                }
            }
            return null;
        }
    }
    [TemplatePart(Name = "total_row", Type = typeof(Grid))]
    public class DataGridTotal : DataGrid, INotifyPropertyChanged
    {
        DataGrid TotalRow;
        List<object> totalRowItemSource;

        public event PropertyChangedEventHandler PropertyChanged;

        public void senvent(string Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }
        public override void OnApplyTemplate()
        {
            TotalRow = base.GetTemplateChild("TotalRow") as DataGrid;

            TotalRow.Background = new SolidColorBrush(Colors.AliceBlue);
            TotalRow.Visibility = Visibility.Visible;
            int displayindex = 0;
            if (TotalRow.Columns != null)
                TotalRow.Columns.Clear();

            foreach (var item in this.Columns)
            {

                DataGridTextColumn cl = new DataGridTextColumn();
                cl.Header = item.Header;
                cl.Width = item.Width;
                cl.DisplayIndex = item.DisplayIndex = displayindex++;

                Binding widthBd = new Binding();
                widthBd.Source = item;
                widthBd.Mode = BindingMode.TwoWay;
                widthBd.Path = new PropertyPath(DataGridColumn.WidthProperty);
                BindingOperations.SetBinding(cl, DataGridTextColumn.WidthProperty, widthBd);

                Binding visibleBd = new Binding();
                visibleBd.Source = item;
                visibleBd.Mode = BindingMode.TwoWay;
                visibleBd.Path = new PropertyPath(DataGridColumn.VisibilityProperty);
                BindingOperations.SetBinding(cl, DataGridTextColumn.VisibilityProperty, visibleBd);

                Binding indexBd = new Binding();
                indexBd.Source = item;
                indexBd.Mode = BindingMode.TwoWay;
                indexBd.Path = new PropertyPath(DataGridColumn.DisplayIndexProperty);
                BindingOperations.SetBinding(cl, DataGridTextColumn.DisplayIndexProperty, indexBd);

                cl.Binding = (item as DataGridTextColumn).Binding;

                TotalRow.Columns.Add(cl);
            }
            this.TotalRow.ItemsSource = totalRowItemSource;
            base.OnApplyTemplate();
        }

        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
        {
            base.OnItemsSourceChanged(oldValue, newValue);

            Type itemType = null;
            totalRowItemSource = new List<object>();
            object obj = null;
            if (newValue == null)
            {
                return;
            }
            #region 新

            DataTable dt = new DataTable();
            dt = (newValue as DataView).Table.Copy();
            var dtl = (newValue as DataView).Table.Clone();

            if (TotalRow != null)
                this.TotalRow.ItemsSource = dt.DefaultView;

            #endregion

            //    #region 原
            //    foreach (var item in newValue)
            //{

            //    itemType = item.GetType();
            //    obj = Activator.CreateInstance(itemType, true);
            //    break;
            //}
            //if (itemType == null)
            //    return;

            //PropertyInfo[] ps = itemType.GetProperties();
            //foreach (var item in newValue)
            //{

            //    foreach (PropertyInfo property in ps)
            //    {
            //        object tmpValue = property.GetValue(item, null);
            //        object totalValue = property.GetValue(obj, null);

            //        if (property.PropertyType == typeof(int))
            //        {
            //            totalValue = (int)tmpValue + (int)totalValue;
            //            property.SetValue(obj, totalValue, null);
            //        }
            //        else if (property.PropertyType == typeof(double))
            //        {
            //            totalValue = (double)tmpValue + (double)totalValue;
            //            property.SetValue(obj, totalValue, null);
            //        }
            //    }
            //}
            //totalRowItemSource.Add(obj);
            //if (TotalRow != null)
            //    this.TotalRow.ItemsSource = totalRowItemSource;
            //#endregion



        }

    }

    public class Test : INotifyPropertyChanged
    {

        private int number;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                SetEvent("Number");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void SetEvent(string Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }
    }


}
