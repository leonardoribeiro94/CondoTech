using Condominio.Controllers;
using Condominio.Model;
using Condominio.Web.Components;
using System;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.UI;
using WebGrease.Css.Extensions;

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
                SelecionaDatasReservadas();
            }
        }


        protected void lkbVoltar_OnClick(object sender, EventArgs e)
        {
            RedirecionaPagina();
        }


        protected void btnSolicitarPedido_OnClick(object sender, EventArgs e)
        {
            try
            {
                var reservaArea =
                    new ReservaAreaDeLazer
                    {
                        IdAreaDeLazer = Convert.ToInt32(ViewState["IdAreaDeLazer"]),
                        IdMorador = Convert.ToInt32(Session["idMoradorUsuarioLogado"]),
                        DataReserva = Convert.ToDateTime(txtDataReserva.Text).Date,
                        Descricao = Convert.ToString(txtObservacao.Value),
                        DataSolicitacaoDoPedido = DateTime.Now
                    };

                _reservaAreaDeLazerControl.InserirReservarAreaDeLazer(reservaArea);
                RedirecionaPagina();
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }


        private void CarregaDadosDaSessao()
        {
            if (Session["IdAreaDeLazer"] != null)
            {

                var idAreaDeLazer = Convert.ToString(Session["IdAreaDeLazer"]);
                spanNomeDaArea.InnerText = Convert.ToString(Session["NomeAreaDeLazer"]);
                Session.Remove("IdAreaDeLazer");

                ViewState.Add("IdAreaDeLazer", idAreaDeLazer);
            }
        }

        private void SelecionaDatasReservadas()
        {
            try
            {
                var idAreaDeLazer = Convert.ToInt32(ViewState["IdAreaDeLazer"]);
                var datasDeReservaDaAreaDeLazer = _reservaAreaDeLazerControl.ObterDatasDaReservaDeUmaAreaDeLazerPorId(idAreaDeLazer).ToArray();

                if (datasDeReservaDaAreaDeLazer.Length > 0)
                {
                    var serialize = new JavaScriptSerializer().Serialize(datasDeReservaDaAreaDeLazer);
                    ScriptManager.RegisterStartupScript(Page, GetType(), "campodatablock", $"dataCalendario({serialize});", true);
                }

            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }


        private void RedirecionaPagina()
        {
            Response.Redirect("~/Pages/Morador/ReservaAreaDeLlazer/ConsultaAreaDeLazer.aspx", false);
        }
    }
}