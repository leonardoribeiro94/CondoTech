using Condominio.Controllers;
using System;

namespace Condominio.Web.Pages.Sindico
{
    public partial class ConsultarFuncionario : System.Web.UI.Page
    {
        private readonly FuncionarioControl _funcionarioControl;

        public ConsultarFuncionario()
        {
            _funcionarioControl = new FuncionarioControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            grvFuncionario.DataSource = _funcionarioControl.ListarFuncionarios();
            grvFuncionario.DataBind();
        }
    }
}