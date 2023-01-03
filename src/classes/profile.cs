namespace OOD_spotify.src.classes
{
    public class profile
    {


        public profile(string name) 
        {
            this.name = name;

            this.playedsongs = new List<song>();
            this.savedsongs = new List<song>();
            this.playLists = new List<playList>();
               
        }
        
        public string name { get; set; }
        public List<song> playedsongs { get; set; }
        public List<song> savedsongs { get; set; }
        public List<playList> playLists { get; set; }
        public void editName()
        {

        }
    }
}