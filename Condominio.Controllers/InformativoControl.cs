using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class InformativoControl
    {
        private readonly InformativoRepositorio _informativo;

        public InformativoControl()
        {
            _informativo = new InformativoRepositorio();
        }

        public void InserirInformativo(Informativo informativo) => _informativo.Inserir(informativo);

        public void AtualizarInformativo(Informativo informativo) => _informativo.Atualizar(informativo);

        public void DeletarInformativo(int idInformativo) => _informativo.Excluir(idInformativo);

        public IEnumerable<QueryInformativo> ObterInformativos() => _informativo.ObterInformativo();

        public QueryInformativo ObterInformativosPorId(int valor) =>
            _informativo.ObterInformativoPorId(valor);

        public IEnumerable<QueryInformativo> ObterInformativoPorTitulo(string titulo) =>
            _informativo.ObterInformativoPorTitulo(titulo);
    }
}
