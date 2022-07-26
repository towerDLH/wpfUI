using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace UI.Control
{
    /// <summary>
    /// SoftKeyBoard.xaml 的交互逻辑
    /// </summary>
    public partial class SoftKeyBoard : UserControl
    {

        /// <summary>
        /// 导入模拟键盘的方法
        /// </summary>
        /// <param name="bVk" >按键的虚拟键值</param>
        /// <param name= "bScan" >扫描码，一般不用设置，用0代替就行</param>
        /// <param name= "dwFlags" >选项标志：0：表示按下，2：表示松开</param>
        /// <param name= "dwExtraInfo">一般设置为0</param>
        [DllImport("User32.dll")]
        public static extern void keybd_event(byte bVK, byte bScan, Int32 dwFlags, int dwExtraInfo);

        #region

        public static readonly DependencyProperty CapsProperty = DependencyProperty.Register(
            "Caps", typeof(bool), typeof(SoftKeyBoard), new PropertyMetadata(default(bool)));

        public bool Caps
        {
            get { return (bool)GetValue(CapsProperty); }
            set { SetValue(CapsProperty, value); }
        }

        public static readonly DependencyProperty CtrlProperty = DependencyProperty.Register(
            "Ctrl", typeof(bool), typeof(SoftKeyBoard), new PropertyMetadata(default(bool)));

        public bool Ctrl
        {
            get { return (bool)GetValue(CtrlProperty); }
            set { SetValue(CtrlProperty, value); }
        }

        public static readonly DependencyProperty AltProperty = DependencyProperty.Register(
            "Alt", typeof(bool), typeof(SoftKeyBoard), new PropertyMetadata(default(bool)));

        public bool Alt
        {
            get { return (bool)GetValue(AltProperty); }
            set { SetValue(AltProperty, value); }
        }

        public static readonly DependencyProperty ShiftProperty = DependencyProperty.Register(
            "Shift", typeof(bool), typeof(SoftKeyBoard), new PropertyMetadata(default(bool)));

        public bool Shift
        {
            get { return (bool)GetValue(ShiftProperty); }
            set { SetValue(ShiftProperty, value); }
        }

        #endregion

        public ICommand KeyCommand { get; set; }

        private Dictionary<string, byte> keys;

        public SoftKeyBoard()
        {
            InitializeComponent();
            SetCommand();
            CreateKeys();

        }

        private void CreateKeys()
        {
            keys = new Dictionary<string, byte>()
            {
                #region row1
                { "`",192},
                { "1",49},
                { "2",50},
                { "3",51},
                { "4",52},
                { "5",53},
                { "6",54},
                { "7",55},
                { "8",56},
                { "9",57},
                { "0",48},
                { "-",189},
                { "=",187},
                { "Delete",8},
                { "~",192},
                { "!",49},
                { "@",50},
                { "#",51},
                { "$",52},
                { "%",53},
                { "^",54},
                { "&",55},
                { "*",56},
                { "(",57},
                { ")",48},
                { "_",189},
                { "+",187},
                #endregion

                #region row2
                { "Tab",9},
                { "q",  81},
                { "w",  87},
                { "e",  69},
                { "r",  82},
                { "t",  84},
                { "y",  89},
                { "u",  85},
                { "i",  73},
                { "o",  79},
                { "p",  80},
                { "[",  219},
                { "]",  221},
                { @"\", 220},
                { "Q",  81},
                { "W",  87},
                { "E",  69},
                { "R",  82},
                { "T",  84},
                { "Y",  89},
                { "U",  85},
                { "I",  73},
                { "O",  79},
                { "P",  80},
                { "{",  219},
                { "}",  221},
                { "|", 220},
                #endregion

                #region row3
                { "a",65},
                { "s",  83},
                { "d",  68},
                { "f",  70},
                { "g",  71},
                { "h",  72},
                { "j",  74},
                { "k",  75},
                { "l",  73},
                { ";",  186},
                { "'",  222},
                { "Enter",  13},
                { "A",65},
                { "S",  83},
                { "D",  68},
                { "F",  70},
                { "G",  71},
                { "H",  72},
                { "J",  74},
                { "K",  75},
                { "L",  73},
                { ":",  186},
                { "\"",  222},

                #endregion

                #region row4
                { "z",90},
                { "x",  88},
                { "c",  67},
                { "v",  86},
                { "b",  66},
                { "n",  78},
                { "m",  77},
                { ",",  188},
                { ".",  190},
                { "/",  191},
                { "Z",90},
                { "X",  88},
                { "C",  67},
                { "V",  86},
                { "B",  66},
                { "N",  78},
                { "M",  77},
                { "<",  188},
                { ">",  190},
                { "?",  191},

                #endregion

                #region other
                {"Space",32 },

                #endregion

            };
        }

        private void SetCommand()
        {
            KeyCommand = new RoutedCommand();
            CommandBinding cbinding = new CommandBinding(KeyCommand, KeyCommand_Excuted, KeyCommand_CanExcute);
            this.CommandBindings.Add(cbinding);
        }

        private void KeyCommand_CanExcute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void KeyCommand_Excuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter != null)
            {
                string code = e.Parameter.ToString();
                if (keys.ContainsKey(code))
                {
                    byte b = keys[code];
                    try
                    {
                        keybd_event(b, 0, 0, 0);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

        }


        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.Property == CapsProperty)
            {
                //按下
                keybd_event(20, 0, 0, 0);
                //抬起
                keybd_event(20, 0, 2, 0);
            }
            else if (e.Property == ShiftProperty)
            {
                if (Shift)
                {
                    //按下
                    keybd_event(16, 0, 0, 0);
                }
                else
                {
                    //抬起
                    keybd_event(16, 0, 2, 0);
                }
            }
            else if (e.Property == CtrlProperty)
            {
                if (Ctrl)
                {
                    //按下
                    keybd_event(17, 0, 0, 0);
                }
                else
                {
                    //抬起
                    keybd_event(17, 0, 2, 0);
                }
            }
            else if (e.Property == AltProperty)
            {
                if (Alt)
                {
                    //按下
                    keybd_event(18, 0, 0, 0);
                }
                else
                {
                    //抬起
                    keybd_event(18, 0, 2, 0);
                }
            }
        }
    }

    public class UperConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
            {
                return "";
            }

            if (value == null)
            {
                if (parameter != null)
                {
                    return parameter.ToString();
                }
                else
                {
                    return "";
                }
            }

            bool isuper = (bool)value;

            if (isuper)
            {
                return parameter.ToString().ToUpper();
            }
            else
            {
                return parameter.ToString().ToLower();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ShiftConvert : IValueConverter
    {
        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            {"`","~" },
            {"1","!" },
            {"2","@" },
            {"3","#" },
            {"4","$" },
            {"5","%" },
            {"6","^" },
            {"7","&" },
            {"8","*" },
            {"9","(" },
            {"0",")" },
            {"-","_" },
            {"=","+" },
            {"[","{" },
            {"]","}" },
            {";",":" },
            {"'","\"" },
            {",","<" },
            {".",">" },
            {"/","?" },
            {@"\","|" },
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
            {
                return "";
            }

            if (value == null)
            {
                if (parameter != null)
                {
                    return parameter.ToString();
                }
                else
                {
                    return "";
                }
            }

            bool shift = (bool)value;

            if (shift)
            {
                var cond = parameter.ToString();
                if (dic.ContainsKey(cond))
                {
                    return dic[cond];
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return parameter.ToString();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
