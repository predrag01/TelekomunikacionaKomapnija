namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class IzmeniTelefonijuForma
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
			this.grbOstaliBr = new System.Windows.Forms.GroupBox();
			this.chbTreciBr = new System.Windows.Forms.CheckBox();
			this.chbCetvrtiBr = new System.Windows.Forms.CheckBox();
			this.numMinuti4 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.txbBrTel4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numMinuti3 = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.txbBrTel3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnIzmeni = new System.Windows.Forms.Button();
			this.chbDrugiBr = new System.Windows.Forms.CheckBox();
			this.PotroseniMin2 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.txbBrTel2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.PotroseniMin1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.txbBrTel1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.grbOstaliBr.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMinuti4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinuti3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PotroseniMin2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PotroseniMin1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.grbOstaliBr);
			this.groupBox1.Controls.Add(this.btnIzmeni);
			this.groupBox1.Controls.Add(this.chbDrugiBr);
			this.groupBox1.Controls.Add(this.PotroseniMin2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txbBrTel2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.PotroseniMin1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txbBrTel1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(888, 202);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovni podaci o telefoniji";
			// 
			// grbOstaliBr
			// 
			this.grbOstaliBr.Controls.Add(this.chbTreciBr);
			this.grbOstaliBr.Controls.Add(this.chbCetvrtiBr);
			this.grbOstaliBr.Controls.Add(this.numMinuti4);
			this.grbOstaliBr.Controls.Add(this.label5);
			this.grbOstaliBr.Controls.Add(this.txbBrTel4);
			this.grbOstaliBr.Controls.Add(this.label6);
			this.grbOstaliBr.Controls.Add(this.numMinuti3);
			this.grbOstaliBr.Controls.Add(this.label7);
			this.grbOstaliBr.Controls.Add(this.txbBrTel3);
			this.grbOstaliBr.Controls.Add(this.label8);
			this.grbOstaliBr.Location = new System.Drawing.Point(432, 19);
			this.grbOstaliBr.Name = "grbOstaliBr";
			this.grbOstaliBr.Size = new System.Drawing.Size(445, 148);
			this.grbOstaliBr.TabIndex = 10;
			this.grbOstaliBr.TabStop = false;
			// 
			// chbTreciBr
			// 
			this.chbTreciBr.AutoSize = true;
			this.chbTreciBr.Location = new System.Drawing.Point(19, 12);
			this.chbTreciBr.Name = "chbTreciBr";
			this.chbTreciBr.Size = new System.Drawing.Size(101, 17);
			this.chbTreciBr.TabIndex = 18;
			this.chbTreciBr.Text = "Dozvoli teci broj";
			this.chbTreciBr.UseVisualStyleBackColor = true;
			this.chbTreciBr.CheckedChanged += new System.EventHandler(this.chbTreciBr_CheckedChanged);
			// 
			// chbCetvrtiBr
			// 
			this.chbCetvrtiBr.AutoSize = true;
			this.chbCetvrtiBr.Location = new System.Drawing.Point(19, 81);
			this.chbCetvrtiBr.Name = "chbCetvrtiBr";
			this.chbCetvrtiBr.Size = new System.Drawing.Size(113, 17);
			this.chbCetvrtiBr.TabIndex = 17;
			this.chbCetvrtiBr.Text = "Dozvoli cetvrti broj";
			this.chbCetvrtiBr.UseVisualStyleBackColor = true;
			this.chbCetvrtiBr.CheckedChanged += new System.EventHandler(this.chbCetvrtiBr_CheckedChanged);
			// 
			// numMinuti4
			// 
			this.numMinuti4.Enabled = false;
			this.numMinuti4.Location = new System.Drawing.Point(366, 114);
			this.numMinuti4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numMinuti4.Name = "numMinuti4";
			this.numMinuti4.Size = new System.Drawing.Size(59, 20);
			this.numMinuti4.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(263, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Potroseni minuti:";
			// 
			// txbBrTel4
			// 
			this.txbBrTel4.Enabled = false;
			this.txbBrTel4.Location = new System.Drawing.Point(114, 113);
			this.txbBrTel4.Name = "txbBrTel4";
			this.txbBrTel4.Size = new System.Drawing.Size(130, 20);
			this.txbBrTel4.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 116);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Broj telefona 3:";
			// 
			// numMinuti3
			// 
			this.numMinuti3.Enabled = false;
			this.numMinuti3.Location = new System.Drawing.Point(366, 35);
			this.numMinuti3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numMinuti3.Name = "numMinuti3";
			this.numMinuti3.Size = new System.Drawing.Size(59, 20);
			this.numMinuti3.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(263, 37);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Potroseni minuti:";
			// 
			// txbBrTel3
			// 
			this.txbBrTel3.Enabled = false;
			this.txbBrTel3.Location = new System.Drawing.Point(114, 34);
			this.txbBrTel3.Name = "txbBrTel3";
			this.txbBrTel3.Size = new System.Drawing.Size(130, 20);
			this.txbBrTel3.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 37);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 13);
			this.label8.TabIndex = 9;
			this.label8.Text = "Broj telefona 3:";
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.BackColor = System.Drawing.Color.SandyBrown;
			this.btnIzmeni.Location = new System.Drawing.Point(802, 173);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
			this.btnIzmeni.TabIndex = 9;
			this.btnIzmeni.Text = "Izmeni";
			this.btnIzmeni.UseVisualStyleBackColor = false;
			this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
			// 
			// chbDrugiBr
			// 
			this.chbDrugiBr.AutoSize = true;
			this.chbDrugiBr.Location = new System.Drawing.Point(9, 97);
			this.chbDrugiBr.Name = "chbDrugiBr";
			this.chbDrugiBr.Size = new System.Drawing.Size(107, 17);
			this.chbDrugiBr.TabIndex = 8;
			this.chbDrugiBr.Text = "Dozvoli drugi broj";
			this.chbDrugiBr.UseVisualStyleBackColor = true;
			this.chbDrugiBr.CheckedChanged += new System.EventHandler(this.chbDrugiBr_CheckedChanged);
			// 
			// PotroseniMin2
			// 
			this.PotroseniMin2.Enabled = false;
			this.PotroseniMin2.Location = new System.Drawing.Point(356, 130);
			this.PotroseniMin2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.PotroseniMin2.Name = "PotroseniMin2";
			this.PotroseniMin2.Size = new System.Drawing.Size(59, 20);
			this.PotroseniMin2.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(253, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Potroseni minuti:";
			// 
			// txbBrTel2
			// 
			this.txbBrTel2.Enabled = false;
			this.txbBrTel2.Location = new System.Drawing.Point(104, 129);
			this.txbBrTel2.Name = "txbBrTel2";
			this.txbBrTel2.Size = new System.Drawing.Size(130, 20);
			this.txbBrTel2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Broj telefona 2:";
			// 
			// PotroseniMin1
			// 
			this.PotroseniMin1.Location = new System.Drawing.Point(356, 51);
			this.PotroseniMin1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.PotroseniMin1.Name = "PotroseniMin1";
			this.PotroseniMin1.Size = new System.Drawing.Size(59, 20);
			this.PotroseniMin1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(253, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Potroseni minuti:";
			// 
			// txbBrTel1
			// 
			this.txbBrTel1.Location = new System.Drawing.Point(104, 50);
			this.txbBrTel1.Name = "txbBrTel1";
			this.txbBrTel1.Size = new System.Drawing.Size(130, 20);
			this.txbBrTel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Broj telefona 1:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// IzmeniTelefonijuForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 226);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "IzmeniTelefonijuForma";
			this.Text = "IzmeniTelefonijuForma";
			this.Load += new System.EventHandler(this.IzmeniTelefonijuForma_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grbOstaliBr.ResumeLayout(false);
			this.grbOstaliBr.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMinuti4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinuti3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PotroseniMin2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PotroseniMin1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PotroseniMin2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBrTel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PotroseniMin1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBrTel1;
        private System.Windows.Forms.CheckBox chbDrugiBr;
        private System.Windows.Forms.Button btnIzmeni;
		private System.Windows.Forms.GroupBox grbOstaliBr;
		private System.Windows.Forms.CheckBox chbTreciBr;
		private System.Windows.Forms.CheckBox chbCetvrtiBr;
		private System.Windows.Forms.NumericUpDown numMinuti4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txbBrTel4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numMinuti3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txbBrTel3;
		private System.Windows.Forms.Label label8;
	}
}