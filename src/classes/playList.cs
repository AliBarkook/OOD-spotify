namespace OOD_spotify.src.classes
{
    public class PlayList
    {


        public PlayList(string name, List<Song> songs)
        {
            this.Name = name;

            this.Songs = songs;

        }
        public string Name { get; set; }

        public List<Song> Songs { get; set; }

        public string EditName()
        {
            return "new name";
        }
        public void EditSong()
        {

        }
    }
}