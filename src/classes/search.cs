using OOD_spotify.src.Interfaces;

namespace OOD_spotify.src.classes
{
    public class Search
    {


        public Search(List<song> songs, List<artist> artists)
        {
            this.Song = songs;
            this.Artist = artists;
        }

        
        public List<song> Song { get; set; }
        public List<artist> Artist { get; set; }


        public void GeneralSearch(string query)
        {
            var songName = this.SearchSong(query);
            var artistName = this.SearchArtist(query);


            Console.WriteLine("\nsong result:");
            Console.WriteLine(songName + "\n");
            Console.WriteLine("artist result:");
            Console.WriteLine(artistName);

        }

        private string SearchSong(string n)
        {
            var result = this.Song.Find(song => song.name == n);
            if (result == null)
                return "not found";
            else
                return result.name + " from " + result.artist.name + " , time: " + result.Duration + "s";
        }

        private string SearchArtist(string n)
        {
            var result = this.Artist.Find(artist => artist.name == n);
            if (result == null)
                return "not found";
            else
                return result.name;
        }
    }
}