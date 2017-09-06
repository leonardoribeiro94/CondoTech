using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositorios
{
    public class FornecedorRepositorio : ConexaoSql
    {
        public void Inserir(Fornecedor fornecedor)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdFuncionario", fornecedor.Funcionario.Id);
                parametros.Add("@Nome", fornecedor.Nome);
                parametros.Add("@Cnpj", fornecedor.Cnpj);
                parametros.Add("@Telefone", fornecedor.Telefone);
                parametros.Add("@TelefoneCelular", fornecedor.TelefoneCelular);
                parametros.Add("@Email", fornecedor.Email);
                parametros.Add("@Descricao", fornecedor.Descricao);
                parametros.Add("@Ativo", fornecedor.EntidadeAtivo == EntidadeAtiva.Ativo);

                Connection.Execute("SPInsert_Fornecedor", parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Alterar(Fornecedor fornecedor)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdFornecedor", fornecedor.Id);
                parametros.Add("@IdFuncionario", fornecedor.Funcionario.Id);
                parametros.Add("@Nome", fornecedor.Nome);
                parametros.Add("@Cnpj", fornecedor.Cnpj);
                parametros.Add("@Telefone", fornecedor.Telefone);
                parametros.Add("@TelefoneCelular", fornecedor.TelefoneCelular);
                parametros.Add("@Email", fornecedor.Email);
                parametros.Add("@Descricao", fornecedor.Descricao);
                parametros.Add("@Ativo", fornecedor.EntidadeAtivo == EntidadeAtiva.Ativo);

                Connection.Execute("SPUpdate_Fornecedor", parametros, commandType: CommandStoredProcedure);
            }

        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdFornecedor", id);
                parametros.Add("@Ativo", EntidadeAtiva.Inativo);
                Connection.Execute("SPDelete_Fornecedor", parametros, commandType: CommandStoredProcedure);
            }

        }

        public IEnumerable<Fornecedor> ObterFornecedores()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlComando = "select * from Fornecedor where Ativo = 0";
                return Connection.Query<Fornecedor>(sqlComando);
            }
        }
    }
}
