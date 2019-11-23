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

        public Slika()
        {
            this.naslovOpenFileDialog = "Images";
            this.filterOpenFileDialog = "All Images | *.jpg; *.bmp; *.png";

        }
        public String GetPutanjaSlike()
        {
            return this.putanjaSlike;
        }
        public void SetPutanjaSlike(string putanja)
        {
            this.putanjaSlike = putanja;
        }
        public String GetNaslov()
        {
            return this.naslovOpenFileDialog;
        }
        public String GetFilter()
        {
            return this.filterOpenFileDialog;
        }

    }
}
