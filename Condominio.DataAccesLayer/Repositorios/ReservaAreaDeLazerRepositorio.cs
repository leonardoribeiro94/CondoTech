using Condominio.DataAccesLayer.Conexao;
using Condominio.Model;
using Condominio.Model.Enum;
using Condominio.Model.QueryModel;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Condominio.DataAccesLayer.Repositorios
{
    public class ReservaAreaDeLazerRepositorio : ConexaoSql
    {
        public void Inserir(ReservaAreaDeLazer reservaAreaDeLazer)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                {
                    parametros.Add("@IdAreaDeLazer", reservaAreaDeLazer.IdAreaDeLazer);
                    parametros.Add("@IdMorador", reservaAreaDeLazer.IdMorador);
                    parametros.Add("@Descricao", reservaAreaDeLazer.Descricao);
                    parametros.Add("@DataReserva", reservaAreaDeLazer.DataReserva);
                    parametros.Add("@DataSolicitacao", DateTime.Now);
                    parametros.Add("@Status", StatusReserva.Reservado);
                };

                Connection.Execute("Insert_ReservaAreaDeLazer", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public void Alterar(ReservaAreaDeLazer reservaAreaDeLazer)
        {
            var parametros = new DynamicParameters();
            {
                parametros.Add("@IdReservaAreaDeLazer", reservaAreaDeLazer.Id);
                parametros.Add("@IdAreaDeLazer", reservaAreaDeLazer.IdAreaDeLazer);
                parametros.Add("@IdMorador", reservaAreaDeLazer.IdMorador);
                parametros.Add("@Descricao", reservaAreaDeLazer.Descricao);
                parametros.Add("@DataReserva", reservaAreaDeLazer.DataReserva);
                parametros.Add("@DataSolicitacao", reservaAreaDeLazer.DataSolicitacaoDoPedido);
                parametros.Add("@Status", StatusReserva.Reservado);
            };


            Connection.Execute("Update_ReservaAreaDeLazer", parametros, commandType: CommandType.StoredProcedure);
        }

        public void Deletar(int idReserva)
        {
            var parametros = new
            {
                idReserva,
                StatusReserva.Cancelado
            };

            Connection.Execute("Insert_ReservaAreaDeLazer", parametros, commandType: CommandType.StoredProcedure);
        }

        public ICollection<QueryReservaAreaDeLazer> ObterReservasAreaDeLazer()
        {
            const string sqlQuery =
                @"SELECT [r].[IdReservaAreaDeLazer] as IdReserva,
	                     [a].[Nome] as NomeAreaDeLazer,
	                     [m].[Nome] as NomeMorador,
	                     [r].[DataReserva] as DataReserva,
	                     [r].[Descricao] as Descricao,
	                     [r].[Status] as Status
	     
                    FROM ReservaAreaDeLazer [r]
                         JOIN Morador [m] ON [r].[IdMorador] = [m].[IdMorador]
                         JOIN AreaDeLazer [a] ON [a].[IdAreaDeLazer] = [r].[IdAreaDeLazer]";

            return Connection.Query<QueryReservaAreaDeLazer>(sqlQuery)
                .OrderBy(x => x.DataSolicitacao).ToList();
        }

        public QueryReservaAreaDeLazer ObteReservaAreaDeLazerPorId(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                return ObterReservasAreaDeLazer().FirstOrDefault(x => x.IdReserva.Equals(id));
            }
        }

        public ICollection<QueryReservaAreaDeLazer> ObterAreasDeLazerPorIdMorador(int idMorador)
        {
            return ObterReservasAreaDeLazer()
                .Where(x => x.IdMorador.Equals(idMorador)).ToList();
        }

        public ICollection<QueryReservaAreaDeLazer> ObterAreasDeLazerPorNomeMorador(string nome)
        {
            return ObterReservasAreaDeLazer()
                .Where(x => x.NomeMorador.Contains(nome)).ToList();
        }

        public ICollection<DateTime> ObterDatasDaReservaDeUmaAreaDeLazerPorId(int id)
        {
            return ObterReservasAreaDeLazer()
                .Where(x => x.Status.Equals(StatusReserva.Reservado)
                 && x.IdAreaDeLazer.Equals(id))
                .Select(x => x.DataReserva).ToList();
        }
    }
}
