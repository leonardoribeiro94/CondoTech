
using Condominio.Model.Enum;
using System;

namespace Condominio.Model.QueryModel
{
    public class QueryReservaAreaDeLazer
    {
        public int IdReserva { get; set; }
        public int IdAreaDeLazer { get; set; }
        public int IdMorador { get; set; }
        public string NomeMorador { get; set; }
        public string Descricao { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public StatusReservaAreaDeLazer Status { get; set; }
    }
}
