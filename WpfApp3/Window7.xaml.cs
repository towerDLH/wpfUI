using Braincase.GanttChart;
using Syncfusion.Windows.Controls.Gantt.Chart;
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

namespace WpfApp3
{
    /// <summary>
    /// Window7.xaml 的交互逻辑
    /// </summary>
    public partial class Window7 : Window
    {
        System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
        Chart _mChart = new Chart();//源文件没说明,没调用该类Post(),报表就没数据;
        ProjectManager _mManager = null;
       // OverlayPainter _mOverlay = new OverlayPainter();
        public Window7()
        {
            InitializeComponent();
            _mManager = new ProjectManager();
            var work = new MyTask(_mManager) { Name = "创建APP" };
            var wake = new MyTask(_mManager) { Name = "框架搭建" };
            var teeth = new MyTask(_mManager) { Name = "数据库创建" };
            var shower = new MyTask(_mManager) { Name = "自定义控件" };
            var clothes = new MyTask(_mManager) { Name = "功能实现" };
            var hair = new MyTask(_mManager) { Name = "功能测试" };
            var pack = new MyTask(_mManager) { Name = "产品上架" };
            var wake1 = new MyTask(_mManager) { Name = "框架搭建1" };
            var wake2 = new MyTask(_mManager) { Name = "框架搭建2" };
            _mManager.Add(work);
            _mManager.Add(wake1);
            _mManager.Add(wake2);
            _mManager.Add(wake);
            _mManager.Add(teeth);
            _mManager.Add(shower);
            _mManager.Add(clothes);
            _mManager.Add(hair);
            _mManager.Add(pack);

            // Create another 1000 tasks for stress testing
            Random rand = new Random();
            //for (int i = 0; i < 1000; i++)
            //{
            //    var task = new MyTask(_mManager) { Name = string.Format("New Task {0}", i.ToString()) };
            //    _mManager.Add(task);
            //    _mManager.SetStart(task, TimeSpan.FromDays(rand.Next(300)));
            //    _mManager.SetDuration(task, TimeSpan.FromDays(rand.Next(50)));
            //}

            // Set task durations, e.g. using ProjectManager methods 
            _mManager.SetDuration(wake, TimeSpan.FromDays(3));
            _mManager.SetDuration(teeth, TimeSpan.FromDays(5));
            _mManager.SetDuration(shower, TimeSpan.FromDays(7));
            _mManager.SetDuration(clothes, TimeSpan.FromDays(4));
            _mManager.SetDuration(hair, TimeSpan.FromDays(3));
            _mManager.SetDuration(pack, TimeSpan.FromDays(5));
            _mManager.SetDuration(wake1, TimeSpan.FromDays(2));
            _mManager.SetDuration(wake2, TimeSpan.FromDays(4));
            _mManager.SetStart(wake, TimeSpan.FromDays(10));
           // _mManager.SetDuration(wake, TimeSpan.FromDays(40));
            // demostrate splitting a task
            _mManager.Split(pack, new MyTask(_mManager), new MyTask(_mManager), TimeSpan.FromDays(2));

            // Set task complete status, e.g. using newly created properties
            wake.Complete = 0.9f;
            teeth.Complete = 0.5f;
            shower.Complete = 0.4f;

            // Give the Tasks some organisation, setting group and precedents
            _mManager.Group(work, wake);
            _mManager.Group(work, teeth);
            _mManager.Group(work, shower);
            _mManager.Group(work, clothes);
            _mManager.Group(work, hair);
            _mManager.Group(work, pack);
            _mManager.Group(wake, wake1);
            _mManager.Group(wake, wake2);
            //_mManager.Relate(wake, teeth);
            //_mManager.Relate(wake, shower);
            //_mManager.Relate(shower, clothes);
            //_mManager.Relate(shower, hair);
            //_mManager.Relate(hair, pack);
            //_mManager.Relate(clothes, pack);

            // Create and assign Resources.
            // MyResource is just custom user class. The API can accept any object as resource.
            var jake = new MyResource() { Name = "张三" };
            var peter = new MyResource() { Name = "李四" };
            var john = new MyResource() { Name = "王五" };
            var lucas = new MyResource() { Name = "赵六" };
            var james = new MyResource() { Name = "李琦" };
            var mary = new MyResource() { Name = "孙斌" };
            // Add some resources
            _mManager.Assign(wake, jake);
            _mManager.Assign(wake, peter);
            _mManager.Assign(wake, john);
            _mManager.Assign(wake1, john);
            _mManager.Assign(wake2, jake);
            _mManager.Assign(teeth, jake);
            _mManager.Assign(teeth, james);
            _mManager.Assign(pack, james);
            _mManager.Assign(pack, lucas);
            _mManager.Assign(shower, mary);
            _mManager.Assign(shower, lucas);
            _mManager.Assign(shower, john);

            // Initialize the Chart with our ProjectManager and CreateTaskDelegate
            _mChart.Init(_mManager);
            _mChart.CreateTaskDelegate = delegate () { return new MyTask(_mManager); };

            // Attach event listeners for events we are interested in
            //_mChart.TaskMouseOver += new EventHandler<TaskMouseEventArgs>(_mChart_TaskMouseOver);
            //_mChart.TaskMouseOut += new EventHandler<TaskMouseEventArgs>(_mChart_TaskMouseOut);
            //_mChart.TaskSelected += new EventHandler<TaskMouseEventArgs>(_mChart_TaskSelected);
            //_mChart.PaintOverlay += _mOverlay.ChartOverlayPainter;
            //_mChart.AllowTaskDragDrop = true;

            // set some tooltips to show the resources in each task
            _mChart.SetToolTip(wake, string.Join(", ", _mManager.ResourcesOf(wake).Select(x => (x as MyResource).Name)));
            _mChart.SetToolTip(teeth, string.Join(", ", _mManager.ResourcesOf(teeth).Select(x => (x as MyResource).Name)));
            _mChart.SetToolTip(pack, string.Join(", ", _mManager.ResourcesOf(pack).Select(x => (x as MyResource).Name)));
            _mChart.SetToolTip(shower, string.Join(", ", _mManager.ResourcesOf(shower).Select(x => (x as MyResource).Name)));

            // Set Time information
            var span = DateTime.Today - _mManager.Start;
            _mManager.Now = span; // set the "Now" marker at the correct date
            _mChart.TimeResolution = TimeResolution.Day; // Set the chart to display in days in header
            host.Child = _mChart as System.Windows.Forms.Control;
            grd.Children.Add(host);
        }

    }


    public class MyResource
    {
        public string Name { get; set; }
    }
    public class MyTask : Braincase.GanttChart.Task
    {
        public MyTask(ProjectManager manager)
            : base()
        {
            Manager = manager;
        }

        private ProjectManager Manager { get; set; }

        public new TimeSpan Start { get { return base.Start; } set { Manager.SetStart(this, value); } }
        public new TimeSpan End { get { return base.End; } set { Manager.SetEnd(this, value); } }
        public new TimeSpan Duration { get { return base.Duration; } set { Manager.SetDuration(this, value); } }
        public new float Complete { get { return base.Complete; } set { Manager.SetComplete(this, value); } }
    }

}
