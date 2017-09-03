using System;

namespace Model
{
    public class Informativo
    {
        public Informativo()
        {

        }

        #region Propriedades

        public int Id { get; set; }
        public int IdEntidade { get; set; }
        public string TipoInformante;
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
