using System;
using Condominio.Model.Enum;

namespace Condominio.Model.QueryModel
{
    public class QueryMorador
    {
        public int IdMorador { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public EntidadeAtiva EntidadeAtiva { get; set; }
    }
}
