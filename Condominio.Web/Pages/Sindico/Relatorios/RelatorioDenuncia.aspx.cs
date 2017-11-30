using Condominio.Controllers;
using Condominio.CrossCutting.Resources;
using Condominio.Web.Components;
using System;
using System.Linq;
using System.Web.UI;

namespace Condominio.Web.Pages.Sindico.Relatorios
{
    public partial class RelatorioDenuncia : Page
    {
        private readonly Mensagens mensagem;

        public RelatorioDenuncia()
        {
            mensagem = new Mensagens();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidaSessao.Funcionario(Page);
            }
        }

        protected void lkbGeraRelatorio_OnClick(object sender, EventArgs e)
        {
            try
            {
                var denunciaControl = new DenunciaControl();
                var dataInicio = Convert.ToDateTime(txtDataInicio.Text);
                var dataFim = Convert.ToDateTime(txtDataFinal.Text);

                var dados = denunciaControl.ObterDenunciasPorData(dataInicio, dataFim).ToList();

                if (!dados.Equals(null))
                {
                    var handler = new Handler.RelatorioDenuncia(dados);
                    ScriptManager.RegisterClientScriptBlock(Page, GetType(), "", "abrirRelatorioDenuncia()", true);
                }
                else
                {
                    mensagem.MensagemDeExcessao(MensagensDoSistema.Erro, Page);
                }
            }
            catch (Exception exception)
            {
                mensagem.MensagemDeExcessao(exception.Message, Page);
            }


        }
    }
}