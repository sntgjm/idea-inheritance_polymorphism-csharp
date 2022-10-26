using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
//sntgjm
namespace inheritance_and_polymorphism_user_and_admin_github
{
    internal class user
    {
        public string user_id;
        protected string user_password;
        public int count = 0;

        public user(string id, string password)
        {
            do
            {
                Console.WriteLine("|-------------------|");
                Console.WriteLine("| OPEN YOUR ACCOUNT |");
                Console.WriteLine("|-------------------|");
                Console.Write("UserID: ");
                user_id = Console.ReadLine();
                Console.Write("Password: ");
                user_password = Console.ReadLine();

                if (user_id != "Jmthegreat" || user_password != "Jmthegreat123")
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
            }
            while ((user_id != "Jmthegreat" || user_password != "Jmthegreat123") && (count != 3));
            Console.WriteLine();
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("| WELCOME TO SECURITY AGENT |");
            Console.WriteLine("|---------------------------|");
        }

        public static bool verifyLogin(string id, string pass)
        {
            return verifyLogin(id, pass);
        }
    }
}
