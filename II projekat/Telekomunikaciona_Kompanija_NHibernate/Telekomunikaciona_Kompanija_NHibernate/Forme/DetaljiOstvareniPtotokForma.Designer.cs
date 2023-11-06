namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
	partial class DetaljiOstvareniPtotokForma
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
			this.lblProtok = new System.Windows.Forms.Label();
			this.brnIzmeni = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblProtok);
			this.groupBox1.Controls.Add(this.brnIzmeni);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(235, 124);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovne informacije o ostvarenom protoku";
			// 
			// lblProtok
			// 
			this.lblProtok.AutoSize = true;
			this.lblProtok.Location = new System.Drawing.Point(100, 25);
			this.lblProtok.Name = "lblProtok";
			this.lblProtok.Size = new System.Drawing.Size(0, 13);
			this.lblProtok.TabIndex = 3;
			// 
			// brnIzmeni
			// 
			this.brnIzmeni.BackColor = System.Drawing.Color.SandyBrown;
			this.brnIzmeni.Location = new System.Drawing.Point(146, 85);
			this.brnIzmeni.Name = "brnIzmeni";
			this.brnIzmeni.Size = new System.Drawing.Size(75, 23);
			this.brnIzmeni.TabIndex = 2;
			this.brnIzmeni.Text = "Izmeni";
			this.brnIzmeni.UseVisualStyleBackColor = false;
			this.brnIzmeni.Click += new System.EventHandler(this.brnIzmeni_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ostvareni protok:";
			// 
			// DetaljiOstvareniPtotokForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(259, 143);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DetaljiOstvareniPtotokForma";
			this.Text = "DetaljiOstvareniPtotokForma";
			this.Load += new System.EventHandler(this.DetaljiOstvareniPtotokForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button brnIzmeni;
		private System.Windows.Forms.Label lblProtok;
	}
}