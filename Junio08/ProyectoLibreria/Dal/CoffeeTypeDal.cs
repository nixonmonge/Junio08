using ProyectoLibreria.Db;
using ProyectoLibreria.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibreria.Dal
{
    public class CoffeeTypeDal
    {
        public static List<CoffeeType> ListarTodo()
        {
            using (var grupo = new Model1())
            {
                return grupo.CoffeeType.OrderBy(ct => ct.Name).ToList();
            }
        }
    }
}
