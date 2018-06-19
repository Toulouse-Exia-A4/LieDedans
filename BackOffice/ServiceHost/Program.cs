using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LnkdDataModel())
            {
                Console.WriteLine("--- Creating a new User ---");

                Console.Write("- Username : ");
                string username = Console.ReadLine();

                Console.Write("- Password : ");
                string password = Console.ReadLine();

                var newUser = new User()
                {
                    Username = username,
                    Password = password
                };

                db.Users.Add(newUser);
                db.SaveChanges();
                Console.WriteLine("DB Saved successfully !");
            }

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
