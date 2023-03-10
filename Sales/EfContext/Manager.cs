using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.EfContext
{
    public class Manager
    {
        public Guid Id { get; set; }
        public String Surname { get; set; } = null!;
        public String Name { get; set; } = null!;
        public String Secname { get; set; } = null!;
        public Guid IdMainDep { get; set; }
        public Guid? IdSecDep { get; set; }
        public Guid? IdChief { get; set; }

        public Department MainDep { get; set; }
        public Department? SecDep { get; set; }

        public Manager? Chief { get; set; }
        public List<Manager> Subordinates { get; set; }

        public String ToShortString()
        {
            return $"{Surname} {Name[0]}. {Secname[0]}.";
        }
    }
}
