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
using System.Windows.Forms;
using System.Reflection;
using System.Threading.Tasks;
using Application = System.Windows.Application;
using System.Windows.Threading;
using System.Linq;
namespace WpfApp3
{
    /// <summary>
    /// Window9.xaml 的交互逻辑
    /// </summary>
    public partial class Window9 : Window
    {
        List<Student> liststudes = new List<Student>();
        DataTable dt = new DataTable();
        public Window9()
        {
            InitializeComponent();
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

        private void DataBinding()
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                Thread.Sleep(3000);
                NUmber.Text = "300000";
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
        //        NPOI.SS.UserModel.IRow rowTemp = sheet1.CreateRow(i + 1);//因为第一行已经被表头占用了，所以要+1
        //        rowTemp.CreateCell(i).SetCellValue(dt.Rows[i]["id"].ToString());
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
            //Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets[1];
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
            // workbook.SaveAs(fileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);

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
            for (int i = 0; i < 8; i++)
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

        }

        private void gtdpurorder_SelectedCellsChanged_1(object sender, System.Windows.Controls.SelectedCellsChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<Student> liststudes = new List<Student>();
            liststudes.Add(new Student() { Number = 1, Text = "张三" });
            liststudes.Add(new Student() { Number = 2, Text = "李四" });
            liststudes.Add(new Student() { Number = 3, Text = "王五" });
            liststudes.Add(new Student() { Number = 4, Text = "赵六" });
            var delmd = liststudes.FirstOrDefault();
            liststudes.Remove(delmd);
        }
    }

}
