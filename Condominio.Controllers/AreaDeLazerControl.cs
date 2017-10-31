using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class AreaDeLazerControl
    {
        private readonly AreaDeLazerRepositorio _areaDeLazerRepositorio = new AreaDeLazerRepositorio();

        public void InserirAreaDeLazer(AreaDeLazer areaDeLazer) => _areaDeLazerRepositorio.Inserir(areaDeLazer);

        public void AlterarAreaDeLazer(AreaDeLazer areaDeLazer) => _areaDeLazerRepositorio.Atualizar(areaDeLazer);

        public void DeletarAreaDeLazer(int codigoAreaDeLazer) => _areaDeLazerRepositorio.Excluir(codigoAreaDeLazer);

        public IEnumerable<QueryAreaDeLazer> ObterAreaDeLazer() => _areaDeLazerRepositorio.ObterAreasDeLazer();
    }

}
