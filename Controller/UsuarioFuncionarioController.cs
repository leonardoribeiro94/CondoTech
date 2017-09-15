using DataAccessLayer.Repositorios;
using Model;
using Model.QueryModel;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class UsuarioFuncionarioController
    {
        private readonly UsuarioFuncionarioRepositorio _usuarioFuncionarioRep;

        public UsuarioFuncionarioController()
        {
            _usuarioFuncionarioRep = new UsuarioFuncionarioRepositorio();
        }

        public void AlterarUsuario(UsuarioFuncionario usuarioFuncionario) =>
            _usuarioFuncionarioRep.Atualizar(usuarioFuncionario);

        public IEnumerable<ObterUsuarioFuncionario> ObterUsuarioFuncionarios()
            => _usuarioFuncionarioRep.ObterUsuarioFuncionarios();

        public IEnumerable<ObterUsuarioFuncionario> ObterPorLoginFuncionariosUsuarios(string login, string senha)
            => _usuarioFuncionarioRep.ObterPorLoginUsuarioFuncionario(login, senha);

        public IEnumerable<ObterUsuarioFuncionario> ObterPorIdObterUsuarioFuncionarios(int idUsuarioFuncionario)
            =>
                ObterUsuarioFuncionarios().Where(x => x.IdUsuario == idUsuarioFuncionario);

    }
}
