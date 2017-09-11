using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Condominio.DeskTop.Componentes
{
    public static class ObterArray
    {
        public static byte[] PictureBox(PictureBox picture)
        {
            using (var memoryStream = new MemoryStream())
            {
                if (picture.Image != null)
                {
                    picture.Image.Save(memoryStream, ImageFormat.Bmp);
                }

                return memoryStream.ToArray();
            }
        }
    }
}
