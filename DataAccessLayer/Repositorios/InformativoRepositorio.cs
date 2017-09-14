using Dapper;
using DataAccessLayer.Conexao;
using Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositorios
{
    public class InformativoRepositorio : ConexaoSql
    {

        public void Inserir(Informativo informativo)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdEntidade", informativo.IdEntidade);
                parametros.Add("@TipoInformante", informativo.TipoInformante);
                parametros.Add("@Descricao", informativo.Descricao);

                Connection.Execute("Insert_Informativo", parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Atualizar(Informativo informativo)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdInformativo", informativo.Id);
                parametros.Add("@IdEntidade", informativo.IdEntidade);
                parametros.Add("@TipoInformante", informativo.TipoInformante);
                parametros.Add("@Descricao", informativo.Descricao);

                Connection.Execute("Update_Informativo", parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdInformativo", id);
                Connection.Execute("Deletar_Informativo", parametros, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<Informativo> ObterInformativo()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                return Connection.Query<Informativo>("Select_Informativo", commandType: CommandStoredProcedure);
            }
        }
    }
}
