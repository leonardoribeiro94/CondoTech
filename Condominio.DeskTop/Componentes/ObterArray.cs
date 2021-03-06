﻿using Condominio.CrossCutting.Resources;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Condominio.DeskTop.Componentes
{
    public static class ObterArray
    {
        public static byte[] PictureBox(PictureBox picture)
        {
            using (var memoryStream = new MemoryStream())
            {
                picture.Image?.Save(memoryStream, ImageFormat.Bmp);
                var imagemParaBase64 = Convert.ToString("data:image/jpeg;base64," + Convert.ToBase64String(memoryStream.ToArray()));
                var larguraArray = imagemParaBase64.ToArray().Length;

                return larguraArray < 2097152 ? memoryStream.ToArray() : throw new Exception(MensagensDoSistema.ImagemMuitoGrande);
            }
        }
    }
}
