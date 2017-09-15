using DataAccessLayer.Repositorios;
using Model;
using System.Collections.Generic;

namespace Controller
{
    public class DenunciaController
    {
        private readonly DenunciaRepositorio _denunciaRepositorio;

        public DenunciaController()
        {
            _denunciaRepositorio = new DenunciaRepositorio();
        }

        public void InserirDenuncia(Denuncia denuncia) => _denunciaRepositorio.Inserir(denuncia);

        public void AtualizarDenuncia(Denuncia denuncia) => _denunciaRepositorio.Atualizar(denuncia);

        public void DeletarDelnuncia(int id) => _denunciaRepositorio.Excluir(id);

        public IEnumerable<Denuncia> ObterDenuncias() => _denunciaRepositorio.ObterDenuncias();
    }
}
