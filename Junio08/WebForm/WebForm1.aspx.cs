using ProyectoLibreria.Dal;
using ProyectoLibreria.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataSource = CoffeeTypeDal.ListarTodo();
            DropDownList1.DataBind();

            GridView1.DataSource = CoffeeDal.ListarTodo(1);
            GridView1.DataBind();
        }
    }
}