using Dapper;
using DataAccessLayer.Conexao;
using Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer.Repositorios
{
    public class HistoricoVisitaRepositorio : ConexaoSql
    {
        public void Inserir(HistoricoVisita historicoVisita)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametro = new DynamicParameters();

                parametro.Add("@IdMorador", historicoVisita.IdMorador);
                parametro.Add("@IdVisitante", historicoVisita.IdVisitante);
                parametro.Add("@DataEntrada", historicoVisita.DataEntrada);
                parametro.Add("@DataSaida", historicoVisita.DataSaida);
                parametro.Add("@Descricao", historicoVisita.Descricao);

                Connection.Execute("Insert_HistoricoVisita", parametro, commandType: CommandType.StoredProcedure);
            }
        }

        public void Alterar(HistoricoVisita historicoVisita)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametro = new DynamicParameters();

                parametro.Add("@IdHistoricoVisita", historicoVisita.IdHistoricoVisita);
                parametro.Add("@IdMorador", historicoVisita.IdMorador);
                parametro.Add("@IdVisitante", historicoVisita.IdVisitante);
                parametro.Add("@DataEntrada", historicoVisita.DataEntrada);
                parametro.Add("@DataSaida", historicoVisita.DataSaida);

                Connection.Execute("Update_HistoricoVisita", parametro, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<HistoricoVisita> ObterHistoricos()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlcomando = "select * from HistoricoVisita";
                return Connection.Query<HistoricoVisita>(sqlcomando).OrderBy(x => x.DataEntrada).ToList();
            }
        }
    }
}
