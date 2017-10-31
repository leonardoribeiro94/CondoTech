using Condominio.Controllers;
using Condominio.Web.Components;
using System;
using System.Linq;

namespace Condominio.Web.Pages.Sindico.Funcionario
{
    public partial class InserirFuncionario : System.Web.UI.Page
    {
        private readonly FuncionarioControl _funcionarioControl;
        private readonly CargoControl _cargoControl;
        private readonly Mensagens _mensagens;

        public InserirFuncionario()
        {
            _mensagens = new Mensagens();
            _cargoControl = new CargoControl();
            _funcionarioControl = new FuncionarioControl();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CarregaDadosDaSessao();
                    CarregarDropDownListCargo();
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        private void CarregarDropDownListCargo()
        {
            ddlCargo.DataSource = _cargoControl.ObterCargo().ToList();
            ddlCargo.DataTextField = "Nome";
            ddlCargo.DataValueField = "IdCargo";
            ddlCargo.DataBind();
        }

        protected void lbtnInserirFuncionario_OnClick(object sender, EventArgs e)
        {
            try
            {
                var funcionario = new Model.Funcionario
                {
                    Nome = txtNome.Text,
                    DataDeNascimento = Convert.ToDateTime(txtDataNascimento.Text).Date,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    IdCargo = Convert.ToInt32(ddlCargo.SelectedValue)
                };

                funcionario.ValidaDados();

                if (ViewState["IdFuncionario"].Equals(null))
                {
                    _funcionarioControl.InserirFuncionario(funcionario);
                }
                else
                {
                    funcionario.Id = Convert.ToInt32(ViewState["IdFuncionario"]);
                    _funcionarioControl.AlterarFuncionario(funcionario);
                }
                Response.Redirect("~/Pages/Sindico/funcionario/ConsultarFuncionario.aspx", false);
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lkbVoltar_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Sindico/funcionario/ConsultarFuncionario.aspx", false);
        }

        private void CarregaDadosDaSessao()
        {
            if (Session["IdFuncionario"] != null)
            {
                ViewState.Add("IdFuncionario", Session["IdFuncionario"]);
                Session.Clear();

                var idFuncionario = Convert.ToInt32(ViewState["IdFuncionario"]);
                var data = _funcionarioControl.ListarFuncionariosPorId(idFuncionario);
                txtNome.Text = data.Nome;
                txtDataNascimento.Text = data.DataDeNascimento.Date.ToShortDateString();
                txtTelefone.Text = data.Telefone;
                txtCelular.Text = data.Celular;
                txtCpf.Text = data.Cpf;
                txtEmail.Text = data.Email;
            }
        }
    }
}