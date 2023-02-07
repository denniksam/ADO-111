using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Entities
{
    public class Manager
    {
        public Guid   Id        { get; set; }
        public String Surname   { get; set; } = null!;
        public String Name      { get; set; } = null!;
        public String Secname   { get; set; } = null!;
        public Guid   IdMainDep { get; set; }
        public Guid?  IdSecDep  { get; set; }
        public Guid?  IdChief   { get; set; }

        public String ToShortString()
        {
            return $"{Id.ToString()[..4]}...  {Surname} {Name[0]}. {Secname[0]}.";
        }
    }
}
