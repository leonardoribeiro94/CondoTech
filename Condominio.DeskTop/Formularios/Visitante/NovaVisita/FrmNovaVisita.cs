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

        }

        private void tblCtrlVisitante_Click(object sender, EventArgs e)
        {

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
        }

        private void LimpaCampos()
        {
            LimparControles.Limpar(groupBoxCadastrar);
        }
        #endregion

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var historicoVisita = new HistoricoVisita();
                historicoVisita.IdMorador = Convert.ToInt32(cmbMorador.SelectedValue);
                historicoVisita.IdVisitante = Convert.ToInt32(cmbVisitante.SelectedValue);
                historicoVisita.DataEntrada = Convert.ToDateTime(txtEntrada.Text);
                historicoVisita.DataSaida = Convert.ToDateTime(txtSaida.Text);
                historicoVisita.Descricao = txtDescricao.Text;

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
    }
}
