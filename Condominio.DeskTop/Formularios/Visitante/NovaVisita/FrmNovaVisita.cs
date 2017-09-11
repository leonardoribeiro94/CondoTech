using Condominio.DeskTop.Componentes;
using Controller;
using Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.Visitante.NovaVisita
{
    public partial class FrmNovaVisita : Form
    {
        private readonly HistoricoVisitaController _historicoVisitaController = new HistoricoVisitaController();

        public FrmNovaVisita()
        {
            InitializeComponent();
        }

        private void FrmNovaVisita_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaDataGrid();
                CarregaComboBoxMorador();
                CarregaComboBoxVisitante();


                txtEntrada.Text = DateTime.Now.ToString();
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
                var valor = txtNomeConsulta.Text.ToLower();
                dgvNovaVisita.DataSource = _historicoVisitaController.ObterHistoricoVisitas()
                    .Where(x => x.Visitante.ToLower().Contains(valor)).ToList();
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void tblCtrlVisitante_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            btnInserir.Enabled = true;
            btnAtualizar.Enabled = false;

            cmbMorador.Enabled = true;
            cmbVisitante.Enabled = true;

            txtEntrada.Text = DateTime.Now.ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var historicoVisita = new HistoricoVisita
                {
                    Descricao = txtDescricao.Text,
                    IdMorador = Convert.ToInt32(cmbMorador.SelectedValue),
                    IdVisitante = Convert.ToInt32(cmbVisitante.SelectedValue),
                    DataEntrada = Convert.ToDateTime(txtEntrada.Text)
                };

                historicoVisita.DataSaida = string.IsNullOrWhiteSpace(txtSaida.Text.Replace("/", "").Replace(":", "").Trim())
                    ? historicoVisita.DataSaida : Convert.ToDateTime(txtSaida.Text);

                _historicoVisitaController.InserirHistoricoVisita(historicoVisita);
                LimpaCampos();
                CarregaDataGrid();
                tblCtrlNovaVisita.SelectedIndex = 0;
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
                var historicoVisita = new HistoricoVisita
                {
                    IdHistoricoVisita = Convert.ToInt32(txtCodigo.Text),
                    Descricao = txtDescricao.Text,
                    IdMorador = Convert.ToInt32(cmbMorador.SelectedValue),
                    IdVisitante = Convert.ToInt32(cmbVisitante.SelectedValue),
                    DataEntrada = Convert.ToDateTime(txtEntrada.Text)
                };

                historicoVisita.DataSaida = string.IsNullOrWhiteSpace(txtSaida.Text.Replace("/", "").Replace(":", "").Trim())
                    ? historicoVisita.DataSaida : Convert.ToDateTime(txtSaida.Text);

                _historicoVisitaController.AlterarHistoricoVisita(historicoVisita);

                LimpaCampos();
                CarregaDataGrid();
                tblCtrlNovaVisita.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        private void dgvNovaVisita_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNovaVisita.CurrentRow != null)
                {
                    txtCodigo.Text = dgvNovaVisita.CurrentRow.Cells[0].Value.ToString();
                    cmbMorador.SelectedValue = dgvNovaVisita.CurrentRow.Cells[1].Value;

                    cmbMorador.Enabled = false;
                    cmbVisitante.SelectedValue = dgvNovaVisita.CurrentRow.Cells[2].Value;

                    cmbVisitante.Enabled = false;
                    txtEntrada.Text = dgvNovaVisita.CurrentRow.Cells[5].Value.ToString();

                    txtSaida.Text = Convert.ToString(dgvNovaVisita.CurrentRow.Cells[6].Value);
                    txtDescricao.Text = dgvNovaVisita.CurrentRow.Cells[7].Value.ToString();

                    tblCtrlNovaVisita.SelectedIndex = 1;
                    btnInserir.Enabled = false;
                    btnAtualizar.Enabled = true;
                }


            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }

        #region Metodos
        private void CarregaComboBoxMorador()
        {
            var moradorCtrl = new MoradorController();
            cmbMorador.DataSource = moradorCtrl.ObterMorador().OrderBy(x => x.Nome).ToList();
            cmbMorador.ValueMember = "IdMorador";
            cmbMorador.DisplayMember = "Nome";
        }

        private void CarregaComboBoxVisitante()
        {
            var visitanteCtrl = new VisitanteController();

            cmbVisitante.DataSource = visitanteCtrl.ObterVisitantes().OrderBy(x => x.Nome).ToList();
            cmbVisitante.ValueMember = "IdVisitante";
            cmbVisitante.DisplayMember = "Nome";
        }

        private void CarregaDataGrid()
        {
            var lista = _historicoVisitaController.ObterHistoricoVisitas().ToList();

            dgvNovaVisita.DataSource = lista;

            dgvNovaVisita.Columns[0].HeaderText = @"Código";
            dgvNovaVisita.Columns[1].Visible = false;
            dgvNovaVisita.Columns[2].Visible = false;
            dgvNovaVisita.Columns[5].HeaderText = @"Horário de Entrada";
            dgvNovaVisita.Columns[6].HeaderText = @"Horário de Saída";
            dgvNovaVisita.Columns[7].HeaderText = @"Descrição";
        }

        private void LimpaCampos()
        {
            LimparControles.Limpar(groupBoxCadastrar);
        }
        #endregion


    }
}
