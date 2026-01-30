using Repository_Factory_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Factory_Pattern.Repositories
{
    public interface IRepo<T> where T : BaseEntity
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int id);
    }
}
