using Dapper;
using DataAccessLayer.Conexao;
using Model;

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
            using (Connection)
            {
                AbrirConexao();
                _parameters.Add("@Nome", areaDeLazer.Nome);
                _parameters.Add("@Descricao", areaDeLazer.Descricao);
                _parameters.Add("@Ativo", areaDeLazer.EntidadeAtiva);
                Connection.Execute("SPInsert_AreaDeLazer");
            }
        }

        public void Atualizar(AreaDeLazer areaDeLazer)
        {
            using (Connection)
            {
                AbrirConexao();
                _parameters.Add("@IdAreaDeLazer", areaDeLazer.Id);
                _parameters.Add("@Nome", areaDeLazer.Nome);
                _parameters.Add("@Descricao", areaDeLazer.Descricao);
                _parameters.Add("@Ativo", areaDeLazer.EntidadeAtiva);
                Connection.Execute("SPInsert_AreaDeLazer");
            }
        }

        public void Excluir(int id)
        {
            using (Connection)
            {
                AbrirConexao();
                _parameters.Add("@IdAreaDeLazer", id);
                Connection.Execute("SPDelete_AreaDeLazer", _parameters, commandType: CommandStoredProcedure);
            }
        }
    }
}
