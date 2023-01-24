namespace OOD_spotify.src.classes
{
    public class profile
    {


        public profile(string name) 
        {
            this.name = name;

            this.playedsongs = new List<song>();
            this.playLists = new List<playList>();
            this.SavedSongs = new SavedSongs();
            
        }

        public string name { get; set; }
        public List<song> playedsongs { get; set; }
        public List<playList> playLists { get; set; }
        public SavedSongs SavedSongs { get; set; }
        public void editName()
        {
            Console.WriteLine("enter new name for profile:");

            var new_name = Console.ReadLine();

            if (new_name != null)
            {
                this.name = new_name;
                Console.WriteLine("profile name changed successfuly!");
            }
        }
        public void AddPlayList(playList playList)
        {
            this.playLists.Add(playList);
        }

        public void SaveSong(song song)
        {
            this.SavedSongs.AddSong(song);
        }

        public void UnSaveSong(song song)
        {
            this.SavedSongs.RemoveSong(song);
        }
    }
}