using System;
using Condominio.Model.Enum;

namespace Condominio.Model
{
    public abstract class Usuario : Entidade
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public EntidadeAtiva EntidadeAtiva { get; set; }
        public SenhaTemporaria SenhaTemporaria { get; set; }

        public void ConfirmaSenha(string novaSenha, string confirmarSenha)
        {
            if (!string.Equals(novaSenha, confirmarSenha))
            {
                throw new Exception("As senhas informadas não coincidem!");
            }

        }

        public void ValidaSenhaAntiga(string senhaAntiga, string senhaDoBanco)
        {
            if (!string.Equals(senhaAntiga, senhaDoBanco))
            {
                throw new Exception("A senha anterior informada não existe  na base de dados!");
            }
        }
    }
}
