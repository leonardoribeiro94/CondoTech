using Condominio.Model.Enum;
using System;

namespace Condominio.Model.QueryModel
{
    public class QueryInformativo
    {
        public int IdInformativo { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public byte[] Documento { get; set; }
        public EntidadeAtiva Ativo { get; set; }
    }
}
