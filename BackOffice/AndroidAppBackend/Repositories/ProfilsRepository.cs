using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppBackend.Repositories
{
    public class ProfilsRepository : IRepository<Profils, int>, IDisposable
    {
        public void Create(Profils entity)
        {
            using (var ctx = new AppDBEntities())
            {
                ctx.Profils.Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Delete(Profils entity)
        {
            using (var ctx = new AppDBEntities())
            {
                var profil = ctx.Profils.Find(entity.Id);
                ctx.Profils.Remove(profil);
                ctx.SaveChanges();
            }
        }

        public void Dispose()
        {
            
        }

        public IEnumerable<Profils> Get()
        {
            using (var ctx = new AppDBEntities())
            {
                return ctx.Profils.ToList();
            }
        }

        public Profils Get(int id)
        {
            using (var ctx = new AppDBEntities())
            {
                return ctx.Profils.Find(id);
            }
        }

        public void Update(Profils entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Projects> GetAcceptedProjects(int id)
        {
            return null;
        }

        public ICollection<Projects> GetProposedProjects(int id)
        {
            return null;
        }
    }
}
