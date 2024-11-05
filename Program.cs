using MusicLibrary;
using MusicLibrary.Models;
using MusicLibrary.Menus;
internal class Program
{
    private static void Main(string[] args)
    {
        Artist artist1 = new Artist("Ira");
        artist1.Rate(new Rating(10));
        artist1.Rate(new Rating(8));
        artist1.Rate(new Rating(6));

        Artist artist2 = new Artist("The Beatles");
        artist2.Rate(new Rating(10));
        artist2.Rate(new Rating(8));
        artist2.Rate(new Rating(6));

        Dictionary<string, Artist> registeredArtists = new();
        registeredArtists.Add(artist1.Name, artist1);
        registeredArtists.Add(artist2.Name, artist2);

        Dictionary<int, Menu> options = new();
        options.Add(1, new MenuRegisterArtist());
        options.Add(2, new MenuRegisterAlbum());
        options.Add(3, new MenuDisplayRegisteredArtists());
        options.Add(4, new MenuRateArtist());
        options.Add(5, new MenuDisplayArtistDetails());

        void DisplayMenuOptions()
        {
            Console.WriteLine("\nType 1 to register a new artist");
            Console.WriteLine("Type 2 to register a new album");
            Console.WriteLine("Type 3 to show registered artist");
            Console.WriteLine("Type 4 to rate a artist");
            Console.WriteLine("Type 5 to show artist details");

            Console.Write("\n Select an options: ");
            string chosenOption = Console.ReadLine()!;
            int chosenOptionNumber = int.Parse(chosenOption);

            if (options.ContainsKey(chosenOptionNumber))
            {
                Menu menu = options[chosenOptionNumber];
            }
            else
            {
                System.Console.WriteLine("Invalid option!");
            }
        }
        DisplayMenuOptions();
    }
}