using MusicLibrary.Models;

namespace MusicLibrary.Test.Models;

public class ArtistTests
{


    [Test]
    public void ArtistStoresName()
    {
        var artist = new Artist { Name = "The Name" };
        Assert.That<string>(artist.Name, Is.EqualTo("The Name"))
;    }
}
