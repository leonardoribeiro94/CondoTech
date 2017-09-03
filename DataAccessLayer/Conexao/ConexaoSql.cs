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

        protected void AbrirConexao()
        {
            try
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["StrConn"].ConnectionString);
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível abrir a conexão com a base de dados: {ex.Message}");
            }

        }

        protected void FecharConexao()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Não foi possível fechar a conexão: {ex.Message}");
            }
        }

        public void Dispose()
        {
            FecharConexao();
            Connection?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
