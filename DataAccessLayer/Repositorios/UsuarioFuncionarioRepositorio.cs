using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositorios
{
    public class UsuarioFuncionarioRepositorio : ConexaoSql
    {

        public void Inserir(Funcionario funcionario)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                AbrirConexao();
                var parameters = new DynamicParameters();
                parameters.Add("@IdFuncionario", funcionario.Id);
                parameters.Add("@Login", funcionario.Cpf);
                parameters.Add("@Senha", "condominio@1");
                parameters.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Insert_UsuarioFuncionario");
            }
        }

        public void Atualizar(Funcionario funcionario)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                AbrirConexao();
                var parameters = new DynamicParameters();
                parameters.Add("@IdFuncionario", funcionario.Id);
                parameters.Add("@Login", funcionario.Cpf);
                parameters.Add("@Senha", funcionario.UsuarioFuncionario.Senha);
                parameters.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Update_UsuarioFuncionario");
            }
        }
    }
}
