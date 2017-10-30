using System;
using System.IO;

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
    }
}
