
namespace hometask_interface_task_13
{
    internal class Song
    {
        public enum MusicGenre
        {
            Pop,
            Rock,
            Jazz,
            Classical
        }

        private string title;
        private string artist;
        private TimeSpan duration;
        private MusicGenre genre;

        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public MusicGenre Genre { get; set; }

        public Song(string title, string artist, TimeSpan duration, MusicGenre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }
    }
}
