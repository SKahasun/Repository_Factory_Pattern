using Repository_Factory_Pattern.Models;
using Repository_Factory_Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Factory_Pattern.Factories
{
    public interface IRepoFactory
    {
        IRepo<T> CreateRepo<T>() where T : BaseEntity;
    }
}
