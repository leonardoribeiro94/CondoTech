using Condominio.DeskTop.Componentes;
using Controller;
using Model;
using Model.QueryModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.AlterarSenha
{
    public partial class FrmAlterarSenha : Form
    {
        private readonly ObterUsuarioFuncionario _obterUsuarioFuncionario;

        public FrmAlterarSenha(ObterUsuarioFuncionario obterUsuarioFuncionario)
        {
            InitializeComponent();

            _obterUsuarioFuncionario = obterUsuarioFuncionario;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuarioFuncionarioCtrl = new UsuarioFuncionarioController();
                var usuarioFuncionario = new UsuarioFuncionario();

                var senhaAntiga = txtSenhaAnterior.Text;
                var novaSenha = txtNovaSenha.Text;
                var confirmarSenha = txtConfirmarSenha.Text;

                var senhaDoBanco = usuarioFuncionarioCtrl.
                    ObterPorIdObterUsuarioFuncionarios(_obterUsuarioFuncionario.IdUsuario).Select(x => x.Senha).FirstOrDefault();

                usuarioFuncionario.ValidaSenhaAntiga(senhaAntiga, senhaDoBanco);
                usuarioFuncionario.ConfirmaSenha(novaSenha, confirmarSenha);

                usuarioFuncionario.Id = _obterUsuarioFuncionario.IdUsuario;
                usuarioFuncionario.Senha = novaSenha;
                usuarioFuncionarioCtrl.AlterarUsuario(usuarioFuncionario);
                CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistemaDesktop.Sucesso);

                Hide();
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }
    }
}
