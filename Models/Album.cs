using System.ComponentModel.DataAnnotations;

class Album
{
    private List<Music> musics = new List<Music>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int Duration => musics.Sum(m => m.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void DisplayAlbumDuration(int Duration)
    {
        int minutes = Duration / 60;
        int seconds = Duration % 60;

        Console.WriteLine($"Duration: {minutes} minutes and {seconds} seconds");
    }

    public void DisplayAlbumInfo()
    {


        Console.WriteLine($"Album Name: {Name}");
        DisplayAlbumDuration(Duration);

        Console.WriteLine("Musics:");
        foreach (var music in musics)
        {
            Console.WriteLine($"{music.Name}");
        }
    }
}