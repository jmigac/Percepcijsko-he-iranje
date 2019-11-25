using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Komponente
{
    public class Slika
    {
        private String putanjaSlike;
        private String naslovOpenFileDialog;
        private String filterOpenFileDialog;
        private String hashSlike;

        public Slika()
        {
            this.naslovOpenFileDialog = "Images";
            this.filterOpenFileDialog = "All Images | *.jpg; *.bmp; *.png";

        }
        /// <summary>
        /// Dohvaćanje izračunatog hasha slike.
        /// </summary>
        /// <returns>Hash slike</returns>
        public String GetHashSlike()
        {
            return this.hashSlike;
        }
        /// <summary>
        /// Postavljanje hash vrijednosti u obliku string vrijednosti.
        /// </summary>
        /// <param name="hash">Hash vrijednost</param>
        public void SetHashSlike(String hash)
        {
            this.hashSlike = hash;
        }
        /// <summary>
        /// Dohvaćanje putanje slike koja je učitana za odabrani objekt.
        /// </summary>
        /// <returns>Vraća putanja do slike na disku.</returns>
        public String GetPutanjaSlike()
        {
            return this.putanjaSlike;
        }
        /// <summary>
        /// Postavljanje putanje slike za određeni objekt koji se upravljaju svojstva određene slike.
        /// </summary>
        /// <param name="putanja"></param>
        public void SetPutanjaSlike(string putanja)
        {
            this.putanjaSlike = putanja;
        }
        /// <summary>
        /// Dohvaćanje vrijednosti o tipu dokumenta koji će se otvarati.
        /// </summary>
        /// <returns>Tip dokumenta</returns>
        public String GetNaslov()
        {
            return this.naslovOpenFileDialog;
        }
        /// <summary>
        /// Dohvaćanje vrijednosti filtera koje datoteke je moguće učitati u program.
        /// </summary>
        /// <returns>Filter za otvaranje datoteka.</returns>
        public String GetFilter()
        {
            return this.filterOpenFileDialog;
        }

    }
}
