using Dapper;
using DataAccessLayer.Conexao;
using Model;
using System.Collections.Generic;

namespace DataAccessLayer.Repositorios
{
    public class RegimentoRepositorio : ConexaoSql
    {
        private readonly DynamicParameters _parametros;

        public RegimentoRepositorio()
        {
            _parametros = new DynamicParameters();
        }

        public void Inserir(Regimento regimento)
        {
            using (Connection)
            {
                AbrirConexao();

                _parametros.Add("@IdFuncionario", regimento.Funcionario.Id);
                _parametros.Add("@Nome", regimento.Nome);
                _parametros.Add("@Descricao", regimento.Documento);

                Connection.Execute("SPInsert_Regimento", commandType: CommandStoredProcedure);
            }
        }

        public void Atualizar(Regimento regimento)
        {
            using (Connection)
            {
                AbrirConexao();

                _parametros.Add("@IdRegimento", regimento.Id);
                _parametros.Add("@IdFuncionario", regimento.Funcionario.Id);
                _parametros.Add("@Nome", regimento.Nome);
                _parametros.Add("@Descricao", regimento.Documento);

                Connection.Execute("SPInsert_Regimento");
            }
        }

        public void Excluir(int id)
        {
            using (Connection)
            {
                AbrirConexao();
                _parametros.Add("@IdFuncionario", id);
                Connection.Execute("SPDelete_Regimento", commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<Regimento> ObteRegimentosRegimentos()
        {
            using (Connection)
            {
                AbrirConexao();
                return Connection.Query<Regimento>("SPSelec_Regimento", commandType: CommandStoredProcedure);
            }
        }
    }
}
