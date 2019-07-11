﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebForm.Models;

namespace ProyectoLibreria.Servicio
{
    public class PaginaServicio
    {
        public static List<Pagina> CrearPagina(int pagActual, int maxPagina, int filtro, string pagina)
        {
            int paginaInicial = pagActual - 3;
            int paginaFinal = pagActual + 3;
            if (paginaInicial <= 0)
            {
                paginaInicial = 1;
            }
            if (paginaFinal > maxPagina)
            {
                paginaFinal = maxPagina;
            }

            var r = new List<Pagina>();
            if (pagActual != 1)
            { 

            r.Add(new Pagina("Previo", pagina + "?pag=" + (pagActual - 1) + "&filtro=" + filtro));
            }
            for (int i = paginaInicial; i <= paginaFinal; i++)

            {
                r.Add(new Pagina(i.ToString(), pagina + "?pag=" + i + "&filtro="+filtro));
            }
            if (pagActual != maxPagina)
            { 
            r.Add(new Pagina("Next", pagina + "?pag=" + (pagActual + 1) + "&filtro=" + filtro));
            }
            return r;
        }
    }
}
