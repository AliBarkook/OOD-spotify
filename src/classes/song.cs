using OOD_spotify.src.Interfaces;

namespace OOD_spotify.src.classes
{
    public class song : ISearchable
    {

        

        public song(double duration, string name, artist artist)
        {
            this.name= name;
            this.Duration = duration;
            this.artist = artist;

        }


        public double Duration { get; set; }
        public string name { get; set; }
        public artist artist { get; set; }
        public int PlayedCount { get; set; }



        public void play()
        {
            this.PlayedCount++;
            Console.WriteLine("song playing");
        }

        public void share()
        {
            Console.WriteLine("");
        }
    }
}