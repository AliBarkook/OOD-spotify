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


        public List<ISearchable> GeneralSearch(string query)
        {
            var songs = this.SearchSong(query);
            var artists = this.SearchArtist(query);

            var songsIter = songs.GetEnumerator();
            var artistsIter = artists.GetEnumerator();

            while (songsIter.MoveNext())
            {
                Console.WriteLine("song result: \n");
                Console.WriteLine(songsIter.Current.name);
            }
            while (artistsIter.MoveNext())
            {
                Console.WriteLine("song result: \n");
                Console.WriteLine(artistsIter.Current.name);
            }

            return songs.Concat(artists).ToList();

        }

        private IEnumerable<ISearchable> SearchSong(string n)
        {
            //var result = this.Song.Find(song => song.name == n);
            //if (result == null)
            //    return "not found";
            //else
            //    return result.name + " from " + result.artist.name + " , time: " + result.Duration + "s";
            var song = new song(0, n, null, null);
            var result = new List<ISearchable>();
            for (int i = 0; i < Song.Count; i++)
            {
                if (Song[i].Equal(song))
                {
                    result.Add(Song[i]);
                }
            }
            return result;
        }

        private IEnumerable<ISearchable> SearchArtist(string n)
        {
            //var result = this.Artist.Find(artist => artist.name == n);
            //if (result == null)
            //    return "not found";
            //else
            //    return result.name;

            var artist = new artist(n);
            var result = new List<ISearchable>();
            for (int i = 0; i < Artist.Count; i++)
            {
                if (Artist[i].Equal(artist))
                {
                    result.Add(Artist[i]);
                }
            }
            return result;
        }
    }
}