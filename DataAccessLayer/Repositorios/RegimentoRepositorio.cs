using Dapper;
using DataAccessLayer.Conexao;
using Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositorios
{
    public class RegimentoRepositorio : ConexaoSql
    {

        public void Inserir(Regimento regimento)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                AbrirConexao();
                var parametros = new DynamicParameters();
                parametros.Add("@IdFuncionario", regimento.Funcionario.Id);
                parametros.Add("@Nome", regimento.Nome);
                parametros.Add("@Descricao", regimento.Documento);

                Connection.Execute("SPInsert_Regimento", commandType: CommandStoredProcedure);
            }
        }

        public void Atualizar(Regimento regimento)
        {
            using (Connection = new SqlConnection(StringConnection))
            {

                var parametros = new DynamicParameters();
                parametros.Add("@IdRegimento", regimento.Id);
                parametros.Add("@IdFuncionario", regimento.Funcionario.Id);
                parametros.Add("@Nome", regimento.Nome);
                parametros.Add("@Descricao", regimento.Documento);

                Connection.Execute("SPInsert_Regimento");
            }
        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdFuncionario", id);
                Connection.Execute("SPDelete_Regimento", commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<Regimento> ObteRegimentosRegimentos()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                return Connection.Query<Regimento>("SPSelect_Regimento", commandType: CommandStoredProcedure);
            }
        }
    }
}
