namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
	partial class IzmeniInternetForma
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
			this.grbInternet = new System.Windows.Forms.GroupBox();
			this.numStanjeRacuna = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.dateUplata = new System.Windows.Forms.DateTimePicker();
			this.lblDatumUplate = new System.Windows.Forms.Label();
			this.btnIzmeni = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chbPostpaid = new System.Windows.Forms.CheckBox();
			this.chbPrepaid = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.grbInternet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStanjeRacuna)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.grbInternet);
			this.groupBox1.Controls.Add(this.btnIzmeni);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(561, 159);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovni podaci o internetu";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// grbInternet
			// 
			this.grbInternet.Controls.Add(this.numStanjeRacuna);
			this.grbInternet.Controls.Add(this.label2);
			this.grbInternet.Controls.Add(this.dateUplata);
			this.grbInternet.Controls.Add(this.lblDatumUplate);
			this.grbInternet.Enabled = false;
			this.grbInternet.Location = new System.Drawing.Point(211, 19);
			this.grbInternet.Name = "grbInternet";
			this.grbInternet.Size = new System.Drawing.Size(343, 100);
			this.grbInternet.TabIndex = 4;
			this.grbInternet.TabStop = false;
			this.grbInternet.Text = "Internet";
			// 
			// numStanjeRacuna
			// 
			this.numStanjeRacuna.Location = new System.Drawing.Point(93, 58);
			this.numStanjeRacuna.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numStanjeRacuna.Name = "numStanjeRacuna";
			this.numStanjeRacuna.Size = new System.Drawing.Size(132, 20);
			this.numStanjeRacuna.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Stanje racuna:";
			// 
			// dateUplata
			// 
			this.dateUplata.Location = new System.Drawing.Point(128, 21);
			this.dateUplata.Name = "dateUplata";
			this.dateUplata.Size = new System.Drawing.Size(200, 20);
			this.dateUplata.TabIndex = 0;
			// 
			// lblDatumUplate
			// 
			this.lblDatumUplate.AutoSize = true;
			this.lblDatumUplate.Location = new System.Drawing.Point(6, 27);
			this.lblDatumUplate.Name = "lblDatumUplate";
			this.lblDatumUplate.Size = new System.Drawing.Size(121, 13);
			this.lblDatumUplate.TabIndex = 5;
			this.lblDatumUplate.Text = "Datum poslednje uplate:";
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.BackColor = System.Drawing.Color.SandyBrown;
			this.btnIzmeni.Location = new System.Drawing.Point(472, 125);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(82, 25);
			this.btnIzmeni.TabIndex = 1;
			this.btnIzmeni.Text = "Izmeni";
			this.btnIzmeni.UseVisualStyleBackColor = false;
			this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chbPostpaid);
			this.groupBox2.Controls.Add(this.chbPrepaid);
			this.groupBox2.Location = new System.Drawing.Point(6, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(190, 64);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tip interneta";
			// 
			// chbPostpaid
			// 
			this.chbPostpaid.AutoSize = true;
			this.chbPostpaid.Location = new System.Drawing.Point(93, 30);
			this.chbPostpaid.Name = "chbPostpaid";
			this.chbPostpaid.Size = new System.Drawing.Size(67, 17);
			this.chbPostpaid.TabIndex = 3;
			this.chbPostpaid.Text = "Postpaid";
			this.chbPostpaid.UseVisualStyleBackColor = true;
			this.chbPostpaid.CheckedChanged += new System.EventHandler(this.chbPostpaid_CheckedChanged);
			// 
			// chbPrepaid
			// 
			this.chbPrepaid.AutoSize = true;
			this.chbPrepaid.Location = new System.Drawing.Point(6, 30);
			this.chbPrepaid.Name = "chbPrepaid";
			this.chbPrepaid.Size = new System.Drawing.Size(62, 17);
			this.chbPrepaid.TabIndex = 2;
			this.chbPrepaid.Text = "Prepaid";
			this.chbPrepaid.UseVisualStyleBackColor = true;
			this.chbPrepaid.CheckedChanged += new System.EventHandler(this.chbPrepaid_CheckedChanged);
			// 
			// IzmeniInternetForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(578, 174);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "IzmeniInternetForma";
			this.Text = "IzmeniInternetForma";
			this.Load += new System.EventHandler(this.IzmeniInternetForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.grbInternet.ResumeLayout(false);
			this.grbInternet.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStanjeRacuna)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnIzmeni;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chbPostpaid;
		private System.Windows.Forms.CheckBox chbPrepaid;
		private System.Windows.Forms.GroupBox grbInternet;
		private System.Windows.Forms.NumericUpDown numStanjeRacuna;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateUplata;
		private System.Windows.Forms.Label lblDatumUplate;
	}
}