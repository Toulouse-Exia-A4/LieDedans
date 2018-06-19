using AndroidAppBackend.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AndroidAppBackend.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ProfileService" à la fois dans le code et le fichier de configuration.
    public class ProfileService : IProfileService
    {
        public string Get(string id)
        {
            using (var repo = new ProfilsRepository())
            {
                return JsonConvert.SerializeObject(repo.Get((int.Parse(id))));
            }
        }

        public ICollection<Projects> GetAcceptedProjects(string id)
        {
            using (var repo = new ProfilsRepository())
            {
                return repo.GetAcceptedProjects(int.Parse(id));
            }
        }

        public ICollection<Projects> GetProposedProjects(string id)
        {
            using (var repo = new ProfilsRepository())
            {
                return repo.GetProposedProjects(int.Parse(id));
            }
        }
    }
}
