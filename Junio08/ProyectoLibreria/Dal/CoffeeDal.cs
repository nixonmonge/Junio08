using ProyectoLibreria.Db;
using ProyectoLibreria.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibreria.Dal
{
    public class CoffeeDal
    {
        const int TAMPAGINA = 20;
        public static List<Coffee> ListarTodo(int pagina)
        {
            using (var grupo = new Model1())
            {
                return grupo.Coffee.OrderBy(c=> c.Title).Skip((pagina-1)*TAMPAGINA).ToList(); // PAGINA 1 = (1-1)*20=0
            }        
        }
        public static List<Coffee> ListarTipo(int tipo, int pagina)
        {
            using (var grupo = new Model1())
            {
                return grupo.Coffee.Where(c => c.TypeId == tipo).OrderBy(c => c.Title).Skip((pagina - 1) * TAMPAGINA).ToList();
            }
        }

    } // final de clase
}
