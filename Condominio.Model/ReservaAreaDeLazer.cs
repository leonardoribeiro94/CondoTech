using Condominio.Model.Enum;
using System;

namespace Condominio.Model
{
    public class ReservaAreaDeLazer : Entidade
    {
        public int IdAreaDeLazer { get; set; }
        public int IdMorador { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataSolicitacaoDoPedido { get; set; }
        public string Descricao { get; set; }
        public StatusReserva Status { get; set; }
    }
}
