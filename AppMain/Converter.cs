using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace AppMain
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string exe = AppDomain.CurrentDomain.BaseDirectory;
            string dir = Path.Combine(exe, "Images");

            return Path.Combine(dir, value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
