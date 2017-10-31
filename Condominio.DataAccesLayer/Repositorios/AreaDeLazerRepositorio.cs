using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Condominio.DataAccesLayer.Conexao;
using Condominio.Model;
using Condominio.Model.Enum;
using Condominio.Model.QueryModel;
using Dapper;

namespace Condominio.DataAccesLayer.Repositorios
{
    public class AreaDeLazerRepositorio : ConexaoSql
    {
        public void Inserir(AreaDeLazer areaDeLazer)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Nome", areaDeLazer.Nome);
                parameters.Add("@Descricao", areaDeLazer.Descricao);
                parameters.Add("@Imagem", areaDeLazer.Imagem);
                parameters.Add("@Ativo", areaDeLazer.EntidadeAtiva);
                Connection.Execute("Insert_AreaDeLazer", parameters, commandType: CommandStoredProcedure);
            }
        }

        public void Atualizar(AreaDeLazer areaDeLazer)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@IdAreaDeLazer", areaDeLazer.IdAreaDeLazer);
                parameters.Add("@Nome", areaDeLazer.Nome);
                parameters.Add("@Descricao", areaDeLazer.Descricao);
                parameters.Add("@Imagem", areaDeLazer.Imagem);
                parameters.Add("@Ativo", areaDeLazer.EntidadeAtiva);

                Connection.Execute("Update_AreaDeLazer", parameters, commandType: CommandStoredProcedure);
            }
        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@IdAreaDeLazer", id);
                parameters.Add("@Ativo", EntidadeAtiva.Inativo);
                Connection.Execute("Delete_AreaDeLazer", parameters, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<QueryAreaDeLazer> ObterAreasDeLazer()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                string query = "Select IdAreaDeLazer,imagem ,Nome, descricao from AreaDeLazer where Ativo = 0";
                return Connection.Query<QueryAreaDeLazer>(query).OrderBy(x => x.IdAreaDeLazer);
            }
        }
    }
}
