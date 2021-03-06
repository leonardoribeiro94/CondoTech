﻿using Condominio.DataAccesLayer.Conexao;
using Condominio.Model;
using Condominio.Model.Enum;
using Condominio.Model.QueryModel;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Condominio.DataAccesLayer.Repositorios
{
    public class UsuarioFuncionarioRepositorio : ConexaoSql
    {

        public void Atualizar(UsuarioFuncionario usuarioFuncionario)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@IdUsuario", usuarioFuncionario.Id);
                parameters.Add("@Senha", usuarioFuncionario.Senha);
                parameters.Add("@SenhaTemporaria", SenhaTemporaria.Inativa);
                parameters.Add("@Ativo", EntidadeAtiva.Ativo);

                Connection.Execute("Update_UsuarioFuncionario", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<QueryUsuarioFuncionario> ObterUsuarioFuncionarios()
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlQuery = @"select u.IdUsuario, 
                                        f.IdFuncionario, 
                                        f.Nome, 
                                        f.Cpf, 
                                        f.Email, 
                                        c.Nome as 'Cargo', 
                                        u.Senha,
                                        u.SenhaTemporaria, 
                                        u.Ativo 
                                        from Funcionario f join Cargo c on c.IdCargo = f.IdCargo
                                        join UsuarioFuncionario u on u.IdFuncionario = f.IdFuncionario";

                return Connection.Query<QueryUsuarioFuncionario>(sqlQuery);
            }
        }

        public IEnumerable<QueryUsuarioFuncionario> ObterPorLoginUsuarioFuncionario(string login, string senha)
        {
            using (Connection = new SqlConnection(StringConnection))
            {
                const string sqlQuery = @"select u.IdUsuario, 
                                        f.IdFuncionario, 
                                        f.Nome, 
                                        c.Nome as 'Cargo', 
                                        u.Senha,
                                        u.SenhaTemporaria, 
                                        u.Ativo 
                                        from Funcionario f join Cargo c on c.IdCargo = f.IdCargo 
                                        join UsuarioFuncionario u on u.IdFuncionario = f.IdFuncionario 
                                        Where u.Login = @login 
                                        and u.Senha = @senha 
                                        and f.Ativo = 0";

                return Connection.Query<QueryUsuarioFuncionario>(sqlQuery, new { login, senha });
            }
        }
    }
}
