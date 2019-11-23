using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Metode
{
    public class AverageHash
    {
        private String hashVrijednostSlike;

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
                        hashVrijednostSlike += "1";
                    }
                    else
                    {
                        hashVrijednostSlike += "0";
                    }
                }
            }
        }
        /// <summary>
        /// Funkcija vraća hash vrijednost za izračunati objekt AverageHash.
        /// </summary>
        /// <returns>String hash vrijednosti.</returns>
        public String GetHash()
        {
            return this.hashVrijednostSlike;
        }
        /// <summary>
        /// Funkcija izračunava broj istih bitova na istim pozicijama.
        /// </summary>
        /// <param name="hash1">Average Hash vrijednost prve slike.</param>
        /// <param name="hash2">Average Hash vrijednost druge slike.</param>
        /// <returns>Broj istih bitova na istim indeksima.</returns>
        public static int IzracunavanjeSlicnihBitova(String hash1, String hash2)
        {
            int brojIstihBitova = 0;
            var arraySlovaHash1 = hash1.ToCharArray();
            var arraySlovaHash2 = hash2.ToCharArray();
            for (int i = 0; i < arraySlovaHash1.Length; i++)
            {
                if (arraySlovaHash1[i].Equals(arraySlovaHash2[i]))
                {
                    brojIstihBitova++;
                }
            }
            return brojIstihBitova;
        }
        /// <summary>
        /// Funkcija izračunava broj različitih bitova na istim pozicijama u nizu.
        /// </summary>
        /// <param name="hash1">Average Hash vrijednost slike.</param>
        /// <param name="hash2">Average Hash vrijednost slike.</param>
        /// <returns>Broj različitih bitova na istim indeksima.</returns>
        public static int IzracunavanjeRazlicitihBitova(String hash1, String hash2)
        {
            int brojRazlicitihBitova = 0;
            var arraySlovaHash1 = hash1.ToCharArray();
            var arraySlovaHash2 = hash2.ToCharArray();
            for (int i = 0; i < arraySlovaHash1.Length; i++)
            {
                if (!arraySlovaHash1[i].Equals(arraySlovaHash2[i]))
                {
                    brojRazlicitihBitova++;
                }
            }
            return brojRazlicitihBitova;
        }
        /// <summary>
        /// Funkcija izračuna prosjek sličnosti između istih i različitih bitova.
        /// </summary>
        /// <param name="isti">Broj istih bitova</param>
        /// <param name="razliciti">Broj različitih bitova</param>
        /// <param name="duljinaNiza">Duljina hash vrijednosti</param>
        /// <returns>Prosjek sličnosti.</returns>
        public static double IzracunajPostotakSlicnosti(int isti, int razliciti, int duljinaNiza)
        {
            double prosjek = 0;
            if(isti != 0 && razliciti != 0)
            {
                prosjek = (isti * 100 / duljinaNiza);
            }
            if(isti != 0 && razliciti == 0)
            {
                prosjek = 100;
            }
            return prosjek;
        }
    }
}
