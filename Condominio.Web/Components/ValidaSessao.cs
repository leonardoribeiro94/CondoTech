using System.Web.UI;

namespace Condominio.Web.Components
{
    public static class ValidaSessao
    {
        public static void Funcionario(Page page)
        {
            if (page.Session["idFuncionarioUsuarioLogado"] == null)
                Redirecionamento.TelaDefault(page);
        }

        public static void Morador(Page page)
        {
            if (page.Session["idMoradorUsuarioLogado"] == null)
                Redirecionamento.TelaDefault(page);
        }
    }
}