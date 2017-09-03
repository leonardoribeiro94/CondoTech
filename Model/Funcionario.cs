namespace Model
{
    public class Funcionario : Pessoa
    {
        #region Construtor
        public Funcionario()
        {
            Cargo = new Cargo();
        }
        #endregion

        #region Propriedades
        public Cargo Cargo { get; set; }
        public UsuarioFuncionario UsuarioFuncionario { get; set; }
        #endregion

    }
}
