using System;
using System.IO;
using System.Web.Script.Serialization;

namespace Condominio.CrossCutting
{
    public static class ConverteArquivo
    {
        public static byte[] ParaByte(Stream fileStream)
        {
            using (var binaryReader = new BinaryReader(fileStream))
            {
                byte[] byteArray = binaryReader.ReadBytes(Convert.ToInt32(fileStream.Length));

                if (fileStream.Length > 0)
                {
                    fileStream.Read(byteArray, 0, Convert.ToInt32(byteArray.Length));
                }

                return byteArray;
            }
        }

        public static string ParaImagem(byte[] imagem)
        {
            var javaScriptSerializer = new JavaScriptSerializer();

            var imagemParaBase64 = Convert.ToString("data:image/jpeg;base64," + Convert.ToBase64String(imagem));
            var novaImagem = javaScriptSerializer.Serialize(imagemParaBase64);


            return novaImagem;
        }
    }
}
