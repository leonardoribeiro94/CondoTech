using Dapper;
using DataAccessLayer.Conexao;
using Model;
using System.Collections.Generic;

namespace DataAccessLayer.Repositorios
{
    public class InformativoRepositorio : ConexaoSql
    {
        private readonly DynamicParameters _parameters;

        public InformativoRepositorio()
        {
            _parameters = new DynamicParameters();
        }

        public void Inserir(Informativo informativo)
        {
            using (Connection)
            {
                AbrirConexao();
                _parameters.Add("@IdEntidade", informativo.IdEntidade);
                _parameters.Add("@TipoInformante", informativo.TipoInformante);
                _parameters.Add("@Descricao", informativo.Descricao);

                Connection.Execute("SPInsert_Informativo", _parameters, commandType: CommandStoredProcedure);
            }
        }

        public void Atualizar(Informativo informativo)
        {
            using (Connection)
            {
                AbrirConexao();
                _parameters.Add("@IdInformativo", informativo.Id);
                _parameters.Add("@IdEntidade", informativo.IdEntidade);
                _parameters.Add("@TipoInformante", informativo.TipoInformante);
                _parameters.Add("@Descricao", informativo.Descricao);

                Connection.Execute("SPInsert_Informativo", _parameters, commandType: CommandStoredProcedure);
            }
        }

        public void Excluir(int id)
        {
            using (Connection)
            {
                AbrirConexao();
                _parameters.Add("@IdInformativo", id);
                Connection.Execute("SPDeletar_Informativo", _parameters, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<Informativo> ObterInformativo()
        {
            using (Connection)
            {
                AbrirConexao();

                return Connection.Query<Informativo>("SPSelect_Informativo", commandType: CommandStoredProcedure);
            }
        }
    }
}
