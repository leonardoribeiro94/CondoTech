using Condominio.DeskTop.Componentes;
using Condominio.DeskTop.Formularios.MasterPage;
using Condominio.DeskTop.Formularios.Senha.RecuperacaoSenha;
using Controller;
using Model.Enum;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.Login
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioFuncionarioController _usuarioFuncionarioCtrl;
        public FrmLogin()
        {
            InitializeComponent();
            _usuarioFuncionarioCtrl = new UsuarioFuncionarioController();
        }

        private void picAjuda_Click(object sender, EventArgs e)
        {
            CaixaDeMensagem.MensagemDeSucesso("Insira seu login e senha, em seguida clique no botão 'login' para prosseguir. " +
                                              "\n\n" +
                                              "Caso tenha esquecido sua senha clique no link 'Esqueceu sua senha?' para recuperá-la. " +
                                              "\n\n" +
                                              "Caso tenha dúvidas procure o responsável pelo sistema em seu condomínio!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var login = txtLogin.Text.Trim();
                var senha = txtSenha.Text.Trim();

                var dadosUsuario = _usuarioFuncionarioCtrl.ObterPorLoginFuncionariosUsuarios(login, senha).FirstOrDefault();

                if (dadosUsuario != null && dadosUsuario.Ativo != EntidadeAtiva.Inativo)
                {
                    Hide();
                    var frmMasterPage = new FrmMaster(dadosUsuario);
                    frmMasterPage.Show();
                }

                else
                {
                    CaixaDeMensagem.MensagemDeErro("Não foi possível realizar login," +
                                                   " verifique sua senha ou informe o Administrador do sistema");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void lblRecuperaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var frmRevuperaSenha = new FrmRecuperaSenha();
                frmRevuperaSenha.ShowDialog();
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(null, null);
            }
        }

        #region Fields de Posições dos formularios

        private bool _drag;
        private int _mousex;
        private int _mousey;

        #endregion

        #region Eventos do Formulario

        #region MÉTODOS DE MOVIMENTAÇÃO DO FORM DE LOGIN
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

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Select();
        }




        #endregion

        #endregion


    }
}
