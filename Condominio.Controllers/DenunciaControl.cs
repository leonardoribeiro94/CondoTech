using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System;
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

        public IEnumerable<QueryDenuncia> ObterDenuncias() => _denunciaRepositorio.ObterDenuncias();

        public IEnumerable<QueryDenuncia> ObterDenunciasPorData(DateTime dataInicial, DateTime dataFinal)
            => _denunciaRepositorio.ObterDenunciasPorData(dataInicial, dataFinal);

        public QueryDenuncia ObterDenunciaPorId(int idDenuncia)
            => _denunciaRepositorio.ObterDenunciaPorId(idDenuncia);

    }
}
