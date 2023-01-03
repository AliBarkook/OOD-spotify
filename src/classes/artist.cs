
namespace OOD_spotify.src.classes
{
    public class artist
    {

        public artist(string name)
        {
            this.songs = new List<song>();
            this.name = name;
        }

        public string name { get; set; }
        public List<song> songs { get; set; }



        public void share()
        {
            Console.WriteLine("artist shared");
        }
    }
}