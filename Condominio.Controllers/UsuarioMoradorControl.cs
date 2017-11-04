using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model.QueryModel;

namespace Condominio.Controllers
{

    public class UsuarioMoradorControl
    {
        private readonly UsuarioMoradorRepositorio _usuarioMoradorRepositorio;

        public UsuarioMoradorControl()
        {
            _usuarioMoradorRepositorio = new UsuarioMoradorRepositorio();
        }

        public QueryUsuarioMorador ObterUsuarioMoradorPorLogin(string login, string senha)
            => _usuarioMoradorRepositorio.ObterUsuarioMoradorPorLogin(login, senha);
    }
}
