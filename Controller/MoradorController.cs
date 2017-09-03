using DataAccessLayer.Repositorios;
using Model;
using Model.QueryModel;
using System;
using System.Collections.Generic;

namespace Controller
{
    public class MoradorController
    {
        private readonly MoradorRepositorio _moradorRepositorio;

        public MoradorController()
        {
            _moradorRepositorio = new MoradorRepositorio();
        }

        public void InserirMorador(Morador morador) => _moradorRepositorio.Inserir(morador);

        public void AlterarMorador(Morador morador) => _moradorRepositorio.Alterar(morador);

        public void ExcluirMorador(int id) => _moradorRepositorio.Excluir(id);

        public IEnumerable<ObterMorador> ObterMorador() => _moradorRepositorio.ObterMoradores();

        public ICollection<ObterMorador> ObterMorador(string nome) => _moradorRepositorio.ObterMoradoresPorNome(nome);

        public ICollection<ObterMorador> ObterMorador(string nome, DateTime nascimento) => _moradorRepositorio
            .ObterMoradoresPorNomeEDataDeNascimento(nome, nascimento);

    }
}
