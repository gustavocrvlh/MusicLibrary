namespace MusicLibrary.Models;

class Artist
{
    private List<Album> albums = new List<Album>();
    private List<int> ratings = new List<int>();

    public Artist(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double AverageRating => ratings.Average();
    public List<Album> Albums => albums;

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void RateAlbum(int rating)
    {
        ratings.Add(rating);
    }

    public void ShowAlbuns()
    {
        Console.WriteLine("");
        Console.WriteLine($"Albums of {Name}:");
        foreach (var album in albums)
        {
            Console.WriteLine(album.Name);
            Console.WriteLine($"{album.Duration} seconds");
        }
    }

}