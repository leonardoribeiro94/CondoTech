using Condominio.DeskTop.Componentes;
using Controller;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.Informativo
{
    public partial class FrmInformativo : Form
    {
        private readonly int _idFuncionario;
        private readonly InformativoController _informativoController;

        public FrmInformativo(int idFuncionario)
        {
            InitializeComponent();

            _idFuncionario = idFuncionario;
            _informativoController = new InformativoController();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var informativo = new Model.Informativo
                {
                    Funcionario = { Id = _idFuncionario },
                    Titulo = txtTitulo.Text,
                    Descricao = txtDescricao.Text
                };

                _informativoController.InserirInformativo(informativo);

                LimparCampos();
                CarregaGridView();
                tblCtrlInformativo.SelectedIndex = 0;
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
                var informativo = new Model.Informativo
                {
                    Id = Convert.ToInt32(txtCodigo.Text),
                    Titulo = txtTitulo.Text,
                    Descricao = txtDescricao.Text
                };

                _informativoController.AtualizarInformativo(informativo);

                LimparCampos();
                CarregaGridView();
                tblCtrlInformativo.SelectedIndex = 0;
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
                var idInformativo = Convert.ToInt32(txtCodigo.Text);
                _informativoController.DeletarInformativo(idInformativo);
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void dgvInformativo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvInformativo.CurrentRow != null)
                {
                    txtCodigo.Text = dgvInformativo.CurrentRow.Cells[0].Value.ToString();
                    txtTitulo.Text = dgvInformativo.CurrentRow.Cells[3].Value.ToString();
                    txtDescricao.Text = dgvInformativo.CurrentRow.Cells[4].Value.ToString();

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

        private void tblCtrlInformativo_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void txtConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            var texto = txtConsulta.Text;
            dgvInformativo.DataSource = _informativoController.ObterInformativos()
                .Where(x => x.Titulo.ToLower().Contains(texto)).ToList();
        }

        #region Metodos

        public void CarregaGridView()
        {
            dgvInformativo.DataSource = _informativoController.ObterInformativos().ToList();
        }

        private void LimparCampos()
        {
            LimparControles.Limpar(groupBoxCadastrar);
        }

        #endregion
    }
}
