using Dapper;
using DataAccessLayer.Conexao;
using Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositorios
{
    public class CargoRepositorio : ConexaoSql
    {


        public void Inserir(Cargo cargo)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@Nome", cargo.Nome);
                parametros.Add("@Descricao", cargo.Descricao);

                Connection.Execute("SPInsert_Cargo", parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Alterar(Cargo cargo)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@Id", cargo.Id);
                parametros.Add("@Nome", cargo.Nome);
                parametros.Add("@Descricao", cargo.Descricao);

                Connection.Execute("SPUpdate_Cargo", parametros, commandType: CommandStoredProcedure);
            }

        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdCargo", id);
                Connection.Execute("SPDelete_Cargo", parametros, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<Cargo> ObterCargos()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var listaCargos = Connection.Query<Cargo>("SPSelect_Cargo", commandType: CommandStoredProcedure);

                return listaCargos;
            }
        }

    }
}
