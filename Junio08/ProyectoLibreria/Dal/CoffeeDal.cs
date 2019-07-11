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
                return grupo.Coffee.Include("Brand").Include("CoffeeType").
                    OrderBy(c=> c.Title).Skip((pagina-1)*TAMPAGINA).Take(TAMPAGINA).ToList(); // PAGINA 1 = (1-1)*20=0
            }        
        }
        public static List<Coffee> ListarTipo(int tipo, int pagina)
        {
            using (var grupo = new Model1())
            {
                return grupo.Coffee.Include("Brand").Include("CoffeeType").Where(c => c.TypeId == tipo).OrderBy(c => c.Title).Skip((pagina - 1) * TAMPAGINA).Take(TAMPAGINA).ToList();
            }
        }
        public static int NumPagina(int tipo)
        {
            using (var grupo = new Model1())

            {
                if (tipo == 0)
                {
                    return (int)Math.Ceiling((double) grupo.Coffee.Count() /TAMPAGINA);
                }
                else
                {
                    int num=grupo.Coffee.Where(c => c.TypeId == tipo).Count();
                    return (int)Math.Ceiling((double)num / TAMPAGINA);
                }
                
            }
        }

    } // final de clase
}
