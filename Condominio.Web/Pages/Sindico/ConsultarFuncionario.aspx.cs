using Condominio.Controllers;
using Condominio.Web.Components;
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
            PreencherGridFuncionarios();
        }

        protected void LkbPesquisar_OnClick(object sender, EventArgs e)
        {
            var nome = txtNomeFuncionario.Text;
            grvFuncionario.DataSource = _funcionarioControl.ListarFuncionariosPorNome(nome).ToList();
            grvFuncionario.DataBind();
        }

        protected void GrvFuncionario_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            grvFuncionario.PageIndex = e.NewPageIndex;
            PreencherGridFuncionarios();
        }


        #region Metodos

        private void PreencherGridFuncionarios()
        {
            grvFuncionario.DataSource = _funcionarioControl.ListarFuncionarios();
            grvFuncionario.DataBind();
        }

        protected void LbtnEditar_Click(object sender, EventArgs e)
        {
            var datakey = Services.AddSession(sender, grvFuncionario);
            Session.Add("IdFuncionario", datakey["IdFuncionario"]);
            Response.Redirect("~/Pages/Protetor/IncProtetor.aspx", false);
        }
        #endregion


    }
}