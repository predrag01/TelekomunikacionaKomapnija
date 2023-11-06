namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
	partial class DodajPlacanjeForma
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
			this.grbStaticka1 = new System.Windows.Forms.GroupBox();
			this.grbStaticka2 = new System.Windows.Forms.GroupBox();
			this.txbStaticka2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chbDozvoliDruguAdresu = new System.Windows.Forms.CheckBox();
			this.txbStaticka1 = new System.Windows.Forms.TextBox();
			this.lblStatickaAdresa = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chbFlatRate = new System.Windows.Forms.CheckBox();
			this.chbOstvareniProtok = new System.Windows.Forms.CheckBox();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.grbStaticka1.SuspendLayout();
			this.grbStaticka2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.grbStaticka1);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.btnDodaj);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(334, 312);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovni podaci o placanju";
			// 
			// grbStaticka1
			// 
			this.grbStaticka1.Controls.Add(this.grbStaticka2);
			this.grbStaticka1.Controls.Add(this.chbDozvoliDruguAdresu);
			this.grbStaticka1.Controls.Add(this.txbStaticka1);
			this.grbStaticka1.Controls.Add(this.lblStatickaAdresa);
			this.grbStaticka1.Enabled = false;
			this.grbStaticka1.Location = new System.Drawing.Point(6, 106);
			this.grbStaticka1.Name = "grbStaticka1";
			this.grbStaticka1.Size = new System.Drawing.Size(319, 166);
			this.grbStaticka1.TabIndex = 3;
			this.grbStaticka1.TabStop = false;
			this.grbStaticka1.Text = "Staticka adresa";
			// 
			// grbStaticka2
			// 
			this.grbStaticka2.Controls.Add(this.txbStaticka2);
			this.grbStaticka2.Controls.Add(this.label1);
			this.grbStaticka2.Enabled = false;
			this.grbStaticka2.Location = new System.Drawing.Point(9, 84);
			this.grbStaticka2.Name = "grbStaticka2";
			this.grbStaticka2.Size = new System.Drawing.Size(300, 72);
			this.grbStaticka2.TabIndex = 3;
			this.grbStaticka2.TabStop = false;
			this.grbStaticka2.Text = "Staticka adresa";
			// 
			// txbStaticka2
			// 
			this.txbStaticka2.Location = new System.Drawing.Point(101, 30);
			this.txbStaticka2.Name = "txbStaticka2";
			this.txbStaticka2.Size = new System.Drawing.Size(182, 20);
			this.txbStaticka2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Staticka adresa :";
			// 
			// chbDozvoliDruguAdresu
			// 
			this.chbDozvoliDruguAdresu.AutoSize = true;
			this.chbDozvoliDruguAdresu.Location = new System.Drawing.Point(9, 61);
			this.chbDozvoliDruguAdresu.Name = "chbDozvoliDruguAdresu";
			this.chbDozvoliDruguAdresu.Size = new System.Drawing.Size(146, 17);
			this.chbDozvoliDruguAdresu.TabIndex = 2;
			this.chbDozvoliDruguAdresu.Text = "Jos jedna staticka adresa";
			this.chbDozvoliDruguAdresu.UseVisualStyleBackColor = true;
			this.chbDozvoliDruguAdresu.CheckedChanged += new System.EventHandler(this.chbDozvoliDruguAdresu_CheckedChanged);
			// 
			// txbStaticka1
			// 
			this.txbStaticka1.Location = new System.Drawing.Point(110, 19);
			this.txbStaticka1.Name = "txbStaticka1";
			this.txbStaticka1.Size = new System.Drawing.Size(182, 20);
			this.txbStaticka1.TabIndex = 1;
			// 
			// lblStatickaAdresa
			// 
			this.lblStatickaAdresa.AutoSize = true;
			this.lblStatickaAdresa.Location = new System.Drawing.Point(17, 22);
			this.lblStatickaAdresa.Name = "lblStatickaAdresa";
			this.lblStatickaAdresa.Size = new System.Drawing.Size(87, 13);
			this.lblStatickaAdresa.TabIndex = 0;
			this.lblStatickaAdresa.Text = "Staticka adresa :";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chbFlatRate);
			this.groupBox3.Controls.Add(this.chbOstvareniProtok);
			this.groupBox3.Location = new System.Drawing.Point(6, 19);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(319, 64);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tip placanja";
			// 
			// chbFlatRate
			// 
			this.chbFlatRate.AutoSize = true;
			this.chbFlatRate.Location = new System.Drawing.Point(207, 30);
			this.chbFlatRate.Name = "chbFlatRate";
			this.chbFlatRate.Size = new System.Drawing.Size(64, 17);
			this.chbFlatRate.TabIndex = 1;
			this.chbFlatRate.Text = "Flat rate";
			this.chbFlatRate.UseVisualStyleBackColor = true;
			this.chbFlatRate.CheckedChanged += new System.EventHandler(this.chbFlatRate_CheckedChanged);
			// 
			// chbOstvareniProtok
			// 
			this.chbOstvareniProtok.AutoSize = true;
			this.chbOstvareniProtok.Location = new System.Drawing.Point(15, 30);
			this.chbOstvareniProtok.Name = "chbOstvareniProtok";
			this.chbOstvareniProtok.Size = new System.Drawing.Size(104, 17);
			this.chbOstvareniProtok.TabIndex = 0;
			this.chbOstvareniProtok.Text = "Ostvareni protok";
			this.chbOstvareniProtok.UseVisualStyleBackColor = true;
			this.chbOstvareniProtok.CheckedChanged += new System.EventHandler(this.chbOstvareniProtok_CheckedChanged);
			// 
			// btnDodaj
			// 
			this.btnDodaj.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDodaj.Location = new System.Drawing.Point(243, 278);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(82, 25);
			this.btnDodaj.TabIndex = 1;
			this.btnDodaj.Text = "Dodaj";
			this.btnDodaj.UseVisualStyleBackColor = false;
			this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
			// 
			// DodajPlacanjeForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(353, 330);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DodajPlacanjeForma";
			this.Text = "DodajPlacanjeForma";
			this.groupBox1.ResumeLayout(false);
			this.grbStaticka1.ResumeLayout(false);
			this.grbStaticka1.PerformLayout();
			this.grbStaticka2.ResumeLayout(false);
			this.grbStaticka2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox grbStaticka1;
		private System.Windows.Forms.GroupBox grbStaticka2;
		private System.Windows.Forms.TextBox txbStaticka2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chbDozvoliDruguAdresu;
		private System.Windows.Forms.TextBox txbStaticka1;
		private System.Windows.Forms.Label lblStatickaAdresa;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox chbFlatRate;
		private System.Windows.Forms.CheckBox chbOstvareniProtok;
		private System.Windows.Forms.Button btnDodaj;
	}
}