using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Metode
{
    public class DifferenceHash : Hash
    {
  
        private String rHashVrijednost;
        private String cHashVrijednost;

        /// <summary>
        /// Konstruktor klase DifferenceHash generira hash vrijednost slika na temelju izračunatih vrijednosti rHashVrijednost i cHashVrijednost koji su zapravo usporedba prethodnika i sljedbenika za određeni stupac, odnosno redak.
        /// </summary>
        /// <param name="slika">Bitmap slika.</param>
        public DifferenceHash(Bitmap slika)
        {
            Bitmap pomocnaSlika = new Bitmap(slika, new Size(9, 9));
            Bitmap grayscale;
            int x, y, avg, a, r, g, b;
            for (x = 0; x < pomocnaSlika.Width; x++)
            {
                for (y = 0; y < pomocnaSlika.Height; y++)
                {
                    Color bojaPiksela = pomocnaSlika.GetPixel(x, y);
                    a = bojaPiksela.A;
                    r = bojaPiksela.R;
                    g = bojaPiksela.G;
                    b = bojaPiksela.B;
                    avg = (r + g + b) / 3;
                    pomocnaSlika.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            grayscale = pomocnaSlika;
            for(int redak = 0; redak < 8; redak++)
            {
                for(int stupac = 0; stupac < 8; stupac++)
                {
                    if (grayscale.GetPixel(stupac, redak + 1).R >= grayscale.GetPixel(stupac, redak).R)
                    {
                        rHashVrijednost += "1";
                    }
                    else
                    {
                        rHashVrijednost += "0";
                    }
                }
            }
            for (int stupac = 0; stupac < 8; stupac++)
            {
                for (int redak = 0; redak < 8; redak++)
                {
                    if (grayscale.GetPixel(stupac+1, redak).R >= grayscale.GetPixel(stupac, redak).R)
                    {
                        cHashVrijednost += "1";
                    }
                    else
                    {
                        cHashVrijednost += "0";
                    }
                }
            }
            PostaviHashVrijednost();

        }
        /// <summary>
        /// Funkcija zbraja rHashVrijednost i cHashVrijednost, odnosno spaja navedene stringove.
        /// </summary>
        private void PostaviHashVrijednost()
        {
            if(rHashVrijednost != "" && cHashVrijednost != "")
            {
                hashVrijednost = rHashVrijednost + cHashVrijednost;
            }
        }
    }
}
