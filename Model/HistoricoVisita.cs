

using System;

namespace Model
{
    public class HistoricoVisita
    {
        public int IdHistoricoVisita { get; set; }
        public int IdMorador { get; set; }
        public int IdVisitante { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string Descricao { get; set; }

    }
}
