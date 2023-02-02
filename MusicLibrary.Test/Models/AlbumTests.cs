using MusicLibrary.Models;

namespace MusicLibrary.Test.Models;

public class AlbumTests
{

    [Test]
    public void AlbumStoresTitle()
    {
        Album album = new Album
        {
            Title = "The Title"
        };

        Assert.That<string>(album.Title, Is.EqualTo("The Title"));
    }

    [Test]
    public void AlbumStoresArtistWhenGiven()
    {
        Album album = new Album
        {
            Title = "Some Title",
            Artist = new Artist { Name = "The Artist" }
        };

        Assert.That<string>(album.Artist.Name, Is.EqualTo("The Artist"));
    }
}
