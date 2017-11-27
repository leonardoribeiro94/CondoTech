using System;

namespace Condominio.Model.QueryModel
{
    public class QueryHistoricoVisita
    {
        public int IdHistoricoVisita { get; set; }
        public int IdMorador { get; set; }
        public int IdVisitante { get; set; }
        public string Visitante { get; set; }
        public string Morador { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string Descricao { get; set; }
    }
}
