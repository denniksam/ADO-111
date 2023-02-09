using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace Sales.LinqContext
{
    public class DataContext
    {
        public List<Entities.Department> Departments { get; set; }
        public List<Entities.Product> Products { get; set; }
        public List<Entities.Manager> Managers { get; set; }
        public DataContext(String connectionString)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();
            Departments = new();
            Products = new();
            Managers = new();
            using SqlCommand cmd = new("SELECT Id, Name FROM Departments", connection);
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Departments.Add(new()  
                    {
                        Id = reader.GetGuid(0),
                        Name = reader.GetString(1)
                    });
                }
                reader.Close();

                cmd.CommandText = "SELECT Id, Name, Price FROM Products";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(new() 
                    {
                        Id = reader.GetGuid(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDouble(2)
                    });
                }
                reader.Close();

                cmd.CommandText = "SELECT Id, Surname, Name, Secname, Id_main_dep, Id_sec_dep, Id_chief FROM Managers";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Managers.Add(new()
                    {
                        Id = reader.GetGuid(0),
                        Surname = reader.GetString(1),
                        Name = reader.GetString(2),
                        Secname = reader.GetString(3),
                        IdMainDep = reader.GetGuid(4),
                        IdSecDep = reader[5] == DBNull.Value   // В БД любой элемент может быть NULL
                                    ? null                     // но в С# значимые типы не могут
                                    : reader.GetGuid(5),       // принимать null значение
                        IdChief = reader[6] == DBNull.Value    // Для передачи значимых типов, но опциональных
                                    ? null                     // сначала запрашивают object, его проверяют
                                    : reader.GetGuid(6)        // на DBNull.Value и если это не так, то
                    });                                        // повторяют запрос со значимым Get-тером (GetGuid)
                }
                reader.Close();
            }
        }
    }
}
