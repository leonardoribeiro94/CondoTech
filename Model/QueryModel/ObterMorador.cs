using System;
using Model.Enum;

namespace Model.QueryModel
{
    public class ObterMorador
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
