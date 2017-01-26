using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MusicApp
{
	public partial class AlbumsPage : ContentPage
	{
		public AlbumsPage()
		{
			InitializeComponent();

			BindingContext = new AlbumsViewModel();
		}
	}
}