namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class PregledDodatnihPaketaTelevizijeForma
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
			this.btnObrisiDodatniPaket = new System.Windows.Forms.Button();
			this.dodatniPaketi = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnIzmenidodatniPaket = new System.Windows.Forms.Button();
			this.btnDodajDodatniPaket = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnObrisiDodatniPaket);
			this.groupBox1.Controls.Add(this.dodatniPaketi);
			this.groupBox1.Controls.Add(this.btnIzmenidodatniPaket);
			this.groupBox1.Controls.Add(this.btnDodajDodatniPaket);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(380, 289);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dodatni paketi televizije";
			// 
			// btnObrisiDodatniPaket
			// 
			this.btnObrisiDodatniPaket.BackColor = System.Drawing.Color.SandyBrown;
			this.btnObrisiDodatniPaket.Location = new System.Drawing.Point(259, 116);
			this.btnObrisiDodatniPaket.Name = "btnObrisiDodatniPaket";
			this.btnObrisiDodatniPaket.Size = new System.Drawing.Size(103, 33);
			this.btnObrisiDodatniPaket.TabIndex = 3;
			this.btnObrisiDodatniPaket.Text = "Orbisi paket";
			this.btnObrisiDodatniPaket.UseVisualStyleBackColor = false;
			this.btnObrisiDodatniPaket.Click += new System.EventHandler(this.btnObrisiDodatniPaket_Click);
			// 
			// dodatniPaketi
			// 
			this.dodatniPaketi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
			this.dodatniPaketi.FullRowSelect = true;
			this.dodatniPaketi.HideSelection = false;
			this.dodatniPaketi.Location = new System.Drawing.Point(6, 19);
			this.dodatniPaketi.Name = "dodatniPaketi";
			this.dodatniPaketi.Size = new System.Drawing.Size(231, 264);
			this.dodatniPaketi.TabIndex = 0;
			this.dodatniPaketi.UseCompatibleStateImageBehavior = false;
			this.dodatniPaketi.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			this.columnHeader1.Width = 34;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Dodatni paket kanala";
			this.columnHeader3.Width = 184;
			// 
			// btnIzmenidodatniPaket
			// 
			this.btnIzmenidodatniPaket.BackColor = System.Drawing.Color.SandyBrown;
			this.btnIzmenidodatniPaket.Location = new System.Drawing.Point(259, 68);
			this.btnIzmenidodatniPaket.Name = "btnIzmenidodatniPaket";
			this.btnIzmenidodatniPaket.Size = new System.Drawing.Size(103, 33);
			this.btnIzmenidodatniPaket.TabIndex = 2;
			this.btnIzmenidodatniPaket.Text = "Izmeni paket";
			this.btnIzmenidodatniPaket.UseVisualStyleBackColor = false;
			this.btnIzmenidodatniPaket.Click += new System.EventHandler(this.btnIzmenidodatniPaket_Click);
			// 
			// btnDodajDodatniPaket
			// 
			this.btnDodajDodatniPaket.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDodajDodatniPaket.Location = new System.Drawing.Point(259, 19);
			this.btnDodajDodatniPaket.Name = "btnDodajDodatniPaket";
			this.btnDodajDodatniPaket.Size = new System.Drawing.Size(103, 33);
			this.btnDodajDodatniPaket.TabIndex = 1;
			this.btnDodajDodatniPaket.Text = "Dodaj paket";
			this.btnDodajDodatniPaket.UseVisualStyleBackColor = false;
			this.btnDodajDodatniPaket.Click += new System.EventHandler(this.btnDodajDodatniPaket_Click);
			// 
			// PregledDodatnihPaketaTelevizijeForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(405, 305);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "PregledDodatnihPaketaTelevizijeForma";
			this.Text = "PregledDodatnihPaketaTelevizijeForma";
			this.Load += new System.EventHandler(this.PregledDodatnihPaketaTelevizijeForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisiDodatniPaket;
        private System.Windows.Forms.ListView dodatniPaketi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnIzmenidodatniPaket;
        private System.Windows.Forms.Button btnDodajDodatniPaket;
    }
}