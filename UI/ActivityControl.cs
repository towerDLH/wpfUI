using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using UI.Inter;

namespace UI
{
    public class ActivityControl : UserControl, IActivity
    {
        static ActivityControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ActivityControl), new FrameworkPropertyMetadata(typeof(ActivityControl)));
        }

        public double X
        {
            set { Canvas.SetLeft(this, value); }
            get { return Canvas.GetLeft(this); }
        }
        public double Y
        {
            set { Canvas.SetTop(this, value); }
            get { return Canvas.GetTop(this); }
        }
        public string type { set; get; }
        public virtual string title { get; set; }
        List<string> _branchList = new List<string>();
        public List<string> branchList
        {
            get { return _branchList; }
            set { value = _branchList; }
        }
        public IDesigner Designer { set; get; }
        public string Dsc { set; get; }
        public object NodeDate { set; get; }

        public void Del()
        {
            Designer.RemoveActivity(this.Name);
        }

        public void SetActive()
        {
            throw new NotImplementedException();
        }
        public event EventHandler LoadEven = null;

        public event EventHandler ConnectEven = null;
        protected void OnLoand()
        {
            if (LoadEven != null)
            {
                LoadEven(this, EventArgs.Empty);
            }
        }

        protected void OnConnect(string s)
        {
            if (ConnectEven != null)
            {
                string[] os = s.Split(',');
                ConnectEven(this, new LinkEventArgs() { Starpoint = os[0], RouCondition = os[1] });
            }
        }
    }
    public class LinkEventArgs : EventArgs
    {
        public string Starpoint
        {
            set;
            get;
        }

        public string RouCondition
        { set; get; }
    }
}
