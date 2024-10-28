using MusicLibrary.Models;
using MusicLibrary.Menus;
internal class Program
{
    private static void Main(string[] args)
    {
        Artist artist1 = new Artist("Ira");
        artist1.RateArtist(new Rating(10));
        artist1.RateArtist(new Rating(8));
        artist1.RateArtist(new Rating(6));

        Artist artist2 = new Artist("The Beatles");
        artist2.RateArtist(new Rating(10));
        artist2.RateArtist(new Rating(8));
        artist2.RateArtist(new Rating(6));

        Dictionary<string, Artist> registeredArtists = new();
        registeredArtists.Add(artist1.Name, artist1);
        registeredArtists.Add(artist2.Name, artist2);

        void DisplayMenuOptions()
        {
            Console.WriteLine("\nType 1 to register a new artist");
            Console.WriteLine("Type 2 to register a new album");
            Console.WriteLine("Type 3 to show registered artist");
            Console.WriteLine("Type 4 to rate a artist");
            Console.WriteLine("Type 5 to show artist details");
            Console.WriteLine("Type -1 to exit");

            Console.Write("\n Select an options: ");
            string chosenOption = Console.ReadLine()!;
            int chosenOptionNumber = int.Parse(chosenOption);

            switch (chosenOptionNumber)
            {
                case 1:
                    MenuRegisterArtist menu1 = new MenuRegisterArtist();
                    menu1.Execute(registeredArtists);
                    DisplayMenuOptions();
                    break;
                case 2:
                    MenuRegisterAlbum menu2 = new MenuRegisterAlbum();
                    menu2.Execute(registeredArtists);
                    DisplayMenuOptions();
                    break;
                case 3:
                    MenuDisplayRegisteredArtists menu3 = new MenuDisplayRegisteredArtists();
                    menu3.Execute(registeredArtists);
                    DisplayMenuOptions();
                    break;
                case 4:
                    MenuRateArtist menu4 = new MenuRateArtist();
                    menu4.Execute(registeredArtists);
                    DisplayMenuOptions();
                    break;
                case 5:
                    MenuDisplayArtistDetails menu5 = new MenuDisplayArtistDetails();
                    menu5.Execute(registeredArtists);
                    DisplayMenuOptions();
                    break;
                case -1:
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(4000);
                    break;
            }
        }
        DisplayMenuOptions();
    }
}