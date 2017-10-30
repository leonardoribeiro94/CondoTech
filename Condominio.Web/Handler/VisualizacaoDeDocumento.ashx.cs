using System.Web;

namespace Condominio.Web.Handler
{
    /// <summary>
    /// Summary description for VisualizacaoDeDocumento
    /// </summary>
    public class VisualizacaoDeDocumento : IHttpHandler
    {
        public static byte[] DocumentArray;
        public static OpcaoHandler TipoOpcaoHandler;

        public enum OpcaoHandler
        {
            Show,
            Download
        }

        public void ProcessRequest(HttpContext context)
        {
            string tipoOpcao;

            switch (TipoOpcaoHandler)
            {
                case OpcaoHandler.Download:
                    tipoOpcao = "application/force-download";
                    break;
                case OpcaoHandler.Show:
                    tipoOpcao = "application/pdf";
                    break;
                default:
                    tipoOpcao = "application/pdf";
                    break;
            }

            context.Response.Clear();
            context.Response.ContentType = tipoOpcao;
            context.Response.AddHeader("content-disposition", "inline;filename=documento.pdf");
            context.Response.OutputStream.Write(DocumentArray, 0, DocumentArray.Length);
            context.Response.OutputStream.Flush();
            context.Response.OutputStream.Close();
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        public bool IsReusable => false;
    }
}