using Condominio.Controllers;
using Condominio.Model;
using Condominio.Web.ViewModels.Funcionario;
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

            var lista = _funcionarioControl.ListarFuncionarios();

            return View(lista.ToList());
        }


        public ActionResult InserirFuncionario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(FuncionarioViewModel funcionarioVm)
        {
            var funcionario = new Funcionario();
            funcionario.Nome = funcionarioVm.Nome;
            funcionario.DataDeNascimento = funcionarioVm.DataDeNascimento;
            return Json($"{funcionario.Nome} - {funcionario.DataDeNascimento}");
        }
    }
}