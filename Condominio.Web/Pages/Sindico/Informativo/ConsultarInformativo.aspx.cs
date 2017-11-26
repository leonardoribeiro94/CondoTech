using Condominio.Controllers;
using Condominio.Web.Components;
using Condominio.Web.Handler;
using System;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Condominio.Web.Pages.Sindico.Informativo
{
    public partial class ConsultarInformativo : Page
    {
        private readonly InformativoControl _informativoControl;
        private readonly Mensagens _mensagens;

        public ConsultarInformativo()
        {
            _mensagens = new Mensagens();
            _informativoControl = new InformativoControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    ValidaSessao.Funcionario(Page);
                    PreencherGridInformativo();
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        private void PreencherGridInformativo()
        {
            grvInformativo.DataSource = _informativoControl.ObterInformativos();
            grvInformativo.DataBind();
        }

        protected void lkbPesquisar_OnClick(object sender, EventArgs e)
        {
            try
            {
                var valor = txtValorInformativo.Text;
                grvInformativo.DataSource = _informativoControl.ObterInformativoPorTitulo(valor).ToList();
                grvInformativo.DataBind();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void grvInformativo_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grvInformativo.PageIndex = e.NewPageIndex;
                PreencherGridInformativo();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lbtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var javascript = new JavaScriptSerializer();
                var gridViewRow = Services.ObterLinhaDeDados(sender, grvInformativo);
                var dataKey = grvInformativo.DataKeys[gridViewRow.RowIndex];

                if (dataKey != null)
                {
                    var idFuncionario = Convert.ToInt32(dataKey["IdInformativo"]);
                    var idSerializado = javascript.Serialize(idFuncionario);

                    ViewState.Add("IdFuncionario", Convert.ToInt32(idSerializado));

                    ScriptManager.RegisterClientScriptBlock(Page, GetType(),
                        "modaldeleteFuncionario", "confirmarExcluir()", true);
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lbtnEditar_OnClick(object sender, EventArgs e)
        {
            try
            {
                var gridViewRow = Services.ObterLinhaDeDados(sender, grvInformativo);
                var dataKey = grvInformativo.DataKeys[gridViewRow.RowIndex];

                if (dataKey != null) Session.Add("IdInformativo", dataKey["IdInformativo"]);

                AtualizaPagina();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void btnDeletarInformativo_OnClick(object sender, EventArgs e)
        {
            try
            {
                var idInformativo = Convert.ToInt32(ViewState["IdFuncionario"]);
                _informativoControl.DeletarInformativo(idInformativo);
                Response.Redirect("~/Pages/Sindico/Informativo/ConsultarInformativo.aspx.", false);
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        private void AtualizaPagina()
        {
            Response.Redirect("~/Pages/Sindico/Informativo/InserirInformativo.aspx", false);
        }

        protected void lblDownload_OnClick(object sender, EventArgs e)
        {
            try
            {
                var gridViewRow = Services.ObterLinhaDeDados(sender, grvInformativo);
                var dataKey = grvInformativo.DataKeys[gridViewRow.RowIndex];

                if (dataKey != null)
                {
                    var idInformativo = Convert.ToInt32(dataKey["IdInformativo"]);
                    var documento = _informativoControl.ObterDocumentoInformativo(idInformativo);

                    if (!documento.Length.Equals(0))
                    {
                        VisualizacaoDeDocumento.DocumentArray = documento;
                        VisualizacaoDeDocumento.TipoOpcaoHandler = VisualizacaoDeDocumento.OpcaoHandler.Show;

                        ScriptManager.RegisterStartupScript(Page, GetType(), "abrirDocumentoWeb", "abrirDocumento()",
                            true);
                    }
                    else
                    {
                        _mensagens.MensagemDeExcessao("<b>Anexo de documento inexistente!</b>!", Page);
                    }
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lkbInserir_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Sindico/Informativo/InserirInformativo.aspx", false);
        }
    }
}