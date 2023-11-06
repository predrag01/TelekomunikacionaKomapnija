namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class InternetForma
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
			this.btnDetaljiPlacanja = new System.Windows.Forms.Button();
			this.btnObrisiNet = new System.Windows.Forms.Button();
			this.btnIzmeniNet = new System.Windows.Forms.Button();
			this.btnDodajInternet = new System.Windows.Forms.Button();
			this.interneti = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDetaljiPlacanja);
			this.groupBox1.Controls.Add(this.btnObrisiNet);
			this.groupBox1.Controls.Add(this.btnIzmeniNet);
			this.groupBox1.Controls.Add(this.btnDodajInternet);
			this.groupBox1.Controls.Add(this.interneti);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(528, 281);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovni podaci o internetu";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnDetaljiPlacanja
			// 
			this.btnDetaljiPlacanja.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDetaljiPlacanja.Location = new System.Drawing.Point(430, 240);
			this.btnDetaljiPlacanja.Name = "btnDetaljiPlacanja";
			this.btnDetaljiPlacanja.Size = new System.Drawing.Size(91, 30);
			this.btnDetaljiPlacanja.TabIndex = 4;
			this.btnDetaljiPlacanja.Text = "Detalji placanja";
			this.btnDetaljiPlacanja.UseVisualStyleBackColor = false;
			this.btnDetaljiPlacanja.Click += new System.EventHandler(this.btnDetaljiPlacanja_Click);
			// 
			// btnObrisiNet
			// 
			this.btnObrisiNet.BackColor = System.Drawing.Color.SandyBrown;
			this.btnObrisiNet.Location = new System.Drawing.Point(430, 112);
			this.btnObrisiNet.Name = "btnObrisiNet";
			this.btnObrisiNet.Size = new System.Drawing.Size(91, 30);
			this.btnObrisiNet.TabIndex = 3;
			this.btnObrisiNet.Text = "Obrisi internet";
			this.btnObrisiNet.UseVisualStyleBackColor = false;
			this.btnObrisiNet.Click += new System.EventHandler(this.btnObrisiNet_Click);
			// 
			// btnIzmeniNet
			// 
			this.btnIzmeniNet.BackColor = System.Drawing.Color.SandyBrown;
			this.btnIzmeniNet.Location = new System.Drawing.Point(430, 64);
			this.btnIzmeniNet.Name = "btnIzmeniNet";
			this.btnIzmeniNet.Size = new System.Drawing.Size(91, 30);
			this.btnIzmeniNet.TabIndex = 2;
			this.btnIzmeniNet.Text = "Izmeni internet";
			this.btnIzmeniNet.UseVisualStyleBackColor = false;
			this.btnIzmeniNet.Click += new System.EventHandler(this.btnIzmeniNet_Click);
			// 
			// btnDodajInternet
			// 
			this.btnDodajInternet.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDodajInternet.Location = new System.Drawing.Point(430, 19);
			this.btnDodajInternet.Name = "btnDodajInternet";
			this.btnDodajInternet.Size = new System.Drawing.Size(91, 30);
			this.btnDodajInternet.TabIndex = 1;
			this.btnDodajInternet.Text = "Dodaj internet";
			this.btnDodajInternet.UseVisualStyleBackColor = false;
			this.btnDodajInternet.Click += new System.EventHandler(this.btnDodajInternet_Click);
			// 
			// interneti
			// 
			this.interneti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.interneti.FullRowSelect = true;
			this.interneti.HideSelection = false;
			this.interneti.Location = new System.Drawing.Point(6, 19);
			this.interneti.Name = "interneti";
			this.interneti.Size = new System.Drawing.Size(401, 251);
			this.interneti.TabIndex = 0;
			this.interneti.UseCompatibleStateImageBehavior = false;
			this.interneti.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			this.columnHeader1.Width = 43;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tip interneta";
			this.columnHeader2.Width = 97;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Datum poslednje uplate";
			this.columnHeader3.Width = 137;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Stanje racna";
			this.columnHeader4.Width = 102;
			// 
			// InternetForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(550, 298);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "InternetForma";
			this.Text = "InternetForma";
			this.Load += new System.EventHandler(this.InternetForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView interneti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDodajInternet;
		private System.Windows.Forms.Button btnIzmeniNet;
		private System.Windows.Forms.Button btnObrisiNet;
		private System.Windows.Forms.Button btnDetaljiPlacanja;
	}
}