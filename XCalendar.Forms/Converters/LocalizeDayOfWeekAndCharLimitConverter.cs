﻿using System;
using System.Globalization;
using Xamarin.Forms;
using XCalendar.Core.Extensions;
using XCalendar.Forms.Resources;

namespace XCalendar.Forms.Converters
{
    public class LocalizeDayOfWeekAndCharLimitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is DayOfWeek dayOfWeek))
            {
                return string.Empty;
            }

            string resourceName = $"{dayOfWeek}";

            string dayName = XCalendarResource.ResourceManager.GetString(resourceName, culture);

            if (string.IsNullOrWhiteSpace(dayName))
            {
                dayName = dayOfWeek.ToString().Substring(0, 3);
            }
            else
            {
                dayName = dayName.TruncateStringToMaxLength(parameter);
            }

            return dayName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
