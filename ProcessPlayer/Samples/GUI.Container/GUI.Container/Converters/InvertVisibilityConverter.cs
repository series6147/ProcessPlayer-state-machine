﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace GUIContainer.Converters
{
    public class InvertVisibilityConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Equals(value, Visibility.Collapsed) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
