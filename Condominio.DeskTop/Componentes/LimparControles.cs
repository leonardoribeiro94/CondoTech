using System.Windows.Forms;

namespace Condominio.DeskTop.Componentes
{
    internal static class LimparControles
    {
        public static void Limpar(Control controles)
        {
            foreach (var tipoDeControle in controles.Controls)
            {
                if (tipoDeControle is TextBox)
                {
                    ((TextBox)tipoDeControle).Text = string.Empty;
                }

                else if (tipoDeControle is MaskedTextBox)
                {
                    ((MaskedTextBox)tipoDeControle).Text = string.Empty;
                }
            }
        }
    }
}
