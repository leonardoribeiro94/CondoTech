using System.Web.UI;

namespace Condominio.Web.Components
{
    public static class Redirecionamento
    {
        public static void TelaDefault(Page page)
        {
            page.Response.Redirect("~/Default.aspx", false);
        }

        public static void TelaHome(Page page)
        {
            page.Response.Redirect("~/Pages/Home.aspx", false);
        }
    }
}