using MusicLibrary.Models;
namespace MusicLibrary.Menus;


internal class MenuDisplayArtistDetails
{
    public void Execute(Dictionary<string, Artist> registeredArtists)
    {

        Console.Clear();
        Console.Write("Artist name: ");
        string artistName = Console.ReadLine()!;
        Artist artist = new Artist(artistName);
        registeredArtists.Add(artistName, artist);
        Console.WriteLine($"The artist {artistName} was registered successfully!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}