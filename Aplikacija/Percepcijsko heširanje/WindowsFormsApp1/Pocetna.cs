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
using BLL.Metode;
namespace WindowsFormsApp1
{
    public partial class Pocetna : Form
    {
        private bool ucitanaPrvaSlika;
        private bool ucitanaDrugaSlika;
        private Slika slika1;
        private Slika slika2;
        private Bitmap bmpSlika1;
        private Bitmap bmpSlika2;
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
                    bmpSlika1 = new Bitmap(slika1.GetPutanjaSlike());
                    pbSlika1.SizeMode = PictureBoxSizeMode.Zoom;
                    pbSlika1.Image = bmpSlika1;
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
                    bmpSlika2 = new Bitmap(slika2.GetPutanjaSlike());
                    pbSlika2.SizeMode = PictureBoxSizeMode.Zoom;
                    pbSlika2.Image = bmpSlika2;
                }
            }
        }

        private void btnAverageHash_Click(object sender, EventArgs e)
        {
            try
            {
                AverageHash aHash1 = new AverageHash(bmpSlika1);
                AverageHash aHash2 = new AverageHash(bmpSlika2);
                lblHashPrveSlike.Text = "Hash prve slike:  " + aHash1.GetHash();
                lblHashDrugeSlike.Text = "Hash druge slike:" + aHash2.GetHash();
                int brojIstihBitova = AverageHash.IzracunavanjeSlicnihBitova(aHash1.GetHash(), aHash2.GetHash());
                lblIstiBitovi.Text = "Isti bitovi:" + " " + brojIstihBitova.ToString();
                int brojRazlicitihBitova = AverageHash.IzracunavanjeRazlicitihBitova(aHash1.GetHash(), aHash2.GetHash());
                lblRazliciti1.Text = brojRazlicitihBitova.ToString();
                double prosjek = AverageHash.IzracunajPostotakSlicnosti(brojIstihBitova, brojRazlicitihBitova, aHash1.GetHash().Length);
                lblRazliciti2.Text = prosjek.ToString() + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Niste uploadali sliku!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnDifferenceHash_Click(object sender, EventArgs e)
        {
            try
            {
                DifferenceHash dHash1 = new DifferenceHash(bmpSlika1);
                DifferenceHash dHash2 = new DifferenceHash(bmpSlika2);
                lblHashPrveSlike.Text = "Hash prve slike:  " + dHash1.GetHash();
                lblHashDrugeSlike.Text = "Hash druge slike:" + dHash2.GetHash();
                int brojIstihBitova = DifferenceHash.IzracunavanjeSlicnihBitova(dHash1.GetHash(), dHash2.GetHash());
                lblIstiBitovi.Text = "Isti bitovi:" + " " + brojIstihBitova.ToString();
                int brojRazlicitihBitova = DifferenceHash.IzracunavanjeRazlicitihBitova(dHash1.GetHash(), dHash2.GetHash());
                lblRazliciti1.Text = brojRazlicitihBitova.ToString();
                double prosjek = DifferenceHash.IzracunajPostotakSlicnosti(brojIstihBitova, brojRazlicitihBitova, dHash1.GetHash().Length);
                lblRazliciti2.Text = prosjek.ToString() + "%";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Niste uploadali sliku!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPerceptualHash_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
