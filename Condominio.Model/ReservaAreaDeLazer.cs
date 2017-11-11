using Condominio.Model.Enum;
using System;

namespace Condominio.Model
{
    public class ReservaAreaDeLazer : Entidade
    {
        public int IdMorador { get; set; }
        public int IdAreaDeLazer { get; set; }
        public string Descricao { get; set; }
        public DateTime DataReserva { get; set; }
        public StatusReservaAreaDeLazer StatusReservaAreaDeLazer { get; set; }

        private void ValidaDataDeAgendaValida()
        {
            var dataAceitavel = DataReserva >= DataReserva.AddMonths(1);

            if (!dataAceitavel)
            {
                throw new Exception("Escolha uma data a partir do mês seguinte");
            }
        }
    }
}
