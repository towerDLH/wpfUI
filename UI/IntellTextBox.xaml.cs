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
    /// <summary>
    /// IntellTextBox.xaml 的交互逻辑
    /// </summary>
    public partial class IntellTextBox : UserControl
    {
        static List<string> Treelist = new List<string>() { };
        public IntellTextBox()
        {
            InitializeComponent();
        }

        public IEnumerable<string> IntellList
        {
            get { return (IEnumerable<string>)GetValue(IntellListProperty); }
            set { SetValue(IntellListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IntellList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IntellListProperty =
            DependencyProperty.Register("IntellList", typeof(IEnumerable<string>), typeof(IntellTextBox), new PropertyMetadata(Treelist, ListChange));



        public string WaterTxt
        {
            get { return (string)GetValue(WaterTxtProperty); }
            set { SetValue(WaterTxtProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WaterTxt.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterTxtProperty =
            DependencyProperty.Register("WaterTxt", typeof(string), typeof(IntellTextBox), new PropertyMetadata(string.Empty, WaterTextChange));

        private static void WaterTextChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IntellTextBox tobj = d as IntellTextBox;
            tobj.WaterTxt = (string)e.NewValue;
            //tobj.OnSamplePropertyChanged(e);
        }
        private void OnSamplePropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            string SamplePropertyNewValue = (string)e.NewValue;
            tTxt.Text = SamplePropertyNewValue;
        }
        public string ContentText
        {
            get { return (string)GetValue(ContentTextProperty); }
            set { SetValue(ContentTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ContentText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentTextProperty =
            DependencyProperty.Register("ContentText", typeof(string), typeof(IntellTextBox), new PropertyMetadata(string.Empty, ContetChange));




        public string NametextProperty
        {
            get { return (string)GetValue(NametextPropertyProperty); }
            set { SetValue(NametextPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NametextProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NametextPropertyProperty =
            DependencyProperty.Register("NametextProperty", typeof(string), typeof(IntellTextBox), new PropertyMetadata(string.Empty));



        private static void ContetChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IntellTextBox tobj = d as IntellTextBox;
            tobj.ContentText = (string)e.NewValue;
           // tobj.LoadText((string)e.NewValue);
        }


        public void LoadText(string TextName)
        {
            tTxt.Text = TextName;
        }
        private static void ListChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IntellTextBox tobj = d as IntellTextBox;
            tobj.IntellList = (IEnumerable<string>)e.NewValue;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tbm = e.OriginalSource as TextBox;
            if (IntellList.ToList().Count != 0)//这里是这样的条件，可以根据需求来改变
            {
                if (e.Key == Key.Enter)
                {
                    if (MailConfigSelection.SelectedItem == null) return;
                    string mailConfig = MailConfigSelection.SelectedItem.ToString();
                    TextBox tb = tTxt;
                    int i = tb.CaretIndex;//获取呼出这个popup的textbox的当前光标位置
                    tb.Text = mailConfig;//插入选择的字符串
                    tb.CaretIndex = i + mailConfig.Length + 1;//移动光标
                    tb.Focus();
                    ConfigPopup.IsOpen = false;
                }
                if (e.Key == Key.Down)
                {
                    int index = MailConfigSelection.SelectedIndex;
                    if (index < MailConfigSelection.Items.Count)
                    {
                        index++;
                    }
                    MailConfigSelection.SelectedIndex = index;
                }
                if (e.Key == Key.Up)
                {
                    int index = MailConfigSelection.SelectedIndex;
                    if (index > 1)
                    {
                        index--;
                    }
                    MailConfigSelection.SelectedIndex = index;
                }
                else if (e.Key != Key.Down && e.Key != Key.Up && e.Key != Key.Enter)
                    ShowPopUp(tbm.GetRectFromCharacterIndex(tbm.CaretIndex), tbm);
            }
        }
        private void ShowPopUp(Rect placementRect, TextBox tb)
        {
            // ConfigPopup.PlacementTarget = tb;
            //ConfigPopup.PlacementRectangle = placementRect;
            ConfigPopup.IsOpen = true;
            List<string> resultList = (from c in IntellList where c.Contains(tb.Text) select c).ToList();
            MailConfigSelection.ItemsSource = resultList;
            MailConfigSelection.SelectedIndex = 0;
            var listBoxItem = (ListBoxItem)MailConfigSelection.ItemContainerGenerator.ContainerFromItem(MailConfigSelection.SelectedItem);
            if (listBoxItem != null) listBoxItem.Focus();
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
                ConfigPopup.IsOpen = false;
            }
            else if (e.Key == Key.Escape)
            {
            }
        }

        private void MailConfigSelection_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ConfigPopup.IsOpen = false;
            System.Windows.Controls.ListBox lb = sender as System.Windows.Controls.ListBox;
            if (lb == null) return;
            if (lb.SelectedItem != null)
            {
                string mailConfig = lb.SelectedItem.ToString();
                TextBox tb = tTxt;
                int i = tb.CaretIndex;//获取呼出这个popup的textbox的当前光标位置
                tb.Text = mailConfig;//插入选择的字符串
                tb.CaretIndex = i + mailConfig.Length + 1;//移动光标
                tb.Focus();
                ConfigPopup.IsOpen = false;
            }
        }

        private void tTxt_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tbm = e.OriginalSource as TextBox;
            if (IntellList.ToList().Count != 0)//这里是这样的条件，可以根据需求来改变
            {
                if (e.Key == Key.Enter)
                {
                    if (MailConfigSelection.SelectedItem == null) return;
                    string mailConfig = MailConfigSelection.SelectedItem.ToString();
                    TextBox tb = tTxt;
                    int i = tb.CaretIndex;//获取呼出这个popup的textbox的当前光标位置
                    tb.Text = mailConfig;//插入选择的字符串
                    tb.CaretIndex = i + mailConfig.Length + 1;//移动光标
                    tb.Focus();
                    ConfigPopup.IsOpen = false;
                }
                if (e.Key == Key.Down)
                {
                    int index = MailConfigSelection.SelectedIndex;
                    if (index < MailConfigSelection.Items.Count)
                    {
                        index++;
                    }
                    MailConfigSelection.SelectedIndex = index;
                }
                if (e.Key == Key.Up)
                {
                    int index = MailConfigSelection.SelectedIndex;
                    if (index > 1)
                    {
                        index--;
                    }
                    MailConfigSelection.SelectedIndex = index;
                }
                else if (e.Key != Key.Down && e.Key != Key.Up && e.Key != Key.Enter)
                    ShowPopUp(tbm.GetRectFromCharacterIndex(tbm.CaretIndex), tbm);
            }
        }
    }
}
