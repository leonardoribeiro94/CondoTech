using Condominio.Controllers;
using Condominio.Web.Components;
using System;

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
            ddlCargo.DataSource = _cargoControl.ObterCargo();
            ddlCargo.DataTextField = "Nome";
            ddlCargo.DataValueField = "Id";
            ddlCargo.DataBind();
        }
    }
}