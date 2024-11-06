using MusicLibrary.Models;
namespace MusicLibrary.Menus;
internal class MenuRegisterAlbum : Menu
{
    public override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        base.Execute(registeredArtists);
        Console.Write("Artist name: ");
        string artistName = Console.ReadLine()!;
        if (registeredArtists.ContainsKey(artistName))
        {
            Console.Write("Album name: ");
            string tituloAlbum = Console.ReadLine()!;
            Artist artist = registeredArtists[artistName];
            artist.AddAlbum(new Album(tituloAlbum));
            Console.WriteLine($"The álbum {tituloAlbum} by {artistName} was registered successfully!");
            Console.WriteLine("Loading menu...");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Artist not found");
            Console.WriteLine("Loading menu...");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}