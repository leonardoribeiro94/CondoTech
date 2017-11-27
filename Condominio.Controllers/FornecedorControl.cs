using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class FornecedorControl
    {
        private readonly FornecedorRepositorio _fornecedorRepositorio;

        public FornecedorControl()
        {
            _fornecedorRepositorio = new FornecedorRepositorio();
        }

        public void InserirFornecedor(Fornecedor fornecedor) => _fornecedorRepositorio.Inserir(fornecedor);

        public void AlterarFornecedor(Fornecedor fornecedor) => _fornecedorRepositorio.Alterar(fornecedor);

        public void ExcluirFornecedor(int idFornecedor) => _fornecedorRepositorio.Excluir(idFornecedor);

        public IEnumerable<QueryFornecedores> ObterFornecedores() => _fornecedorRepositorio.ObterFornecedores();
    }
}
