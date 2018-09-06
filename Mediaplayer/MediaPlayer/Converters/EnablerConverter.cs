using System;
using System.Linq;
using System.Windows.Data;

namespace MediaPlayer.Converters
{
    class EnablerConverter : IMultiValueConverter
    {
        /*
         * takes an array of values convertables to string and return true if all of them have length
         */
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //if there are less than 2 values something is wrong
            if (values.Count() < 2){ return false; }
            //only need to check two values so from [3]... is irrelevant
            return (((string)values[0]).Length > 0 && ((string)values[1]).Length > 0);
        }
        //not needed
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
