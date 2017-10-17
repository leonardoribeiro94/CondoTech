using Condominio.Controllers;
using System;
using System.Linq;

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

        protected void LkbPesquisar_OnClick(object sender, EventArgs e)
        {
            var nome = txtNomeFuncionario.Text;
            grvFuncionario.DataSource = _funcionarioControl.ListarFuncionariosPorNome(nome).ToList();
            grvFuncionario.DataBind();
        }
    }
}