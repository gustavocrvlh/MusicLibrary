

Music music1 = new Music();

music1.Name = "Dead Embryonic Cells";
music1.Artist = "Sepultura";
music1.IsSingle = false;
music1.Album = "Arise";
music1.Year = 1991;


Music music2 = new Music();

music2.Name = "Escravo da TV";
music2.Artist = "Ratos de Porão";
music2.IsSingle = true;
music2.Year = 1989;

music1.DisplayMusicInfo();
music2.DisplayMusicInfo();
Console.WriteLine(music1.Description);
Console.WriteLine(music2.Description);

