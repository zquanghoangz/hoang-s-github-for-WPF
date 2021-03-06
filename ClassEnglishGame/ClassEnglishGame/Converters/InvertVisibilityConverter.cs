﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ClassEnglishGame.Converters
{
    internal class InvertVisibilityConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return Visibility.Collapsed;
            return ((Visibility) value) == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return Visibility.Collapsed;
            return ((Visibility) value) == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        #endregion
    }
}