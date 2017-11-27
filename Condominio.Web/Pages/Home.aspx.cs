using Condominio.Web.Components;
using System;

namespace Condominio.Web.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidaSessao.ValidaSessaoExistente(Page);
            }
        }
    }
}