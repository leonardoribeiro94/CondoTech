using System;


namespace Condominio.Web.Pages.Sindico.Informativo
{
    public partial class InserirInformativo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LkbVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Informativo/InserirInformativo.aspx", false);
        }
    }
}