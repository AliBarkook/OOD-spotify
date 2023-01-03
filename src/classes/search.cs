namespace OOD_spotify.src.classes
{
    public class search
    {


        public search()
        {
            this.songResult = new List<song>();
            this.artistResult = new List<artist>();
        }

        
        public List<song> songResult { get; set; }
        public List<artist> artistResult { get; set; }


        public void generalSearch(string n)
        {
            Console.WriteLine("searching ...");
            this.searchSong(n);
            this.searchArtist(n);

        }

        private List<song> searchSong(string n)
        {
            return new List<song>();
        }

        private List<artist> searchArtist(string n)
        {
            return new List<artist>();
        }
    }
}