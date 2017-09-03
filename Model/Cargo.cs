using Model.Componentes;
using System;

namespace Model
{
    public class Cargo : Entidade
    {
        #region Propriedades
        public string Nome { get; set; }
        public string Descricao { get; set; }
        #endregion

        #region Metodos
        public void ValidaDados()
        {
            if (Nome.Length < 5)
            {
                throw new Exception(MensagensDeValidacao.Nome);
            }
            if (Descricao.Length < 10)
            {
                throw new Exception("Informe uma descrição consistente para este cargo!");
            }
        }
        #endregion
    }
}