namespace OOD_spotify.src.classes
{
    public class playList
    {


        public playList(string name, List<song> songs)
        {
            this.name = name;

            this.songs = songs;

        }
        public string name { get; set; }

        public List<song> songs { get; set; }

        public string editName()
        {
            return "new name";
        }
        public void editSongs()
        {

        }
    }
}