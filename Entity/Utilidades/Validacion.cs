using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity.Utilidades
{
    public static class Validacion
    {
        public static bool EsNuloOVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }

        public static bool EsTamañoImagenValido(Bitmap bitmap, int tamanoMaximoEnKB)
        {
            if (bitmap == null)
            {
                return false;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, bitmap.RawFormat);
                int tamanoEnKB = (int) ms.Length / 1024; // Convertir bytes a kilobytes

                return tamanoEnKB <= tamanoMaximoEnKB;
            }
        }
    }
}
