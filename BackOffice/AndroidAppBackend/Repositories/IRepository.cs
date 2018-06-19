using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppBackend.Repositories
{
    public interface IRepository<TEnt, in TPk> where TEnt : class
    {
        IEnumerable<TEnt> Get();
        TEnt Get(TPk id);
        void Create(TEnt entity);
        void Update(TEnt entity);
        void Delete(TEnt entity);
    }
}
