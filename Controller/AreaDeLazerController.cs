using DataAccessLayer.Repositorios;
using Model;
using Model.QueryModel;
using System.Collections.Generic;

namespace Controller
{
    public class AreaDeLazerController
    {
        private readonly AreaDeLazerRepositorio _areaDeLazerRepositorio = new AreaDeLazerRepositorio();

        public void InserirAreaDeLazer(AreaDeLazer areaDeLazer) => _areaDeLazerRepositorio.Inserir(areaDeLazer);

        public void AlterarAreaDeLazer(AreaDeLazer areaDeLazer) => _areaDeLazerRepositorio.Atualizar(areaDeLazer);

        public void DeletarAreaDeLazer(int codigoAreaDeLazer) => _areaDeLazerRepositorio.Excluir(codigoAreaDeLazer);

        public IEnumerable<ObterAreaDeLazer> ObterAreaDeLazer() => _areaDeLazerRepositorio.ObterAreasDeLazer();
    }

}
