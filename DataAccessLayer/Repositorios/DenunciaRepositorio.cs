using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositorios
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

        public IEnumerable<Denuncia> ObterDenuncias()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlComando = "select * from Denuncia where Ativo = 1";

                return Connection.Query<Denuncia>(sqlComando);
            }
        }
    }
}
