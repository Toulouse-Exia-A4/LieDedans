using AndroidAppBackend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AndroidAppBackend.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "UserService" à la fois dans le code et le fichier de configuration.
    public class UserService : IUserService
    {
        public string Login(string username, string password)
        {
            try
            {
                using (var repo = new UserRepository())
                {
                    var usr = repo.Get().FirstOrDefault(x => x.Username == username);

                    if (usr != null)
                    {
                        if(usr.Password == password)
                            return "OK";
                        else
                            throw new WebFaultException<string>("Wrong password !", System.Net.HttpStatusCode.BadRequest);
                    }
                    throw new WebFaultException<string>("Username doesn't exists.", System.Net.HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>("UserService.Register : Error ! \n" + ex.Message, System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public void Register(string username, string password)
        {
            try
            {
                Users newUser = new Users()
                {
                    Username = username,
                    Password = password
                };

                using (var repo = new UserRepository())
                {
                    repo.Create(newUser);
                }

                Console.WriteLine("New User Created ! " + newUser.Username + " - " + newUser.Password);
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>("UserService.Register : Error ! \n" + ex.Message, System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
