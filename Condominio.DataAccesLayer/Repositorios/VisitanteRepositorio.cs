using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Condominio.DataAccesLayer.Conexao;
using Condominio.Model;
using Condominio.Model.Enum;
using Condominio.Model.QueryModel;
using Dapper;

namespace Condominio.DataAccesLayer.Repositorios
{
    public class VisitanteRepositorio : ConexaoSql
    {

        public void Inserir(Visitante visitante)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();

                parametros.Add("@Imagem", visitante.Imagem);
                parametros.Add("@Nome", visitante.Nome);
                parametros.Add("@Cpf", visitante.Cpf);
                parametros.Add("@Email", visitante.Email);
                parametros.Add("@Celular", visitante.Celular);
                parametros.Add("@Telefone", visitante.Telefone);
                parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Insert_Visitante", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public void Alterar(Visitante visitante)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();

                parametros.Add("@IdVisitante", visitante.Id);
                parametros.Add("@Imagem", visitante.Imagem);
                parametros.Add("@Nome", visitante.Nome);
                parametros.Add("@Cpf", visitante.Cpf);
                parametros.Add("@Email", visitante.Email);
                parametros.Add("@Celular", visitante.Celular);
                parametros.Add("@Telefone", visitante.Telefone);
                parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Update_Visitante", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public void Deletar(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdVisitante", id);
                parametros.Add("@Ativo", EntidadeAtiva.Inativo);
                Connection.Execute("Delete_Visitante", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<ObterVisitante> ObterVisitantes()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string comandoSql = "Select * from visitante where Ativo = 0";

                return Connection.Query<ObterVisitante>(comandoSql).OrderBy(x => x.Nome).ToList();
            }

        }
    }
}
