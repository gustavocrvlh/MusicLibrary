Artist artist1 = new Artist("Sepultura");

Album album1 = new Album("Arise");

Music music1 = new Music(artist1, "Dead Embryonic Cells")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 254
};

Music music2 = new Music(artist1, "Altered State")
{
    IsSingle = true,
    ReleaseYear = 1991,
    Duration = 279
};


album1.AddMusic(music1);
album1.AddMusic(music2);


artist1.AddAlbum(album1);
artist1.ShowAlbuns();