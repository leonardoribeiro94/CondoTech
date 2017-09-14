using Model.Enum;

namespace Model
{
    public abstract class Usuario : Entidade
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public EntidadeAtiva EntidadeAtiva { get; set; }
        public SenhaTemporaria SenhaTemporaria { get; set; }
    }
}
