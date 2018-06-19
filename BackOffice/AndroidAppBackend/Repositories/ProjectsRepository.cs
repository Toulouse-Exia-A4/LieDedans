using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppBackend.Repositories
{
    public class ProjectsRepository : IRepository<Projects, int>, IDisposable
    {
        public void Create(Projects entity)
        {
            using (var ctx = new AppDBEntities())
            {
                ctx.Projects.Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Delete(Projects entity)
        {
            using (var ctx = new AppDBEntities())
            {
                var project = ctx.Projects.Find(entity.Id);
                ctx.Projects.Remove(project);
                ctx.SaveChanges();
            }
        }

        public void Dispose()
        {
            
        }

        public IEnumerable<Projects> Get()
        {
            using (var ctx = new AppDBEntities())
            {
                return ctx.Projects.ToList();
            }
        }

        public Projects Get(int id)
        {
            using (var ctx = new AppDBEntities())
            {
                return ctx.Projects.Find(id);
            }
        }

        public void Update(Projects entity)
        {
            throw new NotImplementedException();
        }
    }
}
