class Music
{
    public string name;
    public string artist;
    public bool isSingle;
    public string? album;
    public int year;

    public void DisplayMusicInfo()
    {
        if (isSingle)
        {
            Console.WriteLine($"Name: {name} - Single");
            Console.WriteLine($"Artist: {artist}");
            Console.WriteLine($"Year: {year}");
        }
        else
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Artist: {artist}");
            Console.WriteLine($"Album: {album}");
            Console.WriteLine($"Year: {year}");
        }
    }
}