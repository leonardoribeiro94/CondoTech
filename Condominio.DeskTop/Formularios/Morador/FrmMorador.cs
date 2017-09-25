using Condominio.DeskTop.Componentes;
using Controller;
using Model.Enum;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.Morador
{
    public partial class FrmMorador : Form
    {
        public FrmMorador()
        {
            InitializeComponent();
        }

        private readonly MoradorController _moradorController = new MoradorController();


        private void FrmMorador_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaGridViewMorador();
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txtNomeConsulta.Text;
                var nascimento = Convert.ToDateTime(txtDataNascimentoConsulta.Text);
                dgvMorador.DataSource = _moradorController.ObterMorador(nome, nascimento);
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void btnInserirMorador_Click(object sender, EventArgs e)
        {
            try
            {
                var morador = new Model.Morador();

                morador.Nome = txtNomeMorador.Text.ToUpper();
                morador.DataDeNascimento = Convert.ToDateTime(txtDataNascimentoMorador.Text);
                morador.Cpf = txtCpfMorador.Text.Replace("-", "");
                morador.Telefone = txtTelefoneFixoMorador.Text;
                morador.Celular = txtTelefoneCelularMorador.Text;
                morador.Email = txtEmailMorador.Text.ToUpper();
                morador.EntidadeAtiva = EntidadeAtiva.Ativo;

                morador.ValidaDados();

                _moradorController.InserirMorador(morador);

                CaixaDeMensagem.MensagemDeSucesso($"Morador inserido com sucesso! \n Usuario: {morador.Cpf} Senha: morador@123");
                CarregaGridViewMorador();
                LimparCampos();
                tblCtrlMorador.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }

        }

        private void btnAtualizarMorador_Click(object sender, EventArgs e)
        {
            try
            {
                var morador = new Model.Morador
                {
                    Id = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text.ToUpper()),
                    Nome = txtNomeMorador.Text.ToUpper(),
                    DataDeNascimento = Convert.ToDateTime(txtDataNascimentoMorador.Text),
                    Cpf = txtCpfMorador.Text.Replace("-", ""),
                    Telefone = txtTelefoneFixoMorador.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                    Celular = txtTelefoneCelularMorador.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                    Email = txtEmailMorador.Text.ToUpper(),
                    EntidadeAtiva = EntidadeAtiva.Ativo
                };

                morador.ValidaDados();
                _moradorController.AlterarMorador(morador);
                CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistemaDesktop.Sucesso);

                LimparCampos();
                CarregaGridViewMorador();
                tblCtrlMorador.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void btnExcluirMorador_Click(object sender, EventArgs e)
        {
            try
            {
                var opcaoMensagem = CaixaDeMensagem.MensagemDeQuestao($"Deseja excluir {txtNomeMorador.Text}?");

                if (opcaoMensagem == DialogResult.OK)
                {
                    var codigoMorador = Convert.ToInt32(txtCodigo.Text);
                    _moradorController.ExcluirMorador(codigoMorador);
                    CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistemaDesktop.Sucesso);

                    LimparCampos();
                    CarregaGridViewMorador();
                    tblCtrlMorador.SelectedIndex = 0;
                }
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
                var nome = txtNomeConsulta.Text;
                dgvMorador.DataSource = _moradorController.ObterMorador(nome);
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void dgvMorador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMorador.CurrentRow != null)
                {
                    txtCodigo.Text = dgvMorador.CurrentRow.Cells[0].Value.ToString();
                    txtNomeMorador.Text = dgvMorador.CurrentRow.Cells[1].Value.ToString();
                    txtDataNascimentoMorador.Text = dgvMorador.CurrentRow.Cells[2].Value.ToString();
                    txtTelefoneFixoMorador.Text = dgvMorador.CurrentRow.Cells[3].Value.ToString();
                    txtTelefoneCelularMorador.Text = dgvMorador.CurrentRow.Cells[4].Value.ToString();
                    txtEmailMorador.Text = dgvMorador.CurrentRow.Cells[5].Value.ToString();
                    txtCpfMorador.Text = dgvMorador.CurrentRow.Cells[6].Value.ToString();
                    tblCtrlMorador.SelectedIndex = 1;

                    btnInserirMorador.Enabled = false;
                    btnAtualizarMorador.Enabled = true;
                    btnExcluirMorador.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void tblCtrlMorador_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnInserirMorador.Enabled = true;
            btnAtualizarMorador.Enabled = false;
            btnExcluirMorador.Enabled = false;
        }

        #region Metodos 

        private void CarregaGridViewMorador()
        {
            dgvMorador.DataSource = _moradorController.ObterMorador().ToList();
            ConfiguraDataGrid();
        }

        public void ConfiguraDataGrid()
        {
            dgvMorador.Columns[0].HeaderText = @"Código";
            dgvMorador.Columns[1].HeaderText = @"Nome";
            dgvMorador.Columns[2].HeaderText = @"Nascimento";
            dgvMorador.Columns[3].HeaderText = @"Telefone";
            dgvMorador.Columns[4].HeaderText = @"Celular";
            dgvMorador.Columns[5].HeaderText = @"E-mail";
            dgvMorador.Columns[6].HeaderText = @"CPF";
            dgvMorador.Columns[7].HeaderText = @"Status";
        }

        private void LimparCampos()
        {

            LimparControles.Limpar(grpPesquisa);
            LimparControles.Limpar(groupBoxCadastrar);
        }

        #endregion
    }
}
