using System;
using System.Collections.Generic;

namespace MusicApp
{
	public static class Data
	{
		public static List<Album> Albums { get; } = new List<Album>();

		static Data()
		{
			AddAlbum();
		}

		private static void AddAlbum()
		{
			var album = new Album()
			{
				Artist = "Ira!",
				Name = "Vivendo e Não Aprendendo",
				Year = 1986,
				Songs = new List<Song>()
				{
					new Song() {Track = 1, Name = "Envelheço Na Cidade", Duration = "3:17"},
					new Song() {Track = 2, Name = "Casa De Papel", Duration = "3:36"},
					new Song() {Track = 3, Name = "Dias de Luta", Duration = "4:26"},
					new Song() {Track = 4, Name = "Tanto Quanto Eu", Duration = "2:50"},
					new Song() {Track = 5, Name = "Vitrine Viva", Duration = "2:20"},
					new Song() {Track = 6, Name = "Flores Em Você", Duration = "1:54"},
					new Song() {Track = 7, Name = "Quinze Anos (Vivendo E Não Aprendendo)", Duration = "2:40"},
					new Song() {Track = 8, Name = "Nas Ruas", Duration = "4:17"},
					new Song() {Track = 9, Name = "Gritos Na Multidão", Duration = "3:08"},
					new Song() {Track = 10, Name = "Pobre Paulista", Duration = "4:57"}
				}
			};

			Albums.Add(album);
		}
	}
}