﻿using Condominio.CrossCutting.Resources;
using System;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace Condominio.CrossCutting
{
    public static class ConverteArquivo
    {
        private static readonly JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer();

        public static byte[] ParaByte(Stream fileStream)
        {
            using (var binaryReader = new BinaryReader(fileStream))
            {

                byte[] byteArray = binaryReader.ReadBytes(Convert.ToInt32(fileStream.Length));

                if (byteArray.Length > JavaScriptSerializer.MaxJsonLength)
                {
                    throw new Exception("A imagem selecionada é incompatível, altere a imagem para uma semelhante de tamanho menor");
                }

                if (fileStream.Length > 0)
                {
                    fileStream.Read(byteArray, 0, Convert.ToInt32(byteArray.Length));
                }

                return byteArray;
            }
        }

        public static string ParaImagem(byte[] imagem)
        {
            JavaScriptSerializer.MaxJsonLength = int.MaxValue;
            var imagemParaBase64 = Convert.ToString("data:image/jpeg;base64," + Convert.ToBase64String(imagem));
            var tamanhoImagem = imagemParaBase64.ToArray().Length;
            var retorno = tamanhoImagem < JavaScriptSerializer.MaxJsonLength ? JavaScriptSerializer.Serialize(imagemParaBase64)
                : throw new Exception(MensagensDoSistema.ImagemMuitoGrande);

            return retorno;
        }
    }
}
