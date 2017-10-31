using Condominio.Model.Enum;
using System;

namespace Condominio.Model.QueryModel
{
    public class QueryFuncionario
    {
        public int IdFuncionario { get; set; }
        public string Cargo { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public EntidadeAtiva Ativo { get; set; }
    }
}
