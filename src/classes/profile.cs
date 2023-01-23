namespace OOD_spotify.src.classes
{
    public class Profile
    {


        public Profile(string name) 
        {
            this.Name = name;

            this.PlayedSongs = new List<Song>();
            this.SavedSongs = new List<Song>();
            this.PlayLists = new List<PlayList>();
               
        }

        public string Name { get; set; }
        public List<Song> PlayedSongs { get; set; }
        public List<Song> SavedSongs { get; set; }
        public List<PlayList> PlayLists { get; set; }
        public void EditName()
        {
            Console.WriteLine("editing ...");
        }
    }
}