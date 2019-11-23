using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Komponente;
namespace WindowsFormsApp1
{
    public partial class Pocetna : Form
    {
        private bool ucitanaPrvaSlika;
        private bool ucitanaDrugaSlika;
        private Slika slika1;
        private Slika slika2;
        public Pocetna()
        {
            InitializeComponent();
            ucitanaPrvaSlika = false;
            ucitanaDrugaSlika = false;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {

        }
        private void ProvjeriUcitaneSlike()
        {
            if (ucitanaPrvaSlika && ucitanaDrugaSlika)
            {
                btnAverageHash.Enabled = true;
                btnDifferenceHash.Enabled = true;
                btnPerceptualHash.Enabled = true;
                btnWaveletHash.Enabled = true;
            }
        }
        private void btnUcitajSliku1_Click(object sender, EventArgs e)
        {
            slika1 = new Slika();
            OpenFileDialog ucitajSliku = new OpenFileDialog();
            ucitajSliku.Title = slika1.GetNaslov();
            ucitajSliku.Filter = slika1.GetFilter();
            if(ucitajSliku.ShowDialog() == DialogResult.OK)
            {
                if(ucitajSliku.FileName != "")
                {
                    slika1.SetPutanjaSlike(ucitajSliku.FileName);
                    ucitanaPrvaSlika = true;
                    ProvjeriUcitaneSlike();
                }
            }
        }

        private void btnUcitajSliku2_Click(object sender, EventArgs e)
        {
            slika2 = new Slika();
            OpenFileDialog ucitajSliku = new OpenFileDialog();
            ucitajSliku.Title = slika2.GetNaslov();
            ucitajSliku.Filter = slika2.GetFilter();
            if (ucitajSliku.ShowDialog() == DialogResult.OK)
            {
                if (ucitajSliku.FileName != "")
                {
                    slika2.SetPutanjaSlike(ucitajSliku.FileName);
                    ucitanaDrugaSlika = true;
                    ProvjeriUcitaneSlike();
                }
            }
        }
    }
}
