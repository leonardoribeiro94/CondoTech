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
                Session.Clear();
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
                        Session.Add("tipoUsuarioLogado", TipoUsuario.Funcionario);
                        Session.Add("idFuncionarioUsuarioLogado", dataFuncionario.IdFuncionario);
                        Session.Add("nomeUsuario", dataFuncionario.Nome);
                        Session.Add("emailUsuario", dataFuncionario.Email);

                        Redirecionamento.TelaHome(Page);
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

                        Session.Add("tipoUsuarioLogado", TipoUsuario.Morador);
                        Session.Add("idMoradorUsuarioLogado", dataMorador.IdMorador);
                        Session.Add("nomeUsuario", dataMorador.Nome);
                        Session.Add("emailUsuario", dataMorador.Email);
                        Redirecionamento.TelaHome(Page);
                    }
                    else
                    {
                        _mensagens.MensagemDeInformacao(MensagensDoSistema.LoginNaoPermitido, Page);
                    }
                }

                else
                {
                    _mensagens.MensagemDeExcessao(MensagensDoSistema.LoginNaoPermitido, Page);
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }
    }
}