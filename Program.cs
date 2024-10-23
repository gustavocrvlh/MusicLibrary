Artist artist1 = new Artist("Sepultura");

Album album1 = new Album("Arise");

Music music1 = new Music(artist1, "Arise")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 254
};

Music music2 = new Music(artist1, "Dead Embryonic Cells")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 279
};

Music music3 = new Music(artist1, "Desperate Cry")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 254
};

Music music4 = new Music(artist1, "Murder")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 279
};

Music music5 = new Music(artist1, "Subtraction")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 254
};

Music music6 = new Music(artist1, "Altered State")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 279
};

Music music7 = new Music(artist1, "Under Siege")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 254
};

Music music8 = new Music(artist1, "Meaningless Movements")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 279
};

Music music9 = new Music(artist1, "Infected Voice")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 254
};

Music music10 = new Music(artist1, "Orgasmatron")
{
    IsSingle = true,
    ReleaseYear = 1991,
    Duration = 279
};

artist1.AddAlbum(album1);
album1.AddMusic(music1);
album1.AddMusic(music2);
album1.AddMusic(music3);
album1.AddMusic(music4);
album1.AddMusic(music5);
album1.AddMusic(music6);
album1.AddMusic(music7);
album1.AddMusic(music8);
album1.AddMusic(music9);

artist1.ShowAlbuns();
album1.DisplayAlbumInfo();


music1.DisplayMusicInfo();
music2.DisplayMusicInfo();
music10.DisplayMusicInfo();