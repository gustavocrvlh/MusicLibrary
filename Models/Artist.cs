namespace MusicLibrary.Models;

internal class Artist : IRetable
{
    private List<Album> albums = new List<Album>();
    private List<Rating> ratings = new List<Rating>();

    public Artist(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double AverageRating
    {
        get
        {
            if (ratings.Count == 0) return 0;
            else return ratings.Average(r => r.RatingValue);
        }
    }

    public string? Description { get; set; }
    public List<Album> Albums => albums;

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void Rate(Rating rating)
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