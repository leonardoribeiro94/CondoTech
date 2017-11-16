using Condominio.Controllers;
using Condominio.Model;
using Condominio.Web.Components;
using System;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace Condominio.Web.Pages.Morador.ReservaAreaDeLlazer
{
    public partial class InserirReservaDeAreasDeLazer : Page
    {
        private readonly ReservaAreaDeLazerControl _reservaAreaDeLazerControl;
        private readonly Mensagens _mensagens;

        public InserirReservaDeAreasDeLazer()
        {
            _reservaAreaDeLazerControl = new ReservaAreaDeLazerControl();
            _mensagens = new Mensagens();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidaSessao.Morador(Page);
                CarregaDadosDaSessao();
                VerificaDatasJaAgendadas();
            }
        }



        protected void lkbVoltar_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Morador/ReservaAreaDeLlazer/ConsultaAreaDeLazer.aspx", false);
        }

        private void CarregaDadosDaSessao()
        {
            if (Session["IdAreaDeLazer"] != null)
            {

                var idAreaDeLazer = Convert.ToString(Session["IdAreaDeLazer"]);
                spanNomeDaArea.InnerText = Convert.ToString(Session["NomeAreaDeLazer"]);
                Session.Remove("IdAreaDeLazer");

                ViewState.Add("idAreaDeLazer", idAreaDeLazer);
            }
        }

        protected void btnSolicitarPedido_OnClick(object sender, EventArgs e)
        {
            try
            {
                var reservaArea =
                    new ReservaAreaDeLazer
                    {
                        IdAreaDeLazer = Convert.ToInt32(ViewState["idAreaDeLazer"]),
                        IdMorador = Convert.ToInt32(Session["idMoradorUsuarioLogado"]),
                        DataReserva = Convert.ToDateTime(txtDataReserva.Text),
                        Descricao = Convert.ToString(txtObservacao.Value),
                        DataSolicitacaoDoPedido = DateTime.Now
                    };

                _reservaAreaDeLazerControl.InserirReservarAreaDeLazer(reservaArea);
                Response.Redirect("~/Pages/Morador/ReservaAreaDeLazer/ConsultaAreaDeLazer.aspx", false);
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        private void VerificaDatasJaAgendadas()
        {
            try
            {
                var serialize = new JavaScriptSerializer().Serialize("26/06/2018");
                ScriptManager.RegisterStartupScript(Page, GetType(), "campodatablock", $"dataCalendario({serialize});", true);
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }
    }
}