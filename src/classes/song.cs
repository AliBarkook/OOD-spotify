using OOD_spotify.src.Interfaces;

namespace OOD_spotify.src.classes
{
    public class song : ISearchable
    {

        

        public song(double duration, string name)
        {
            this.name= name;
            this.Duration = duration;

        }


        public double Duration { get; set; }
        public string name { get; set; }
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