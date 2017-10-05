using System.Collections.Generic;
using System.Linq;
using Condominio.Model;

namespace Condominio.DataAccesLayer.Repositorios.FalsoRepositorio
{
    public class FuncionarioFalsoRepositorio
    {
        private readonly List<Funcionario> _listaFuncionario;

        public FuncionarioFalsoRepositorio()
        {
            if (_listaFuncionario == null)
            {
                _listaFuncionario = new List<Funcionario>();
            }
        }

        public Funcionario ObterPorId(int id)
        {
            return _listaFuncionario.FirstOrDefault(x => x.Id == id);
        }

        public void Cadastrar(Funcionario funcionario)
        {
            var id = 1;

            while (_listaFuncionario.Any(x => x.Id == id))
            {
                id++;
            }

            funcionario.Id = id;
            _listaFuncionario.Add(funcionario);
        }

        public void Atualizar(Funcionario funcionario)
        {
            var funcionarioExistente = ObterPorId(funcionario.Id);

            foreach (var propriedade in typeof(Funcionario).GetProperties().Where(x => x.Name != "id"))
            {
                propriedade.SetValue(funcionarioExistente, propriedade.GetValue(funcionario));
            }
        }

        public void Excluir(int id)
        {
            var funcionario = ObterPorId(id);

            _listaFuncionario.Remove(funcionario);
        }

        public IEnumerable<Funcionario> Listar()
        {
            return _listaFuncionario.OrderBy(x => x.Nome);
        }
    }
}
