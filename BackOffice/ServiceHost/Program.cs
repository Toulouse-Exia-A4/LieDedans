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
            //using (var db = new LnkdDataModel())
            //{
            //    Console.WriteLine("--- Creating a new User ---");

            //    Console.Write("- Username : ");
            //    string username = Console.ReadLine();

            //    Console.Write("- Password : ");
            //    string password = Console.ReadLine();

            //    var newUser = new User()
            //    {
            //        Username = username,
            //        Password = password
            //    };

            //    db.Users.Add(newUser);
            //    db.SaveChanges();
            //    Console.WriteLine("DB Saved successfully !");
            //}

            //Console.WriteLine("Press any key to exit ...");
            //Console.ReadKey();
            using (var ctx = new LnkdDataModel())
            {
                DevelopperProfile pr = new DevelopperProfile()
                {
                    FirstName = "DevProfil",
                    LastName = "DevProfil",
                };

                ctx.DevelopperProfiles.Add(pr);

                ProjectChiefProfile pc = new ProjectChiefProfile()
                {
                    FirstName = "ProjectChiefProfil",
                    LastName = "ProjectChiefProfil",
                };

                ctx.ProjectChiefProfiles.Add(pc);

                Project p = new Project()
                {
                    Name = "Projet A",
                    ProjectChief = pc
                };

                p.ProposedProfiles.Add(pr);
                p.ProposedProfiles.Add(pc);

                ctx.Projects.Add(p);

                ctx.SaveChanges();
            }

            System.ServiceModel.ServiceHost loginServiceHost = new System.ServiceModel.ServiceHost(typeof(LoginService));
            loginServiceHost.Open();
            Console.WriteLine("Login Service Started...");

            System.ServiceModel.ServiceHost profileServiceHost = new System.ServiceModel.ServiceHost(typeof(ProfilService));
            profileServiceHost.Open();
            Console.WriteLine("Profile Service Started...");


            Console.ReadKey();
            loginServiceHost.Close();
            profileServiceHost.Close();
            Console.WriteLine("Service(s) closed.");
        }
    }
}
