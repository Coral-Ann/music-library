using System;
using MusicLibrary.Models;

namespace MusicLibrary.Repositories
{
    public class FakeArtistRepository : IRepository<Artist>
    {
        List<Artist> artists = new List<Artist>
        {
            new Artist { Name = "Pixies" },
            new Artist { Name = "ABBA" },
            new Artist { Name = "Taylor Swift" },
            new Artist { Name = "Nina Simone" }
        };

        IEnumerable<Artist> IRepository<Artist>.GetAll()
        {
            return artists;
        }
    }
}

