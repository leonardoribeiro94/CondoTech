using DataAccessLayer.Repositorios.FalsoRepositorio;
using Model;
using System.Collections.Generic;

namespace Controller
{
    public class FuncionarioController
    {
        private readonly FuncionarioFalsoRepositorio _funcionarioRepositorio = new FuncionarioFalsoRepositorio();

        public void InserirFuncionario(Funcionario funcionario) => _funcionarioRepositorio.Cadastrar(funcionario);

        public void AlterarFuncionario(Funcionario funcionario) => _funcionarioRepositorio.Atualizar(funcionario);

        public IEnumerable<Funcionario> ListarFuncionarios() => _funcionarioRepositorio.Listar();
    }
}
