using Dapper;
using DataAccessLayer.Conexao;
using Model;
using Model.Enum;
using Model.QueryModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer.Repositorios
{
    public class MoradorRepositorio : ConexaoSql
    {
        public void Inserir(Morador morador)
        {
            var moradorLista = ObterMoradores().Where(x => x.Cpf == morador.Cpf).ToList();

            using (Connection = new SqlConnection(StringConnection))
            {
                if (moradorLista.Count == 0)
                {
                    var parametros = new DynamicParameters();
                    parametros.Add("@Nome", morador.Nome.Trim().ToUpper());
                    parametros.Add("@DataDeNascimento", morador.DataDeNascimento);
                    parametros.Add("@Telefone", morador.Telefone.Trim());
                    parametros.Add("@Celular", morador.Celular.Trim());
                    parametros.Add("@Email", morador.Email.Trim().ToUpper());
                    parametros.Add("@Cpf", morador.Cpf.Trim());
                    parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                    Connection.Execute("SPInsert_Morador", parametros, commandType: CommandType.StoredProcedure);
                }
                else
                {
                    throw new Exception($"Já existe um morador com o CPF {morador.Cpf} registrado!");
                }
            }
        }

        public void Alterar(Morador morador)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdMorador", morador.Id);
                parametros.Add("@Nome", morador.Nome.Trim().ToUpper());
                parametros.Add("@DataDeNascimento", morador.DataDeNascimento);
                parametros.Add("@Telefone", morador.Telefone.Trim());
                parametros.Add("@Celular", morador.Celular.Trim());
                parametros.Add("@Email", morador.Email.Trim().ToUpper());
                parametros.Add("@Cpf", morador.Cpf.Trim());
                parametros.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("SPUpdate_Morador", parametros, commandType: CommandStoredProcedure);
            }
        }

        public void Excluir(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdMorador", id);
                parametros.Add("@Ativo", EntidadeAtiva.Inativo);

                Connection.Execute("SPDelete_Morador", parametros, commandType: CommandStoredProcedure);
            }
        }

        public IEnumerable<ObterMorador> ObterMoradores()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var sqlComando = $"Select * from Morador where Ativo = 0";
                var lista = Connection.Query<ObterMorador>(sqlComando).ToList();
                return lista;
            }
        }

        public ICollection<ObterMorador> ObterMoradoresPorId(int id)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var sqlComando = $"Select * from Morador where Nome like '%@id%' and Ativo = 0";
                return Connection.Query<ObterMorador>(sqlComando, new { id }).ToList();
            }
        }

        public ICollection<ObterMorador> ObterMoradoresPorNome(string nome)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var sqlComando = $"Select * from Morador where Nome like '%'+@nome+'%' and ativo = 0";

                return Connection.Query<ObterMorador>(sqlComando, new { nome }).ToList();
            }
        }

        public ICollection<ObterMorador> ObterMoradoresPorNomeEDataDeNascimento(string nome, DateTime nascimento)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlComando = "Select * from Morador where Nome like '%'+@nome+'%' or datadenascimento  = @nascimento and Ativo = 0";
                return Connection.Query<ObterMorador>(sqlComando, new { nome, nascimento }).ToList();
            }

        }
    }
}
