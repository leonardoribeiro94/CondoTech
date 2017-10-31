using Condominio.Controllers;
using Condominio.Web.Components;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Condominio.Web.Pages.Sindico.Denuncia
{
    public partial class ConsultaDenuncia : System.Web.UI.Page
    {
        private readonly DenunciaControl _denunciaControl;
        private readonly Mensagens _mensagens;

        public ConsultaDenuncia()
        {
            _denunciaControl = new DenunciaControl();
            _mensagens = new Mensagens();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CarregaGridDenuncia();
                }

            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void lbtnDetalhe_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void lkbPesquisar_OnClick(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDataInicio.Text) &&
                    !string.IsNullOrEmpty(txtDataFim.Text))
                {
                    var dataInicio = Convert.ToDateTime(txtDataInicio.Text);
                    var dataFim = Convert.ToDateTime(txtDataFim.Text);

                    grvDenuncia.DataSource = _denunciaControl.ObterDenunciasPorData(dataInicio, dataFim).ToList();
                    grvDenuncia.DataBind();
                }
                else
                {
                    CarregaGridDenuncia();
                }
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void grvDenuncia_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        private void CarregaGridDenuncia()
        {
            grvDenuncia.DataSource = _denunciaControl.ObterDenuncias().ToList();
            grvDenuncia.DataBind();
        }
    }
}