using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sntgjm
namespace inheritance_and_polymorphism_user_and_admin_github
{
    internal class administrator : user
    {
        private string admin_name;
        private string newPassword;
        private string updatedAdminName;

        public administrator(string id, string password, string name) : base(id, password)
        {
            this.admin_name = name;
        }

        public void displayAdmin()
        {
            Console.WriteLine("User Admin: " + this.admin_name);
            Console.WriteLine();
        }

        public administrator(string newPassword, string updatedAdminName) : base(newPassword, updatedAdminName)
        {
            this.user_password = newPassword;
            this.admin_name = updatedAdminName;
        }

        public void displayUpdateInformations()
        {
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("| CHANGE YOUR USERNAME AND PASSWORD |");
            Console.WriteLine("|-----------------------------------|");
            Console.Write("New Admin name: ");
            updatedAdminName = Console.ReadLine();
            Console.Write("New Password: ");
            newPassword = Console.ReadLine();
            string updateQuery = "UPDATE Details user_password " + newPassword + "WHERE admin_name " + updatedAdminName + " ";
            Console.WriteLine();

            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("| YOU USERNAME AND PASSWORD SUCCESSFULLY UPDATED |");
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("Admin name: " + this.updatedAdminName);
            Console.WriteLine("Password: " + this.newPassword);

        }
    }
}
