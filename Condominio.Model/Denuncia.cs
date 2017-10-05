using System;
using Condominio.Model.Enum;

namespace Condominio.Model
{
    public class Denuncia : Entidade
    {
        #region Propriedades

        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public byte[] Imagem { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDenuncia { get; set; }
        public EntidadeAtiva Ativo { get; set; }
        public bool Anonimo { get; }

        #endregion

        #region Metodos
        public void ValidaDados()
        {
            Descricao = Descricao.ToUpper();

            if (Descricao.Length < 5)
            {
                throw new Exception("A quantidade de caracteres informados na descrição é inválida!");
            }


        }

        private string ValidaCelular(string celular)
        {
            string newCel = null;

            if (Celular.Length == 11)
            {
                newCel = celular.Replace("(", "").Replace(")", "").Replace("-", "");
            }

            return newCel;
        }

        #endregion
    }
}
