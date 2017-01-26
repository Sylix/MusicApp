using System;
using System.Collections.ObjectModel;
using XamarinUniversity.Infrastructure;

namespace MusicApp
{
	public class AlbumViewModel : SimpleViewModel
	{
		private readonly Album album;

		public AlbumViewModel(Album album)
		{
			this.album = album;
			Songs = new ObservableCollection<Song>(album.Songs);
		}

		public string Name
		{
			get { return album.Name; }
			set
			{
				if (album.Name != value)
				{
					album.Name = value;
					RaisePropertyChanged();
				}
			}
		}

		public string Artist
		{
			get { return album.Artist; }
			set
			{
				if (album.Artist != value)
				{
					album.Artist = value;
					RaisePropertyChanged();
				}
			}
		}

		public int Year
		{
			get { return album.Year; }
			set
			{
				if (album.Year != value)
				{
					album.Year = value;
					RaisePropertyChanged();
				}
			}
		}

		public ObservableCollection<Song> Songs { get; }
	}
}