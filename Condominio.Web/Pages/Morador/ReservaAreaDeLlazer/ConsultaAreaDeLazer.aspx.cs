using Condominio.Controllers;
using Condominio.CrossCutting;
using Condominio.Web.Components;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Condominio.Web.Pages.Morador.ReservaAreaDeLlazer
{
    public partial class ConsultaAreaDeLazer : Page
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
            grvAreaDeLazer.PageIndex = e.NewPageIndex;
            CarregaAreaDeLazer();
        }

        protected void lkbPesquisar_OnClick(object sender, EventArgs e)
        {

        }

        protected void GridAreasDeLazerReservadas_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lblExibeImagem_OnClick(object sender, EventArgs e)
        {
            try
            {
                var areaDeLazer = new Model.AreaDeLazer();

                var gridViewRow = Services.ObterLinhaDeDados(sender, grvAreaDeLazer);
                var dataKey = grvAreaDeLazer.DataKeys[gridViewRow.RowIndex];
                var idAreaDeLazer = Convert.ToInt32(dataKey?["IdAreaDeLazer"]);

                areaDeLazer.Imagem = _areaDeLazerCtrl.ObterAreaDeLazerPorId(idAreaDeLazer).Imagem;
                var novaImagem = ConverteArquivo.ParaImagem(areaDeLazer.Imagem);

                ScriptManager.RegisterClientScriptBlock(Page, GetType(),
                    "modalExibirImagem", $"fn_ModalExibirImagem({novaImagem})", true);
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lblSolicitaReserva_OnClick(object sender, EventArgs e)
        {
            var datakey = Services.AddSession(sender, grvAreaDeLazer);
            Session.Add("IdAreaDeLazer", datakey["IdAreaDeLazer"]);
            Session.Add("NomeAreaDeLazer", datakey["Nome"]);
            Response.Redirect("~/Pages/Morador/ReservaAreaDeLlazer/InserirReservaDeAreasDeLazer.aspx", false);
        }

        private void CarregaAreaDeLazer()
        {
            grvAreaDeLazer.DataSource = _areaDeLazerCtrl.ObterAreaDeLazer().ToList();
            grvAreaDeLazer.DataBind();
        }
    }


}