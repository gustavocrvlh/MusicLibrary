class Music
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public bool IsSingle { get; set; }
    public string Album { get; set; }
    public int Year { get; set; }
    public string Description
    {
        get
        {
            if (IsSingle)
            {
                return $"This is a single named {Name} by {Artist}, release in {Year}.";
            }
            else
            {
                return $"This is a song named {Name} from the album {Album} by {Artist}, released in {Year}.";
            }
        }
    }

    public void DisplayMusicInfo()
    {
        if (IsSingle)
        {
            Console.WriteLine($"Name: {Name} - Single");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Year: {Year}");
        }
        else
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Year: {Year}");
        }
    }
}