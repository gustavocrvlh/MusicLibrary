class Artist
{
    private List<Album> albums = new List<Album>();

    public Artist(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
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