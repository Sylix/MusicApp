using System;
using System.Collections.Generic;

namespace MusicApp
{
	public class Album
	{
		public string Name { get; set; }
		public string Artist { get; set; }
		public List<Song> Songs { get; set; }
		public int Year { get; set; }

		public Album()
		{
			Songs = new List<Song>();
		}
	}
}