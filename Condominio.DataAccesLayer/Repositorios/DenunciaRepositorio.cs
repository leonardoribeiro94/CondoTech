using Condominio.DataAccesLayer.Conexao;
using Condominio.Model;
using Condominio.Model.Enum;
using Condominio.Model.QueryModel;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Condominio.DataAccesLayer.Repositorios
{
    public class DenunciaRepositorio : ConexaoSql
    {
        public void Inserir(Denuncia denuncia)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@Nome", denuncia.Nome);
                parametros.Add("@Celular", denuncia.Celular);
                parametros.Add("@Email", denuncia.Email);
                parametros.Add("@Imagem", denuncia.Imagem);
                parametros.Add("@Descricao", denuncia.Descricao);
                parametros.Add("@DataDenuncia", DateTime.Now);
                parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Insert_Denuncia", parametros, commandType: CommandStoredProcedure);
            }
        }


        public void Atualizar(Denuncia denuncia)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdDenuncia", denuncia.Id);
                parametros.Add("@Nome", denuncia.Nome);
                parametros.Add("@Celular", denuncia.Celular);
                parametros.Add("@Email", denuncia.Email);
                parametros.Add("@Imagem", denuncia.Imagem);
                parametros.Add("@Descricao", denuncia.Descricao);
                parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Update_Denuncia", parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Excluir(int id)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdDenuncia", id);
            parametros.Add("@Ativo", EntidadeAtiva.Ativo);

            Connection.Execute("Delete_Denuncia", parametros, commandType: CommandStoredProcedure);
        }

        public IEnumerable<QueryDenuncia> ObterDenuncias()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlComando = "select * from Denuncia where Ativo = 0 order by DataDenuncia desc";

                return Connection.Query<QueryDenuncia>(sqlComando);
            }
        }


        public IEnumerable<QueryDenuncia> ObterDenunciasPorData(DateTime dataInicial, DateTime dataFinal)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                return ObterDenuncias()
                    .Where(x => x.DataDenuncia.Date >= dataInicial.Date
                    && x.DataDenuncia <= dataFinal.Date);
            }
        }

        public QueryDenuncia ObterDenunciaPorId(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                return ObterDenuncias()
                    .FirstOrDefault(x => x.IdDenuncia.Equals(id));
            }
        }
    }
}
