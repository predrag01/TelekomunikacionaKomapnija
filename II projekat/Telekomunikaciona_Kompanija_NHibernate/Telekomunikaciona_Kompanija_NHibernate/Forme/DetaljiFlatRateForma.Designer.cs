namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
	partial class DetaljiFlatRateForma
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
			this.btnIzmeni = new System.Windows.Forms.Button();
			this.lblStaticka1 = new System.Windows.Forms.Label();
			this.lblStaticka2 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnIzmeni);
			this.groupBox1.Controls.Add(this.lblStaticka1);
			this.groupBox1.Controls.Add(this.lblStaticka2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 135);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovne informacije o flat rate";
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.BackColor = System.Drawing.Color.SandyBrown;
			this.btnIzmeni.Location = new System.Drawing.Point(200, 103);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
			this.btnIzmeni.TabIndex = 1;
			this.btnIzmeni.Text = "Izmeni";
			this.btnIzmeni.UseVisualStyleBackColor = false;
			this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
			// 
			// lblStaticka1
			// 
			this.lblStaticka1.AutoSize = true;
			this.lblStaticka1.Location = new System.Drawing.Point(114, 30);
			this.lblStaticka1.Name = "lblStaticka1";
			this.lblStaticka1.Size = new System.Drawing.Size(0, 13);
			this.lblStaticka1.TabIndex = 3;
			// 
			// lblStaticka2
			// 
			this.lblStaticka2.AutoSize = true;
			this.lblStaticka2.Location = new System.Drawing.Point(114, 64);
			this.lblStaticka2.Name = "lblStaticka2";
			this.lblStaticka2.Size = new System.Drawing.Size(0, 13);
			this.lblStaticka2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Staticka adresa 2:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Staticka adresa 1:";
			// 
			// DetaljiFlatRateForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(309, 153);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DetaljiFlatRateForma";
			this.Text = "DetaljiFlatRateForma";
			this.Load += new System.EventHandler(this.DetaljiFlatRateForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblStaticka1;
		private System.Windows.Forms.Label lblStaticka2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnIzmeni;
	}
}