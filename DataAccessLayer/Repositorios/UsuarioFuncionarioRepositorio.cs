using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;
using Model.QueryModel;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositorios
{
    public class UsuarioFuncionarioRepositorio : ConexaoSql
    {

        public void Atualizar(Funcionario funcionario)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@IdFuncionario", funcionario.Id);
                parameters.Add("@Login", funcionario.Cpf);
                parameters.Add("@Senha", funcionario.UsuarioFuncionario.Senha);
                parameters.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Update_UsuarioFuncionario");
            }
        }

        public IEnumerable<ObterUsuarioFuncionario> ObterUsuarioFuncionarios()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlQuery = "select f.Nome," +
                                        "c.Nome as 'Cargo'," +
                                        "u.Senha," +
                                        "u.SenhaTemporaria as 'SenhaTemporaria'" +
                                        "u.Ativo" +
                                        "from Funcionario f join Cargo c on c.IdCargo = f.IdCargo " +
                                        "join UsuarioFuncionario u on u.IdFuncionario = f.IdFuncionario";

                return Connection.Query<ObterUsuarioFuncionario>(sqlQuery);
            }
        }

        public IEnumerable<ObterUsuarioFuncionario> ObterPorLoginUsuarioFuncionario(string login, string senha)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlQuery = "select f.Nome, " +
                                        "c.Nome as 'Cargo', " +
                                        "u.Senha," +
                                        "u.SenhaTemporaria, " +
                                        "u.Ativo " +
                                        "from Funcionario f join Cargo c on c.IdCargo = f.IdCargo " +
                                        "join UsuarioFuncionario u on u.IdFuncionario = f.IdFuncionario " +
                                        "Where u.Login = @login and u.Senha = @senha";

                return Connection.Query<ObterUsuarioFuncionario>(sqlQuery, new { login, senha });
            }
        }
    }
}
