using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinUniversity.Interfaces;

namespace MusicApp
{
	public class AlbumsViewModel
	{
		Album currentAlbum;
		public ObservableCollection<Album> Albums { get; private set; }

		public ICommand TappedCommand { protected set; get; }
		public ICommand NewCommand { protected set; get; }
		public ICommand DeleteCommand { protected set; get; }

		public AlbumsViewModel()
		{
			Albums = new ObservableCollection<Album>(Data.Albums);

			NewCommand = new Command(NewAlbum);

			DeleteCommand = new Command<Album>((album) => Albums.Remove(album));

			TappedCommand = new Command<Album>(async (album) =>
			{
				currentAlbum = album;
				var vm = new AlbumViewModel(currentAlbum);
				await DependencyService.Get<INavigationService>().NavigateAsync(App.AppPages.AlbumPage, vm);
			});
		}

		private async void NewAlbum()
		{
			currentAlbum = new Album();
			var vm = new AlbumViewModel(currentAlbum);
			await DependencyService.Get<INavigationService>().PushModalAsync(App.AppPages.EditAlbumPage, vm);
		}
	}
}