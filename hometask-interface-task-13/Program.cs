using hometask_interface_task_13;

public static class Program
{
    public static void Main(string[] args)
    {
        Playlist playlist = new Playlist();

        playlist.AddSong(new Song("Musictitle1", "Music Artist1", new TimeSpan(0, 3, 0), Song.MusicGenre.Jazz));
        playlist.AddSong(new Song("Musictitle2", "Music Artist2", new TimeSpan(0, 4, 0), Song.MusicGenre.Pop));
        playlist.AddSong(new Song("Musictitle3", "Music Artist3", new TimeSpan(0, 2, 0), Song.MusicGenre.Rock));
        playlist.AddSong(new Song("Musictitle4", "Music Artist4", new TimeSpan(0, 5, 0), Song.MusicGenre.Classical));

        playlist.GetAllSong();
        Console.WriteLine();
        playlist.GetAllSongsByGenre(Song.MusicGenre.Rock);
    }
}