using MusicLibrary.Models;
using MusicLibrary.Repositories;
using System;

namespace MusicLibrary.Comptrollers
{
    public class AlbumComptroller
    {
        private readonly IRepository<Album> repo;

        public AlbumComptroller(IRepository<Album> repo)
        {
            this.repo = repo;

        }

        public AlbumComptroller()
        {
            repo = new FakeAlbumRepository();
        }

        public void DisplayAllAlbums()
        {
            Console.WriteLine(string.Join(", ", repo.GetAll().Select(album => album.Title)) + "\n");
        }

        internal void DisplayAlbumsByArtist(string artist)
        {
            var albumsByArtist = repo.GetAll().Where(album => album.Artist?.Name == artist);
            Console.WriteLine(string.Join(", ", albumsByArtist.Select(album => album.Title)) + "\n");
        }
    }
}

