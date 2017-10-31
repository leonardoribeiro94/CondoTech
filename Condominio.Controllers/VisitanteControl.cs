using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class VisitanteControl
    {
        private readonly VisitanteRepositorio _visitanteRepositorio;

        public VisitanteControl()
        {
            _visitanteRepositorio = new VisitanteRepositorio();
        }

        public void InserirVisitante(Visitante visitante) => _visitanteRepositorio.Inserir(visitante);

        public void AlterarVisitante(Visitante visitante) => _visitanteRepositorio.Alterar(visitante);

        public void DeletarVisitante(int id) => _visitanteRepositorio.Deletar(id);

        public IEnumerable<QueryVisitante> ObterVisitantes()
        {
            return _visitanteRepositorio.ObterVisitantes();
        }
    }
}
