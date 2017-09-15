using System;

namespace Model
{
    public class Informativo
    {
        public Informativo()
        {
            Funcionario = new Funcionario();
        }

        #region Propriedades

        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        #endregion


        #region Metodos

        public void ValidaDescricao()
        {
            if (Descricao.Length < 10)
            {
                throw new Exception("A descrição possui caracteres insuficientes!");
            }
        }

        #endregion

    }
}
