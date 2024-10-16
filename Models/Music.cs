class Music
{
    public string name;
    public string artist;
    public bool isSingle;
    public string? album;
    public int year;

    public void DisplayMusicInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Is Single: {isSingle}");
        Console.WriteLine($"Album: {album ?? "N/A"}");
        Console.WriteLine($"Year: {year}");
    }
}