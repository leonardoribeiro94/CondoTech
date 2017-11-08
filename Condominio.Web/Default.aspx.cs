using Condominio.Controllers;
using Condominio.CrossCutting.Resources;
using Condominio.Model.Enum;
using Condominio.Web.Components;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Condominio.Web
{
    public partial class Default : Page
    {
        private readonly UsuarioFuncionarioControl _funcionarioControl;
        private readonly UsuarioMoradorControl _moradorControl;
        private readonly Mensagens _mensagens;

        public Default()
        {
            _funcionarioControl = new UsuarioFuncionarioControl();
            _moradorControl = new UsuarioMoradorControl();
            _mensagens = new Mensagens();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            try
            {
                var login = txtLogin.Text.Trim();
                var senha = txtSenha.Text.Trim();

                var dataFuncionario = _funcionarioControl.ObterPorLoginFuncionariosUsuarios(login, senha).FirstOrDefault();
                var dataMorador = _moradorControl.ObterUsuarioMoradorPorLogin(login, senha);

                if (dataFuncionario != null)
                {
                    var cargoFuncionario = dataFuncionario.Cargo.ToLower();

                    if (cargoFuncionario.Equals("sindico"))
                    {
                        var panelSindico = (Panel)Master?.FindControl("panelSindico");
                        if (panelSindico != null) panelSindico.Visible = true;

                        Session.Add("usuarioLogado", dataFuncionario.IdUsuario);
                        Response.Redirect("~/Pages/Sindico/Informativo/ConsultarInformativo.aspx", false);
                    }
                    else
                    {
                        _mensagens.MensagemDeInformacao(MensagensDoSistema.LoginNaoPermitido, Page);
                    }
                }

                else if (dataMorador != null)
                {
                    if (dataMorador.Ativo != EntidadeAtiva.Inativo)
                    {
                        var panelMorador = (Panel)Master?.FindControl("panelMorador");
                        if (panelMorador != null) panelMorador.Visible = true;

                        Session.Add("usuarioLogado", dataMorador.IdUsuario);
                    }
                    else
                    {
                        _mensagens.MensagemDeInformacao(MensagensDoSistema.LoginNaoPermitido, Page);
                    }
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }
    }
}