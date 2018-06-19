using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceHost
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "LoginService" à la fois dans le code et le fichier de configuration.
    public class LoginService : ILoginService
    {
        public User Login(User user)
        {
            try
            {
                using (var ctx = new LnkdDataModel())
                {
                    User usr = ctx.Users.FirstOrDefault(x => x.Username == user.Username);

                    if (usr == null)
                    {
                        throw new WebFaultException<string>("Utilisateur introuvable.", System.Net.HttpStatusCode.BadRequest);
                    }
                    else
                    {
                        if (usr.Password != user.Password)
                        {
                            throw new WebFaultException<string>("Wrong Password.", System.Net.HttpStatusCode.BadRequest);
                        }
                    }

                    return usr;
                }

            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>("Server Error : Cannot access database.\n" + ex.Message, System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
