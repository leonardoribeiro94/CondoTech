using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;
using System.Collections.Generic;

namespace DataAccessLayer.Repositorios
{
    public class FornecedorRepositorio : ConexaoSql
    {
        private readonly DynamicParameters _parameters;
        public FornecedorRepositorio()
        {
            _parameters = new DynamicParameters();
        }

        public void Inserir(Fornecedor fornecedor)
        {
            using (Connection)
            {
                AbrirConexao();
                _parameters.Add("@IdFuncionario", fornecedor.Funcionario.Id);
                _parameters.Add("@Nome", fornecedor.Nome);
                _parameters.Add("@Cnpj", fornecedor.Cnpj);
                _parameters.Add("@Telefone", fornecedor.Telefone);
                _parameters.Add("@TelefoneCelular", fornecedor.TelefoneCelular);
                _parameters.Add("@Email", fornecedor.Email);
                _parameters.Add("@Descricao", fornecedor.Descricao);
                _parameters.Add("@Ativo", fornecedor.EntidadeAtivo == EntidadeAtiva.Ativo);

                Connection.Execute("SPInsert_Fornecedor", _parameters, commandType: CommandStoredProcedure);
            }
        }

        public void Alterar(Fornecedor fornecedor)
        {
            AbrirConexao();
            _parameters.Add("@IdFornecedor", fornecedor.Id);
            _parameters.Add("@IdFuncionario", fornecedor.Funcionario.Id);
            _parameters.Add("@Nome", fornecedor.Nome);
            _parameters.Add("@Cnpj", fornecedor.Cnpj);
            _parameters.Add("@Telefone", fornecedor.Telefone);
            _parameters.Add("@TelefoneCelular", fornecedor.TelefoneCelular);
            _parameters.Add("@Email", fornecedor.Email);
            _parameters.Add("@Descricao", fornecedor.Descricao);
            _parameters.Add("@Ativo", fornecedor.EntidadeAtivo == EntidadeAtiva.Ativo);

            Connection.Execute("SPUpdate_Fornecedor", _parameters, commandType: CommandStoredProcedure);
        }

        public void Excluir(int id)
        {
            AbrirConexao();
            _parameters.Add("@IdFornecedor", id);
            _parameters.Add("@Ativo", EntidadeAtiva.Inativo);
            Connection.Execute("SPDelete_Fornecedor", _parameters, commandType: CommandStoredProcedure);
        }

        public IEnumerable<Fornecedor> ObterFornecedores()
        {
            using (Connection)
            {
                const string sqlComando = "select * from Fornecedor where Ativo = 0";
                return Connection.Query<Fornecedor>(sqlComando);
            }
        }
    }
}
