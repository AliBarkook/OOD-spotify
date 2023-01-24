using OOD_spotify.src.Interfaces;

namespace OOD_spotify.src.classes
{
    public class song : ISearchable
    {

        public song(double duration, string name, artist artist, category category)
        {
            this.name= name;
            this.Duration = duration;
            this.artist = artist;
            this.category = category;

        }

        public double Duration { get; set; }
        public string name { get; set; }
        public artist artist { get; set; }
        public int PlayedCount { get; set; }

        public category category { get; set; }



        public void play()
        {
            this.PlayedCount++;
            Console.WriteLine("song playing");
        }


        public Boolean Equal(ISearchable song)
        {
            if(this.name.Contains(song.name)) return true;
            return false;
        }

        public void share()
        {
            Console.WriteLine("");
        }
    }
}