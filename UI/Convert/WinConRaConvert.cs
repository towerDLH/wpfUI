using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace UI.Convert
{
    public class WinConRaConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int v = (int)value;
            string p = parameter.ToString().Trim().ToLower();
            if (p == "header")
                return new CornerRadius(v, v, 0, 0);
            else if (p == "btnclose")
                return new CornerRadius(0, v, 0, 0);
            else
                return new CornerRadius(0, 0, v, v);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
