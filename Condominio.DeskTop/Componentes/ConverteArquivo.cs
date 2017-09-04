using System;
using System.IO;

namespace Condominio.DeskTop.Componentes
{
    public static class ConverteArquivo
    {
        public static byte[] ParaByte(Stream fileStream)
        {
            using (var binaryReader = new BinaryReader(fileStream))
            {
                byte[] byteImg = binaryReader.ReadBytes(Convert.ToInt32(fileStream.Length));

                if (fileStream.Length > 0)
                {
                    fileStream.Read(byteImg, 0, Convert.ToInt32(byteImg.Length));
                }

                if (fileStream.Length == 0)
                {
                    byteImg = null;
                }

                return byteImg;
            }
        }
    }
}
