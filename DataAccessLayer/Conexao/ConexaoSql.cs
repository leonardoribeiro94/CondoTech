using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Conexao
{

    public class ConexaoSql : IDisposable
    {

        //propriedade que vai obter a conexão com o SqlServer através da webConfig/AppConfig:
        protected string StringConnection = ConfigurationManager.ConnectionStrings["StrConn"].ConnectionString;

        protected SqlConnection Connection = new SqlConnection();

        protected CommandType CommandStoredProcedure = CommandType.StoredProcedure;

        public void Dispose()
        {
            Connection?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
