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
                return $"This is a single named {Name} by {Artist}, release in {ReleaseYear}.";
            }
            else
            {
                return $"This is a song named {Name} from the album {Album} by {Artist}, released in {ReleaseYear}.";
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
            Console.WriteLine($"Year: {ReleaseYear}");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artist: {Artist.Name}");
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Year: {ReleaseYear}");
        }
    }
}