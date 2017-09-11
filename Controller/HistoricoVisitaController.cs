using DataAccessLayer.Repositorios;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class HistoricoVisitaController
    {
        private readonly HistoricoVisitaRepositorio _historicoVisitaRepositorio;

        public HistoricoVisitaController()
        {
            _historicoVisitaRepositorio = new HistoricoVisitaRepositorio();
        }

        public void InserirHistoricoVisita(HistoricoVisita historicoVisita)
            => _historicoVisitaRepositorio.Inserir(historicoVisita);

        public void AlterarHistoricoVisita(HistoricoVisita historicoVisita)
            => _historicoVisitaRepositorio.Inserir(historicoVisita);

        public IEnumerable<HistoricoVisita> ObterHistoricoVisitas()
        => _historicoVisitaRepositorio.ObterHistoricos().ToList();

    }
}
