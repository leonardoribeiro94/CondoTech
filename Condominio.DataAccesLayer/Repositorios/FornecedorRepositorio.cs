using System.Collections.Generic;
using System.Data.SqlClient;
using Condominio.DataAccesLayer.Conexao;
using Condominio.Model;
using Condominio.Model.Enum;
using Condominio.Model.QueryModel;
using Dapper;

namespace Condominio.DataAccesLayer.Repositorios
{
    public class FornecedorRepositorio : ConexaoSql
    {
        public void Inserir(Fornecedor fornecedor)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();

                parametros.Add("@Nome", fornecedor.Nome);
                parametros.Add("@Cnpj", fornecedor.Cnpj);
                parametros.Add("@Telefone", fornecedor.Telefone);
                parametros.Add("@Celular", fornecedor.TelefoneCelular);
                parametros.Add("@Email", fornecedor.Email);
                parametros.Add("@Descricao", fornecedor.Descricao);
                parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Insert_Fornecedor", parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Alterar(Fornecedor fornecedor)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdFornecedor", fornecedor.Id);
                parametros.Add("@Nome", fornecedor.Nome);
                parametros.Add("@Cnpj", fornecedor.Cnpj);
                parametros.Add("@Telefone", fornecedor.Telefone);
                parametros.Add("@Celular", fornecedor.TelefoneCelular);
                parametros.Add("@Email", fornecedor.Email);
                parametros.Add("@Descricao", fornecedor.Descricao);
                parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Update_Fornecedor", parametros, commandType: CommandStoredProcedure);
            }

        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdFornecedor", id);
                parametros.Add("@Ativo", EntidadeAtiva.Inativo);
                Connection.Execute("Delete_Fornecedor", parametros, commandType: CommandStoredProcedure);
            }

        }

        public IEnumerable<ObterFornecedores> ObterFornecedores()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlComando = "select * from Fornecedor where Ativo = 0";
                return Connection.Query<ObterFornecedores>(sqlComando);
            }
        }
    }
}
