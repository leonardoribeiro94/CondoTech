using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;

namespace DataAccessLayer.Repositorios
{
    public class UsuarioFuncionarioRepositorio : ConexaoSql
    {
        private readonly DynamicParameters _parametros;

        public UsuarioFuncionarioRepositorio()
        {
            _parametros = new DynamicParameters();
        }

        public void Inserir(Funcionario funcionario)
        {
            using (Connection)
            {
                AbrirConexao();

                _parametros.Add("@IdFuncionario", funcionario.Id);
                _parametros.Add("@Login", funcionario.Cpf);
                _parametros.Add("@Senha", "condominio@1");
                _parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("SPInsert_UsuarioFuncionario");
            }
        }

        public void Atualizar(Funcionario funcionario)
        {
            using (Connection)
            {
                AbrirConexao();

                _parametros.Add("@IdFuncionario", funcionario.Id);
                _parametros.Add("@Login", funcionario.Cpf);
                _parametros.Add("@Senha", funcionario.UsuarioFuncionario.Senha);
                _parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("SPInsert_UsuarioFuncionario");
            }
        }
    }
}
