using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_spotify.src.classes
{
    public class SavedSongs
    {
        public List<song> Songs{ get; set; }
        bool LocalDownloaded { get; set; }

        public SavedSongs() { 
            this.Songs = new List<song>();
        }

        public void DownloadAll()
        {
            this.LocalDownloaded = true;
        }

        public void AddSong(song song)
        {
            this.Songs.Add(song);
        }

        public void RemoveSong(song song) 
        { 
            this.Songs.Remove(song);
        }


    }
}
