using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppBackend.Repositories
{
    public class UserRepository : IRepository<Users, int>, IDisposable
    {
        public void Create(Users entity)
        {
            using (var ctx = new AppDBEntities())
            {
                ctx.Users.Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Delete(Users entity)
        {
            using (var ctx = new AppDBEntities())
            {
                var ent = ctx.Users.Find(entity.Id);
                ctx.Users.Remove(ent);
                ctx.SaveChanges();
            }
        }

        public void Dispose()
        {
            
        }

        public IEnumerable<Users> Get()
        {
            using (var ctx = new AppDBEntities())
            {
                return ctx.Users;
            }
        }

        public Users Get(int id)
        {
            using (var ctx = new AppDBEntities())
            {
                var ent = ctx.Users.Find(id);
                return ent;
            }
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
