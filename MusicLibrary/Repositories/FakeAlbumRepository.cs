using System;
using MusicLibrary.Models;

namespace MusicLibrary.Repositories
{
	public class FakeAlbumRepository
	{
		List<Album> albums = new List<Album>
		{
            new Album { Title = "Doolittle", Artist = new Artist { Name = "Pixies" } },
			new Album { Title = "Surfer Rosa", Artist = new Artist { Name = "Pixies" } },
			new Album { Title = "Waterloo", Artist = new Artist { Name = "ABBA" } },
			new Album { Title = "Folklore" },
			new Album { Title = "Bossanova", Artist = new Artist { Name = "Pixies" } },

        };

		public FakeAlbumRepository()
		{
		}
	}
}

