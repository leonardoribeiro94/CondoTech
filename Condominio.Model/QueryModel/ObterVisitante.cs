using Condominio.Model.Enum;

namespace Condominio.Model.QueryModel
{
    public class ObterVisitante
    {
        public int IdVisitante { get; set; }
        public byte[] Imagem { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public EntidadeAtiva Ativo { get; set; }
    }
}
