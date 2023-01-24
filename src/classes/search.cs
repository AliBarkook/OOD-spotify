using OOD_spotify.src.Interfaces;

namespace OOD_spotify.src.classes
{
    public class Search
    {


        public Search()
        {
            this.SongResult = new List<song>();
            this.ArtistResult = new List<artist>();
        }

        
        public List<song> SongResult { get; set; }
        public List<artist> ArtistResult { get; set; }


        public IEnumerable<ISearchable> GeneralSearch(string query)
        {
            IEnumerable<ISearchable> SongResult = this.SearchSong(query);
            IEnumerable<ISearchable> ArtistResult = this.SearchArtist(query);
            return SongResult.Concat(ArtistResult);
        }

        private IEnumerable<ISearchable> SearchSong(string n)
        {
            return new List<song>();
        }

        private IEnumerable<ISearchable> SearchArtist(string n)
        {
            return new List<artist>();
        }
    }
}