
using static hometask_interface_task_13.Song;

namespace hometask_interface_task_13
{
    internal class Playlist
    {
        private Song[] songs = [];

        public void AddSong(Song song)
        {
            Array.Resize(ref songs, songs.Length + 1);
            songs[songs.Length - 1] = song;
        }

        public void GetAllSong()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine($"Title: {song.Title} Artist: {song.Artist} Duration: {song.Duration} Genre: {song.Genre}");
            }
        }

        public void GetAllSongsByGenre(MusicGenre musicGenre)
        {
            for (int i = 0; i < songs.Length; i++)
            {
                if (songs[i].Genre == musicGenre)
                {
                    Console.WriteLine($"{songs[i].Title} {songs[i].Artist} {songs[i].Duration} {songs[i].Genre}");
                }
            }
        }
    }
}
