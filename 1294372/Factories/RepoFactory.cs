using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Factory_Pattern.Models;
using Repository_Factory_Pattern.Repositories;

namespace Repository_Factory_Pattern.Factories
{
    public class RepoFactory : IRepoFactory
    {
        public IRepo<T> CreateRepo<T>() where T : BaseEntity
        {
            return new GenericRepo<T>();
        }
    }
}
