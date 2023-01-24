using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_spotify.src.classes
{
    internal class Main
    {
        public List<user> users{ get; set; }
        Main() {
            users = new List<user>();
        }
        public void BeforeLogin()
        {
            bool isSignedIn = false;
            while (isSignedIn)
            {
                Console.WriteLine("Enter username:\n");
                string user = Console.ReadLine();
                if (user == null) { continue; }
                Console.WriteLine("Enter password:\n");
                string password = Console.ReadLine();
                if (password == null) { continue; }
                //this.addUser(new user());
            }
        }
        private void addUser()
        {

        }
    }
}
