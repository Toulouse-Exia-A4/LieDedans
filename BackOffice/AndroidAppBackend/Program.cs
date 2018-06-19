using AndroidAppBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost UserServiceHost = new ServiceHost(typeof(UserService));
            ServiceHost ProfilServiceHost = new ServiceHost(typeof(ProfileService));

            UserServiceHost.Open();
            Console.WriteLine("--- User Service Host - Running...");

            ProfilServiceHost.Open();
            Console.WriteLine("--- Profils Service Host - Running...");

            //---
            Console.ReadKey();
            Console.WriteLine("--- Good bye ! --- ");
            UserServiceHost.Close();
            ProfilServiceHost.Close();
        }
    }
}
