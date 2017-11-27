using Condominio.Model.Enum;
using System;

namespace Condominio.Model.QueryModel
{
    public class QueryDenuncia
    {
        #region Propriedades

        public int IdDenuncia { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public byte[] Imagem { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDenuncia { get; set; }
        public EntidadeAtiva Ativo { get; set; }
        public bool Anonimo { get; }

        #endregion
    }
}
