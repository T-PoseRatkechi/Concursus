using Avalonia.Controls.Presenters;
using Avalonia.Data.Converters;
using System;
using System.Globalization;

namespace Concursus.Desktop.Converters;

public class InContentPresenter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        => new ContentPresenter() { Content = value };

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is ContentPresenter contentPresenter)
        {
            return contentPresenter.Content;
        }

        return null;
    }
}
