namespace OOD_spotify.src.classes
{
    public class User
    {


        public User()
        {
            // ? initial data:
            this.smapleArtist1 = new Artist("mehrad hidden");
            this.smapleArtist2 = new Artist("shajarian");

            //this.smapleSong1 = new Song(125, smapleArtist1, "test");
            //this.smapleSong2 = new Song(98, smapleArtist1, "test");
            //this.smapleSong3 = new Song(450, smapleArtist2, "test");

            string username = this.login();
            this.Profile = new Profile(username);

            //this.searchConsole = new search();

        }


        public Search searchConsole { get; set; }
        public Profile Profile { get; set; }





        // ? sample data
        public Artist smapleArtist1 { get; set; }
        public Artist smapleArtist2 { get; set; }


        public Song smapleSong1 { get; set; }
        public Song smapleSong2 { get; set; }
        public Song smapleSong3 { get; set; }



        public void SelectAction()
        {
            int action = -1;
            while (action != 0)
            {
                Console.WriteLine("select action number from menu:");

                Console.WriteLine("1- create new play list");
                Console.WriteLine("2- search");
                Console.WriteLine("3- edit user name");
                Console.WriteLine("...");
                Console.WriteLine("0- exit application");

                action = Int32.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        this.CreatePlayList();
                        break;

                    case 2:
                        this.search();
                        break;

                    case 3:
                        this.EditUsername();
                        break;

                    case 0:
                        break;
                    
                    default:
                        break;
                }
            }

        }




        private void EditUsername()
        {
            this.Profile.EditName();
        }




        private void CreatePlayList()
        {

            Console.WriteLine("creating plaulist ...");
            string playListName = "playlist 1";

            List<Song> songs = new List<Song>();

            songs.Add(this.smapleSong1);
            songs.Add(this.smapleSong2);

            var newPlayList = new PlayList(playListName, songs);
            this.Profile.PlayLists.Add(newPlayList);
        }

        private void search()
        {
            string searchTerm = "song or artist name";
            this.searchConsole.GeneralSearch(searchTerm);
        }


        private string login()
        {
            Console.WriteLine("welcome to spotify app!");
            Console.WriteLine("enter your username:");

            Console.WriteLine("loged in ...");
            return "Ali Barkook";
        }
    }
}