using Condominio.DeskTop.Componentes;
using Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.Denuncia
{
    public partial class FrmDenuncia : Form
    {
        public FrmDenuncia()
        {
            InitializeComponent();
        }


        private void btnExibirImagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var nomeDoArquivo = openFileDialog1.FileName;
                    var imagemBitMap = new Bitmap(nomeDoArquivo);
                    picDenuncia.Image = imagemBitMap;
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro($"{MensagensDoSistemaDesktop.ImagemInvalida} \n Erro:" + exception.Message);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                var denuncia = new Model.Denuncia();
                var denunciaController = new DenunciaController();

                if (!ckbAnonimo.Checked)
                {
                    denuncia.Nome = txtNome.Text;
                    denuncia.Celular = txtCelular.Text;
                    denuncia.Email = txtEmail.Text;
                }

                denuncia.Descricao = txtDescricao.Text;
                denuncia.Imagem = ObterArray.PictureBox(picDenuncia);

                denuncia.ValidaDados();

                const string mensagem = "O conteúdo informado será enviado e análizado pelos administradores do condomínio. " +
                               "\n deseja continuar?";

                var opcao = CaixaDeMensagem.MensagemDeQuestao(mensagem);
                if (opcao == DialogResult.OK)
                {
                    denunciaController.InserirDenuncia(denuncia);
                    LimparCampos();
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void ckbAnonimo_Click(object sender, EventArgs e)
        {
            if (ckbAnonimo.Checked)
            {
                txtCelular.Enabled = false;
                txtNome.Enabled = false;
                txtEmail.Enabled = false;

                LimparCampos();
            }
            else
            {
                txtCelular.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
            }
        }

        private void LimparCampos()
        {
            LimparControles.Limpar(groupBoxDados);
        }
    }
}
