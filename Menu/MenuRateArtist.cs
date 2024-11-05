using MusicLibrary.Models;
namespace MusicLibrary.Menus;

internal class MenuRateArtist : Menu
{
    public override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        base.Execute(registeredArtists);
        Console.Write("Artist name: ");
        string artistName = Console.ReadLine()!;

        if (registeredArtists.ContainsKey(artistName))
        {
            Artist artist = registeredArtists[artistName];
            Console.Write($"Give a rating from 0 to 10 to {artistName}: ");
            Rating ratingValue = Rating.Parse(Console.ReadLine()!);
            artist.Rate(ratingValue);
            Console.WriteLine($"\n The rating {ratingValue.RatingValue} was registered to the artist {artistName} successfully!");
            Thread.Sleep(2000);
            Console.Clear();
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