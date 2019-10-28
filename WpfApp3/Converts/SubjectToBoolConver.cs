using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp3.Converts
{

    public class SubjectToBoolConver : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {

            if (values == null)
                return false;
            if (int.Parse(values[0].ToString()) == int.Parse(values[1].ToString()))
                return true;
            return false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            string[] splitValues = ((string)value).Split(' ');
                 return splitValues;
            int[] Subject = new int[2];
            return null;
            //return (int)targetTypes[0];
        }
    }
}
