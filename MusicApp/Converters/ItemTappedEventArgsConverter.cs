using System;
using System.Globalization;
using Xamarin.Forms;

namespace MusicApp
{
	public class ItemTappedEventArgsConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			// value = sender
			// parameter = EventArgs
			var args = parameter as ItemTappedEventArgs;
			return args.Item;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}