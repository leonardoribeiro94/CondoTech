using Condominio.DataAccesLayer.Conexao;
using Condominio.Model.QueryModel;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace Condominio.DataAccesLayer.Repositorios
{
    public class UsuarioMoradorRepositorio : ConexaoSql
    {
        public QueryUsuarioMorador ObterUsuarioMoradorPorLogin(string login, string senha)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlQuery =
                    @"SELECT [u].[IdMorador],
                           [u].[IdMorador],
                           [u].[Login],
                           [u].[senha],
                           [m].[Nome],
                           [m].[Email],
                           [m].[DataDeNascimento],
                           [m].[Cpf]
                           FROM usuariomorador u
                           INNER JOIN morador m ON [u].[IdMorador] = [m].[IdMorador]
                           WHERE u.login = @login and u.senha = @senha 
                           AND u.Ativo = 0";

                return Connection.Query<QueryUsuarioMorador>(sqlQuery, new { login, senha }).FirstOrDefault();
            }
        }
    }
}
