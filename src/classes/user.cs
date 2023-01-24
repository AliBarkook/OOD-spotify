namespace OOD_spotify.src.classes
{
    public class user
    {


        public user()
        {




            // ? initialaizing data

            this.artistList = new List<artist>();

            this.artistList.Add(new artist("shajarian"));
            this.artistList.Add(new artist("mehrad hidden"));
            this.artistList.Add(new artist("ebi"));
            this.artistList.Add(new artist("yas"));
            this.artistList.Add(new artist("sognad"));
            this.artistList.Add(new artist("hichkas"));

            Console.WriteLine(this.artistList);


            this.songList = new List<song>();

            this.songList.Add(new song(125, "rabbana", this.artistList[0]));
            this.songList.Add(new song(98, "seyl", this.artistList[1]));
            this.songList.Add(new song(450, "man mijangam", this.artistList[3]));
            this.songList.Add(new song(230, "baroon", this.artistList[4]));
            this.songList.Add(new song(130, "mara beboos", this.artistList[4]));
            this.songList.Add(new song(90, "tehran", this.artistList[5]));


            string username = this.login();
            this.Profile = new profile(username);

            this.searchConsole = new Search(this.songList, this.artistList);

        }


        public Search searchConsole { get; set; }
        public profile Profile { get; set; }





        public List<artist> artistList { get; set; }

        public List<song> songList { get; set; }



        public void selectAction()
        {
            int action = -1;
            while (action != 0)
            {
                Console.WriteLine("select action number from menu:\n");

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
            this.Profile.editName();
        }




        private void CreatePlayList()
        {

            Console.WriteLine("creating plaulist ...");
            string playListName = "playlist 1";

            List<song> songs = new List<song>();

            // songs.Add(this.smapleSong1);
            // songs.Add(this.smapleSong2);

            var newPlayList = new playList(playListName, songs);
            this.Profile.playLists.Add(newPlayList);
        }

        private void search()
        {

            Console.WriteLine("enter song or artist name:");
            var searchTerm = Console.ReadLine();

            if (searchTerm != null)
            {
                this.searchConsole.GeneralSearch(searchTerm);
            }
        }


        private string login()
        {
            Console.WriteLine("enter your username:");
            var username = Console.ReadLine();


            if (username == null || username == "")
                username = "guest user";

            Console.WriteLine("wellcome " + username);

            return username;
        }
    }
}