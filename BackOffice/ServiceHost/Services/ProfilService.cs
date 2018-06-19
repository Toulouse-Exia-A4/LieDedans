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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ProfilService" à la fois dans le code et le fichier de configuration.
    public class ProfilService : IProfilService
    {
        public Profile AssociateTechnologies(string id, Technology[] technologies)
        {
            throw new NotImplementedException();
        }

        public string Get(string id)
        {
            using (var ctx = new LnkdDataModel())
            {
                int pId = int.Parse(id);
                Profile profil = ctx.Profiles.Where(x => x.Id == pId).FirstOrDefault();

                if(profil == null)
                {
                    throw new WebFaultException<string>("Profil not found.", System.Net.HttpStatusCode.BadRequest);
                }

                return JsonConvert.SerializeObject(profil);
            }
        }

        public Project[] GetAcceptedProjects(string id)
        {
            throw new NotImplementedException();
        }

        public Project[] GetProposedProjects(string id)
        {
            throw new NotImplementedException();
        }
    }
}
