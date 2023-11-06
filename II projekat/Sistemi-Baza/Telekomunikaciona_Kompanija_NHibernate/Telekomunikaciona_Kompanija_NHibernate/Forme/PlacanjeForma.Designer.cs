namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class PlacanjeForma
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnObrisiPlacanje = new System.Windows.Forms.Button();
			this.btnIzmeniPlacanje = new System.Windows.Forms.Button();
			this.btnDodajPlacanje = new System.Windows.Forms.Button();
			this.placanja = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnObrisiPlacanje);
			this.groupBox1.Controls.Add(this.btnIzmeniPlacanje);
			this.groupBox1.Controls.Add(this.btnDodajPlacanje);
			this.groupBox1.Controls.Add(this.placanja);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(464, 273);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovne informacije o placanju";
			// 
			// btnObrisiPlacanje
			// 
			this.btnObrisiPlacanje.BackColor = System.Drawing.Color.SandyBrown;
			this.btnObrisiPlacanje.Location = new System.Drawing.Point(351, 86);
			this.btnObrisiPlacanje.Name = "btnObrisiPlacanje";
			this.btnObrisiPlacanje.Size = new System.Drawing.Size(92, 27);
			this.btnObrisiPlacanje.TabIndex = 3;
			this.btnObrisiPlacanje.Text = "Obrisi placanje";
			this.btnObrisiPlacanje.UseVisualStyleBackColor = false;
			this.btnObrisiPlacanje.Click += new System.EventHandler(this.btnObrisiPlacanje_Click);
			// 
			// btnIzmeniPlacanje
			// 
			this.btnIzmeniPlacanje.BackColor = System.Drawing.Color.SandyBrown;
			this.btnIzmeniPlacanje.Location = new System.Drawing.Point(351, 53);
			this.btnIzmeniPlacanje.Name = "btnIzmeniPlacanje";
			this.btnIzmeniPlacanje.Size = new System.Drawing.Size(92, 27);
			this.btnIzmeniPlacanje.TabIndex = 2;
			this.btnIzmeniPlacanje.Text = "Izmeni placanje";
			this.btnIzmeniPlacanje.UseVisualStyleBackColor = false;
			this.btnIzmeniPlacanje.Click += new System.EventHandler(this.btnIzmeniPlacanje_Click);
			// 
			// btnDodajPlacanje
			// 
			this.btnDodajPlacanje.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDodajPlacanje.Location = new System.Drawing.Point(351, 19);
			this.btnDodajPlacanje.Name = "btnDodajPlacanje";
			this.btnDodajPlacanje.Size = new System.Drawing.Size(92, 28);
			this.btnDodajPlacanje.TabIndex = 1;
			this.btnDodajPlacanje.Text = "Dodaj placanje";
			this.btnDodajPlacanje.UseVisualStyleBackColor = false;
			this.btnDodajPlacanje.Click += new System.EventHandler(this.btnDodajPlacanje_Click);
			// 
			// placanja
			// 
			this.placanja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
			this.placanja.FullRowSelect = true;
			this.placanja.HideSelection = false;
			this.placanja.Location = new System.Drawing.Point(6, 19);
			this.placanja.Name = "placanja";
			this.placanja.Size = new System.Drawing.Size(317, 247);
			this.placanja.TabIndex = 0;
			this.placanja.UseCompatibleStateImageBehavior = false;
			this.placanja.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			this.columnHeader1.Width = 45;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tip placanja";
			this.columnHeader2.Width = 92;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Kolicina ostvarenog protoka";
			this.columnHeader4.Width = 158;
			// 
			// PlacanjeForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(482, 289);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "PlacanjeForma";
			this.Text = "PlacanjeForma";
			this.Load += new System.EventHandler(this.PlacanjeForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView placanja;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button btnObrisiPlacanje;
		private System.Windows.Forms.Button btnIzmeniPlacanje;
		private System.Windows.Forms.Button btnDodajPlacanje;
	}
}