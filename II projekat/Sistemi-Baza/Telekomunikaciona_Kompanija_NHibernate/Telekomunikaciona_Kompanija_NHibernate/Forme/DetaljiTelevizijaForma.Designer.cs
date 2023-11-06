namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
	partial class DetaljiTelevizijaForma
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
			this.lblPaket = new System.Windows.Forms.Label();
			this.dodatniPaketi = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dodatniPaketi);
			this.groupBox1.Controls.Add(this.lblPaket);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblId);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(262, 288);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovni podaci o televiziji";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id:";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(31, 27);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(0, 13);
			this.lblId.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Paketa:";
			// 
			// lblPaket
			// 
			this.lblPaket.AutoSize = true;
			this.lblPaket.Location = new System.Drawing.Point(73, 60);
			this.lblPaket.Name = "lblPaket";
			this.lblPaket.Size = new System.Drawing.Size(0, 13);
			this.lblPaket.TabIndex = 3;
			// 
			// dodatniPaketi
			// 
			this.dodatniPaketi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.dodatniPaketi.HideSelection = false;
			this.dodatniPaketi.Location = new System.Drawing.Point(9, 114);
			this.dodatniPaketi.Name = "dodatniPaketi";
			this.dodatniPaketi.Size = new System.Drawing.Size(233, 154);
			this.dodatniPaketi.TabIndex = 4;
			this.dodatniPaketi.UseCompatibleStateImageBehavior = false;
			this.dodatniPaketi.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Paket";
			this.columnHeader2.Width = 135;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Dodatni paketi";
			// 
			// DetaljiTelevizijaForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(283, 307);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DetaljiTelevizijaForma";
			this.Text = "DetaljiTelevizijaForma";
			this.Load += new System.EventHandler(this.DetaljiTelevizijaForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView dodatniPaketi;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label lblPaket;
		private System.Windows.Forms.Label label2;
	}
}