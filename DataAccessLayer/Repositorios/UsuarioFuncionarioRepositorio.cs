using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;
using Model.QueryModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositorios
{
    public class UsuarioFuncionarioRepositorio : ConexaoSql
    {

        public void Atualizar(UsuarioFuncionario usuarioFuncionario)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@IdUsuario", usuarioFuncionario.Id);
                parameters.Add("@Senha", usuarioFuncionario.Senha);
                parameters.Add("@SenhaTemporaria", SenhaTemporaria.Inativa);
                parameters.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Update_UsuarioFuncionario", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<ObterUsuarioFuncionario> ObterUsuarioFuncionarios()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlQuery = "select u.IdUsuario, " +
                                        "f.IdFuncionario, " +
                                        "f.Nome, " +
                                        "f.Cpf, " +
                                        "f.Email, " +
                                        "c.Nome as 'Cargo', " +
                                        "u.Senha," +
                                        "u.SenhaTemporaria, " +
                                        "u.Ativo " +
                                        "from Funcionario f join Cargo c on c.IdCargo = f.IdCargo " +
                                        "join UsuarioFuncionario u on u.IdFuncionario = f.IdFuncionario";

                return Connection.Query<ObterUsuarioFuncionario>(sqlQuery);
            }
        }

        public IEnumerable<ObterUsuarioFuncionario> ObterPorLoginUsuarioFuncionario(string login, string senha)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlQuery = "select u.IdUsuario, " +
                                        "f.IdFuncionario, " +
                                        "f.Nome, " +
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
