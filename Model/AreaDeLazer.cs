using Model.Componentes;
using Model.Enum;
using System;

namespace Model
{
    public class AreaDeLazer
    {
        #region Construtor

        public AreaDeLazer()
        {
            EntidadeAtiva = new EntidadeAtiva();
        }

        #endregion

        #region Propriedades

        public int Id { get; set; }
        public byte[] Imagem { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public EntidadeAtiva EntidadeAtiva { get; set; }

        #endregion

        #region Medotos

        public void ValidaDados()
        {
            if (Nome.Length < 5)
            {
                throw new Exception(MensagensDeValidacao.Nome);
            }

            if (Descricao.Length < 10)
            {
                throw new Exception("Descrição informada possui poucos caracteres!");
            }
        }

        #endregion

    }
}
