using ProyectoLibreria.Dal;
using ProyectoLibreria.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm.Models;

namespace WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string pagT = Request.QueryString["pag"];
                string filtroT = Request.QueryString["filtro"];
                if (pagT == null || pagT == "")
                {
                    DropDownList1.DataSource = CoffeeTypeDal.ListarTodo();
                    DropDownList1.DataBind();

                    GridView1.DataSource = CoffeeDal.ListarTodo(1);
                    GridView1.DataBind();

                    var paginas = new List<Pagina>();
                    for (int i = 1; i < CoffeeDal.NumPagina(0); i++)
                    {
                        paginas.Add(new Pagina(i, "WebForm1.aspx?pag=" + i + "&filtro=0"));
                    }
                    Repeater1.DataSource = paginas;
                    Repeater1.DataBind();

                }
                else {//convertir la pagina y filtro en numero
                    int pag = Convert.ToInt32(pagT);
                    int filtro = Convert.ToInt32(filtroT);
                    // cargar el combo box
                    DropDownList1.DataSource = CoffeeTypeDal.ListarTodo();                    
                    DropDownList1.DataBind();
                    DropDownList1.SelectedValue = filtro.ToString();

                    //cargar la grilla usando el filtro
                    if (filtro == 0)
                    {
                        GridView1.DataSource = CoffeeDal.ListarTodo(pag);
                    }
                    else
                    {
                        GridView1.DataSource = CoffeeDal.ListarTipo(filtro, pag);
                    }
                    GridView1.DataBind();
                   
                    //cargar la paginacion usuando ese filtro
                    var paginas = new List<Pagina>();
                    for (int i = 1; i < CoffeeDal.NumPagina(filtro); i++)
                    {
                        paginas.Add(new Pagina(i, "WebForm1.aspx?pag=" + i + "&filtro=" + filtro));
                    }
                    Repeater1.DataSource = paginas;
                    Repeater1.DataBind();
                }
                
            }
            else
            {
                // cambio de seleccion
                // que quiero hacer
                // 1 leer tipo de cafe
                int tipoCafe = Convert.ToInt32(DropDownList1.SelectedItem.Value);
                // 2 listar usando tipo de cafe
                if (tipoCafe == 0)
                {
                    GridView1.DataSource = CoffeeDal.ListarTodo(1);
                }
                else
                {
                    GridView1.DataSource = CoffeeDal.ListarTipo(tipoCafe, 1);
                }
                
                GridView1.DataBind();
                // 3 gernerar paginacion usando tipo de cafe
                var paginas = new List<Pagina>();
                for (int i = 1; i < CoffeeDal.NumPagina(tipoCafe); i++)
                {
                    paginas.Add(new Pagina(i, "WebForm1.aspx?pag=" + i+"&filtro="+tipoCafe));
                }
                Repeater1.DataSource = paginas;
                Repeater1.DataBind();

            }
        }//fin page load
    }
}