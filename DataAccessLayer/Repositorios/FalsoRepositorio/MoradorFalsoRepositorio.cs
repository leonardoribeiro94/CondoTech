using Model;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositorios.FalsoRepositorio
{
    public class MoradorFalsoRepositorio
    {
        //como o foco nao é banco de dados[por enquanto], criei uma lista
        private static List<Morador> _listaMorador;

        public MoradorFalsoRepositorio()
        {
            if (_listaMorador == null)
            {
                //caso nossa lista nao for instanciada, ele cria a nova instancia
                _listaMorador = new List<Morador>();
            }
        }

        public Morador ObterPorId(int id)
        {
            return _listaMorador.SingleOrDefault(m => m.Id == id);
        }

        public void Cadastrar(Morador morador)
        {
            var id = 1;

            while (_listaMorador.Any(x => x.Id == id))
            {
                //vai incrementando a variavel até que nao existir um Id
                //com aquele valor
                id++;
            }

            morador.Id = id;

            _listaMorador.Add(morador);
        }

        public void Atualizar(Morador morador)
        {
            var moradorExistente = ObterPorId(morador.Id);

            if (moradorExistente != null)
            {
                /*
                 usando reflection, pegamos todas as propriedades
                 daquela pessoa com exceção do Id
                 e adicionamos o novo valor do objeto
                */
                foreach (var propriedade in typeof(Morador).GetProperties().Where(x => x.Name != "Id"))
                {
                    propriedade.SetValue(moradorExistente, propriedade.GetValue(morador));
                }
            }

        }

        public void Deletar(int id)
        {
            var morador = ObterPorId(id);
            _listaMorador.Remove(morador);
        }

        public IEnumerable<Morador> Listar()
        {
            return _listaMorador.OrderBy(x => x.Nome);
        }
    }
}
