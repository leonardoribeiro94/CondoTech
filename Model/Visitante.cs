using System;

namespace Model
{
    public class Visitante : Pessoa
    {
        public byte[] Imagem { get; set; }


        public void ValidaImagem()
        {
            if (Imagem.Length < 1)
            {
                throw new Exception("Insira uma imagem");
            }
        }
    }
}
