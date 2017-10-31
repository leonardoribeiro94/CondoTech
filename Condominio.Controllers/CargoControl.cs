using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model.QueryModel;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class CargoControl
    {
        private readonly CargoRepositorio _cargoRepositorio;

        public CargoControl()
        {
            _cargoRepositorio = new CargoRepositorio();
        }

        public IEnumerable<QueryCargos> ObterCargo() => _cargoRepositorio.ObterCargos();
    }
}
