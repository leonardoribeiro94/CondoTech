using DataAccessLayer.Repositorios;
using Model;
using Model.QueryModel;
using System.Collections.Generic;

namespace Controller
{
    public class VisitanteController
    {
        private readonly VisitanteRepositorio _visitanteRepositorio;

        public VisitanteController()
        {
            _visitanteRepositorio = new VisitanteRepositorio();
        }

        public void InserirVisitante(Visitante visitante) => _visitanteRepositorio.Inserir(visitante);

        public void AlterarVisitante(Visitante visitante) => _visitanteRepositorio.Alterar(visitante);

        public void DeletarVisitante(int id) => _visitanteRepositorio.Deletar(id);

        public IEnumerable<ObterVisitante> ObterVisitantes()
        {
            return _visitanteRepositorio.ObterVisitantes();
        }
    }
}
