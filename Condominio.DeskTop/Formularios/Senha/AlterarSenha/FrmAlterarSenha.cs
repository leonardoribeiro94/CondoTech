using Condominio.Controllers;
using Condominio.CrossCutting.Resources;
using Condominio.DeskTop.Componentes;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.Senha.AlterarSenha
{
    public partial class FrmAlterarSenha : Form
    {
        private readonly QueryUsuarioFuncionario _obterUsuarioFuncionario;

        public FrmAlterarSenha(QueryUsuarioFuncionario obterUsuarioFuncionario)
        {
            InitializeComponent();

            _obterUsuarioFuncionario = obterUsuarioFuncionario;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuarioFuncionarioCtrl = new UsuarioFuncionarioControl();
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
                CaixaDeMensagem.MensagemDeSucesso(MensagensDoSistema.Sucesso);

                Hide();
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }
    }
}
