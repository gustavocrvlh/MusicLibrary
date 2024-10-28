using MusicLibrary.Models;
namespace MusicLibrary.Menus;
internal class MenuDisplayRegisteredArtists
{
    public void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.Clear();
        foreach (string banda in registeredArtists.Keys)
        {
            Console.WriteLine($"Artist: {banda}");
        }
        Console.WriteLine("\nType any key to return to the main menu");
        Console.ReadKey();
        Console.Clear();
    }
}