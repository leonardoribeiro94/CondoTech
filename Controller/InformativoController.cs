using DataAccessLayer.Repositorios;
using Model;
using Model.QueryModel;
using System.Collections.Generic;

namespace Controller
{
    public class InformativoController
    {
        private readonly InformativoRepositorio _informativo;

        public InformativoController()
        {
            _informativo = new InformativoRepositorio();
        }

        public void InserirInformativo(Informativo informativo) => _informativo.Inserir(informativo);

        public void AtualizarInformativo(Informativo informativo) => _informativo.Atualizar(informativo);

        public void DeletarInformativo(int idInformativo) => _informativo.Excluir(idInformativo);

        public IEnumerable<ObterInformativo> ObterInformativos() => _informativo.ObterInformativo();

    }
}
