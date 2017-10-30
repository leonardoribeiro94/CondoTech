using System;

namespace Condominio.Model
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
        public byte[] Documento { get; set; }
        public string TipoDocumento { get; set; }
        #endregion


        #region Metodos

        public void ValidaDados()
        {
            if (Titulo.Length < 5)
            {
                throw new Exception("O título possui caracteres insuficientes!");
            }

            if (Descricao.Length < 10)
            {
                throw new Exception("A descrição possui caracteres insuficientes!");
            }

            if (Documento != null)
            {
                if (!TipoDocumento.ToLower().Equals(".pdf"))
                {
                    throw new Exception("O documento deve ser de formato PDF!");
                }
            }
            CamposTextosMaiusculos();
        }

        private void CamposTextosMaiusculos()
        {
            Titulo = Titulo.ToUpper();
            Descricao = Descricao.ToUpper();
        }

        #endregion

    }
}
