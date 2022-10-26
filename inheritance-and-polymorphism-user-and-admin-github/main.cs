using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sntgjm
namespace inheritance_and_polymorphism_user_and_admin_github
{
    internal class main
    {
        static void Main(string[] args) {
            administrator admin = new administrator
                                      ("agencySntgjm1",
                                       "agencySntgjm2",
                                       "agencySntgjm3");
            admin.displayAdmin();
            admin.displayUpdateInformations();
            Console.WriteLine();
            Console.WriteLine("Press any numbers or letters to exit this program");
            Console.ReadLine();
        
        }
    }
}
