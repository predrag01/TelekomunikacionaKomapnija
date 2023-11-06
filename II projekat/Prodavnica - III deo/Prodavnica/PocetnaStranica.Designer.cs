namespace Prodavnica
{
    partial class PocetnaStranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaStranica));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProdavnice = new System.Windows.Forms.Button();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.btnIgracke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(153, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "LANAC PRODAVNICA\r\n        IGRACAKA";
            // 
            // btnProdavnice
            // 
            this.btnProdavnice.BackColor = System.Drawing.Color.SandyBrown;
            this.btnProdavnice.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdavnice.Location = new System.Drawing.Point(153, 456);
            this.btnProdavnice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProdavnice.Name = "btnProdavnice";
            this.btnProdavnice.Size = new System.Drawing.Size(341, 88);
            this.btnProdavnice.TabIndex = 2;
            this.btnProdavnice.Text = "Prodavnice";
            this.btnProdavnice.UseVisualStyleBackColor = false;
            this.btnProdavnice.Click += new System.EventHandler(this.btnProdavnice_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.BackColor = System.Drawing.Color.SandyBrown;
            this.btnZaposleni.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposleni.Location = new System.Drawing.Point(153, 554);
            this.btnZaposleni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(341, 88);
            this.btnZaposleni.TabIndex = 3;
            this.btnZaposleni.Text = "Zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = false;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // btnIgracke
            // 
            this.btnIgracke.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIgracke.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgracke.Location = new System.Drawing.Point(153, 651);
            this.btnIgracke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIgracke.Name = "btnIgracke";
            this.btnIgracke.Size = new System.Drawing.Size(341, 88);
            this.btnIgracke.TabIndex = 4;
            this.btnIgracke.Text = "Igracke";
            this.btnIgracke.UseVisualStyleBackColor = false;
            this.btnIgracke.Click += new System.EventHandler(this.btnIgracke_Click);
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(650, 805);
            this.Controls.Add(this.btnIgracke);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.btnProdavnice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(672, 861);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(672, 861);
            this.Name = "PocetnaStranica";
            this.Text = "POCETNA STRANICA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProdavnice;
        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Button btnIgracke;
    }
}