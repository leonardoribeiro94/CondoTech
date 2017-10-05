using Condominio.Controllers;
using Condominio.DeskTop.Componentes;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;


namespace Condominio.DeskTop.Formularios.Visitante
{
    public partial class FrmVisitante : Form
    {
        private readonly VisitanteControl _visitanteController = new VisitanteControl();

        public FrmVisitante()
        {
            InitializeComponent();
        }

        private void FrmVisitante_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaDataGrid();
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void btnInserirAreaDeLazer_Click(object sender, EventArgs e)
        {
            try
            {
                var visitante = new Model.Visitante
                {
                    Imagem = ObterArray.PictureBox(picVisitante),
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    Celular = txtCelular.Text,
                    Telefone = txtTelefoneFixo.Text
                };

                visitante.ValidaImagem();
                visitante.ValidaDados();
                _visitanteController.InserirVisitante(visitante);
                CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistemaDesktop.Sucesso);

                LimparCampos();
                CarregaDataGrid();
                tblCtrlVisitante.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void btnAtualizarAreaDeLazer_Click(object sender, EventArgs e)
        {
            try
            {
                var visitante = new Model.Visitante();
                visitante.Imagem = ObterArray.PictureBox(picVisitante);
                visitante.Id = Convert.ToInt32(txtCodigo.Text);
                visitante.Nome = txtNome.Text;
                visitante.Cpf = txtCpf.Text;
                visitante.Email = txtEmail.Text;
                visitante.Celular = txtCelular.Text;
                visitante.Telefone = txtTelefoneFixo.Text;

                visitante.ValidaImagem();
                visitante.ValidaDados();
                _visitanteController.AlterarVisitante(visitante);
                CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistemaDesktop.Sucesso);

                LimparCampos();
                CarregaDataGrid();
                tblCtrlVisitante.SelectedIndex = 0;
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
                var opcao = CaixaDeMensagem.MensagemDeQuestao(MensagensDoSistemaDesktop.Questao);

                if (opcao == DialogResult.OK)
                {
                    var idVisitante = Convert.ToInt32(txtCodigo.Text);
                    _visitanteController.DeletarVisitante(idVisitante);
                    CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistemaDesktop.Sucesso);

                    LimparCampos();
                    CarregaDataGrid();
                    tblCtrlVisitante.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void tblCtrlAreaDeLazer_Click(object sender, EventArgs e)
        {
            LimparCampos();

            btnInserir.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExibirImagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileVisitante.ShowDialog() == DialogResult.OK)
                {
                    var nomeDoArquivo = openFileVisitante.FileName;
                    var imagemBitMap = new Bitmap(nomeDoArquivo);
                    picVisitante.Image = imagemBitMap;
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro("Verifique se o arquivo escolhido é realmente uma imagem \n Erro:" + exception.Message);
            }
        }

        private void txtNomeConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var nomeValor = txtNomeConsulta.Text.ToLower();

                var lista = _visitanteController.ObterVisitantes()
                             .Where(x => x.Nome.ToLower().Contains(nomeValor)).ToList();

                dgvVisitante.DataSource = lista;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void dgvVisitante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvVisitante.CurrentRow != null)
                {
                    var bytedaImagem = (byte[])dgvVisitante.CurrentRow.Cells[1].Value;
                    var foto = new MemoryStream(bytedaImagem);

                    picVisitante.Image = Image.FromStream(foto);
                    txtCodigo.Text = dgvVisitante.CurrentRow.Cells[0].Value.ToString();
                    txtNome.Text = dgvVisitante.CurrentRow.Cells[2].Value.ToString();
                    txtCpf.Text = dgvVisitante.CurrentRow.Cells[3].Value.ToString();
                    txtEmail.Text = dgvVisitante.CurrentRow.Cells[4].Value.ToString();
                    txtCelular.Text = dgvVisitante.CurrentRow.Cells[5].Value.ToString();
                    txtTelefoneFixo.Text = dgvVisitante.CurrentRow.Cells[6].Value.ToString();

                    tblCtrlVisitante.SelectedIndex = 1;
                    btnInserir.Enabled = false;
                    btnAtualizar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        #region Metodos

        private void CarregaDataGrid()
        {
            var lista = _visitanteController.ObterVisitantes().ToList();
            dgvVisitante.DataSource = lista;

            dgvVisitante.Columns[0].HeaderText = @"Código";
            dgvVisitante.Columns[1].HeaderText = @"Imagem";
            dgvVisitante.Columns[1].Visible = false;
        }

        private void LimparCampos()
        {
            try
            {
                picVisitante.Image = Image.FromFile(@"../PictureImages/users.png");
                LimparControles.Limpar(groupBoxDados);
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }

        }


        #endregion

    }
}
