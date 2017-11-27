using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System.Collections.Generic;
using System.Linq;

namespace Condominio.Controllers
{
    public class UsuarioFuncionarioControl
    {
        private readonly UsuarioFuncionarioRepositorio _usuarioFuncionarioRep;

        public UsuarioFuncionarioControl()
        {
            _usuarioFuncionarioRep = new UsuarioFuncionarioRepositorio();
        }

        public void AlterarUsuario(UsuarioFuncionario usuarioFuncionario) =>
            _usuarioFuncionarioRep.Atualizar(usuarioFuncionario);

        public IEnumerable<QueryUsuarioFuncionario> ObterUsuarioFuncionarios()
            => _usuarioFuncionarioRep.ObterUsuarioFuncionarios();

        public IEnumerable<QueryUsuarioFuncionario> ObterPorLoginFuncionariosUsuarios(string login, string senha)
            => _usuarioFuncionarioRep.ObterPorLoginUsuarioFuncionario(login, senha);

        public IEnumerable<QueryUsuarioFuncionario> ObterPorIdObterUsuarioFuncionarios(int idUsuarioFuncionario)
            =>
                ObterUsuarioFuncionarios().Where(x => x.IdUsuario == idUsuarioFuncionario);

        public IEnumerable<QueryUsuarioFuncionario> ObterPorCpfUsuarioFuncionarios(string cpf)
            => _usuarioFuncionarioRep.ObterUsuarioFuncionarios().Where(x => x.Cpf == cpf.Replace("-", ""));
    }
}
