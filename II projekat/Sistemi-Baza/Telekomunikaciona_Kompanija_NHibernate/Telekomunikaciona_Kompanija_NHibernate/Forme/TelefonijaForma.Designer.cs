namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class TelefonijaForma
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
			this.telefonije = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnDodajTelefoniju = new System.Windows.Forms.Button();
			this.btnIZmeniTelefoniju = new System.Windows.Forms.Button();
			this.btnObrisiTelefoniju = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.telefonije);
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(871, 323);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Telefonija";
			// 
			// telefonije
			// 
			this.telefonije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
			this.telefonije.Dock = System.Windows.Forms.DockStyle.Fill;
			this.telefonije.FullRowSelect = true;
			this.telefonije.HideSelection = false;
			this.telefonije.Location = new System.Drawing.Point(3, 16);
			this.telefonije.Name = "telefonije";
			this.telefonije.Size = new System.Drawing.Size(865, 304);
			this.telefonije.TabIndex = 0;
			this.telefonije.UseCompatibleStateImageBehavior = false;
			this.telefonije.View = System.Windows.Forms.View.Details;
			this.telefonije.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tip usluge";
			this.columnHeader2.Width = 72;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Broj telefona 1";
			this.columnHeader3.Width = 85;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ostvareni minuti";
			this.columnHeader4.Width = 94;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Broj telefona 2";
			this.columnHeader5.Width = 91;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Ostvareni minuti";
			this.columnHeader6.Width = 92;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Broj telefona 3";
			this.columnHeader7.Width = 84;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Ostvareni minuti";
			this.columnHeader8.Width = 90;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Broj telefona 4";
			this.columnHeader9.Width = 84;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Ostvareni minuti";
			this.columnHeader10.Width = 89;
			// 
			// btnDodajTelefoniju
			// 
			this.btnDodajTelefoniju.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDodajTelefoniju.Location = new System.Drawing.Point(907, 28);
			this.btnDodajTelefoniju.Name = "btnDodajTelefoniju";
			this.btnDodajTelefoniju.Size = new System.Drawing.Size(118, 31);
			this.btnDodajTelefoniju.TabIndex = 1;
			this.btnDodajTelefoniju.Text = "Dodaj telefoniju";
			this.btnDodajTelefoniju.UseVisualStyleBackColor = false;
			this.btnDodajTelefoniju.Click += new System.EventHandler(this.btnDodajTelefoniju_Click);
			// 
			// btnIZmeniTelefoniju
			// 
			this.btnIZmeniTelefoniju.BackColor = System.Drawing.Color.SandyBrown;
			this.btnIZmeniTelefoniju.Location = new System.Drawing.Point(907, 78);
			this.btnIZmeniTelefoniju.Name = "btnIZmeniTelefoniju";
			this.btnIZmeniTelefoniju.Size = new System.Drawing.Size(118, 33);
			this.btnIZmeniTelefoniju.TabIndex = 2;
			this.btnIZmeniTelefoniju.Text = "Izmeni telefoniju";
			this.btnIZmeniTelefoniju.UseVisualStyleBackColor = false;
			this.btnIZmeniTelefoniju.Click += new System.EventHandler(this.btnIZmeniTelefoniju_Click);
			// 
			// btnObrisiTelefoniju
			// 
			this.btnObrisiTelefoniju.BackColor = System.Drawing.Color.SandyBrown;
			this.btnObrisiTelefoniju.Location = new System.Drawing.Point(907, 132);
			this.btnObrisiTelefoniju.Name = "btnObrisiTelefoniju";
			this.btnObrisiTelefoniju.Size = new System.Drawing.Size(118, 32);
			this.btnObrisiTelefoniju.TabIndex = 3;
			this.btnObrisiTelefoniju.Text = "Obrisi telefoniju";
			this.btnObrisiTelefoniju.UseVisualStyleBackColor = false;
			this.btnObrisiTelefoniju.Click += new System.EventHandler(this.btnObrisiTelefoniju_Click);
			// 
			// TelefonijaForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1048, 347);
			this.Controls.Add(this.btnObrisiTelefoniju);
			this.Controls.Add(this.btnIZmeniTelefoniju);
			this.Controls.Add(this.btnDodajTelefoniju);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "TelefonijaForma";
			this.Text = "Telefonija";
			this.Load += new System.EventHandler(this.TelefonijaForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView telefonije;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDodajTelefoniju;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnIZmeniTelefoniju;
        private System.Windows.Forms.Button btnObrisiTelefoniju;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
	}
}