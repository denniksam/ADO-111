using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.EfContext
{
    public class DataContext : DbContext
    {
        // ORM коллекции с данными
        public DbSet<Department> Departments { get; set; }

        // Управление созданием, развертыванием БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // конфигурирование - установление связи с БД
            // !! строка подключения к пока что несуществующей БД
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EfSales111;Integrated Security=True");
        }
    }
}
