namespace OOD_spotify.src.classes
{
    public class user
    {


        public user()
        {
            // ? initial data:
            this.smapleArtist1 = new artist("mehrad hidden");
            this.smapleArtist2 = new artist("shajarian");

            this.smapleSong1 = new song(125, smapleArtist1);
            this.smapleSong2 = new song(98, smapleArtist1);
            this.smapleSong3 = new song(450, smapleArtist2);

            string username = this.login();
            this.profile = new profile(username);

            this.searchConsole = new search();

        }


        public search searchConsole { get; set; }
        public profile profile { get; set; }





        // ? sample data
        public artist smapleArtist1 { get; set; }
        public artist smapleArtist2 { get; set; }


        public song smapleSong1 { get; set; }
        public song smapleSong2 { get; set; }
        public song smapleSong3 { get; set; }



        public void selectAction()
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
                        this.createPlayList();
                        break;

                    case 2:
                        this.search();
                        break;

                    case 3:
                        this.editUsername();
                        break;

                    case 0:
                        break;
                    
                    default:
                        break;
                }
            }

        }




        private void editUsername()
        {
            this.profile.editName();
        }




        private void createPlayList()
        {

            Console.WriteLine("creating plaulist ...");
            string playListName = "playlist 1";

            List<song> songs = new List<song>();

            songs.Add(this.smapleSong1);
            songs.Add(this.smapleSong2);

            var newPlayList = new playList(playListName, songs);
            this.profile.playLists.Add(newPlayList);
        }

        private void search()
        {
            string searchTerm = "song or artist name";
            this.searchConsole.generalSearch(searchTerm);
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