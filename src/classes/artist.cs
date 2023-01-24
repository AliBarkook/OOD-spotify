
using OOD_spotify.src.Interfaces;

namespace OOD_spotify.src.classes
{
    public class artist : ISearchable
    {

        public artist(string name)
        {
            this.songs = new List<song>();
            this.name = name;
        }

        private List<song> songs { get; set; }
        public string name { get ; set; }

        public void share()
        {
            
        }

        public void AddSong(string name, category category)
        {
            var song = new song(10, name, this, category);
            this.songs.Add(song);
        }

        public void RemoveSong(string name) { 
            var song = this.songs.FirstOrDefault(song => song.name== name);
            if(song != null)
            {
                this.songs.Remove(song);
            }
        }

        public Boolean Equal(ISearchable artist)
        {
            if (this.name.Contains(artist.name))
            {
                return true;
            }
            return false;
        }
    }
}