namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class Uredjaji
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
            this.ListaUredjaja = new System.Windows.Forms.ListView();
            this.Serijski_Broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UredjajiLabel = new System.Windows.Forms.Label();
            this.OtvoriDodajFormuBtn = new System.Windows.Forms.Button();
            this.OtvoriIzmeniFormubtn = new System.Windows.Forms.Button();
            this.OtvoriObrisiFormuBtn = new System.Windows.Forms.Button();
            this.OtvoriDetaljiUredjajaFormuBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaUredjaja
            // 
            this.ListaUredjaja.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListaUredjaja.BackColor = System.Drawing.Color.SandyBrown;
            this.ListaUredjaja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Serijski_Broj,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListaUredjaja.FullRowSelect = true;
            this.ListaUredjaja.GridLines = true;
            this.ListaUredjaja.HideSelection = false;
            this.ListaUredjaja.Location = new System.Drawing.Point(3, 48);
            this.ListaUredjaja.Name = "ListaUredjaja";
            this.ListaUredjaja.Size = new System.Drawing.Size(519, 258);
            this.ListaUredjaja.TabIndex = 0;
            this.ListaUredjaja.UseCompatibleStateImageBehavior = false;
            this.ListaUredjaja.View = System.Windows.Forms.View.Details;
            // 
            // Serijski_Broj
            // 
            this.Serijski_Broj.Text = "Serijski broj";
            this.Serijski_Broj.Width = 130;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Proizvodjac";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Datum pocetka upotrebe";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 164;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip uredjaja";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 125;
            // 
            // UredjajiLabel
            // 
            this.UredjajiLabel.AutoSize = true;
            this.UredjajiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UredjajiLabel.Location = new System.Drawing.Point(6, 16);
            this.UredjajiLabel.Name = "UredjajiLabel";
            this.UredjajiLabel.Size = new System.Drawing.Size(70, 20);
            this.UredjajiLabel.TabIndex = 1;
            this.UredjajiLabel.Text = "Uredjaji";
            // 
            // OtvoriDodajFormuBtn
            // 
            this.OtvoriDodajFormuBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.OtvoriDodajFormuBtn.Location = new System.Drawing.Point(23, 48);
            this.OtvoriDodajFormuBtn.Name = "OtvoriDodajFormuBtn";
            this.OtvoriDodajFormuBtn.Size = new System.Drawing.Size(97, 41);
            this.OtvoriDodajFormuBtn.TabIndex = 2;
            this.OtvoriDodajFormuBtn.Text = "Dodaj uredjaj";
            this.OtvoriDodajFormuBtn.UseVisualStyleBackColor = false;
            this.OtvoriDodajFormuBtn.Click += new System.EventHandler(this.OtvoriDodajFormuBtn_Click);
            // 
            // OtvoriIzmeniFormubtn
            // 
            this.OtvoriIzmeniFormubtn.BackColor = System.Drawing.Color.SandyBrown;
            this.OtvoriIzmeniFormubtn.Location = new System.Drawing.Point(23, 113);
            this.OtvoriIzmeniFormubtn.Name = "OtvoriIzmeniFormubtn";
            this.OtvoriIzmeniFormubtn.Size = new System.Drawing.Size(97, 41);
            this.OtvoriIzmeniFormubtn.TabIndex = 3;
            this.OtvoriIzmeniFormubtn.Text = "Izmeni uredjaj";
            this.OtvoriIzmeniFormubtn.UseVisualStyleBackColor = false;
            this.OtvoriIzmeniFormubtn.Click += new System.EventHandler(this.OtvoriIzmeniFormubtn_Click);
            // 
            // OtvoriObrisiFormuBtn
            // 
            this.OtvoriObrisiFormuBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.OtvoriObrisiFormuBtn.Location = new System.Drawing.Point(23, 180);
            this.OtvoriObrisiFormuBtn.Name = "OtvoriObrisiFormuBtn";
            this.OtvoriObrisiFormuBtn.Size = new System.Drawing.Size(97, 36);
            this.OtvoriObrisiFormuBtn.TabIndex = 4;
            this.OtvoriObrisiFormuBtn.Text = "Obrisi uredjaj";
            this.OtvoriObrisiFormuBtn.UseVisualStyleBackColor = false;
            this.OtvoriObrisiFormuBtn.Click += new System.EventHandler(this.OtvoriObrisiFormuBtn_Click);
            // 
            // OtvoriDetaljiUredjajaFormuBtn
            // 
            this.OtvoriDetaljiUredjajaFormuBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.OtvoriDetaljiUredjajaFormuBtn.Location = new System.Drawing.Point(23, 250);
            this.OtvoriDetaljiUredjajaFormuBtn.Name = "OtvoriDetaljiUredjajaFormuBtn";
            this.OtvoriDetaljiUredjajaFormuBtn.Size = new System.Drawing.Size(97, 36);
            this.OtvoriDetaljiUredjajaFormuBtn.TabIndex = 7;
            this.OtvoriDetaljiUredjajaFormuBtn.Text = "Detalji uredjaja";
            this.OtvoriDetaljiUredjajaFormuBtn.UseVisualStyleBackColor = false;
            this.OtvoriDetaljiUredjajaFormuBtn.Click += new System.EventHandler(this.OtvoriDetaljiUredjajaFormuBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListaUredjaja);
            this.groupBox1.Controls.Add(this.UredjajiLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 312);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OtvoriDodajFormuBtn);
            this.groupBox3.Controls.Add(this.OtvoriDetaljiUredjajaFormuBtn);
            this.groupBox3.Controls.Add(this.OtvoriIzmeniFormubtn);
            this.groupBox3.Controls.Add(this.OtvoriObrisiFormuBtn);
            this.groupBox3.Location = new System.Drawing.Point(544, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 312);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // Uredjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 336);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Uredjaji";
            this.Text = "Uredjaji";
            this.Load += new System.EventHandler(this.Uredjaji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListaUredjaja;
        private System.Windows.Forms.ColumnHeader Serijski_Broj;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label UredjajiLabel;
        private System.Windows.Forms.Button OtvoriDodajFormuBtn;
        private System.Windows.Forms.Button OtvoriIzmeniFormubtn;
        private System.Windows.Forms.Button OtvoriObrisiFormuBtn;
        private System.Windows.Forms.Button OtvoriDetaljiUredjajaFormuBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}