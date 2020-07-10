using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Msl.HtmlEditor
{
    /// <summary>
    /// FacePicker.xaml 的交互逻辑
    /// </summary>
    public partial class FacePicker : UserControl
    {
        public FacePicker()
        {
            InitializeComponent();
            InitFace();
        }
        void HandleSelect(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem item = sender as ListBoxItem;
            if (item != null)
                SelectedFace = (String)item.Content;
        }
        public String SelectedFace
        {
            get { return (String)GetValue(SelectedFaceProperty); }
            set { SetValue(SelectedFaceProperty, value); }
        }
        //注册属性 SelectedFace
        public static readonly DependencyProperty SelectedFaceProperty =
           DependencyProperty.Register("SelectedFace", typeof(String), typeof(FacePicker),
               new UIPropertyMetadata("", new PropertyChangedCallback(OnSelectedFacePropertyChanged)));

        public event EventHandler<PropertyChangedEventArgs<String>> SelectedFaceChanged;
        bool IsRaiseFaceChangedEvent = true;
        static void OnSelectedFacePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            FacePicker control = sender as FacePicker;
            if (control != null && control.SelectedFaceChanged != null && control.IsRaiseFaceChangedEvent)
                control.SelectedFaceChanged(control, PropertyChangedEventArgs<String>.Create((String)e.NewValue));
        }
        //重置
        public void Reset()
        {
            IsRaiseFaceChangedEvent = false;
            lstFace.SelectedItem = null;
            SelectedFace = "0.gif";
            IsRaiseFaceChangedEvent = true;
        }
        //初始化
        void InitFace()
        {
            if (!Directory.Exists(Glo.FaceImagePath))
                return;

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Glo.FaceImagePath);
            FileInfo[] fis = di.GetFiles();
            if (fis == null) return;

            List<String> ls = new List<String>();
            foreach (FileInfo fi in fis)
                ls.Add(fi.Name);

            this.lstFace.ItemsSource = ls;
        }
    }
}
