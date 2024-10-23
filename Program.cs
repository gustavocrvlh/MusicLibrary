Artist artist1 = new Artist("Sepultura");

Album album1 = new Album("Arise");

Music music1 = new Music(artist1, "Arise")
{
    IsSingle = false,
    ReleaseYear = 1991,
    Duration = 254
};

Music music2 = new Music(artist1, "Orgasmatron")
{
    IsSingle = true,
    ReleaseYear = 1991,
    Duration = 279
};

artist1.AddAlbum(album1);
album1.AddMusic(music1);
album1.AddMusic(music2);


artist1.ShowAlbuns();
album1.DisplayAlbumInfo();


music1.DisplayMusicInfo();
music2.DisplayMusicInfo();