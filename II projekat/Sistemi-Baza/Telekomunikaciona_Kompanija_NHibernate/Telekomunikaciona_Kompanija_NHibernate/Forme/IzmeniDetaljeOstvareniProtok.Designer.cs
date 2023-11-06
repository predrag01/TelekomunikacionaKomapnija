namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
	partial class IzmeniDetaljeOstvareniProtok
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
			this.brnsacuvaj = new System.Windows.Forms.Button();
			this.numOstvareniProtok = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numOstvareniProtok)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.brnsacuvaj);
			this.groupBox1.Controls.Add(this.numOstvareniProtok);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(235, 124);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovne informacije o ostvarenom protoku";
			// 
			// brnsacuvaj
			// 
			this.brnsacuvaj.BackColor = System.Drawing.Color.SandyBrown;
			this.brnsacuvaj.Location = new System.Drawing.Point(146, 85);
			this.brnsacuvaj.Name = "brnsacuvaj";
			this.brnsacuvaj.Size = new System.Drawing.Size(75, 23);
			this.brnsacuvaj.TabIndex = 2;
			this.brnsacuvaj.Text = "Sacuvaj";
			this.brnsacuvaj.UseVisualStyleBackColor = false;
			this.brnsacuvaj.Click += new System.EventHandler(this.brnsacuvaj_Click);
			// 
			// numOstvareniProtok
			// 
			this.numOstvareniProtok.Location = new System.Drawing.Point(101, 25);
			this.numOstvareniProtok.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numOstvareniProtok.Name = "numOstvareniProtok";
			this.numOstvareniProtok.Size = new System.Drawing.Size(120, 20);
			this.numOstvareniProtok.TabIndex = 1;
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
			// IzmeniDetaljeOstvareniProtok
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(256, 141);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "IzmeniDetaljeOstvareniProtok";
			this.Text = "IzmeniDetaljeOstvareniProtok";
			this.Load += new System.EventHandler(this.IzmeniDetaljeOstvareniProtok_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numOstvareniProtok)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button brnsacuvaj;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numOstvareniProtok;
	}
}