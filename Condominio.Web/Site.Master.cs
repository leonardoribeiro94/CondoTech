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
                    liManualSindico.Visible = true;
                    panelMorador.Visible = false;
                    liManualMorador.Visible = false;
                }
                else
                {
                    panelSindico.Visible = false;
                    liManualSindico.Visible = false;
                    panelMorador.Visible = true;
                    liManualMorador.Visible = true;
                }

                lblNome.Text = Convert.ToString(Session["nomeUsuario"]);
                lblUsuario.Text = Convert.ToString(Session["nomeUsuario"]);
                lblEmail.Text = Convert.ToString(Session["emailUsuario"]);
            }
        }

        protected void lbtnSair_OnClick(object sender, EventArgs e)
        {
            Redirecionamento.TelaDefault(Page);
        }
    }
}