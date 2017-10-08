using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using System.Collections.Generic;
using System.Linq;

namespace Condominio.Controllers
{
    public class CargoControl
    {
        private readonly CargoRepositorio _cargoRepositorio;

        public CargoControl()
        {
            _cargoRepositorio = new CargoRepositorio();
        }

        public IEnumerable<Cargo> ObterCargo() => _cargoRepositorio.ObterCargos();
    }
}
