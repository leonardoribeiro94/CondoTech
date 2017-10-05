using Condominio.Controllers;
using Condominio.DeskTop.Componentes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.Fornecedor
{
    public partial class FrmFornecedor : Form
    {
        private readonly FornecedorControl _fornecedorController = new FornecedorControl();

        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarFornecedores();
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeSucesso(exception.Message);
            }
        }

        private void btnInserirMorador_Click(object sender, EventArgs e)
        {
            try
            {
                var fornecedor = new Model.Fornecedor
                {
                    Nome = txtNome.Text,
                    Cnpj = txtCNPJ.Text,
                    Telefone = txtTelefoneFixo.Text,
                    TelefoneCelular = txtTelefoneCelular.Text,
                    Email = txtEmail.Text,
                    Descricao = txtDescricao.Text
                };

                fornecedor.ValidaDados();
                _fornecedorController.InserirFornecedor(fornecedor);
                CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistemaDesktop.Sucesso);
                LimparCampos();
                CarregarFornecedores();

                tblCtrlFornecedor.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var fornecedor = new Model.Fornecedor
                {
                    Id = Convert.ToInt32(txtCodigo.Text),
                    Nome = txtNome.Text,
                    Cnpj = txtCNPJ.Text,
                    Telefone = txtTelefoneFixo.Text,
                    TelefoneCelular = txtTelefoneCelular.Text,
                    Email = txtEmail.Text,
                    Descricao = txtDescricao.Text
                };

                fornecedor.ValidaDados();
                _fornecedorController.AlterarFornecedor(fornecedor);
                CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistemaDesktop.Sucesso);

                LimparCampos();
                CarregarFornecedores();
                tblCtrlFornecedor.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void tblCtrlFornecedor_Click(object sender, EventArgs e)
        {
            LimparCampos();

            btnInserir.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgvFornecedor.CurrentRow != null)
                {
                    txtCodigo.Text = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
                    txtNome.Text = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
                    txtCNPJ.Text = dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
                    txtTelefoneFixo.Text = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
                    txtTelefoneCelular.Text = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
                    txtEmail.Text = dgvFornecedor.CurrentRow.Cells[5].Value.ToString();
                    txtDescricao.Text = dgvFornecedor.CurrentRow.Cells[6].Value.ToString();

                    tblCtrlFornecedor.SelectedIndex = 1;

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var opcao = CaixaDeMensagem.MensagemDeQuestao(MensagensDoSistemaDesktop.Questao);

                if (opcao == DialogResult.OK)
                {
                    var idFornecedor = Convert.ToInt32(txtCodigo.Text);
                    _fornecedorController.ExcluirFornecedor(idFornecedor);
                    CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistemaDesktop.Sucesso);

                    LimparCampos();
                    CarregarFornecedores();
                    tblCtrlFornecedor.SelectedIndex = 0;
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
                var valorNome = txtNomeConsulta.Text.ToLower();
                var filtroLista = _fornecedorController.ObterFornecedores().Where(x => x.Nome.ToLower().Contains(valorNome)).ToList();

                dgvFornecedor.DataSource = filtroLista;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        #region Metodos
        private void CarregarFornecedores()
        {
            dgvFornecedor.DataSource = _fornecedorController.ObterFornecedores();

            dgvFornecedor.Columns[0].HeaderText = @"Código";
        }

        private void LimparCampos()
        {
            LimparControles.Limpar(groupBoxCadastrar);
        }

        #endregion
    }
}
