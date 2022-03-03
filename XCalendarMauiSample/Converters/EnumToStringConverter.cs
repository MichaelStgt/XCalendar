using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Maui.Extensions;
using System.Globalization;

namespace XCalendarMauiSample.Converters
{
    public class EnumToStringConverter : ValueConverterExtension, ICommunityToolkitValueConverter, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return Enum.GetName(value.GetType(), value);
            }
            
            catch
            {
                return value?.ToString();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Enum.Parse(Type.GetType((string)parameter, true), (string)value);
        }
    }
}
