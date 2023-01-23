namespace OOD_spotify.src.classes
{
    public class category
    {
        public category(string name, List<song> songs)
        {
            this.name = name;
            this.songs = songs;
        }

        public List<song> songs { get; set; }
        public string name { get; set; }
    }
}