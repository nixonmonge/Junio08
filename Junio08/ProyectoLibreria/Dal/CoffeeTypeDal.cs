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
                var types = grupo.CoffeeType.OrderBy(ct => ct.Name).ToList();
                CoffeeType vacio = new CoffeeType();
                vacio.CoffeeTypeId = 0;
                vacio.Name = "--Seleccione Un Tipo--";
                types.Insert(0, vacio);
                return types;
            }
        }
    }
}
