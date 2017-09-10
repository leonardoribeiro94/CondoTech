using Model.Enum;

namespace Model.QueryModel
{
    public class ObterFornecedores
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Descricao { get; set; }
        public EntidadeAtiva Ativo { get; set; }
    }
}
