using Condominio.Model.Enum;
using System;

namespace Condominio.Web.ViewModels.Funcionario
{
    public class FuncionarioViewModel
    {
        public int IdFuncionario { get; set; }
        public string Cargo { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public EntidadeAtiva EntidadeAtiva { get; set; }
    }
}