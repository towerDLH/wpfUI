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
using System.ComponentModel;
namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student Model;
        public MainWindow()
        {
            InitializeComponent();
            Model = new Student();
            grd.DataContext = Model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

    
            MessageBox.Show($"{Model.Number}");
            //Console.WriteLine(Model.Number);
            MessageBox.Show(Model.Text);
        }
    }
    public class Student : INotifyPropertyChanged
    {


        private Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }


        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; OnPropertyChanged("Number"); }
        }

        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; OnPropertyChanged("Text"); }
        }
        protected void OnPropertyChanged(string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
