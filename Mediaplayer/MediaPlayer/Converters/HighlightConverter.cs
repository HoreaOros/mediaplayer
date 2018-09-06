using MediaPlayer.Controls;
using System;
using System.Globalization;
using System.Windows.Data;

namespace MediaPlayer.Converters
{
    class HighlightConverter : IValueConverter
    {
        public object Convert(object value, Type TargetType, object parameter, CultureInfo culture)
        {
            MediaPlayerThePlayer test = (MediaPlayerThePlayer)value;
            return test.CurrentIndexPlaying;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
