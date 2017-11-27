using System.Web.UI.WebControls;

namespace Condominio.Web.Components
{
    public static class Services
    {
        public static DataKey AddSession(object newSender, GridView gridViewName)
        {
            var linkButton = (LinkButton)newSender;
            var gridViewRow = (GridViewRow)linkButton.NamingContainer;
            var dataKey = gridViewName.DataKeys[gridViewRow.RowIndex];
            return dataKey;
        }

        public static GridViewRow ObterLinhaDeDados(object newSender, GridView gridViewName)
        {
            var linkButton = (LinkButton)newSender;
            var gridViewRow = (GridViewRow)linkButton.NamingContainer;
            return gridViewRow;
        }
    }
}