using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Entities
{
    // Класс-сущность, отображающая таблицу Departments
    public class Department
    {
        public Guid Id { get; set; }
        public String Name { get; set; } = null!;
    }
}
