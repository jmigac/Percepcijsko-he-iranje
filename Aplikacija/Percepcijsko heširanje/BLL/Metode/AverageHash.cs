using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Metode
{
    public class AverageHash : Hash
    {
        /// <summary>
        /// Konstruktor funkcije kreira hash vrijednost na temelju izračunatih vrijednosti prosječne brightness vrijednosti na temelju slike koja je pretvorena u grayscale te kasnije s izračunatim vrijednostima uspoređena za izračun finalne hash vrijednosti.
        /// </summary>
        /// <param name="bmpSlika">Bitmap učitana slika</param>
        public AverageHash(Bitmap bmpSlika)
        {
            Bitmap slika = new Bitmap(bmpSlika, new Size(8, 8));
            Bitmap grayscale;
            int x, y, avg, a, r, g, b;
            for (x = 0; x < slika.Width; x++)
            {
                for (y = 0; y < slika.Height; y++)
                {
                    Color bojaPiksela = slika.GetPixel(x, y);
                    a = bojaPiksela.A;
                    r = bojaPiksela.R;
                    g = bojaPiksela.G;
                    b = bojaPiksela.B;
                    avg = (r + g + b) / 3;
                    slika.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            grayscale = slika;
            int avgCrvena = 0, avgZelena = 0, avgPlava = 0;
            for (x = 0; x < grayscale.Width; x++)
            {
                for (y = 0; y < grayscale.Height; y++)
                {
                    r = grayscale.GetPixel(x, y).R;
                    g = grayscale.GetPixel(x, y).G;
                    b = grayscale.GetPixel(x, y).B;
                    avgCrvena += r;
                    avgZelena += g;
                    avgPlava += b;
                }
            }
            Color prosjekBoja = Color.FromArgb(avgCrvena / 64, avgZelena / 64, avgPlava / 64);
            for (x = 0; x < grayscale.Width; x++)
            {
                for (y = 0; y < grayscale.Height; y++)
                {
                    if (grayscale.GetPixel(x, y).GetBrightness() < prosjekBoja.GetBrightness())
                    {
                        hashVrijednost += "1";
                    }
                    else
                    {
                        hashVrijednost += "0";
                    }
                }
            }
        }
        /// <summary>
        /// Funkcija vraća hash vrijednost za izračunati objekt AverageHash.
        /// </summary>
        /// <returns>String hash vrijednosti.</returns>
    }
}
