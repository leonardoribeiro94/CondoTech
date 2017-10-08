using Condominio.DataAccesLayer.Conexao;
using Condominio.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Condominio.DataAccesLayer.Repositorios
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

                Connection.Execute("Insert_Cargo", parametros, commandType: CommandStoredProcedure);
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

                Connection.Execute("Update_Cargo", parametros, commandType: CommandStoredProcedure);
            }

        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdCargo", id);
                Connection.Execute("Delete_Cargo", parametros, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<Cargo> ObterCargos()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string queryString = "Select * from Cargo";
                var listaCargos = Connection.Query<Cargo>(queryString);

                return listaCargos;
            }
        }

    }
}
