using Dapper;
using DataAccessLayer.Conexao;
using Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer.Repositorios
{
    public class AreaDeLazerRepositorio : ConexaoSql
    {
        private readonly DynamicParameters _parameters;

        public AreaDeLazerRepositorio()
        {
            _parameters = new DynamicParameters();
        }

        public void Inserir(AreaDeLazer areaDeLazer)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                _parameters.Add("@Nome", areaDeLazer.Nome);
                _parameters.Add("@Descricao", areaDeLazer.Descricao);
                _parameters.Add("@Imagem", areaDeLazer.Imagem);
                _parameters.Add("@Ativo", areaDeLazer.EntidadeAtiva);
                Connection.Execute("SPInsert_AreaDeLazer", _parameters, commandType: CommandStoredProcedure);
            }
        }

        public void Atualizar(AreaDeLazer areaDeLazer)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                _parameters.Add("@IdAreaDeLazer", areaDeLazer.Id);
                _parameters.Add("@Nome", areaDeLazer.Nome);
                _parameters.Add("@Descricao", areaDeLazer.Descricao);
                _parameters.Add("@Ativo", areaDeLazer.EntidadeAtiva);
                Connection.Execute("SPUpdate_AreaDeLazer", _parameters, commandType: CommandStoredProcedure);
            }
        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                _parameters.Add("@IdAreaDeLazer", id);
                Connection.Execute("SPDelete_AreaDeLazer", _parameters, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<AreaDeLazer> ObterAreasDeLazer()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                string query = "Select  IdAreaDeLazer,imagem ,Nome, descricao from AreaDeLazer";
                return Connection.Query<AreaDeLazer>(query).OrderBy(x => x.Nome);
            }
        }
    }
}
