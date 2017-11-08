using Condominio.Model.Enum;
using Condominio.Web.Components;
using System;
using System.Web.UI;

namespace Condominio.Web
{
    public partial class SiteMaster : MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var usuarioLogado = (TipoUsuario)Convert.ToInt32(Session["tipoUsuarioLogado"]);

                if (usuarioLogado.Equals(TipoUsuario.Funcionario))
                {
                    panelSindico.Visible = true;
                    panelMorador.Visible = false;
                }
                else
                {
                    panelSindico.Visible = false;
                    panelMorador.Visible = true;
                }
            }
        }

        protected void lbtnSair_OnClick(object sender, EventArgs e)
        {
            Redirecionamento.TelaDefault(Page);
        }
    }
}