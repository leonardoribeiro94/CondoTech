using Condominio.DataAccesLayer.Conexao;
using Condominio.Model;
using Condominio.Model.Enum;
using Condominio.Model.QueryModel;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Condominio.DataAccesLayer.Repositorios
{
    public class FuncionarioRepositorio : ConexaoSql
    {
        public void Inserir(Funcionario funcionario)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdCargo", funcionario.IdCargo);
                parametros.Add("@Nome", funcionario.Nome.Trim().ToUpper());
                parametros.Add("@DataDeNascimento", funcionario.DataDeNascimento);
                parametros.Add("@Telefone", funcionario.Telefone.Trim());
                parametros.Add("@Celular", funcionario.Celular.Trim());
                parametros.Add("@Email", funcionario.Email.Trim().ToUpper());
                parametros.Add("@Cpf", funcionario.Cpf.Trim());
                parametros.Add("@Ativo", funcionario.EntidadeAtiva == EntidadeAtiva.Ativo);

                Connection.Execute("Insert_Funcionario", parametros, commandType: CommandStoredProcedure);
            }

        }

        public void Alterar(Funcionario funcionario)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@Nome", funcionario.Nome.Trim().ToUpper());
                parametros.Add("@DataDeNascimento", funcionario.DataDeNascimento);
                parametros.Add("@Telefone", funcionario.Telefone.Trim());
                parametros.Add("@Celular", funcionario.Celular.Trim());
                parametros.Add("@Email", funcionario.Email.Trim().ToUpper());
                parametros.Add("@Cpf", funcionario.Cpf.Trim());

                Connection.Execute("Update_Funcionario", parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdFuncionario", id);
                parametros.Add("@Ativo", EntidadeAtiva.Inativo);
                Connection.Execute("Delete_Funcionario", parametros, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<ObterFuncionario> ObterFuncionarios()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string queryString = "SELECT [f].[IdFuncionario]," +
                                                  "[f].[Nome]," +
                                                  "[f].[DataDeNascimento]," +
                                                  "[f].[Telefone]," +
                                                  "[f].[Celular]," +
                                                  "[f].[Email]," +
                                                  "[f].[Cpf]," +
                                                  "[f].[Ativo]," +
                                                  "[c].[Nome] AS 'Cargo'" +
                                                  "FROM Funcionario f " +
                                                  "INNER JOIN Cargo c " +
                                                  "ON f.IdCargo = c.IdCargo " +
                                                  "AND f.Ativo = 0";

                return Connection.Query<ObterFuncionario>(queryString);
            }
        }

        public IEnumerable<ObterFuncionario> ObterFuncionariosPorNome(string nome)
        {
            return ObterFuncionarios().Where(x => x.Nome.ToLower().Contains(nome));
        }

        public ObterFuncionario ObterFuncionariosPorId(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                return ObterFuncionarios().FirstOrDefault(x => x.IdFuncionario == id);
            }
        }
    }
}
