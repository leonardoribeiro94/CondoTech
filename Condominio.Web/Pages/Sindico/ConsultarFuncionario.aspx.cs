using Condominio.Controllers;
using Condominio.Web.Components;
using System;
using System.Linq;

namespace Condominio.Web.Pages.Sindico
{
    public partial class ConsultarFuncionario : System.Web.UI.Page
    {
        private readonly FuncionarioControl _funcionarioControl;
        private readonly Mensagens _mensagens;

        public ConsultarFuncionario()
        {
            _funcionarioControl = new FuncionarioControl();
            _mensagens = new Mensagens();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            PreencherGridFuncionarios();
        }

        protected void LkbPesquisar_OnClick(object sender, EventArgs e)
        {
            try
            {
                var nome = txtNomeFuncionario.Text;
                grvFuncionario.DataSource = _funcionarioControl.ListarFuncionariosPorNome(nome).ToList();
                grvFuncionario.DataBind();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void GrvFuncionario_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            try
            {
                grvFuncionario.PageIndex = e.NewPageIndex;
                PreencherGridFuncionarios();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void LbtnEditar_Click(object sender, EventArgs e)
        {
            var datakey = Services.AddSession(sender, grvFuncionario);
            Session.Add("IdFuncionario", datakey["IdFuncionario"]);
            Response.Redirect("~/Pages/Sindico/InserirFuncionario.aspx", false);
        }

        #region Metodos

        private void PreencherGridFuncionarios()
        {
            grvFuncionario.DataSource = _funcionarioControl.ListarFuncionarios();
            grvFuncionario.DataBind();
        }

        #endregion
        
    }
}