namespace MusicLibrary.Models;

class Music
{
    public Music(Artist artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; }
    public Artist Artist { get; }
    public bool IsSingle { get; set; }
    public string? Album { get; set; }
    public int ReleaseYear { get; set; }
    public int Duration { get; set; }

    public string Description
    {
        get
        {
            if (IsSingle)
            {
                return $"The single {Name} by {Artist} was release in {ReleaseYear}.";
            }
            else
            {
                return $"The song {Name} by {Artist}, from the album {Album} was released in {ReleaseYear}.";
            }
        }
    }

    public void DisplayMusicInfo()
    {
        if (IsSingle)
        {
            Console.WriteLine("");
            Console.WriteLine($"Name: {Name} - Single");
            Console.WriteLine($"Artist: {Artist.Name}");
            Console.WriteLine($"Released in {ReleaseYear}");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artist: {Artist.Name}");
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Released in {ReleaseYear}");
        }
    }
}