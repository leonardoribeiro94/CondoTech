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
                    divManualSindico.Visible = true;
                    panelMorador.Visible = false;
                    divManualMorador.Visible = false;
                }
                else
                {
                    panelSindico.Visible = false;
                    divManualSindico.Visible = false;
                    panelMorador.Visible = true;
                    divManualMorador.Visible = true;
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