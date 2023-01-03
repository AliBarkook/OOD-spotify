namespace OOD_spotify.src.classes
{
    public class song
    {

        

        public song(double time, bool saved, int playedtime, artist artist)
        {
            this.time = time;
            this.saved = saved;
            this.playedtime = playedtime;
            this.artist = artist;

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