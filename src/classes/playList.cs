namespace OOD_spotify.src.classes
{
    public class playList
    {


        public playList(string name, List<song> songs)
        {
            this.Name = name;

            this.Songs = songs;

        }
        public string Name { get; set; }

        public List<song> Songs { get; set; }

        public void EditName(string name)
        {
            Name = name;
        }
        public void EditSongs(song song)
        {
            this.Songs.Remove(song);
        }
    }
}