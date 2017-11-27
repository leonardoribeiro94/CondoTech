using Condominio.Model.Enum;

namespace Condominio.Model.QueryModel
{
    public class QueryAreaDeLazer
    {
        public int IdAreaDeLazer { get; set; }
        public byte[] Imagem { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public EntidadeAtiva Ativo { get; set; }

    }
}
