using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Concursus.Library.Games;
using System;
using System.Globalization;

namespace Concursus.Desktop.Converters;

public class ToGameAsset : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is Game game && parameter is string file)
        {
            return new Bitmap(AssetLoader.Open(new Uri($"avares://Concursus.Desktop/Assets/Games/{game.InternalName}/{file}")));
        }

        return value;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return new BindingNotification(new Exception(), BindingErrorType.Error);
    }
}
