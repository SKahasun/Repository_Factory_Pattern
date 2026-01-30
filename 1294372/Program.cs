using Repository_Factory_Pattern.DITest;
using Repository_Factory_Pattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepoFactory repo = new RepoFactory();
            TastClass tc = new TastClass(repo);
            tc.Run();
            Console.ReadKey();
        }
    }
}
