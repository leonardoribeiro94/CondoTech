﻿using Condominio.Model.Enum;

namespace Condominio.Model.QueryModel
{
    public class QueryUsuarioMorador
    {
        public int IdUsuario { get; set; }
        public int IdMorador { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public SenhaTemporaria SenhaTemporaria { get; set; }
        public EntidadeAtiva Ativo { get; set; }
    }
}
