using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Metode
{
    public class WaveletHash : Hash
    {
        private const double w0 = 0.5;
        private const double w1 = -0.5;
        private const double s0 = 0.5;
        private const double s1 = 0.5;

        /// <summary>
        /// Funkcija generira hash vrijednost za ulaznu vrijednost Bitmap slike.
        /// </summary>
        /// <param name="bitmap">Bitmap objekt</param>
        public WaveletHash(Bitmap bitmap)
        {
            Bitmap slika = new Bitmap(bitmap, new Size(32, 32));
            Bitmap pomocnaBitmapa;
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
            pomocnaBitmapa = slika;
            double[,] Crvena = new double[pomocnaBitmapa.Width, pomocnaBitmapa.Height];
            double[,] Zelena = new double[pomocnaBitmapa.Width, pomocnaBitmapa.Height];
            double[,] Plava = new double[pomocnaBitmapa.Width, pomocnaBitmapa.Height];

            Color boja;
            for (int j = 0; j < pomocnaBitmapa.Height; j++)
            {
                for (int i = 0; i < pomocnaBitmapa.Width; i++)
                {
                    boja = pomocnaBitmapa.GetPixel(i, j);
                    Crvena[i, j] = (double)Scale(0, 255, -1, 1, boja.R);
                    Zelena[i,j] = (double)Scale(0, 255, -1, 1, boja.G);
                    Plava[i,j] = (double)Scale(0, 255, -1, 1, boja.B);
                }
            }
            FWT(Crvena, 4);
            FWT(Zelena, 4);
            FWT(Plava, 4);

            for (int j = 0; j < pomocnaBitmapa.Height; j++)
            {
                for (int i = 0; i < pomocnaBitmapa.Width; i++)
                {
                    pomocnaBitmapa.SetPixel(i, j, Color.FromArgb((int)Scale(-1, 1, 0, 255, Crvena[i, j]), (int)Scale(-1, 1, 0, 255, Zelena[i, j]), (int)Scale(-1, 1, 0, 255, Plava[i, j])));
                }
            }
            Bitmap bitmapPromjena = new Bitmap(pomocnaBitmapa, new Size(8, 8));
            int avgr = 0, avgg = 0, avgb = 0;
            for (x = 0; x < bitmapPromjena.Width; x++)
            {
                for (y = 0; y < bitmapPromjena.Height; y++)
                {
                    r = bitmapPromjena.GetPixel(x, y).R;
                    g = bitmapPromjena.GetPixel(x, y).G;
                    b = bitmapPromjena.GetPixel(x, y).B;
                    avgr += r;
                    avgg += g;
                    avgb += b;
                }
            }
            Color prosjekBoja = Color.FromArgb(avgr / 64, avgg / 64, avgb / 64);
            for (x = 0; x < bitmapPromjena.Width; x++)
            {
                for (y = 0; y < bitmapPromjena.Height; y++)
                {
                    if (bitmapPromjena.GetPixel(x, y).GetBrightness() < prosjekBoja.GetBrightness())
                        this.hashVrijednost += "1";
                    else
                        this.hashVrijednost += "0";
                }
            }
        }

        private double Scale(double fromMin, double fromMax, double toMin, double toMax, double x)
        {
            if (fromMax - fromMin == 0) return 0;
            double value = (toMax - toMin) * (x - fromMin) / (fromMax - fromMin) + toMin;
            if (value > toMax)
            {
                value = toMax;
            }
            if (value < toMin)
            {
                value = toMin;
            }
            return value;
        }
        /// <summary>
        /// Funkcija računa podatke pojednostavljanja vrijednosti boja na određenim lokacijama za određeni stupac ili redak ovisno o lokaciji.
        /// </summary>
        /// <param name="data">Double vrijednost retka / stupca</param>
        private void FWT(double[] data)
        {
            double[] temp = new double[data.Length];

            int h = data.Length >> 1;
            for (int i = 0; i < h; i++)
            {
                int k = (i << 1);
                temp[i] = data[k] * s0 + data[k + 1] * s1;
                temp[i + h] = data[k] * w0 + data[k + 1] * w1;
            }

            for (int i = 0; i < data.Length; i++)
                data[i] = temp[i];
        }

        /// <summary>
        /// Funkcija generira diskretni wavelet koeficijent od ulaznog signala data koristeći "iterations" iteracija od jednostavnog wavelet filtera definiranog prema Mallatovom algoritmu.
        /// Glavna zadaća je demonstrirati rastavljanje osnovnih boja na s više inačica na manji broj istih dimenzija boja ovisno o iteraciji.
        /// Primjerice Crvena boja --> (početna inačica 128 prikaza crvene) svesti kroz 10 iteracija na recimo 6.
        /// </summary>
        /// <param name="data">Podatak o boji u određenoj skali</param>
        /// <param name="iterations">Broj iteracija</param>
        private void FWT(double[,] data, int iterations)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            double[] row = new double[cols];
            double[] col = new double[rows];

            for (int k = 0; k < iterations; k++)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < row.Length; j++)
                        row[j] = data[i, j];

                    FWT(row);

                    for (int j = 0; j < row.Length; j++)
                        data[i, j] = row[j];
                }

                for (int j = 0; j < cols; j++)
                {
                    for (int i = 0; i < col.Length; i++)
                        col[i] = data[i, j];

                    FWT(col);

                    for (int i = 0; i < col.Length; i++)
                        data[i, j] = col[i];
                }
            }
        }

    }
}
