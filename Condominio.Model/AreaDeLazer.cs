using System;
using Condominio.Model.Enum;
using Condominio.Model.Componentes;

namespace Condominio.Model
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

        public int IdAreaDeLazer { get; set; }
        public byte[] Imagem { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public EntidadeAtiva EntidadeAtiva { get; set; }

        #endregion

        #region Medotos

        public void ValidaDados()
        {
            if (Imagem.Length < 1)
            {
                throw new Exception("Insira uma Imagem!");
            }
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
