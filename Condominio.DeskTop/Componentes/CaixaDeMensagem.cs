using System.Windows.Forms;

namespace Condominio.DeskTop.Componentes
{
    public static class CaixaDeMensagem
    {
        public static void MensagemDeSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, MensagensDoSistemaDesktop.Sucesso, MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        public static void MensagemDeAlerta(string mensagem)
        {
            MessageBox.Show(mensagem, MensagensDoSistemaDesktop.Atencao, MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        public static void MensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, MensagensDoSistemaDesktop.Erro, MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static DialogResult MensagemDeQuestao(string mensagem)
        {
            return MessageBox.Show(mensagem, MensagensDoSistemaDesktop.Questao,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
