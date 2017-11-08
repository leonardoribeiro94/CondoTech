using Condominio.Controllers;
using Condominio.CrossCutting;
using Condominio.Web.Components;
using System;
using System.IO;


namespace Condominio.Web.Pages.Sindico.Informativo
{
    public partial class InserirInformativo : System.Web.UI.Page
    {
        private readonly InformativoControl _informativoControl;
        private readonly Mensagens _mensagem;

        public InserirInformativo()
        {
            _informativoControl = new InformativoControl();
            _mensagem = new Mensagens();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    ValidaSessao.Funcionario(Page);
                    CarregaDadosDaSessao();
                }
            }
            catch (Exception exception)
            {
                _mensagem.MensagemDeExcessao(exception.Message, Page);
            }
        }

        protected void LkbVoltar_Click(object sender, EventArgs e)
        {
            RedirecionaParaTelaDeConsulta();
        }

        private void CarregaDadosDaSessao()
        {
            if (Session["IdInformativo"] != null)
            {
                ViewState.Add("IdInformativo", Session["IdInformativo"]);
                Session.Clear();

                var idInformativo = Convert.ToInt32(ViewState["IdInformativo"]);
                var funcionario = _informativoControl.ObterInformativosPorId(idInformativo);

                txtTitulo.Text = funcionario.Titulo;
                txtObservacao.Value = funcionario.Descricao;
            }
        }

        protected void btnInserir_OnClick(object sender, EventArgs e)
        {
            try
            {
                var informativo = new Model.Informativo
                {
                    Funcionario = { Id = 1 },
                    Titulo = txtTitulo.Text,
                    Descricao = txtObservacao.Value
                };

                if (myFileUpload.PostedFile.ContentLength > 0)
                {
                    informativo.TipoDocumento = Path.GetExtension(myFileUpload.Value);
                    informativo.Documento = ConverteArquivo.ParaByte(myFileUpload.PostedFile.InputStream);
                }

                informativo.ValidaDados();

                if (ViewState["IdInformativo"] == null)
                {
                    _informativoControl.InserirInformativo(informativo);
                }
                else
                {
                    informativo.Id = Convert.ToInt32(ViewState["IdInformativo"]);
                    _informativoControl.AtualizarInformativo(informativo);
                }

                RedirecionaParaTelaDeConsulta();
            }
            catch (Exception exception)
            {
                _mensagem.MensagemDeExcessao(exception.Message, Page);
            }
        }

        private void RedirecionaParaTelaDeConsulta()
        {
            Response.Redirect("~/Pages/Sindico/Informativo/ConsultarInformativo.aspx", false);
        }
    }
}