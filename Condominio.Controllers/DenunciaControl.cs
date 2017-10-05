using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class DenunciaControl
    {
        private readonly DenunciaRepositorio _denunciaRepositorio;

        public DenunciaControl()
        {
            _denunciaRepositorio = new DenunciaRepositorio();
        }

        public void InserirDenuncia(Denuncia denuncia) => _denunciaRepositorio.Inserir(denuncia);

        public void AtualizarDenuncia(Denuncia denuncia) => _denunciaRepositorio.Atualizar(denuncia);

        public void DeletarDelnuncia(int id) => _denunciaRepositorio.Excluir(id);

        public IEnumerable<Denuncia> ObterDenuncias() => _denunciaRepositorio.ObterDenuncias();
    }
}
