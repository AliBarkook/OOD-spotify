
using OOD_spotify.src.Interfaces;

namespace OOD_spotify.src.classes
{
    public class Artist : ISearchable
    {

        public Artist(string Name)
        {
            this.Songs = new List<Song>();
            this.Name = Name;
        }

        private List<Song> Songs { get; set; }
        public string Name { get ; set; }

        public void Share()
        {
            
        }

        public void AddSong(string name)
        {
            var song = new Song(10,name);
            this.Songs.Add(song);
        }

        public void RemoveSong(string name) { 
            var song = this.Songs.FirstOrDefault(song => song.Name== name);
            if(song != null)
            {
                this.Songs.Remove(song);
            }
        }

        public Boolean Equal(Artist artist)
        {
            if (this.Name.Contains(artist.Name))
            {
                return true;
            }
            return false;
        }
    }
}