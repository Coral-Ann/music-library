// See https://aka.ms/new-console-template for more information
using MusicLibrary.Comptrollers;
using MusicLibrary.Models;
using MusicLibrary.Repositories;

Console.WriteLine("Music Library!\n");

Console.WriteLine("Artists:");
new ArtistsComptroller().DisplayAllArtists();

Console.WriteLine("Albums:");
new AlbumComptroller().DisplayAllAlbums();

while (true)
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1: List Album by Artist");
    Console.WriteLine("2: Add a new Album");
    Console.WriteLine("3: Remove an Album");
    Console.WriteLine("4: Exit");
    switch (Console.ReadLine())
    {
        case "1":
            while (true)
            {
                Console.WriteLine("Please enter an artist name:");
                string? artist = Console.ReadLine()?.Trim();
                if (!string.IsNullOrWhiteSpace(artist))
                {
                    new AlbumComptroller().DisplayAlbumsByArtist(artist);
                }

                Console.WriteLine("Would you like to find another album by artist? (Y/N)");
                string? choice = Console.ReadLine()?.Trim().ToUpper();
                Console.WriteLine();

                if (choice == "N")
                {
                    break;
                }
            }
            break;

        case "2":
            Console.WriteLine("\nOops! Not implemented yet!\n");
            break;

        case "3":
            Console.WriteLine("\nOops! Not implemented yet!\n");
            break;

        case "4":
            Console.WriteLine("Exiting the program...");
            Environment.Exit(0);
            break;

        default: continue;
    }
}