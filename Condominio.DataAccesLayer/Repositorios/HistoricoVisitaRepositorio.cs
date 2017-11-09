using Condominio.DataAccesLayer.Conexao;
using Condominio.Model;
using Condominio.Model.QueryModel;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Condominio.DataAccesLayer.Repositorios
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
                parametro.Add("@Descricao", historicoVisita.Descricao);

                Connection.Execute("Update_HistoricoVisita", parametro, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<QueryHistoricoVisita> ObterHistoricos()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlcomando = @"select h.IdHistoricoVisita, 
                                                   m.IdMorador, 
                                                   v.IdVisitante,
                                                   v.Nome as 'Visitante', 
                                                   m.Nome as 'Morador', 
                                                   h.DataEntrada, 
                                                   h.DataSaida, 
                                                   h.Descricao 
                                                   from HistoricoVisita h 
                                                   inner join Morador m on h.IdMorador = m.IdMorador 
                                                   inner join Visitante v on h.IdMorador = v.IdVisitante";

                return Connection.Query<QueryHistoricoVisita>(sqlcomando).OrderBy(x => x.DataEntrada);
            }
        }
    }
}
