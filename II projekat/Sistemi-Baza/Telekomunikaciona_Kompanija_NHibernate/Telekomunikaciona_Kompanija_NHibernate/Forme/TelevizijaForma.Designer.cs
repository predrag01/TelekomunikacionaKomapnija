namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class TelevizijaForma
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
			this.btnDodatniPaket = new System.Windows.Forms.Button();
			this.btnObrisiTeleviziju = new System.Windows.Forms.Button();
			this.televizije = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnIzmeniTeleviziju = new System.Windows.Forms.Button();
			this.btnDodajTeleviziju = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDodatniPaket);
			this.groupBox1.Controls.Add(this.btnObrisiTeleviziju);
			this.groupBox1.Controls.Add(this.televizije);
			this.groupBox1.Controls.Add(this.btnIzmeniTeleviziju);
			this.groupBox1.Controls.Add(this.btnDodajTeleviziju);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(390, 289);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Televizija";
			// 
			// btnDodatniPaket
			// 
			this.btnDodatniPaket.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDodatniPaket.Location = new System.Drawing.Point(259, 221);
			this.btnDodatniPaket.Name = "btnDodatniPaket";
			this.btnDodatniPaket.Size = new System.Drawing.Size(103, 37);
			this.btnDodatniPaket.TabIndex = 4;
			this.btnDodatniPaket.Text = "Dodatni paket kanala";
			this.btnDodatniPaket.UseVisualStyleBackColor = false;
			this.btnDodatniPaket.Click += new System.EventHandler(this.btnDodatniPaket_Click);
			// 
			// btnObrisiTeleviziju
			// 
			this.btnObrisiTeleviziju.BackColor = System.Drawing.Color.SandyBrown;
			this.btnObrisiTeleviziju.Location = new System.Drawing.Point(259, 116);
			this.btnObrisiTeleviziju.Name = "btnObrisiTeleviziju";
			this.btnObrisiTeleviziju.Size = new System.Drawing.Size(103, 33);
			this.btnObrisiTeleviziju.TabIndex = 3;
			this.btnObrisiTeleviziju.Text = "Orbisi televiziju";
			this.btnObrisiTeleviziju.UseVisualStyleBackColor = false;
			this.btnObrisiTeleviziju.Click += new System.EventHandler(this.btnObrisiTeleviziju_Click);
			// 
			// televizije
			// 
			this.televizije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.televizije.FullRowSelect = true;
			this.televizije.HideSelection = false;
			this.televizije.Location = new System.Drawing.Point(6, 19);
			this.televizije.Name = "televizije";
			this.televizije.Size = new System.Drawing.Size(231, 264);
			this.televizije.TabIndex = 0;
			this.televizije.UseCompatibleStateImageBehavior = false;
			this.televizije.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			this.columnHeader1.Width = 34;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tip usluge";
			this.columnHeader2.Width = 65;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Paket";
			this.columnHeader3.Width = 111;
			// 
			// btnIzmeniTeleviziju
			// 
			this.btnIzmeniTeleviziju.BackColor = System.Drawing.Color.SandyBrown;
			this.btnIzmeniTeleviziju.Location = new System.Drawing.Point(259, 68);
			this.btnIzmeniTeleviziju.Name = "btnIzmeniTeleviziju";
			this.btnIzmeniTeleviziju.Size = new System.Drawing.Size(103, 33);
			this.btnIzmeniTeleviziju.TabIndex = 2;
			this.btnIzmeniTeleviziju.Text = "Izmeni televiziju";
			this.btnIzmeniTeleviziju.UseVisualStyleBackColor = false;
			this.btnIzmeniTeleviziju.Click += new System.EventHandler(this.btnIzmeniTeleviziju_Click);
			// 
			// btnDodajTeleviziju
			// 
			this.btnDodajTeleviziju.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDodajTeleviziju.Location = new System.Drawing.Point(259, 19);
			this.btnDodajTeleviziju.Name = "btnDodajTeleviziju";
			this.btnDodajTeleviziju.Size = new System.Drawing.Size(103, 33);
			this.btnDodajTeleviziju.TabIndex = 1;
			this.btnDodajTeleviziju.Text = "Dodaj televiziju";
			this.btnDodajTeleviziju.UseVisualStyleBackColor = false;
			this.btnDodajTeleviziju.Click += new System.EventHandler(this.btnDodajTeleviziju_Click);
			// 
			// TelevizijaForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(407, 313);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "TelevizijaForma";
			this.Text = "TelevizijaForma";
			this.Load += new System.EventHandler(this.TelevizijaForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView televizije;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDodajTeleviziju;
        private System.Windows.Forms.Button btnIzmeniTeleviziju;
        private System.Windows.Forms.Button btnObrisiTeleviziju;
        private System.Windows.Forms.Button btnDodatniPaket;
    }
}