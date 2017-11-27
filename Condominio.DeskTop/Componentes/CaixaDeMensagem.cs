using Condominio.CrossCutting.Resources;
using System.Windows.Forms;

namespace Condominio.DeskTop.Componentes
{
    public static class CaixaDeMensagem
    {
        public static void MensagemDeSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, MensagensDoSistema.Sucesso, MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        public static void MensagemDeAlerta(string mensagem)
        {
            MessageBox.Show(mensagem, MensagensDoSistema.Atencao, MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        public static void MensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, MensagensDoSistema.Erro, MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static DialogResult MensagemDeQuestao(string mensagem)
        {
            return MessageBox.Show(mensagem, MensagensDoSistema.Questao,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
