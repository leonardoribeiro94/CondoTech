using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class FuncionarioControl
    {
        private readonly FuncionarioRepositorio _funcionarioRepositorio = new FuncionarioRepositorio();

        public void InserirFuncionario(Funcionario funcionario) => _funcionarioRepositorio.Inserir(funcionario);

        public void AlterarFuncionario(Funcionario funcionario) => _funcionarioRepositorio.Alterar(funcionario);

        public IEnumerable<ObterFuncionario> ListarFuncionarios() => _funcionarioRepositorio.ObterFuncionarios();

        public ObterFuncionario ListarFuncionariosPorId(int id) => _funcionarioRepositorio.ObterFuncionariosPorId(id);
    }
}
