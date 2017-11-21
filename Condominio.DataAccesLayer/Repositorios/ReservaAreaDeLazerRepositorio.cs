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
                }

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
            }

            Connection.Execute("Update_ReservaAreaDeLazer", parametros, commandType: CommandType.StoredProcedure);
        }

        public void Deletar(int idReserva)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                {
                    parametros.Add("@IdReservaAreaDeLazer", idReserva);
                    parametros.Add("@Status", StatusReserva.Cancelado);
                }

                Connection.Execute("Delete_ReservaAreaDeLazer", parametros, commandType: CommandType.StoredProcedure);
            }

        }

        public ICollection<QueryReservaAreaDeLazer> ObterReservasAreaDeLazer()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlQuery =
                 @"SELECT r.IdReservaAreaDeLazer as IdReserva,
                         r.IdAreaDeLazer,
	                     a.Nome as NomeAreaDeLazer,
	                     m.Nome as NomeMorador,
                         m.Cpf,
                         m.IdMorador,
                         m.Email,
	                     m.Telefone,
	                     r.DataReserva as DataReserva,
                         r.DataSolicitacao,
	                     r.Descricao as Descricao,
	                     r.StatusReserva as Status
	     
                    FROM ReservaAreaDeLazer r
                         JOIN Morador m 
                         ON 
                         r.IdMorador = m.IdMorador
                         JOIN AreaDeLazer a 
                         ON 
                         a.IdAreaDeLazer = r.IdAreaDeLazer";

                return Connection.Query<QueryReservaAreaDeLazer>(sqlQuery)
                    .OrderBy(x => x.DataSolicitacao).ToList();
            }
        }

        public ICollection<QueryReservaAreaDeLazer> ObteReservaAreaDeLazerPorId(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                return ObterReservasAreaDeLazer().Where(x => x.IdReserva.Equals(id)).ToList();
            }
        }


        public ICollection<QueryReservaAreaDeLazer> ObterAreasDeLazerPorIdMorador(int idMorador)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                return ObterReservasAreaDeLazer()
               .Where(x => x.IdMorador.Equals(idMorador)
               && x.Status.Equals(StatusReserva.Reservado)).ToList();
            }
        }

        public ICollection<QueryReservaAreaDeLazer> ObterAreasDeLazerPorNomeMorador(string nome)
        {
            using (Connection)
            {
                return ObterReservasAreaDeLazer()
               .Where(x => x.NomeMorador.Contains(nome)).ToList();
            }
        }

        public ICollection<string> ObterDatasDaReservaDeUmaAreaDeLazerPorId(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlQuery = @"SELECT DataReserva
                                          FROM ReservaAreaDeLazer
                                          WHERE IdAreaDeLazer = @id 
                                          AND StatusReserva = @status";
                var parametros = new
                {
                    id,
                    status = StatusReserva.Reservado
                };

                var listaDatas = new List<string>();

                Connection.Query<DateTime>(sqlQuery, parametros).ToList()
                    .ForEach(x => listaDatas.Add(Convert.ToDateTime(x.Date).ToShortDateString()));

                return listaDatas;
            }
        }
    }
}
