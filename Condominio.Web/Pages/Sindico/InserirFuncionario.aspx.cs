using Condominio.Controllers;
using Condominio.Model;
using Condominio.Web.Components;
using System;
using System.Linq;

namespace Condominio.Web.Pages.Sindico
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
                CarregarDropDownListCargo();
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
                var funcionario = new Funcionario();
                funcionario.Nome = txtNome.Text;
                funcionario.DataDeNascimento = Convert.ToDateTime(txtDataNascimento.Text).Date;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Celular = txtCelular.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Email = txtEmail.Text;
                funcionario.IdCargo = Convert.ToInt32(ddlCargo.SelectedValue);
                funcionario.ValidaDados();
                _funcionarioControl.InserirFuncionario(funcionario);
                Response.Redirect("~/Pages/Sindico/ConsultarFuncionario.aspx", false);
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }
    }
}