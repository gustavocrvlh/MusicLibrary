using MusicLibrary.Models;
namespace MusicLibrary.Menus;

internal class Menu
{
    public virtual void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.Clear();
    }

}