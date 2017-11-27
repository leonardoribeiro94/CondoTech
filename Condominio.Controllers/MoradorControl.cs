using Condominio.DataAccesLayer.Repositorios;
using Condominio.Model;
using Condominio.Model.QueryModel;
using System;
using System.Collections.Generic;

namespace Condominio.Controllers
{
    public class MoradorControl
    {
        private readonly MoradorRepositorio _moradorRepositorio;

        public MoradorControl()
        {
            _moradorRepositorio = new MoradorRepositorio();
        }

        public void InserirMorador(Morador morador) => _moradorRepositorio.Inserir(morador);

        public void AlterarMorador(Morador morador) => _moradorRepositorio.Alterar(morador);

        public void ExcluirMorador(int id) => _moradorRepositorio.Excluir(id);

        public IEnumerable<QueryMorador> ObterMorador() => _moradorRepositorio.ObterMoradores();

        public ICollection<QueryMorador> ObterMorador(string nome) => _moradorRepositorio.ObterMoradoresPorNome(nome);

        public ICollection<QueryMorador> ObterMorador(string nome, DateTime nascimento) => _moradorRepositorio
            .ObterMoradoresPorNomeEDataDeNascimento(nome, nascimento);

    }
}
