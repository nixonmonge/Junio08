using ProyectoLibreria.Dal;
using ProyectoLibreria.Db;
using ProyectoLibreria.Servicio;
using WebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC.Controllers
{
    public class CoffeeController : Controller
    {
        // GET: Coffee
        // coffee/
        // coffe/index/
        public ActionResult Index()
        {
            string paginaT = Request.QueryString["pag"];
            
            int  pagina = 1;
            if (paginaT != null && paginaT != "")
            {
                pagina = Convert.ToInt32(paginaT);
            }
            ViewBag.lista = CoffeeDal.ListarTodo(pagina);
            int totalPaginas = CoffeeDal.NumPagina(0);
            ViewBag.listaPagina = PaginaServicio.CrearPagina(pagina, totalPaginas,0,"","/Coffee/Index/");

            ViewBag.pagina = pagina;
            Pagina tmp2 = new Pagina();
            Coffee tmp = new Coffee();

            return View();
        }
    }
}