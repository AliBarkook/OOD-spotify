using OOD_spotify.src.Interfaces;

namespace OOD_spotify.src.classes
{
    public class Song : ISearchable
    {

        

        public Song(double duration, string name)
        {
            this.Name= name;
            this.Duration = duration;

        }


        public double Duration { get; set; }
        public string Name { get; set; }
        public int PlayedCount { get; set; }



        public void Play()
        {
            this.PlayedCount++;
            Console.WriteLine("song playing");
        }

        public void Share()
        {
            Console.WriteLine("");
        }
    }
}