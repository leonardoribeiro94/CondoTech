using Condominio.DeskTop.Componentes;
using Controller;
using Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.Senha.RecuperacaoSenha
{
    public partial class FrmRecuperaSenha : Form
    {
        private readonly UsuarioFuncionarioController _usuarioFuncionarioCtrl;

        public FrmRecuperaSenha()
        {
            InitializeComponent();
            _usuarioFuncionarioCtrl = new UsuarioFuncionarioController();
        }
        private void FrmRecuperaSenha_Load(object sender, EventArgs e)
        {
            txtCpf.Focus();
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                var cpf = txtCpf.Text.Replace("-", "");
                var usuario = _usuarioFuncionarioCtrl.ObterPorCpfUsuarioFuncionarios(cpf).FirstOrDefault();

                if (usuario != null)
                {
                    var usuarioFuncionario = new UsuarioFuncionario
                    {
                        Id = usuario.IdUsuario,
                        Senha = Guid.NewGuid().ToString()
                    };

                    _usuarioFuncionarioCtrl.AlterarUsuario(usuarioFuncionario);
                    EnviarEmail(cpf, usuario.Nome, usuarioFuncionario.Senha, usuario.Email);

                    CaixaDeMensagem.MensagemDeSucesso("Sua senha foi alterada!, Verifique seu Email cadastrado e tente novamente!");
                    Close();
                }
                else
                {
                    CaixaDeMensagem.MensagemDeSucesso("Não Encontrado! \n Não foi possível encontrar um usuário com o cpf informado, " +
                        "procure um responsável pelo cadastro de funcionários ou tente novamente!");
                }
            }
            catch (Exception exception)
            {
                CaixaDeMensagem.MensagemDeErro(exception.Message);
            }
        }



        private static void EnviarEmail(string cpf, string nome, string novaSenha, string email)
        {
            var funcionario = new Funcionario();
            var cpfValido = funcionario.ValidaCpf(cpf);

            if (cpfValido)
            {
                var conteudoEmail =
                    $"Olá {nome}, Sua senha foi alterada para: <b>{novaSenha}</b>" +
                    "<br/>" +
                    "<b>Atenção! Caso não tenha solicitado a recuperação de senha, Ligue para o responsável pelo sistema Imediatamente!<b>";

                ServicoDeEmail.EnviaEmail(email, "Recuperação de Senha CondoTech", conteudoEmail);
            }
            else
            {
                CaixaDeMensagem.MensagemDeAlerta("CPF INVÁLIDO!");
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnRecuperarSenha_Click(null, null);
            }
        }
    }
}
