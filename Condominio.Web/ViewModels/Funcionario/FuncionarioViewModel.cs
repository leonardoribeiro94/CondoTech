using Condominio.Model;
using Condominio.Model.Enum;
using System;
using System.Collections.Generic;

namespace Condominio.Web.ViewModels.Funcionario
{
    public class FuncionarioViewModel
    {
        public int IdFuncionario { get; set; }
        public Cargo Cargo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public IEnumerable<Cargo> Cargos { get; set; }
        public EntidadeAtiva EntidadeAtiva { get; set; }
    }
}