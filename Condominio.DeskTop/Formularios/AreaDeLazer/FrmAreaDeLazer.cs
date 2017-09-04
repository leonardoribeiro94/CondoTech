using Condominio.DeskTop.Componentes;
using Controller;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.AreaDeLazer
{
    public partial class FrmAreaDeLazer : Form
    {
        public FrmAreaDeLazer()
        {
            InitializeComponent();
        }

        private readonly AreaDeLazerController _areaDeLazerCtrl = new AreaDeLazerController();

        private void FrmAreaDeLazer_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaGridAreaDeLazer();
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void btnExibirImagem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var nomeDoArquivo = openFileDialog1.FileName;
                    var imagemBitMap = new Bitmap(nomeDoArquivo);

                    picAreaDeLazer.Image = imagemBitMap;
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro("Verifique se o arquivo escolhido é realmente uma imagem \n Erro:" + exception.Message);
            }
        }

        private void btnInserirMorador_Click(object sender, EventArgs e)
        {
            try
            {
                var areaDeLazer = new Model.AreaDeLazer();
                areaDeLazer.Imagem = ConverteArquivoDeImagem(openFileDialog1.FileName);
                areaDeLazer.Nome = txtNome.Text;
                areaDeLazer.Descricao = txtDescricao.Text;

                areaDeLazer.ValidaDados();
                _areaDeLazerCtrl.InserirAreaDeLazer(areaDeLazer);

            }

            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        #region Metodos
        public byte[] ConverteArquivoDeImagem(string nomeArquivo)
        {
            var arquivo = new Bitmap(nomeArquivo);
            var memoryStream = new MemoryStream();
            arquivo.Save(memoryStream, ImageFormat.Bmp);
            var foto = memoryStream.ToArray();
            return foto;
        }

        public void CarregaGridAreaDeLazer()
        {
            dgvAreaDeLazer.DataSource = _areaDeLazerCtrl.ObterAreaDeLazer().ToList();

        }
        #endregion


    }
}
