using System;

namespace Model.QueryModel
{
    public class ObterHistoricoVisita
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
