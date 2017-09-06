using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositorios
{
    public class FuncionarioRepositorio : ConexaoSql
    {
        public void Inserir(Funcionario funcionario)
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
                parametros.Add("@Ativo", funcionario.EntidadeAtiva == EntidadeAtiva.Ativo);

                Connection.Execute("SPInsert_Funcionario", parametros, commandType: CommandStoredProcedure);
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

                Connection.Execute("SPUpdate_Funcionario", parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdFuncionario", id);
                parametros.Add("@Ativo", EntidadeAtiva.Inativo);
                Connection.Execute("SPDelete_Funcionario", parametros, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<Funcionario> ObterFuncionarios()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                return Connection.Query<Funcionario>("SPSelect_Funcionario", commandType: CommandStoredProcedure);
            }
        }
    }
}
