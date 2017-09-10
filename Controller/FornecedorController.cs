using DataAccessLayer.Repositorios;
using Model;
using Model.QueryModel;
using System.Collections.Generic;

namespace Controller
{
    public class FornecedorController
    {
        private readonly FornecedorRepositorio _fornecedorRepositorio;

        public FornecedorController()
        {
            _fornecedorRepositorio = new FornecedorRepositorio();
        }

        public void InserirFornecedor(Fornecedor fornecedor) => _fornecedorRepositorio.Inserir(fornecedor);

        public void AlterarFornecedor(Fornecedor fornecedor) => _fornecedorRepositorio.Alterar(fornecedor);

        public void ExcluirFornecedor(int idFornecedor) => _fornecedorRepositorio.Excluir(idFornecedor);

        public IEnumerable<ObterFornecedores> ObterFornecedores() => _fornecedorRepositorio.ObterFornecedores();
    }
}
