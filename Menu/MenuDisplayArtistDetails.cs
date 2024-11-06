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
            Artist artist = registeredArtists[artistName];
            Console.WriteLine($"\nA média da banda {artistName} é {artist.AverageRating}.");
            /**
            * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
            */
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
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