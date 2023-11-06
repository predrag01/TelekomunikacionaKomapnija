namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
	partial class DetaljiInternetForma
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTip = new System.Windows.Forms.Label();
			this.datum = new System.Windows.Forms.Label();
			this.lblDatum = new System.Windows.Forms.Label();
			this.stanje = new System.Windows.Forms.Label();
			this.lblStanje = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblStanje);
			this.groupBox1.Controls.Add(this.stanje);
			this.groupBox1.Controls.Add(this.lblDatum);
			this.groupBox1.Controls.Add(this.datum);
			this.groupBox1.Controls.Add(this.lblTip);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblId);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(307, 156);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovne informacije o internetu";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id:";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(32, 20);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(0, 13);
			this.lblId.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tip interneta:";
			// 
			// lblTip
			// 
			this.lblTip.AutoSize = true;
			this.lblTip.Location = new System.Drawing.Point(82, 53);
			this.lblTip.Name = "lblTip";
			this.lblTip.Size = new System.Drawing.Size(0, 13);
			this.lblTip.TabIndex = 3;
			// 
			// datum
			// 
			this.datum.AutoSize = true;
			this.datum.Location = new System.Drawing.Point(7, 86);
			this.datum.Name = "datum";
			this.datum.Size = new System.Drawing.Size(118, 13);
			this.datum.TabIndex = 4;
			this.datum.Text = "Datum poslednje uplate";
			// 
			// lblDatum
			// 
			this.lblDatum.AutoSize = true;
			this.lblDatum.Location = new System.Drawing.Point(142, 86);
			this.lblDatum.Name = "lblDatum";
			this.lblDatum.Size = new System.Drawing.Size(0, 13);
			this.lblDatum.TabIndex = 5;
			// 
			// stanje
			// 
			this.stanje.AutoSize = true;
			this.stanje.Location = new System.Drawing.Point(7, 120);
			this.stanje.Name = "stanje";
			this.stanje.Size = new System.Drawing.Size(73, 13);
			this.stanje.TabIndex = 6;
			this.stanje.Text = "Stanje racuna";
			// 
			// lblStanje
			// 
			this.lblStanje.AutoSize = true;
			this.lblStanje.Location = new System.Drawing.Point(90, 120);
			this.lblStanje.Name = "lblStanje";
			this.lblStanje.Size = new System.Drawing.Size(0, 13);
			this.lblStanje.TabIndex = 7;
			// 
			// DetaljiInternetForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(331, 175);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DetaljiInternetForma";
			this.Text = "DetaljiInternetForma";
			this.Load += new System.EventHandler(this.DetaljiInternetForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblStanje;
		private System.Windows.Forms.Label stanje;
		private System.Windows.Forms.Label lblDatum;
		private System.Windows.Forms.Label datum;
		private System.Windows.Forms.Label lblTip;
		private System.Windows.Forms.Label label2;
	}
}