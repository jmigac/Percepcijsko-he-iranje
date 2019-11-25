namespace WindowsFormsApp1
{
    partial class Pocetna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbSlika1 = new System.Windows.Forms.PictureBox();
            this.pbSlika2 = new System.Windows.Forms.PictureBox();
            this.labelSlika1 = new System.Windows.Forms.Label();
            this.labelSlika2 = new System.Windows.Forms.Label();
            this.btnUcitajSliku1 = new System.Windows.Forms.Button();
            this.btnUcitajSliku2 = new System.Windows.Forms.Button();
            this.btnAverageHash = new System.Windows.Forms.Button();
            this.btnDifferenceHash = new System.Windows.Forms.Button();
            this.btnPerceptualHash = new System.Windows.Forms.Button();
            this.btnWaveletHash = new System.Windows.Forms.Button();
            this.lblHashPrveSlike = new System.Windows.Forms.Label();
            this.lblHashDrugeSlike = new System.Windows.Forms.Label();
            this.lblIstiBitovi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRazliciti1 = new System.Windows.Forms.Label();
            this.lblRazliciti2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlika1
            // 
            this.pbSlika1.Location = new System.Drawing.Point(42, 37);
            this.pbSlika1.Name = "pbSlika1";
            this.pbSlika1.Size = new System.Drawing.Size(187, 160);
            this.pbSlika1.TabIndex = 0;
            this.pbSlika1.TabStop = false;
            // 
            // pbSlika2
            // 
            this.pbSlika2.Location = new System.Drawing.Point(277, 36);
            this.pbSlika2.Name = "pbSlika2";
            this.pbSlika2.Size = new System.Drawing.Size(187, 160);
            this.pbSlika2.TabIndex = 0;
            this.pbSlika2.TabStop = false;
            // 
            // labelSlika1
            // 
            this.labelSlika1.AutoSize = true;
            this.labelSlika1.Location = new System.Drawing.Point(114, 21);
            this.labelSlika1.Name = "labelSlika1";
            this.labelSlika1.Size = new System.Drawing.Size(39, 13);
            this.labelSlika1.TabIndex = 1;
            this.labelSlika1.Text = "Slika1:";
            // 
            // labelSlika2
            // 
            this.labelSlika2.AutoSize = true;
            this.labelSlika2.Location = new System.Drawing.Point(351, 20);
            this.labelSlika2.Name = "labelSlika2";
            this.labelSlika2.Size = new System.Drawing.Size(39, 13);
            this.labelSlika2.TabIndex = 1;
            this.labelSlika2.Text = "Slika2:";
            // 
            // btnUcitajSliku1
            // 
            this.btnUcitajSliku1.Location = new System.Drawing.Point(97, 203);
            this.btnUcitajSliku1.Name = "btnUcitajSliku1";
            this.btnUcitajSliku1.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajSliku1.TabIndex = 2;
            this.btnUcitajSliku1.Text = "Ucitaj";
            this.btnUcitajSliku1.UseVisualStyleBackColor = true;
            this.btnUcitajSliku1.Click += new System.EventHandler(this.btnUcitajSliku1_Click);
            // 
            // btnUcitajSliku2
            // 
            this.btnUcitajSliku2.Location = new System.Drawing.Point(335, 203);
            this.btnUcitajSliku2.Name = "btnUcitajSliku2";
            this.btnUcitajSliku2.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajSliku2.TabIndex = 3;
            this.btnUcitajSliku2.Text = "Ucitaj";
            this.btnUcitajSliku2.UseVisualStyleBackColor = true;
            this.btnUcitajSliku2.Click += new System.EventHandler(this.btnUcitajSliku2_Click);
            // 
            // btnAverageHash
            // 
            this.btnAverageHash.Enabled = false;
            this.btnAverageHash.Location = new System.Drawing.Point(92, 248);
            this.btnAverageHash.Name = "btnAverageHash";
            this.btnAverageHash.Size = new System.Drawing.Size(75, 59);
            this.btnAverageHash.TabIndex = 4;
            this.btnAverageHash.Text = "Average Hash";
            this.btnAverageHash.UseVisualStyleBackColor = true;
            this.btnAverageHash.Click += new System.EventHandler(this.btnAverageHash_Click);
            // 
            // btnDifferenceHash
            // 
            this.btnDifferenceHash.Enabled = false;
            this.btnDifferenceHash.Location = new System.Drawing.Point(173, 248);
            this.btnDifferenceHash.Name = "btnDifferenceHash";
            this.btnDifferenceHash.Size = new System.Drawing.Size(75, 59);
            this.btnDifferenceHash.TabIndex = 5;
            this.btnDifferenceHash.Text = "Difference Hash";
            this.btnDifferenceHash.UseVisualStyleBackColor = true;
            this.btnDifferenceHash.Click += new System.EventHandler(this.btnDifferenceHash_Click);
            // 
            // btnPerceptualHash
            // 
            this.btnPerceptualHash.Enabled = false;
            this.btnPerceptualHash.Location = new System.Drawing.Point(254, 248);
            this.btnPerceptualHash.Name = "btnPerceptualHash";
            this.btnPerceptualHash.Size = new System.Drawing.Size(75, 59);
            this.btnPerceptualHash.TabIndex = 6;
            this.btnPerceptualHash.Text = "Perception Hash";
            this.btnPerceptualHash.UseVisualStyleBackColor = true;
            this.btnPerceptualHash.Click += new System.EventHandler(this.btnPerceptualHash_Click);
            // 
            // btnWaveletHash
            // 
            this.btnWaveletHash.Enabled = false;
            this.btnWaveletHash.Location = new System.Drawing.Point(335, 248);
            this.btnWaveletHash.Name = "btnWaveletHash";
            this.btnWaveletHash.Size = new System.Drawing.Size(75, 59);
            this.btnWaveletHash.TabIndex = 7;
            this.btnWaveletHash.Text = "Wavelet Hash";
            this.btnWaveletHash.UseVisualStyleBackColor = true;
            // 
            // lblHashPrveSlike
            // 
            this.lblHashPrveSlike.AutoSize = true;
            this.lblHashPrveSlike.Location = new System.Drawing.Point(13, 337);
            this.lblHashPrveSlike.Name = "lblHashPrveSlike";
            this.lblHashPrveSlike.Size = new System.Drawing.Size(83, 13);
            this.lblHashPrveSlike.TabIndex = 8;
            this.lblHashPrveSlike.Text = "Hash prve slike:";
            // 
            // lblHashDrugeSlike
            // 
            this.lblHashDrugeSlike.AutoSize = true;
            this.lblHashDrugeSlike.Location = new System.Drawing.Point(13, 360);
            this.lblHashDrugeSlike.Name = "lblHashDrugeSlike";
            this.lblHashDrugeSlike.Size = new System.Drawing.Size(89, 13);
            this.lblHashDrugeSlike.TabIndex = 8;
            this.lblHashDrugeSlike.Text = "Hash druge slike:";
            // 
            // lblIstiBitovi
            // 
            this.lblIstiBitovi.AutoSize = true;
            this.lblIstiBitovi.Location = new System.Drawing.Point(13, 384);
            this.lblIstiBitovi.Name = "lblIstiBitovi";
            this.lblIstiBitovi.Size = new System.Drawing.Size(51, 13);
            this.lblIstiBitovi.TabIndex = 8;
            this.lblIstiBitovi.Text = "Isti bitovi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Različiti bitovi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // lblRazliciti1
            // 
            this.lblRazliciti1.AutoSize = true;
            this.lblRazliciti1.Location = new System.Drawing.Point(93, 407);
            this.lblRazliciti1.Name = "lblRazliciti1";
            this.lblRazliciti1.Size = new System.Drawing.Size(32, 13);
            this.lblRazliciti1.TabIndex = 8;
            this.lblRazliciti1.Text = "bitovi";
            // 
            // lblRazliciti2
            // 
            this.lblRazliciti2.AutoSize = true;
            this.lblRazliciti2.Location = new System.Drawing.Point(93, 428);
            this.lblRazliciti2.Name = "lblRazliciti2";
            this.lblRazliciti2.Size = new System.Drawing.Size(32, 13);
            this.lblRazliciti2.TabIndex = 8;
            this.lblRazliciti2.Text = "bitovi";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRazliciti2);
            this.Controls.Add(this.lblRazliciti1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIstiBitovi);
            this.Controls.Add(this.lblHashDrugeSlike);
            this.Controls.Add(this.lblHashPrveSlike);
            this.Controls.Add(this.btnWaveletHash);
            this.Controls.Add(this.btnPerceptualHash);
            this.Controls.Add(this.btnDifferenceHash);
            this.Controls.Add(this.btnAverageHash);
            this.Controls.Add(this.btnUcitajSliku2);
            this.Controls.Add(this.btnUcitajSliku1);
            this.Controls.Add(this.labelSlika2);
            this.Controls.Add(this.labelSlika1);
            this.Controls.Add(this.pbSlika2);
            this.Controls.Add(this.pbSlika1);
            this.Name = "Pocetna";
            this.Text = "Percepcijsko heširanje";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlika1;
        private System.Windows.Forms.PictureBox pbSlika2;
        private System.Windows.Forms.Label labelSlika1;
        private System.Windows.Forms.Label labelSlika2;
        private System.Windows.Forms.Button btnUcitajSliku1;
        private System.Windows.Forms.Button btnUcitajSliku2;
        private System.Windows.Forms.Button btnAverageHash;
        private System.Windows.Forms.Button btnDifferenceHash;
        private System.Windows.Forms.Button btnPerceptualHash;
        private System.Windows.Forms.Button btnWaveletHash;
        private System.Windows.Forms.Label lblHashPrveSlike;
        private System.Windows.Forms.Label lblHashDrugeSlike;
        private System.Windows.Forms.Label lblIstiBitovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRazliciti1;
        private System.Windows.Forms.Label lblRazliciti2;
    }
}

