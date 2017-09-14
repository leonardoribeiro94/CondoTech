using DataAccessLayer.Repositorios;
using Model.QueryModel;
using System.Collections.Generic;

namespace Controller
{
    public class UsuarioFuncionarioController
    {
        private readonly UsuarioFuncionarioRepositorio _usuarioFuncionarioRep;

        public UsuarioFuncionarioController()
        {
            _usuarioFuncionarioRep = new UsuarioFuncionarioRepositorio();
        }

        public IEnumerable<ObterUsuarioFuncionario> ObterUsuarioFuncionarios()
            => _usuarioFuncionarioRep.ObterUsuarioFuncionarios();

        public IEnumerable<ObterUsuarioFuncionario> ObterPorLoginFuncionariosUsuarios(string login, string senha)
            => _usuarioFuncionarioRep.ObterPorLoginUsuarioFuncionario(login, senha);
    }
}
