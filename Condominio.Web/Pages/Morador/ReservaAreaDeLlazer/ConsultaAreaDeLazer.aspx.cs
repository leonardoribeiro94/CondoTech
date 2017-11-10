using Condominio.Controllers;
using Condominio.Web.Components;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Condominio.CrossCutting;

namespace Condominio.Web.Pages.Morador.ReservaAreaDeLlazer
{
    public partial class ConsultaAreaDeLazer : System.Web.UI.Page
    {
        private readonly AreaDeLazerControl _areaDeLazerCtrl;
        private readonly Mensagens _mensagens;

        public ConsultaAreaDeLazer()
        {
            _areaDeLazerCtrl = new AreaDeLazerControl();
            _mensagens = new Mensagens();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ValidaSessao.Morador(Page);
                CarregaAreaDeLazer();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void grvAreaDeLazer_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void lkbPesquisar_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void CarregaAreaDeLazer()
        {
            grvAreaDeLazer.DataSource = _areaDeLazerCtrl.ObterAreaDeLazer().ToList();
            grvAreaDeLazer.DataBind();
        }

        protected void GridAreasDeLazerReservadas_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void lblExibeImagem_OnClick(object sender, EventArgs e)
        {
            try
            {
                var areaDeLazer = new Model.AreaDeLazer();

                var gridViewRow = Services.ObterLinhaDeDados(sender, grvAreaDeLazer);
                var dataKey = grvAreaDeLazer.DataKeys[gridViewRow.RowIndex];
                var idAreaDeLazer = Convert.ToInt32(dataKey["IdAreaDeLazer"]);

                areaDeLazer.Imagem = _areaDeLazerCtrl.ObterAreaDeLazerPorId(idAreaDeLazer).Imagem;
                var novaImagem = ConverteArquivo.ParaImagem(areaDeLazer.Imagem);

                ScriptManager.RegisterClientScriptBlock(Page, GetType(),
                    "modalExibirImagem", $"fn_ModalExibirImagem({novaImagem})", true);
            }
            catch (Exception exception)
            {
               _mensagens.MensagemDeExcessao(exception.Message,Page);
            }
        }
    }
}