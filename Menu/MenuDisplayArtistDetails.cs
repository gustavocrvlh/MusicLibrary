using MusicLibrary.Models;
namespace MusicLibrary.Menus;


internal class MenuDisplayArtistDetails : Menu
{
    public override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        base.Execute(registeredArtists);
        Console.Write("Artist name: ");
        string artistName = Console.ReadLine()!;
        if (registeredArtists.ContainsKey(artistName))
        {
            Console.Clear();
            Artist artist = registeredArtists[artistName];
            Console.WriteLine($"Artist: {artist.Name}");
            Console.WriteLine(artist.Description);
            Console.WriteLine($"Albums:");
            foreach (Album album in artist.Albums)
            {
                Console.WriteLine($"{album.Name} | Average Rating: {album.AverageRating}");
            }
            Console.WriteLine($"\nThe average rating for {artistName} is {artist.AverageRating}.");
            Console.WriteLine("Type any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\n {artistName} was not found!");
            Console.WriteLine("Type any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}