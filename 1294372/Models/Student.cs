using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Factory_Pattern.Models
{
    public class Student:BaseEntity
    {
        public string name { get; set; }
        public decimal fees { get; set; }
        public int batch { get; set; }
        public int departmentId { get; set; }
    }
}
