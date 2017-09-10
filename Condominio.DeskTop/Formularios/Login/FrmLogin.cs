using Condominio.DeskTop.Componentes;
using Condominio.DeskTop.Formularios.MasterPage;
using System;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Posições dos formularios

        private bool _drag;
        private int _mousex;
        private int _mousey;

        #endregion

        #region Eventos do Formulario

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drag)
            {
                Top = Cursor.Position.Y - _mousey;
                Left = Cursor.Position.X - _mousex;
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            _drag = true;
            _mousey = Cursor.Position.Y - Top;
            _mousex = Cursor.Position.X - Left;
        }

        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            _drag = false;
        }

        private void lblSair_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, System.EventArgs e)
        {
            txtLogin.Select();
        }

        #endregion

        private void picAjuda_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(@"Ajuda");
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                var login = txtLogin.Text;
                var senha = txtSenha.Text;

                if (login == "admin" && senha == "admin")
                {
                    Hide();
                    var frmMasterPage = new FrmMaster();
                    frmMasterPage.Show();
                }

                else
                {
                    CaixaDeMensagem.MensagemDeErro("Erro de autenticação");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
