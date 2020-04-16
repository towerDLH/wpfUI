using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
namespace UI.Convert
{
    public class TextDoubleToString : IValueConverter
    {
        string unmber = "";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double t = 0;
            if (!string.IsNullOrEmpty(unmber))
            {
                double.TryParse(unmber, out t);
            }
            if (t == double.Parse(value.ToString()))
            {
                return unmber;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            unmber = value.ToString();
            double relst = 0;
            double.TryParse(unmber, out relst);
            return relst;
        }
    }
}
