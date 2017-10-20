using System;
using System.Web.UI;

namespace Condominio.Web.Components
{
    public class Mensagens
    {
        public void MensagemDeExcessao(string excessao, Control nomeDoFormulario)
        =>
            ScriptManager.RegisterClientScriptBlock(nomeDoFormulario.Page, GetType(), "modalExcessao",
                "fn_ModalError(\" " + excessao.Replace("\'", string.Empty)
                .Replace(Environment.NewLine, string.Empty) + "\");", true);
    }
}