using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm.Models
{
    public class Pagina
    {
        public string Pag { set; get; }
        public string Url { set; get; }

        public Pagina()
        {
        }

        public Pagina(string pag, string url)
        {
            Pag = pag;
            Url = url;
        }
    }
}