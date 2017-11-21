using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class ReservaAreaDeLazerControl
    {
        private readonly ReservaAreaDeLazerRepositorio _reservaAreaRepositorio;

        public ReservaAreaDeLazerControl()
        {
            _reservaAreaRepositorio = new ReservaAreaDeLazerRepositorio();
        }

        public void InserirReservarAreaDeLazer(ReservaAreaDeLazer reserva)
            => _reservaAreaRepositorio.Inserir(reserva);


        public void AlterarReservaAreaDeLazer(ReservaAreaDeLazer reserva)
            => _reservaAreaRepositorio.Alterar(reserva);


        public void DeletarReservaAreaDeLazer(int idReserva)
            => _reservaAreaRepositorio.Deletar(idReserva);


        public ICollection<QueryReservaAreaDeLazer> ObterReservasDeaAreaDeLazer()
            => _reservaAreaRepositorio.ObterReservasAreaDeLazer();


        public ICollection<QueryReservaAreaDeLazer> ObterReservasPorNomedeMorador(string nome)
            => _reservaAreaRepositorio.ObterAreasDeLazerPorNomeMorador(nome);


        public IEnumerable<QueryReservaAreaDeLazer> ObterAreasDeLazerPorIdMorador(int id)
            => _reservaAreaRepositorio.ObterAreasDeLazerPorIdMorador(id);


        public ICollection<QueryReservaAreaDeLazer> ObterReservasPorId(int id)
            => _reservaAreaRepositorio.ObteReservaAreaDeLazerPorId(id);


        public ICollection<string> ObterDatasDaReservaDeUmaAreaDeLazerPorId(int id)
            => _reservaAreaRepositorio.ObterDatasDaReservaDeUmaAreaDeLazerPorId(id);
    }
}
