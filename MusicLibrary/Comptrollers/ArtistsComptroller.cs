using System;
using MusicLibrary.Repositories;
using MusicLibrary.Models;

namespace MusicLibrary.Comptrollers
{
	public class ArtistsComptroller
	{
        private readonly IRepository<Artist> repo;

        public ArtistsComptroller(IRepository<Artist> repo)
		{
            this.repo = repo;
            
        }

        public ArtistsComptroller()
        {
            repo = new FakeArtistRepository();
        }

        public void DisplayAllArtists()
        {
            Console.WriteLine(string.Join(", ", repo.GetAll().Select(artist => artist.Name)));
        }
	}
}

