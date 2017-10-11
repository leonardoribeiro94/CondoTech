using AutoMapper;
using Condominio.Controllers;
using Condominio.Model;
using Condominio.Model.QueryModel;
using Condominio.Web.ViewModels.Funcionario;
using System.Collections.Generic;
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
        public ActionResult Index()
        {
            var funcionarioViewModel = Mapper.Map<IEnumerable<ObterFuncionario>,
                IEnumerable<FuncionarioViewModel>>(_funcionarioControl.ListarFuncionarios());

            var cargos = new CargoControl();
            ViewBag.ListadeCargos = new SelectList(cargos.ObterCargo().ToList(), "Id", "Nome");

            return View(funcionarioViewModel);
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FuncionarioViewModel funcionario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var funcionarioModel = Mapper.Map<FuncionarioViewModel, Funcionario>(funcionario);
                    _funcionarioControl.InserirFuncionario(funcionarioModel);

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add Delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
