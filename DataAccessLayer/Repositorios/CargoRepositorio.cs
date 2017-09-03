using Dapper;
using DataAccessLayer.Conexao;
using Model;
using System.Collections.Generic;

namespace DataAccessLayer.Repositorios
{
    public class CargoRepositorio : ConexaoSql
    {
        private readonly DynamicParameters _parametros;

        public CargoRepositorio()
        {
            _parametros = new DynamicParameters();
        }

        public void Inserir(Cargo cargo)
        {
            using (Connection)
            {
                Connection.Open();
                _parametros.Add("@Nome", cargo.Nome);
                _parametros.Add("@Descricao", cargo.Descricao);

                Connection.Execute("SPInsert_Cargo", _parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Alterar(Cargo cargo)
        {
            Connection.Open();
            _parametros.Add("@Id", cargo.Id);
            _parametros.Add("@Nome", cargo.Nome);
            _parametros.Add("@Descricao", cargo.Descricao);

            Connection.Execute("SPUpdate_Cargo", _parametros, commandType: CommandStoredProcedure);
        }

        public void Excluir(int id)
        {
            using (Connection)
            {
                Connection.Open();
                _parametros.Add("@IdCargo", id);
                Connection.Execute("SPDelete_Cargo", _parametros, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<Cargo> ObterCargos()
        {
            using (Connection)
            {
                Connection.Open();
                var listaCargos = Connection.Query<Cargo>("SPSelect_Cargo", commandType: CommandStoredProcedure);

                return listaCargos;
            }
        }

    }
}
