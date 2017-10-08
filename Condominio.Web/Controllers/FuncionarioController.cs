using Condominio.Controllers;
using Condominio.Model;
using Condominio.Web.ViewModels.Funcionario;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Condominio.Web.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioControl _funcionarioControl;

        public FuncionarioController()
        {
            _funcionarioControl = new FuncionarioControl();
        }
        // GET: Funcionario
        public ActionResult ConsultarFuncionario()
        {
            try
            {
                var lista = _funcionarioControl.ListarFuncionarios();
                return View(lista.ToList());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public ActionResult InserirFuncionario()
        {
            var cargoControl = new CargoControl();
            ViewBag.ListadeCargos = new SelectList(cargoControl.ObterCargo().ToList(), "id", "Nome");

            return View();
        }


        [HttpPost]
        public ActionResult Inserir(FuncionarioViewModel funcionarioVm)
        {
            var funcionario = new Funcionario
            {
                Nome = funcionarioVm.Nome,
                Cpf = funcionarioVm.Cpf,
                Telefone = funcionarioVm.Telefone,
            };

            return Json($"{funcionario.Nome} - {funcionario.DataDeNascimento}");
        }

    }
}