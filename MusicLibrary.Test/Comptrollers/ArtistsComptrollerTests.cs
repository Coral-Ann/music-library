using Moq;
using MusicLibrary.Comptrollers;
using MusicLibrary.Models;
using MusicLibrary.Repositories;

namespace MusicLibrary.Test;

public class ArtistsComptrollerTests
{
    Mock<IRepository<Artist>> mockRepository;
    StringWriter consoleOutput;

    [SetUp]
    public void Setup()
    {
        mockRepository = new Mock<IRepository<Artist>>();

        //console stuff taken from https://pmichaels.net/2022/05/26/unit-testing-a-console-application/
        consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
    }

    [Test]
    public void ArtistsComptrollerDisplaysAllArtistsFromArtistRepository()
    {
        //arrange
        var subject = new ArtistsComptroller(mockRepository.Object);

        mockRepository.Setup(m => m.GetAll()).Returns(new List<Artist>
        {
            new Artist { Name = "Alice" },
            new Artist { Name = "Bob" },
            new Artist { Name = "Carol" }
        });

        //act
        subject.DisplayAllArtists();

        //assert
        var output = consoleOutput.GetStringBuilder().ToString().Trim();

        Assert.That(output, Is.EqualTo("Alice, Bob, Carol"));
    }
}
