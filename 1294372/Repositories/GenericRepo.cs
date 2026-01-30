using Repository_Factory_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Factory_Pattern.Repositories
{
    public class GenericRepo<T> : IRepo<T> where T : BaseEntity
    {
        private readonly IList<T> Data;
        public GenericRepo()
        {
            Data = new List<T>();
        }
        public void Add(T entity)
        {
            Data.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var item in entities)
            {
                Data.Add(item);
            }
        }

        public void Delete(int id)
        {
            var entity = Data.FirstOrDefault(x => x.Id == id);
            if(entity != null)
            {
                Data.Remove(entity);
            }
        }

        public T Get(int id)
        {
            return Data.FirstOrDefault(x=>x.Id== id);
        }

        public List<T> GetAll()
        {
            return Data.ToList();
        }

        public void Update(T entity)
        {
            int i = Data.IndexOf(entity);
            Data.RemoveAt(i);
            Data.Add(entity);
        }
    }
}
