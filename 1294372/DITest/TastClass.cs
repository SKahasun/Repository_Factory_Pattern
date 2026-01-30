using Repository_Factory_Pattern.Factories;
using Repository_Factory_Pattern.Models;
using Repository_Factory_Pattern.Repositories;
using Repository_Factory_Pattern.DITest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Factory_Pattern.DITest
{
    public class TastClass
    {
        IRepoFactory factory;
        public TastClass(IRepoFactory factory)
        {
            this.factory = factory;
        }
        public void Run()
        {
            //======================| Add Department |======================

            IRepo<Department> repoD = factory.CreateRepo<Department>();
            repoD.AddRange(new Department[] {
                new Department{Id = 1, name = "SQL Server"},
                new Department{Id = 2, name = "C#"},
                new Department{Id = 3, name = "Oracol"},
                new Department{Id = 4, name = "Java"},
                new Department{Id = 5, name = "UI/UX"},
                });

            Console.WriteLine("=================| Department |=================");
            Console.WriteLine("=================| Get All |=================");
            repoD.GetAll().ToList().ForEach(c => Console.WriteLine($"ID : {c.Id}, Name : {c.name}"));

            Console.WriteLine();

            Console.WriteLine("=================| Get |=================");
            var d = repoD.Get(3);
            Console.WriteLine($"ID : {d.Id}, Name : {d.name}");

            Console.WriteLine();

            Console.WriteLine("=================| Update |=================");
            d.name = "Python";
            repoD.Update(d);
            repoD.GetAll().OrderBy(x => x.Id).ToList().ForEach(c => Console.WriteLine($"ID : {c.Id}, Name : {c.name}"));

            Console.WriteLine();
            Console.WriteLine("=================| Delete |=================");
            repoD.Delete(3);
            repoD.GetAll().OrderBy(x => x.Id).ToList().ForEach(c => Console.WriteLine($"ID : {c.Id}, Name : {c.name}"));


            //======================| Add Student |======================
            IRepo<Student> repoS = factory.CreateRepo<Student>();
            repoS.AddRange(new Student[]
            {
                new Student{ Id = 1, name = "Sheikh Ahasunul Islam", batch = 30, fees = 10000, departmentId = 5 },
                new Student{ Id = 2, name = "Sheikh Rakibul Islam", batch = 20, fees = 15000, departmentId = 4 },
                new Student{ Id = 3, name = "Abdullah Al Mamun", batch = 30, fees = 12000, departmentId = 1 },
                new Student{ Id = 4, name = "Fatima Zohra", batch = 25, fees = 11000, departmentId = 2 },
                new Student{ Id = 5, name = "Sajid Ahmed", batch = 30, fees = 10500, departmentId = 3 },
                new Student{ Id = 6, name = "Nusrat Jahan", batch = 22, fees = 14000, departmentId = 1 },
                new Student{ Id = 7, name = "Tanvir Hossain", batch = 30, fees = 10000, departmentId = 5 },
                new Student{ Id = 8, name = "Kamrul Hasan", batch = 28, fees = 12500, departmentId = 4 },
                new Student{ Id = 9, name = "Mehedi Hasan", batch = 30, fees = 13000, departmentId = 2 },
                new Student{ Id = 10, name = "Ayesha Siddiqua", batch = 21, fees = 15000, departmentId = 3 },
                new Student{ Id = 11, name = "Ariful Islam", batch = 30, fees = 11500, departmentId = 1 },
                new Student{ Id = 12, name = "Sabina Yasmin", batch = 24, fees = 10000, departmentId = 5 },
                new Student{ Id = 13, name = "Rashedul Islam", batch = 30, fees = 14500, departmentId = 4 },
                new Student{ Id = 14, name = "Jannatul Ferdous", batch = 27, fees = 11000, departmentId = 2 },
                new Student{ Id = 15, name = "Mahmudur Rahman", batch = 30, fees = 12000, departmentId = 3 },
                new Student{ Id = 16, name = "Sumaiya Akter", batch = 23, fees = 13500, departmentId = 1 },
                new Student{ Id = 17, name = "Imtiaz Ahmed", batch = 30, fees = 10500, departmentId = 5 },
                new Student{ Id = 18, name = "Farhana Islam", batch = 26, fees = 15000, departmentId = 4 },
                new Student{ Id = 19, name = "Hasan Ali", batch = 30, fees = 12500, departmentId = 2 },
                new Student{ Id = 20, name = "Rokeya Begum", batch = 29, fees = 11000, departmentId = 3 },
                new Student{ Id = 21, name = "Sabbir Hossain", batch = 30, fees = 14000, departmentId = 1 },
                new Student{ Id = 22, name = "Mst. Khadiza", batch = 20, fees = 10000, departmentId = 5 },
                new Student{ Id = 23, name = "Emon Ahmed", batch = 30, fees = 13000, departmentId = 4 },
                new Student{ Id = 24, name = "Lutfur Rahman", batch = 25, fees = 12000, departmentId = 2 },
                new Student{ Id = 25, name = "Sonia Akter", batch = 30, fees = 11500, departmentId = 3 },
                new Student{ Id = 26, name = "Habibur Rahman", batch = 22, fees = 14500, departmentId = 1 },
                new Student{ Id = 27, name = "Tahmina Chowdhury", batch = 30, fees = 10500, departmentId = 5 },
                new Student{ Id = 28, name = "Zubayer Hossain", batch = 28, fees = 13500, departmentId = 4 },
                new Student{ Id = 29, name = "Nasrin Akter", batch = 30, fees = 12000, departmentId = 2 },
                new Student{ Id = 30, name = "Mizanur Rahman", batch = 21, fees = 11000, departmentId = 3 }
            });
            Console.WriteLine();
            Console.WriteLine("\n=================| Student |=================");
            Console.WriteLine("=================| Get All |=================\n");
            repoS.GetAll().ToList().ForEach(x => Console.WriteLine($"Student Id : {x.Id}, Name : {x.name}, Fees : {x.fees}, Batch Id : {x.batch}, Department Id : {x.departmentId}"));

            Console.WriteLine("\n=================| Get |=================\n");
            var s = repoS.Get(1);
            Console.WriteLine($"Student Id : {s.Id}, Name : {s.name}, Fees : {s.fees}, Batch Id : {s.batch}, Department Id : {s.departmentId}");

            Console.WriteLine("\n=================| Update |=================\n");
            s.name = "Sheikh Abir Islam";
            repoS.Update(s);
            repoS.GetAll().ToList().ForEach(x => Console.WriteLine($"Student Id : {x.Id}, Name : {x.name}, Fees : {x.fees}, Batch Id : {x.batch}, Department Id : {x.departmentId}"));

            Console.WriteLine();
            Console.WriteLine("\n=================| Delete |=================\n");
            repoS.Delete(2);
            repoS.GetAll().ToList().ForEach(x => Console.WriteLine($"Student Id : {x.Id}, Name : {x.name}, Fees : {x.fees}, Batch Id : {x.batch}, Department Id : {x.departmentId}"));
        }
    }
}
