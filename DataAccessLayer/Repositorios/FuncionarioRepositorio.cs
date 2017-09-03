using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;
using System.Collections.Generic;

namespace DataAccessLayer.Repositorios
{
    public class FuncionarioRepositorio : ConexaoSql
    {
        private readonly DynamicParameters _parametros;

        public FuncionarioRepositorio()
        {
            _parametros = new DynamicParameters();
        }

        public void Inserir(Funcionario funcionario)
        {
            using (Connection)
            {
                _parametros.Add("@Nome", funcionario.Nome.Trim().ToUpper());
                _parametros.Add("@DataDeNascimento", funcionario.DataDeNascimento);
                _parametros.Add("@Telefone", funcionario.Telefone.Trim());
                _parametros.Add("@Celular", funcionario.Celular.Trim());
                _parametros.Add("@Email", funcionario.Email.Trim().ToUpper());
                _parametros.Add("@Cpf", funcionario.Cpf.Trim());
                _parametros.Add("@Ativo", funcionario.EntidadeAtiva == EntidadeAtiva.Ativo);

                Connection.Execute("SPInsert_Funcionario", _parametros, commandType: CommandStoredProcedure);
            }

        }

        public void Alterar(Funcionario funcionario)
        {
            using (Connection)
            {
                _parametros.Add("@Nome", funcionario.Nome.Trim().ToUpper());
                _parametros.Add("@DataDeNascimento", funcionario.DataDeNascimento);
                _parametros.Add("@Telefone", funcionario.Telefone.Trim());
                _parametros.Add("@Celular", funcionario.Celular.Trim());
                _parametros.Add("@Email", funcionario.Email.Trim().ToUpper());
                _parametros.Add("@Cpf", funcionario.Cpf.Trim());

                Connection.Execute("SPUpdate_Funcionario", _parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Excluir(int id)
        {
            using (Connection)
            {
                _parametros.Add("@IdFuncionario", id);
                _parametros.Add("@Ativo", EntidadeAtiva.Inativo);
                Connection.Execute("SPDelete_Funcionario", _parametros, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<Funcionario> ObterFuncionarios()
        {
            using (Connection)
            {
                return Connection.Query<Funcionario>("SPSelect_Funcionario", commandType: CommandStoredProcedure);
            }
        }
    }
}
