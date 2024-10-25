using MusicLibrary.Models;
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
                    RegisterArtist();
                    break;
                case 2:
                    RegisterAlbum();
                    break;
                case 3:
                    DisplayRegisteredArtists();
                    break;
                case 4:
                    AddArtistRating();
                    break;
                case 5:
                    DisplayArtistDetails();
                    break;
                case -1:
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(4000);
                    break;
            }
        }

        void RegisterAlbum()
        {
            Console.Clear();
            Console.Write("Artist name: ");
            string artistName = Console.ReadLine()!;
            if (registeredArtists.ContainsKey(artistName))
            {
                Console.Write("Album name: ");
                string tituloAlbum = Console.ReadLine()!;
                Artist artist = registeredArtists[artistName];
                artist.AddAlbum(new Album(tituloAlbum));
                Console.WriteLine($"The álbum {tituloAlbum} by {artistName} was registered successfully!");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Artist not found");
                Thread.Sleep(4000);
                Console.Clear();
            }
            DisplayMenuOptions();

        }

        void RegisterArtist()
        {
            Console.Clear();
            Console.Write("Artist name: ");
            string artistName = Console.ReadLine()!;
            Artist artist = new Artist(artistName);
            registeredArtists.Add(artistName, artist);
            Console.WriteLine($"The artist {artistName} was registered successfully!");
            Thread.Sleep(4000);
            Console.Clear();
            DisplayMenuOptions();
        }

        void DisplayRegisteredArtists()
        {
            Console.Clear();

            foreach (string banda in registeredArtists.Keys)
            {
                Console.WriteLine($"Artist: {banda}");
            }

            Console.WriteLine("\nType any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
            DisplayMenuOptions();

        }

        void AddArtistRating()
        {
            Console.Clear();
            Console.Write("Artist name: ");
            string artistName = Console.ReadLine()!;

            if (registeredArtists.ContainsKey(artistName))
            {
                Artist artist = registeredArtists[artistName];
                Console.Write($"Give a rating from 0 to 10 to {artistName}: ");
                int rating = int.Parse(Console.ReadLine()!);
                artist.RateArtist(new Rating(rating));
                Console.WriteLine($"\n The rating {rating} was registered to the artist {artistName} successfully!");
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
            DisplayMenuOptions();
        }

        void DisplayArtistDetails()
        {
            Console.Clear();
            Console.Write("Artist name ");
            string artistName = Console.ReadLine()!;
            if (registeredArtists.ContainsKey(artistName))
            {
                Artist artist = registeredArtists[artistName];
                Console.WriteLine($"\nA média da banda {artistName} é {artist.AverageRating}.");
                /**
                * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
                */
                Console.WriteLine("Digite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                DisplayMenuOptions();

            }
            else
            {
                Console.WriteLine($"\n {artistName} was not found!");
                Console.WriteLine("Type any key to return to the main menu");
                Console.ReadKey();
                Console.Clear();
                DisplayMenuOptions();
            }
        }

        DisplayMenuOptions();
    }
}