// See https://aka.ms/new-console-template for more information
using MusicLibrary.Comptrollers;

Console.WriteLine("Hello, World!");

// Oh dear! Past Alex hasn't done a great job with this repo!
// It looks like they had heard of MVC, but have tried to apply it to a Console application
// It also looks like they ran out of time to finish this application - it builds, but it doesn't do what it's supposed to!

Console.WriteLine("Artists:");
new ArtistsComptroller().DisplayAllArtists();

Console.WriteLine("Albums:");
new AlbumComptroller().DisplayAllAlbums();

Console.WriteLine("List all albums by artist:");
string? artist = Console.ReadLine()?.Trim();
if (!string.IsNullOrWhiteSpace(artist))
{
    //TODO
    // new AlbumComptroller().DisplayAlbumsByArtist(artist);
}

Console.Read();