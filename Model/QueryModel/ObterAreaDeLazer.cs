using Model.Enum;

namespace Model.QueryModel
{
    public class ObterAreaDeLazer
    {
        public int IdAreaDeLazer { get; set; }
        public byte[] Imagem { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public EntidadeAtiva Ativo { get; set; }

    }
}
