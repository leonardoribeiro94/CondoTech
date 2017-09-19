using Condominio.DeskTop.Formularios.AreaDeLazer;
using Condominio.DeskTop.Formularios.Denuncia;
using Condominio.DeskTop.Formularios.Fornecedor;
using Condominio.DeskTop.Formularios.Informativo;
using Condominio.DeskTop.Formularios.Login;
using Condominio.DeskTop.Formularios.Morador;
using Condominio.DeskTop.Formularios.Visitante;
using Condominio.DeskTop.Formularios.Visitante.NovaVisita;
using Model.QueryModel;
using System.Windows.Forms;
using Condominio.DeskTop.Formularios.Senha.AlterarSenha;

namespace Condominio.DeskTop.Formularios.MasterPage
{
    public partial class FrmMaster : Form
    {
        private readonly ObterUsuarioFuncionario _obterUsuarioFucnionario;

        public FrmMaster(ObterUsuarioFuncionario usuarioFuncionario)
        {
            InitializeComponent();

            ConfiguraAcesso(usuarioFuncionario.Cargo);
            toolStripStatusNome.Text = $@"USUARIO: {usuarioFuncionario.Nome}";
            toolStripStatusCargo.Text = $@"PERFIL: {usuarioFuncionario.Cargo}";

            _obterUsuarioFucnionario = usuarioFuncionario;
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var resultado = MessageBox.Show(@"Deseja sair da Aplicação?", @"Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                var frmLogin = new FrmLogin();
                frmLogin.Show();
            }
        }

        private void FrmMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void moradoresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmMorador = new FrmMorador { MdiParent = this };
            frmMorador.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmFornecedor = new FrmFornecedor() { MdiParent = this };
            frmFornecedor.Show();
        }

        private void áreaDeLazerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmAreaDeLazer = new FrmAreaDeLazer() { MdiParent = this };
            frmAreaDeLazer.Show();
        }

        private void visitantesToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var frmVisitante = new FrmVisitante { MdiParent = this };
            frmVisitante.Show();
        }

        private void novaVisitaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmNovaVisita = new FrmNovaVisita() { MdiParent = this };

            frmNovaVisita.Show();
        }

        private void senhaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmAlterarSenha = new FrmAlterarSenha(_obterUsuarioFucnionario) { MdiParent = this };

            frmAlterarSenha.Show();
        }

        private void informativoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmInformativo = new FrmInformativo(_obterUsuarioFucnionario.IdFuncionario) { MdiParent = this };
            frmInformativo.Show();
        }

        private void visitantesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmDenuncia = new FrmDenuncia { MdiParent = this };
            frmDenuncia.Show();
        }

        #region Metodos do formulario

        private void ConfiguraAcesso(string cargo)
        {

            if (cargo.ToLower().Equals("sindico"))
            {
                HabilitaItemsMenu();
            }

            else if (cargo.ToLower().Equals("porteiro"))
            {
                DesabilitaItemsMenu();
                visitantesTsmi.Enabled = true;
            }

            else if (cargo.ToLower().Equals("recepcionista"))
            {
                DesabilitaItemsMenu();
                moradoresToolStripMenuItem.Enabled = true;
                areaDeLazerToolStripMenuItem.Enabled = true;
            }

            else if (cargo.ToLower().Equals("zelador"))
            {
                HabilitaItemsMenu();
            }
        }

        private void HabilitaItemsMenu()
        {
            foreach (var item in menuStrip1.Items)
            {
                if (item is ToolStripMenuItem)
                {
                    ((ToolStripMenuItem)item).Enabled = true;
                }
            }
        }

        private void DesabilitaItemsMenu()
        {
            visitantesTsmi.Enabled = false;
            moradoresToolStripMenuItem.Enabled = false;
            areaDeLazerToolStripMenuItem.Enabled = false;
            fornecedorToolStripMenuItem.Enabled = false;
        }


        #endregion
    }
}
