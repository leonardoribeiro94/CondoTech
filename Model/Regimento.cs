using Model.Componentes;
using System;

namespace Model
{
    public class Regimento : Entidade
    {
        #region Propriedades

        public string Nome;
        public byte[] Documento;
        public Funcionario Funcionario;

        #endregion


        #region Metodos

        public void ValidaNome()
        {
            if (Nome.Length < 3)
            {
                throw new Exception(MensagensDeValidacao.Nome);
            }
        }

        #endregion

    }
}
