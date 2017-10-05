using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class HistoricoVisitaControl
    {
        private readonly HistoricoVisitaRepositorio _historicoVisitaRepositorio;

        public HistoricoVisitaControl()
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
