namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class Korisnici
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OtvoriDodajFormuBtn = new System.Windows.Forms.Button();
            this.OtvoriDetaljiFormuBtn = new System.Windows.Forms.Button();
            this.OtvoriIzmeniFormubtn = new System.Windows.Forms.Button();
            this.OtvoriObrisiFormuBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListKorisnika = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UredjajiLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OtvoriDodajFormuBtn);
            this.groupBox3.Controls.Add(this.OtvoriDetaljiFormuBtn);
            this.groupBox3.Controls.Add(this.OtvoriIzmeniFormubtn);
            this.groupBox3.Controls.Add(this.OtvoriObrisiFormuBtn);
            this.groupBox3.Location = new System.Drawing.Point(799, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 324);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // OtvoriDodajFormuBtn
            // 
            this.OtvoriDodajFormuBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.OtvoriDodajFormuBtn.Location = new System.Drawing.Point(23, 48);
            this.OtvoriDodajFormuBtn.Name = "OtvoriDodajFormuBtn";
            this.OtvoriDodajFormuBtn.Size = new System.Drawing.Size(97, 41);
            this.OtvoriDodajFormuBtn.TabIndex = 2;
            this.OtvoriDodajFormuBtn.Text = "Dodaj korisnika";
            this.OtvoriDodajFormuBtn.UseVisualStyleBackColor = false;
            this.OtvoriDodajFormuBtn.Click += new System.EventHandler(this.OtvoriDodajFormuBtn_Click);
            // 
            // OtvoriDetaljiFormuBtn
            // 
            this.OtvoriDetaljiFormuBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.OtvoriDetaljiFormuBtn.Location = new System.Drawing.Point(23, 250);
            this.OtvoriDetaljiFormuBtn.Name = "OtvoriDetaljiFormuBtn";
            this.OtvoriDetaljiFormuBtn.Size = new System.Drawing.Size(97, 39);
            this.OtvoriDetaljiFormuBtn.TabIndex = 7;
            this.OtvoriDetaljiFormuBtn.Text = "Detalji korisnika";
            this.OtvoriDetaljiFormuBtn.UseVisualStyleBackColor = false;
            this.OtvoriDetaljiFormuBtn.Click += new System.EventHandler(this.OtvoriDetaljiFormuBtn_Click);
            // 
            // OtvoriIzmeniFormubtn
            // 
            this.OtvoriIzmeniFormubtn.BackColor = System.Drawing.Color.SandyBrown;
            this.OtvoriIzmeniFormubtn.Location = new System.Drawing.Point(23, 113);
            this.OtvoriIzmeniFormubtn.Name = "OtvoriIzmeniFormubtn";
            this.OtvoriIzmeniFormubtn.Size = new System.Drawing.Size(97, 41);
            this.OtvoriIzmeniFormubtn.TabIndex = 3;
            this.OtvoriIzmeniFormubtn.Text = "Izmeni korisnika";
            this.OtvoriIzmeniFormubtn.UseVisualStyleBackColor = false;
            this.OtvoriIzmeniFormubtn.Click += new System.EventHandler(this.OtvoriIzmeniFormubtn_Click);
            // 
            // OtvoriObrisiFormuBtn
            // 
            this.OtvoriObrisiFormuBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.OtvoriObrisiFormuBtn.Location = new System.Drawing.Point(23, 180);
            this.OtvoriObrisiFormuBtn.Name = "OtvoriObrisiFormuBtn";
            this.OtvoriObrisiFormuBtn.Size = new System.Drawing.Size(97, 39);
            this.OtvoriObrisiFormuBtn.TabIndex = 4;
            this.OtvoriObrisiFormuBtn.Text = "Obrisi korisnika";
            this.OtvoriObrisiFormuBtn.UseVisualStyleBackColor = false;
            this.OtvoriObrisiFormuBtn.Click += new System.EventHandler(this.OtvoriObrisiFormuBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListKorisnika);
            this.groupBox1.Controls.Add(this.UredjajiLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 324);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ListKorisnika
            // 
            this.ListKorisnika.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListKorisnika.BackColor = System.Drawing.Color.SandyBrown;
            this.ListKorisnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.ListKorisnika.FullRowSelect = true;
            this.ListKorisnika.GridLines = true;
            this.ListKorisnika.HideSelection = false;
            this.ListKorisnika.Location = new System.Drawing.Point(3, 48);
            this.ListKorisnika.Name = "ListKorisnika";
            this.ListKorisnika.Size = new System.Drawing.Size(717, 270);
            this.ListKorisnika.TabIndex = 0;
            this.ListKorisnika.UseCompatibleStateImageBehavior = false;
            this.ListKorisnika.View = System.Windows.Forms.View.Details;
            this.ListKorisnika.SelectedIndexChanged += new System.EventHandler(this.ListaUredjaja_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JMBG";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adresa";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Grad";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 98;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tip korisnika";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 91;
            // 
            // UredjajiLabel
            // 
            this.UredjajiLabel.AutoSize = true;
            this.UredjajiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UredjajiLabel.Location = new System.Drawing.Point(6, 16);
            this.UredjajiLabel.Name = "UredjajiLabel";
            this.UredjajiLabel.Size = new System.Drawing.Size(76, 20);
            this.UredjajiLabel.TabIndex = 1;
            this.UredjajiLabel.Text = "Korisnici";
            // 
            // Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 348);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Korisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.Korisnici_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button OtvoriDodajFormuBtn;
        private System.Windows.Forms.Button OtvoriDetaljiFormuBtn;
        private System.Windows.Forms.Button OtvoriIzmeniFormubtn;
        private System.Windows.Forms.Button OtvoriObrisiFormuBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ListKorisnika;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label UredjajiLabel;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}