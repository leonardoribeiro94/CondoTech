using Condominio.Controllers;
using Condominio.Web.Components;
using System;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace Condominio.Web.Pages.Sindico
{
    public partial class ConsultarFuncionario : Page
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

        protected void GrvFuncionario_PageIndexChanging(object sender,
            System.Web.UI.WebControls.GridViewPageEventArgs e)
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

        protected void LkbInserir_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Sindico/InserirFuncionario.aspx", false);
        }

        protected void LbtnEditar_Click(object sender, EventArgs e)
        {
            var datakey = Services.AddSession(sender, grvFuncionario);
            Session.Add("IdFuncionario", datakey["IdFuncionario"]);
            Response.Redirect("~/Pages/Sindico/InserirFuncionario.aspx", false);
        }

        protected void LbtnExcluir_OnClick(object sender, EventArgs e)
        {
            try
            {
                var javascript = new JavaScriptSerializer();
                var gridViewRow = Services.ObterLinhaDeDados(sender, grvFuncionario);
                var dataKey = grvFuncionario.DataKeys[gridViewRow.RowIndex];

                if (dataKey != null)
                {
                    var idFuncionario = Convert.ToInt32(dataKey["IdFuncionario"]);
                    var idSerializado = javascript.Serialize(idFuncionario);

                    ViewState.Add("IdFuncionario", Convert.ToInt32(idSerializado));

                    ScriptManager.RegisterClientScriptBlock(Page, GetType(),
                        "modaldeleteFuncionario", "confirmarExcluir(\"" + idSerializado + "\")", true);
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void DeletarFuncionario(object sender, EventArgs e)
        {
            try
            {
                var idFuncionario = Convert.ToInt32(ViewState["IdFuncionario"]);
                _funcionarioControl.ExcluirFuncionario(idFuncionario);

                Response.Redirect("~/Pages/Sindico/ConsultarFuncionario.aspx", false);
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }
        #region Metodos

        private void PreencherGridFuncionarios()
        {
            try
            {
                grvFuncionario.DataSource = _funcionarioControl.ListarFuncionarios();
                grvFuncionario.DataBind();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        #endregion
    }
}