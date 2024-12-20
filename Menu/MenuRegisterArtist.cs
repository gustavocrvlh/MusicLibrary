using GenerativeAI.Models;
using GenerativeAI.Types;
using MusicLibrary.Models;
using DotNetEnv;
namespace MusicLibrary.Menus;

internal class MenuRegisterArtist : Menu
{
    public override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        base.Execute(registeredArtists);
        Console.Write("Artist name: ");
        string artistName = Console.ReadLine()!;
        Artist artist = new Artist(artistName);
        registeredArtists.Add(artistName, artist);

        Env.Load();

        var apiKey = Env.GetString("API_KEY");

        var model = new GenerativeModel(apiKey);

        var chat = model.StartChat(new StartChatParams());

        var result = chat.SendMessageAsync($"Write a short paragraf about the artist {artistName}").GetAwaiter().GetResult();



        artist.Description = result;

        Console.WriteLine(" ");
        Console.WriteLine(result);
        Console.WriteLine($"\nThe artist {artistName} was registered successfully!");
        Console.WriteLine("\nType any key to return to the main menu");
        Console.ReadKey();
        Console.Clear();
    }
}