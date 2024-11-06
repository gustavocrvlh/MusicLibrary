namespace MusicLibrary.Models;

internal class Album : IRetable
{
    private List<Music> musics = new List<Music>();
    private List<Rating> ratingValues = new();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int Duration => musics.Sum(m => m.Duration);

    public double AverageRating
    {
        get
        {
            if (ratingValues.Count == 0) return 0;
            else return ratingValues.Average(r => r.RatingValue);
        }
    }

    public void AddMusic(Music music)
    {
        music.Album = Name;
        musics.Add(music);
    }

    public void DisplayAlbumInfo()
    {
        int minutes = Duration / 60;
        int seconds = Duration % 60;

        Console.WriteLine("");
        Console.WriteLine($"Album Name: {Name}");
        DisplayAlbumDuration(Duration);

        Console.WriteLine("Musics:");
        foreach (var music in musics)
        {
            Console.WriteLine($"{music.Name}");
        }
    }

    public void DisplayAlbumDuration(int Duration)
    {
        int minutes = Duration / 60;
        int seconds = Duration % 60;

        Console.WriteLine($"Duration: {minutes} minutes and {seconds} seconds");
    }

    public void Rate(Rating ratingValue)
    {
        ratingValues.Add(ratingValue);
    }
}