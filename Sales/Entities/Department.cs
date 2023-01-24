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
        public Guid Id { get; set; }                 // Набор свойств сущности в точности
        public String Name { get; set; } = null!;    // повторяет структуру таблицы

        public String ToShortString()
        {
            return Id.ToString()[..4] + "... " + Name;
        }
    }
}
