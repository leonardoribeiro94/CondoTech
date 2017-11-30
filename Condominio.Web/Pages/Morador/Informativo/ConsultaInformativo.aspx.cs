using Condominio.Controllers;
using Condominio.Web.Components;
using Condominio.Web.Handler;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Condominio.Web.Pages.Morador.Informativo
{
    public partial class ConsultaInformativo : Page
    {
        private readonly InformativoControl _informativoControl;
        private readonly Mensagens _mensagens;

        public ConsultaInformativo()
        {
            _mensagens = new Mensagens();
            _informativoControl = new InformativoControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PreencherGridInformativo();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lkbPesquisar_OnClick(object sender, EventArgs e)
        {
            try
            {
                var valor = txtValorInformativo.Text;
                grvInformativoMorador.DataSource = _informativoControl.ObterInformativoPorTitulo(valor).ToList();
                grvInformativoMorador.DataBind();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }


        protected void lblDownload_OnClick(object sender, EventArgs e)
        {
            try
            {
                var gridViewRow = Services.ObterLinhaDeDados(sender, grvInformativoMorador);
                var dataKey = grvInformativoMorador.DataKeys[gridViewRow.RowIndex];

                if (dataKey != null)
                {
                    var idInformativo = Convert.ToInt32(dataKey["IdInformativo"]);
                    var documento = _informativoControl.ObterDocumentoInformativo(idInformativo);

                    if (documento != null)
                    {
                        VisualizacaoDeDocumento.DocumentArray = documento;
                        VisualizacaoDeDocumento.TipoOpcaoHandler = VisualizacaoDeDocumento.OpcaoHandler.Show;
                        ScriptManager.RegisterStartupScript(Page, GetType(), "abrirDocumentoWeb", "abrirDocumento()",
                            true);
                    }
                    else
                    {
                        _mensagens.MensagemDeExcessao("Anexo de documento inexistente!", Page);
                    }
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }


        protected void grvInformativoMorador_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grvInformativoMorador.PageIndex = e.NewPageIndex;
                PreencherGridInformativo();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        private void PreencherGridInformativo()
        {
            grvInformativoMorador.DataSource = _informativoControl.ObterInformativos();
            grvInformativoMorador.DataBind();
        }

    }
}