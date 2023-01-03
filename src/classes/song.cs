namespace OOD_spotify.src.classes
{
    public class song
    {

        

        public song(double time, artist artist)
        {
            this.time = time;
            this.artist = artist;
            
            this.saved = false;
            this.playedtime = 0;

        }


        public double time { get; set; }
        public string name { get; set; }
        public artist artist {get; set;}
        public bool saved { get; set; }
        public int playedtime { get; set; }


        public bool save_unsave()
        {
            Console.WriteLine("song saved/unsaved");
            return true;
        }

        public void play()
        {
            Console.WriteLine("song playing");
        }
    }
}