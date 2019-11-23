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
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlika1
            // 
            this.pbSlika1.Location = new System.Drawing.Point(13, 37);
            this.pbSlika1.Name = "pbSlika1";
            this.pbSlika1.Size = new System.Drawing.Size(187, 160);
            this.pbSlika1.TabIndex = 0;
            this.pbSlika1.TabStop = false;
            // 
            // pbSlika2
            // 
            this.pbSlika2.Location = new System.Drawing.Point(248, 36);
            this.pbSlika2.Name = "pbSlika2";
            this.pbSlika2.Size = new System.Drawing.Size(187, 160);
            this.pbSlika2.TabIndex = 0;
            this.pbSlika2.TabStop = false;
            // 
            // labelSlika1
            // 
            this.labelSlika1.AutoSize = true;
            this.labelSlika1.Location = new System.Drawing.Point(85, 21);
            this.labelSlika1.Name = "labelSlika1";
            this.labelSlika1.Size = new System.Drawing.Size(39, 13);
            this.labelSlika1.TabIndex = 1;
            this.labelSlika1.Text = "Slika1:";
            // 
            // labelSlika2
            // 
            this.labelSlika2.AutoSize = true;
            this.labelSlika2.Location = new System.Drawing.Point(322, 20);
            this.labelSlika2.Name = "labelSlika2";
            this.labelSlika2.Size = new System.Drawing.Size(39, 13);
            this.labelSlika2.TabIndex = 1;
            this.labelSlika2.Text = "Slika2:";
            // 
            // btnUcitajSliku1
            // 
            this.btnUcitajSliku1.Location = new System.Drawing.Point(68, 203);
            this.btnUcitajSliku1.Name = "btnUcitajSliku1";
            this.btnUcitajSliku1.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajSliku1.TabIndex = 2;
            this.btnUcitajSliku1.Text = "Ucitaj";
            this.btnUcitajSliku1.UseVisualStyleBackColor = true;
            // 
            // btnUcitajSliku2
            // 
            this.btnUcitajSliku2.Location = new System.Drawing.Point(306, 203);
            this.btnUcitajSliku2.Name = "btnUcitajSliku2";
            this.btnUcitajSliku2.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajSliku2.TabIndex = 3;
            this.btnUcitajSliku2.Text = "Ucitaj";
            this.btnUcitajSliku2.UseVisualStyleBackColor = true;
            // 
            // btnAverageHash
            // 
            this.btnAverageHash.Location = new System.Drawing.Point(63, 248);
            this.btnAverageHash.Name = "btnAverageHash";
            this.btnAverageHash.Size = new System.Drawing.Size(75, 59);
            this.btnAverageHash.TabIndex = 4;
            this.btnAverageHash.Text = "Average Hash";
            this.btnAverageHash.UseVisualStyleBackColor = true;
            // 
            // btnDifferenceHash
            // 
            this.btnDifferenceHash.Location = new System.Drawing.Point(144, 248);
            this.btnDifferenceHash.Name = "btnDifferenceHash";
            this.btnDifferenceHash.Size = new System.Drawing.Size(75, 59);
            this.btnDifferenceHash.TabIndex = 5;
            this.btnDifferenceHash.Text = "Difference Hash";
            this.btnDifferenceHash.UseVisualStyleBackColor = true;
            // 
            // btnPerceptualHash
            // 
            this.btnPerceptualHash.Location = new System.Drawing.Point(225, 248);
            this.btnPerceptualHash.Name = "btnPerceptualHash";
            this.btnPerceptualHash.Size = new System.Drawing.Size(75, 59);
            this.btnPerceptualHash.TabIndex = 6;
            this.btnPerceptualHash.Text = "Perception Hash";
            this.btnPerceptualHash.UseVisualStyleBackColor = true;
            // 
            // btnWaveletHash
            // 
            this.btnWaveletHash.Location = new System.Drawing.Point(306, 248);
            this.btnWaveletHash.Name = "btnWaveletHash";
            this.btnWaveletHash.Size = new System.Drawing.Size(75, 59);
            this.btnWaveletHash.TabIndex = 7;
            this.btnWaveletHash.Text = "Wavelet Hash";
            this.btnWaveletHash.UseVisualStyleBackColor = true;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
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
    }
}

