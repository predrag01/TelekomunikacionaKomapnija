namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class DodajTelefonijuForma
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
			this.okvir = new System.Windows.Forms.GroupBox();
			this.grbOstaliBrojevi = new System.Windows.Forms.GroupBox();
			this.chbTreciBroj = new System.Windows.Forms.CheckBox();
			this.txbBr4 = new System.Windows.Forms.TextBox();
			this.chbCetvrtiBroj = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBr3 = new System.Windows.Forms.TextBox();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.chbDrugiBr = new System.Windows.Forms.CheckBox();
			this.txbBrTel2 = new System.Windows.Forms.TextBox();
			this.txbBrTel1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.okvir.SuspendLayout();
			this.grbOstaliBrojevi.SuspendLayout();
			this.SuspendLayout();
			// 
			// okvir
			// 
			this.okvir.Controls.Add(this.grbOstaliBrojevi);
			this.okvir.Controls.Add(this.btnDodaj);
			this.okvir.Controls.Add(this.chbDrugiBr);
			this.okvir.Controls.Add(this.txbBrTel2);
			this.okvir.Controls.Add(this.txbBrTel1);
			this.okvir.Controls.Add(this.label2);
			this.okvir.Controls.Add(this.label1);
			this.okvir.Location = new System.Drawing.Point(12, 12);
			this.okvir.Name = "okvir";
			this.okvir.Size = new System.Drawing.Size(486, 201);
			this.okvir.TabIndex = 0;
			this.okvir.TabStop = false;
			this.okvir.Text = "Osnovni podaci o telefoniji";
			// 
			// grbOstaliBrojevi
			// 
			this.grbOstaliBrojevi.Controls.Add(this.chbTreciBroj);
			this.grbOstaliBrojevi.Controls.Add(this.txbBr4);
			this.grbOstaliBrojevi.Controls.Add(this.chbCetvrtiBroj);
			this.grbOstaliBrojevi.Controls.Add(this.label4);
			this.grbOstaliBrojevi.Controls.Add(this.label3);
			this.grbOstaliBrojevi.Controls.Add(this.txtBr3);
			this.grbOstaliBrojevi.Enabled = false;
			this.grbOstaliBrojevi.Location = new System.Drawing.Point(236, 10);
			this.grbOstaliBrojevi.Name = "grbOstaliBrojevi";
			this.grbOstaliBrojevi.Size = new System.Drawing.Size(237, 154);
			this.grbOstaliBrojevi.TabIndex = 1;
			this.grbOstaliBrojevi.TabStop = false;
			// 
			// chbTreciBroj
			// 
			this.chbTreciBroj.AutoSize = true;
			this.chbTreciBroj.Location = new System.Drawing.Point(14, 23);
			this.chbTreciBroj.Name = "chbTreciBroj";
			this.chbTreciBroj.Size = new System.Drawing.Size(104, 17);
			this.chbTreciBroj.TabIndex = 12;
			this.chbTreciBroj.Text = "Dozvoli treci broj";
			this.chbTreciBroj.UseVisualStyleBackColor = true;
			this.chbTreciBroj.CheckedChanged += new System.EventHandler(this.chbTreciBroj_CheckedChanged);
			// 
			// txbBr4
			// 
			this.txbBr4.Enabled = false;
			this.txbBr4.Location = new System.Drawing.Point(98, 117);
			this.txbBr4.Name = "txbBr4";
			this.txbBr4.Size = new System.Drawing.Size(131, 20);
			this.txbBr4.TabIndex = 10;
			// 
			// chbCetvrtiBroj
			// 
			this.chbCetvrtiBroj.AutoSize = true;
			this.chbCetvrtiBroj.Location = new System.Drawing.Point(14, 86);
			this.chbCetvrtiBroj.Name = "chbCetvrtiBroj";
			this.chbCetvrtiBroj.Size = new System.Drawing.Size(113, 17);
			this.chbCetvrtiBroj.TabIndex = 11;
			this.chbCetvrtiBroj.Text = "Dozvoli cetvrti broj";
			this.chbCetvrtiBroj.UseVisualStyleBackColor = true;
			this.chbCetvrtiBroj.CheckedChanged += new System.EventHandler(this.chbCetvrtiBroj_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Broj telefona 3: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Broj telefona 4: ";
			// 
			// txtBr3
			// 
			this.txtBr3.Enabled = false;
			this.txtBr3.Location = new System.Drawing.Point(98, 46);
			this.txtBr3.Name = "txtBr3";
			this.txtBr3.Size = new System.Drawing.Size(131, 20);
			this.txtBr3.TabIndex = 9;
			this.txtBr3.TextChanged += new System.EventHandler(this.txtBr3_TextChanged);
			// 
			// btnDodaj
			// 
			this.btnDodaj.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDodaj.Location = new System.Drawing.Point(398, 170);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(75, 23);
			this.btnDodaj.TabIndex = 4;
			this.btnDodaj.Text = "Dodaj";
			this.btnDodaj.UseVisualStyleBackColor = false;
			this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
			// 
			// chbDrugiBr
			// 
			this.chbDrugiBr.AutoSize = true;
			this.chbDrugiBr.Location = new System.Drawing.Point(15, 97);
			this.chbDrugiBr.Name = "chbDrugiBr";
			this.chbDrugiBr.Size = new System.Drawing.Size(107, 17);
			this.chbDrugiBr.TabIndex = 6;
			this.chbDrugiBr.Text = "Dozvoli drugi broj";
			this.chbDrugiBr.UseVisualStyleBackColor = true;
			this.chbDrugiBr.CheckedChanged += new System.EventHandler(this.chbDrugiBr_CheckedChanged);
			// 
			// txbBrTel2
			// 
			this.txbBrTel2.Enabled = false;
			this.txbBrTel2.Location = new System.Drawing.Point(90, 129);
			this.txbBrTel2.Name = "txbBrTel2";
			this.txbBrTel2.Size = new System.Drawing.Size(131, 20);
			this.txbBrTel2.TabIndex = 3;
			// 
			// txbBrTel1
			// 
			this.txbBrTel1.Location = new System.Drawing.Point(90, 57);
			this.txbBrTel1.Name = "txbBrTel1";
			this.txbBrTel1.Size = new System.Drawing.Size(131, 20);
			this.txbBrTel1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Broj telefona 2: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Broj telefona 1: ";
			// 
			// DodajTelefonijuForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(504, 219);
			this.Controls.Add(this.okvir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DodajTelefonijuForma";
			this.Text = "DodajTelefonijuForma";
			this.okvir.ResumeLayout(false);
			this.okvir.PerformLayout();
			this.grbOstaliBrojevi.ResumeLayout(false);
			this.grbOstaliBrojevi.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox okvir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBrTel2;
        private System.Windows.Forms.TextBox txbBrTel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.CheckBox chbDrugiBr;
		private System.Windows.Forms.GroupBox grbOstaliBrojevi;
		private System.Windows.Forms.CheckBox chbTreciBroj;
		private System.Windows.Forms.TextBox txbBr4;
		private System.Windows.Forms.CheckBox chbCetvrtiBroj;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBr3;
	}
}