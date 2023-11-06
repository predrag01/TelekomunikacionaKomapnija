namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class IzmeniTelevizijuForma
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
			this.txbPaket = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnIzmeni);
			this.groupBox1.Controls.Add(this.txbPaket);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(246, 145);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovne informacije o televiziji";
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.BackColor = System.Drawing.Color.SandyBrown;
			this.btnIzmeni.Location = new System.Drawing.Point(153, 105);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
			this.btnIzmeni.TabIndex = 2;
			this.btnIzmeni.Text = "Izmeni";
			this.btnIzmeni.UseVisualStyleBackColor = false;
			this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
			// 
			// txbPaket
			// 
			this.txbPaket.Location = new System.Drawing.Point(83, 39);
			this.txbPaket.Name = "txbPaket";
			this.txbPaket.Size = new System.Drawing.Size(145, 20);
			this.txbPaket.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Paket";
			// 
			// IzmeniTelevizijuForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(260, 156);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "IzmeniTelevizijuForma";
			this.Text = "IzmeniTelevizijuForma";
			this.Load += new System.EventHandler(this.IzmeniTelevizijuForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txbPaket;
        private System.Windows.Forms.Label label1;
    }
}