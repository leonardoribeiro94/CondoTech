using DataAccessLayer.Repositorios;
using Model;
using Model.QueryModel;
using System.Collections.Generic;

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
            => _historicoVisitaRepositorio.Alterar(historicoVisita);

        public IEnumerable<ObterHistoricoVisita> ObterHistoricoVisitas()
        => _historicoVisitaRepositorio.ObterHistoricos();

    }
}
