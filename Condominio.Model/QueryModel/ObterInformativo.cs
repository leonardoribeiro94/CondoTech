using System;

namespace Condominio.Model.QueryModel
{
    public class ObterInformativo
    {
        public int IdInformativo { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
