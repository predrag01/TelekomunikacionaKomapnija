namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
	partial class PotvrdiBrisanjeTelefonijeForma
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
			this.grbBrisanje = new System.Windows.Forms.GroupBox();
			this.btnNe = new System.Windows.Forms.Button();
			this.btnDa = new System.Windows.Forms.Button();
			this.lblPoruka = new System.Windows.Forms.Label();
			this.grbBrisanje.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbBrisanje
			// 
			this.grbBrisanje.Controls.Add(this.btnNe);
			this.grbBrisanje.Controls.Add(this.btnDa);
			this.grbBrisanje.Controls.Add(this.lblPoruka);
			this.grbBrisanje.Location = new System.Drawing.Point(12, 12);
			this.grbBrisanje.Name = "grbBrisanje";
			this.grbBrisanje.Size = new System.Drawing.Size(264, 120);
			this.grbBrisanje.TabIndex = 2;
			this.grbBrisanje.TabStop = false;
			// 
			// btnNe
			// 
			this.btnNe.BackColor = System.Drawing.Color.Red;
			this.btnNe.Location = new System.Drawing.Point(150, 77);
			this.btnNe.Name = "btnNe";
			this.btnNe.Size = new System.Drawing.Size(87, 23);
			this.btnNe.TabIndex = 2;
			this.btnNe.Text = "Ne";
			this.btnNe.UseVisualStyleBackColor = false;
			this.btnNe.Click += new System.EventHandler(this.btnNe_Click);
			// 
			// btnDa
			// 
			this.btnDa.BackColor = System.Drawing.Color.Green;
			this.btnDa.Location = new System.Drawing.Point(18, 77);
			this.btnDa.Name = "btnDa";
			this.btnDa.Size = new System.Drawing.Size(87, 23);
			this.btnDa.TabIndex = 1;
			this.btnDa.Text = "Da";
			this.btnDa.UseVisualStyleBackColor = false;
			this.btnDa.Click += new System.EventHandler(this.btnDa_Click);
			// 
			// lblPoruka
			// 
			this.lblPoruka.AutoSize = true;
			this.lblPoruka.Location = new System.Drawing.Point(28, 36);
			this.lblPoruka.Name = "lblPoruka";
			this.lblPoruka.Size = new System.Drawing.Size(0, 13);
			this.lblPoruka.TabIndex = 0;
			this.lblPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PotvrdiBrisanjeTelefonijeForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(292, 141);
			this.Controls.Add(this.grbBrisanje);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "PotvrdiBrisanjeTelefonijeForma";
			this.Text = "PotvrdiBrisanjeTelefonijeForma";
			this.Load += new System.EventHandler(this.PotvrdiBrisanjeTelefonijeForma_Load);
			this.grbBrisanje.ResumeLayout(false);
			this.grbBrisanje.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbBrisanje;
		private System.Windows.Forms.Button btnNe;
		private System.Windows.Forms.Button btnDa;
		private System.Windows.Forms.Label lblPoruka;
	}
}