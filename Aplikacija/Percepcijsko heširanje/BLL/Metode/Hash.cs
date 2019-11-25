using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Metode
{
    public class Hash
    {
        protected String hashVrijednost;

        /// <summary>
        /// Funkcija vraća hash vrijednost za određenu sliku prosljeđenu preko konstruktora.
        /// </summary>
        /// <returns>Hash vrijednost slike.</returns>
        public String GetHash()
        {
            return this.hashVrijednost;
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
            int duljinaPrvogHasha = hash1.Length;
            int duljinaDrugogHasha = hash2.Length;
            if (!duljinaPrvogHasha.Equals(duljinaDrugogHasha))
            {
                throw new Exception("Veličine hash vrijednosti nisu jednake!");
            }
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
            int duljinaPrvogHasha = hash1.Length;
            int duljinaDrugogHasha = hash2.Length;
            if (!duljinaPrvogHasha.Equals(duljinaDrugogHasha))
            {
                throw new Exception("Veličine hash vrijednosti nisu jednake!");
            }
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
            if (isti != 0 && razliciti != 0)
            {
                prosjek = (isti * 100 / duljinaNiza);
            }
            if (isti != 0 && razliciti == 0)
            {
                prosjek = 100;
            }
            return prosjek;
        }
        /// <summary>
        /// Funkcija vraća bitove iz niza bytova u string obliku.
        /// </summary>
        /// <param name="byteZapis">Niz bitova</param>
        /// <returns>String bitova</returns>
        public String GetBitsFromBytes(BitArray bitZapis)
        {
            String outputString = "";
            for (int i = 0; i < bitZapis.Length; i++)
            {
                outputString += bitZapis.Get(i) ? "1" : "0";
            }
            return outputString;
        }
    }
}
