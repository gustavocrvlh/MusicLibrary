using MusicLibrary.Models;

namespace MusicLibrary.Menus;

internal class MenuRateAlbum : Menu
{
    public override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        base.Execute(registeredArtists);
        Console.Write("Artist name: ");
        string artistName = Console.ReadLine()!;

        if (registeredArtists.ContainsKey(artistName))
        {
            Artist artist = registeredArtists[artistName];
            Console.Write($"Album name: ");
            string albumName = Console.ReadLine()!;
            if (artist.Albums.Any(a => a.Name.Equals(albumName)))
            {
                Album album = artist.Albums.First(a => a.Name.Equals(albumName));
                Console.Write($"Give a rating from 0 to 10 to {albumName}: ");
                Rating ratingValue = Rating.Parse(Console.ReadLine()!);
                album.Rate(ratingValue);
                Console.WriteLine($"\n The rating {ratingValue.RatingValue} was registered to {albumName} successfully!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\n{albumName} was not found!");
                Console.WriteLine("Type any key to return to the main menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\n{artistName} was not found!");
            Console.WriteLine("Type any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}