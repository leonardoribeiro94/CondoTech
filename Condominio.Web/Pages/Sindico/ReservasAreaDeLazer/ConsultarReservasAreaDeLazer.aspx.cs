using Condominio.Controllers;
using Condominio.Web.Components;
using System;
using System.Web.UI.WebControls;

namespace Condominio.Web.Pages.Sindico.ReservasAreaDeLazer
{
    public partial class ConsultarReservasAreaDeLazer : System.Web.UI.Page
    {
        private readonly ReservaAreaDeLazerControl _reservaAreaDeLazerCtrl;
        private readonly Mensagens _mensagens;

        public ConsultarReservasAreaDeLazer()
        {
            _reservaAreaDeLazerCtrl = new ReservaAreaDeLazerControl();
            _mensagens = new Mensagens();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregaGridReserva();
            }
        }

        protected void grvReserva_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grvReserva.PageIndex = e.NewPageIndex;
                CarregaGridReserva();
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
                var codigoValor = txtCodigoReserva.Text;

                if (!string.IsNullOrEmpty(codigoValor))
                {
                    var idReserva = Convert.ToInt32(codigoValor);
                    grvReserva.DataSource = _reservaAreaDeLazerCtrl.ObterReservasPorId(idReserva);
                    grvReserva.DataBind();
                }
                else
                {
                    CarregaGridReserva();
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lbtnDetalhes_OnClick(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        private void CarregaGridReserva()
        {
            grvReserva.DataSource = _reservaAreaDeLazerCtrl.ObterReservasDeaAreaDeLazer();
            grvReserva.DataBind();
        }


    }
}