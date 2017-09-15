using Condominio.DeskTop.Componentes;
using Controller;
using System;
using System.Drawing;
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

        private void btnExibirImagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var nomeDoArquivo = openFileDialog.FileName;
                    var imagemBitMap = new Bitmap(nomeDoArquivo);
                    picAreaDeLazer.Image = imagemBitMap;
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro($"{MensagensDoSistemaDesktop.ImagemInvalida} \n Erro:" + exception.Message);
            }
        }

        private void btnInserirMorador_Click(object sender, EventArgs e)
        {
            try
            {
                var areaDeLazer = new Model.AreaDeLazer
                {
                    Imagem = ObterArray.PictureBox(picAreaDeLazer),
                    Nome = txtNome.Text.ToUpper().Trim(),
                    Descricao = txtDescricao.Text.ToUpper().Trim()
                };

                areaDeLazer.ValidaDados();
                _areaDeLazerCtrl.InserirAreaDeLazer(areaDeLazer);

                LimpaCampos();
                CarregaGridAreaDeLazer();
                tblCtrlAreaDeLazer.SelectedIndex = 0;
            }

            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void btnExcluirAreaDeLazer_Click(object sender, EventArgs e)
        {
            try
            {
                var idAreaDeLazer = Convert.ToInt32(txtCodigo.Text);

                var opcao = CaixaDeMensagem.MensagemDeQuestao(MensagensDoSistemaDesktop.Questao);

                if (opcao == DialogResult.OK)
                {
                    _areaDeLazerCtrl.DeletarAreaDeLazer(idAreaDeLazer);

                    LimpaCampos();
                    CarregaGridAreaDeLazer();
                    tblCtrlAreaDeLazer.SelectedIndex = 0;
                }

            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void dgvAreaDeLazer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAreaDeLazer.CurrentRow != null)
                {
                    var bytedaImagem = (byte[])dgvAreaDeLazer.CurrentRow.Cells[1].Value;
                    var foto = new MemoryStream(bytedaImagem);

                    picAreaDeLazer.Image = Image.FromStream(foto);
                    txtCodigo.Text = dgvAreaDeLazer.CurrentRow.Cells[0].Value.ToString();
                    txtNome.Text = dgvAreaDeLazer.CurrentRow.Cells[2].Value.ToString();
                    txtDescricao.Text = dgvAreaDeLazer.CurrentRow.Cells[3].Value.ToString();
                    tblCtrlAreaDeLazer.SelectedIndex = 1;
                    btnInserirAreaDeLazer.Enabled = false;
                    btnAtualizarAreaDeLazer.Enabled = true;
                    btnExcluirAreaDeLazer.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void tblCtrlAreaDeLazer_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            btnInserirAreaDeLazer.Enabled = true;
            btnAtualizarAreaDeLazer.Enabled = false;
            btnExcluirAreaDeLazer.Enabled = false;
        }

        private void btnAtualizarAreaDeLazer_Click(object sender, EventArgs e)
        {
            try
            {
                var areaDeLazer = new Model.AreaDeLazer();
                areaDeLazer.IdAreaDeLazer = Convert.ToInt32(txtCodigo.Text);
                areaDeLazer.Nome = txtNome.Text;
                areaDeLazer.Descricao = txtDescricao.Text;
                areaDeLazer.Imagem = ObterArray.PictureBox(picAreaDeLazer);
                _areaDeLazerCtrl.AlterarAreaDeLazer(areaDeLazer);
                CarregaGridAreaDeLazer();
                tblCtrlAreaDeLazer.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void txtNomeConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var nomeValor = txtNomeConsulta.Text.ToLower();
                var listaFiltro = _areaDeLazerCtrl.ObterAreaDeLazer()
                    .Where(x => x.Nome.ToLower().Contains(nomeValor)).ToList();

                dgvAreaDeLazer.DataSource = listaFiltro;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        #region Metodos

        public void CarregaGridAreaDeLazer()
        {
            dgvAreaDeLazer.DataSource = _areaDeLazerCtrl.ObterAreaDeLazer().ToList();

            dgvAreaDeLazer.Columns[0].HeaderText = @"Código";
            dgvAreaDeLazer.Columns[1].HeaderText = @"Imagem";
            dgvAreaDeLazer.Columns[1].Visible = false;
            dgvAreaDeLazer.Columns[2].HeaderText = @"Nome";
            dgvAreaDeLazer.Columns[3].HeaderText = @"Descrição";
            dgvAreaDeLazer.Columns[4].HeaderText = @"Ativo";

        }

        public void LimpaCampos()
        {
            picAreaDeLazer.Image = Image.FromFile(@"C:\dev\CondoTech\Condominio.DeskTop\Resources\picture-2.png");
            LimparControles.Limpar(groupBoxCadastrar);
            LimparControles.Limpar(groupBoxDadosAreaDeLazer);
        }

        #endregion
    }
}
