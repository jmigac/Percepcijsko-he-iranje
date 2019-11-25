using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shipwreck.Phash;
using Shipwreck.Phash.Bitmaps;
namespace BLL.Metode
{
    public class PerceptionHash : Hash
    {
        private Digest prvobitniHashSlike;
        /// <summary>
        /// Konstruktor izračunava hash vrijednost u string obliku i učahuruje unutar klase.
        /// </summary>
        /// <param name="bitmap">Bitmap slika</param>
        public PerceptionHash(Bitmap bitmap)
        {
            this.prvobitniHashSlike = ImagePhash.ComputeDigest(bitmap.ToLuminanceImage());
            byte[] hashSlikeBytes = Encoding.ASCII.GetBytes(this.prvobitniHashSlike.ToString());
            this.hashVrijednost = GetBitsFromBytes(new BitArray(hashSlikeBytes));
        }
        /// <summary>
        /// Funkcija vraća originalni zapis hash vrijednosti slike.
        /// </summary>
        /// <returns>Vraća Digest prosljeđene slike.</returns>
        public Digest GetDigest()
        {
            return this.prvobitniHashSlike;
        }
        /// <summary>
        /// Funkcija izračunava sličnost između dviju percepcijskih hasheva. 
        /// </summary>
        /// <param name="pHashPrveSlike">Digest slike</param>
        /// <param name="pHashDrugeSlike">Digest slike</param>
        /// <returns>Postotak sličnosti dviju slika.</returns>
        public static double IzracunajSlicnostPercepcijskogHasha(PerceptionHash pHashPrveSlike, PerceptionHash pHashDrugeSlike)
        {
            return ImagePhash.GetCrossCorrelation(pHashPrveSlike.GetDigest(), pHashDrugeSlike.GetDigest()) * 100;
        }
    }
}
