using Condominio.Controllers;
using Condominio.CrossCutting;
using Condominio.Web.Components;
using System;
using System.IO;
using System.Web.UI;

namespace Condominio.Web.Pages.Morador.Denuncia
{
    public partial class InserirDenuncia : Page
    {
        private readonly DenunciaControl _denunciaControl;
        private readonly Mensagens _mensagens;


        public InserirDenuncia()
        {
            _denunciaControl = new DenunciaControl();
            _mensagens = new Mensagens();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidaSessao.Morador(Page);
            }
        }

        protected void btnInserir_OnClick(object sender, EventArgs e)
        {
            try
            {
                var denuncia = new Model.Denuncia();

                if (!ckbAnonimo.Checked)
                {
                    denuncia.Nome = txtNome.Text;
                    denuncia.Celular = txtCelular.Text;
                    denuncia.Email = txtEmail.Text;
                }

                if (myFileUpload.PostedFile.ContentLength > 0)
                {
                    var fluxoDeArquivo = myFileUpload.PostedFile.InputStream;
                    var tipoConteudo = Path.GetExtension(myFileUpload.PostedFile.FileName);

                    denuncia.ValidaExtensaoDoAnexo(tipoConteudo);
                    denuncia.Imagem = ConverteArquivo.ParaByte(fluxoDeArquivo);
                }

                denuncia.Descricao = txtObservacao.Value;
                denuncia.ValidaDados();

                _denunciaControl.InserirDenuncia(denuncia);

                _mensagens.MensagemDeInformacao("<h4><b>Denuncia</b> enviada!</h4>", Page);
            }
            catch (Exception exception)
            {
                _mensagens.MensagemDeExcessao(exception.Message, Page);
            }
        }
    }
}