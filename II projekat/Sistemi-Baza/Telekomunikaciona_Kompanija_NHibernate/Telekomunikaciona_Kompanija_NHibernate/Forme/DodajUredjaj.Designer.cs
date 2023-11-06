namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class DodajUredjaj
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
            this.TipUredjajaCb = new System.Windows.Forms.ComboBox();
            this.TipUredjajaLabel = new System.Windows.Forms.Label();
            this.ProizvodjacTB = new System.Windows.Forms.TextBox();
            this.DatumPocDate = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RazlogServisaBox = new System.Windows.Forms.RichTextBox();
            this.SerijskiBrojNum = new System.Windows.Forms.NumericUpDown();
            this.DatumPocLabela = new System.Windows.Forms.Label();
            this.RazlogServisaLabel = new System.Windows.Forms.Label();
            this.ProizvodjacLabel = new System.Windows.Forms.Label();
            this.SerijskiBrojLabel = new System.Windows.Forms.Label();
            this.GlavnaStanicaGB = new System.Windows.Forms.GroupBox();
            this.ProglasiHubCheckBox = new System.Windows.Forms.CheckBox();
            this.RegionTB = new System.Windows.Forms.TextBox();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.KomCvorGB = new System.Windows.Forms.GroupBox();
            this.SerBrGlavneStananiceKCLabel = new System.Windows.Forms.Label();
            this.OpisTB = new System.Windows.Forms.RichTextBox();
            this.BrLokacijeKCNum = new System.Windows.Forms.NumericUpDown();
            this.AdresaTB = new System.Windows.Forms.TextBox();
            this.AdresaLabel = new System.Windows.Forms.Label();
            this.BrojLokacijeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DodajUredjajBtn = new System.Windows.Forms.Button();
            this.SerBrHubaGS = new System.Windows.Forms.Label();
            this.SerBrHubovaCB = new System.Windows.Forms.ComboBox();
            this.SerBrGSCB = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerijskiBrojNum)).BeginInit();
            this.GlavnaStanicaGB.SuspendLayout();
            this.KomCvorGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrLokacijeKCNum)).BeginInit();
            this.SuspendLayout();
            // 
            // TipUredjajaCb
            // 
            this.TipUredjajaCb.FormattingEnabled = true;
            this.TipUredjajaCb.Location = new System.Drawing.Point(9, 34);
            this.TipUredjajaCb.Name = "TipUredjajaCb";
            this.TipUredjajaCb.Size = new System.Drawing.Size(152, 21);
            this.TipUredjajaCb.TabIndex = 0;
            this.TipUredjajaCb.SelectedIndexChanged += new System.EventHandler(this.TipUredjajaCb_SelectedIndexChanged);
            // 
            // TipUredjajaLabel
            // 
            this.TipUredjajaLabel.AutoSize = true;
            this.TipUredjajaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipUredjajaLabel.Location = new System.Drawing.Point(6, 16);
            this.TipUredjajaLabel.Name = "TipUredjajaLabel";
            this.TipUredjajaLabel.Size = new System.Drawing.Size(88, 15);
            this.TipUredjajaLabel.TabIndex = 1;
            this.TipUredjajaLabel.Text = "Tip uredjaja:";
            // 
            // ProizvodjacTB
            // 
            this.ProizvodjacTB.Location = new System.Drawing.Point(100, 87);
            this.ProizvodjacTB.Name = "ProizvodjacTB";
            this.ProizvodjacTB.Size = new System.Drawing.Size(120, 20);
            this.ProizvodjacTB.TabIndex = 3;
            // 
            // DatumPocDate
            // 
            this.DatumPocDate.Location = new System.Drawing.Point(180, 117);
            this.DatumPocDate.Name = "DatumPocDate";
            this.DatumPocDate.Size = new System.Drawing.Size(178, 20);
            this.DatumPocDate.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RazlogServisaBox);
            this.groupBox1.Controls.Add(this.SerijskiBrojNum);
            this.groupBox1.Controls.Add(this.DatumPocLabela);
            this.groupBox1.Controls.Add(this.RazlogServisaLabel);
            this.groupBox1.Controls.Add(this.ProizvodjacLabel);
            this.groupBox1.Controls.Add(this.DatumPocDate);
            this.groupBox1.Controls.Add(this.SerijskiBrojLabel);
            this.groupBox1.Controls.Add(this.TipUredjajaCb);
            this.groupBox1.Controls.Add(this.TipUredjajaLabel);
            this.groupBox1.Controls.Add(this.ProizvodjacTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 279);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // RazlogServisaBox
            // 
            this.RazlogServisaBox.Location = new System.Drawing.Point(9, 162);
            this.RazlogServisaBox.Name = "RazlogServisaBox";
            this.RazlogServisaBox.Size = new System.Drawing.Size(349, 98);
            this.RazlogServisaBox.TabIndex = 7;
            this.RazlogServisaBox.Text = "";
            // 
            // SerijskiBrojNum
            // 
            this.SerijskiBrojNum.Location = new System.Drawing.Point(100, 61);
            this.SerijskiBrojNum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.SerijskiBrojNum.Name = "SerijskiBrojNum";
            this.SerijskiBrojNum.Size = new System.Drawing.Size(120, 20);
            this.SerijskiBrojNum.TabIndex = 10;
            this.SerijskiBrojNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DatumPocLabela
            // 
            this.DatumPocLabela.AutoSize = true;
            this.DatumPocLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatumPocLabela.Location = new System.Drawing.Point(6, 117);
            this.DatumPocLabela.Name = "DatumPocLabela";
            this.DatumPocLabela.Size = new System.Drawing.Size(168, 15);
            this.DatumPocLabela.TabIndex = 9;
            this.DatumPocLabela.Text = "Datum pocetka upotrebe:";
            // 
            // RazlogServisaLabel
            // 
            this.RazlogServisaLabel.AutoSize = true;
            this.RazlogServisaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RazlogServisaLabel.Location = new System.Drawing.Point(6, 140);
            this.RazlogServisaLabel.Name = "RazlogServisaLabel";
            this.RazlogServisaLabel.Size = new System.Drawing.Size(176, 15);
            this.RazlogServisaLabel.TabIndex = 9;
            this.RazlogServisaLabel.Text = "Razlog poslednjeg servisa";
            // 
            // ProizvodjacLabel
            // 
            this.ProizvodjacLabel.AutoSize = true;
            this.ProizvodjacLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProizvodjacLabel.Location = new System.Drawing.Point(6, 88);
            this.ProizvodjacLabel.Name = "ProizvodjacLabel";
            this.ProizvodjacLabel.Size = new System.Drawing.Size(85, 15);
            this.ProizvodjacLabel.TabIndex = 8;
            this.ProizvodjacLabel.Text = "Proizvodjac:";
            // 
            // SerijskiBrojLabel
            // 
            this.SerijskiBrojLabel.AutoSize = true;
            this.SerijskiBrojLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerijskiBrojLabel.Location = new System.Drawing.Point(6, 62);
            this.SerijskiBrojLabel.Name = "SerijskiBrojLabel";
            this.SerijskiBrojLabel.Size = new System.Drawing.Size(88, 15);
            this.SerijskiBrojLabel.TabIndex = 7;
            this.SerijskiBrojLabel.Text = "Serijski broj:";
            // 
            // GlavnaStanicaGB
            // 
            this.GlavnaStanicaGB.Controls.Add(this.SerBrHubovaCB);
            this.GlavnaStanicaGB.Controls.Add(this.SerBrHubaGS);
            this.GlavnaStanicaGB.Controls.Add(this.ProglasiHubCheckBox);
            this.GlavnaStanicaGB.Controls.Add(this.RegionTB);
            this.GlavnaStanicaGB.Controls.Add(this.RegionLabel);
            this.GlavnaStanicaGB.Location = new System.Drawing.Point(393, 12);
            this.GlavnaStanicaGB.Name = "GlavnaStanicaGB";
            this.GlavnaStanicaGB.Size = new System.Drawing.Size(326, 119);
            this.GlavnaStanicaGB.TabIndex = 7;
            this.GlavnaStanicaGB.TabStop = false;
            this.GlavnaStanicaGB.Visible = false;
            // 
            // ProglasiHubCheckBox
            // 
            this.ProglasiHubCheckBox.AutoSize = true;
            this.ProglasiHubCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProglasiHubCheckBox.Location = new System.Drawing.Point(65, 82);
            this.ProglasiHubCheckBox.Name = "ProglasiHubCheckBox";
            this.ProglasiHubCheckBox.Size = new System.Drawing.Size(128, 19);
            this.ProglasiHubCheckBox.TabIndex = 2;
            this.ProglasiHubCheckBox.Text = "Proglasi za Hub";
            this.ProglasiHubCheckBox.UseVisualStyleBackColor = true;
            this.ProglasiHubCheckBox.CheckedChanged += new System.EventHandler(this.ProglasiHubCheckBox_CheckedChanged);
            // 
            // RegionTB
            // 
            this.RegionTB.Location = new System.Drawing.Point(71, 51);
            this.RegionTB.Name = "RegionTB";
            this.RegionTB.Size = new System.Drawing.Size(234, 20);
            this.RegionTB.TabIndex = 1;
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionLabel.Location = new System.Drawing.Point(4, 52);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(61, 15);
            this.RegionLabel.TabIndex = 0;
            this.RegionLabel.Text = "Region: ";
            // 
            // KomCvorGB
            // 
            this.KomCvorGB.Controls.Add(this.SerBrGSCB);
            this.KomCvorGB.Controls.Add(this.SerBrGlavneStananiceKCLabel);
            this.KomCvorGB.Controls.Add(this.OpisTB);
            this.KomCvorGB.Controls.Add(this.BrLokacijeKCNum);
            this.KomCvorGB.Controls.Add(this.AdresaTB);
            this.KomCvorGB.Controls.Add(this.AdresaLabel);
            this.KomCvorGB.Controls.Add(this.BrojLokacijeLabel);
            this.KomCvorGB.Controls.Add(this.label1);
            this.KomCvorGB.Location = new System.Drawing.Point(393, 137);
            this.KomCvorGB.Name = "KomCvorGB";
            this.KomCvorGB.Size = new System.Drawing.Size(326, 224);
            this.KomCvorGB.TabIndex = 8;
            this.KomCvorGB.TabStop = false;
            this.KomCvorGB.Visible = false;
            // 
            // SerBrGlavneStananiceKCLabel
            // 
            this.SerBrGlavneStananiceKCLabel.AutoSize = true;
            this.SerBrGlavneStananiceKCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerBrGlavneStananiceKCLabel.Location = new System.Drawing.Point(11, 168);
            this.SerBrGlavneStananiceKCLabel.Name = "SerBrGlavneStananiceKCLabel";
            this.SerBrGlavneStananiceKCLabel.Size = new System.Drawing.Size(105, 15);
            this.SerBrGlavneStananiceKCLabel.TabIndex = 8;
            this.SerBrGlavneStananiceKCLabel.Text = "Glavna stanica:";
            // 
            // OpisTB
            // 
            this.OpisTB.Location = new System.Drawing.Point(65, 71);
            this.OpisTB.Name = "OpisTB";
            this.OpisTB.Size = new System.Drawing.Size(240, 64);
            this.OpisTB.TabIndex = 7;
            this.OpisTB.Text = "";
            // 
            // BrLokacijeKCNum
            // 
            this.BrLokacijeKCNum.Location = new System.Drawing.Point(103, 16);
            this.BrLokacijeKCNum.Name = "BrLokacijeKCNum";
            this.BrLokacijeKCNum.Size = new System.Drawing.Size(120, 20);
            this.BrLokacijeKCNum.TabIndex = 6;
            this.BrLokacijeKCNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AdresaTB
            // 
            this.AdresaTB.Location = new System.Drawing.Point(103, 41);
            this.AdresaTB.Name = "AdresaTB";
            this.AdresaTB.Size = new System.Drawing.Size(202, 20);
            this.AdresaTB.TabIndex = 5;
            // 
            // AdresaLabel
            // 
            this.AdresaLabel.AutoSize = true;
            this.AdresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresaLabel.Location = new System.Drawing.Point(11, 44);
            this.AdresaLabel.Name = "AdresaLabel";
            this.AdresaLabel.Size = new System.Drawing.Size(55, 15);
            this.AdresaLabel.TabIndex = 2;
            this.AdresaLabel.Text = "Adresa:";
            // 
            // BrojLokacijeLabel
            // 
            this.BrojLokacijeLabel.AutoSize = true;
            this.BrojLokacijeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrojLokacijeLabel.Location = new System.Drawing.Point(7, 18);
            this.BrojLokacijeLabel.Name = "BrojLokacijeLabel";
            this.BrojLokacijeLabel.Size = new System.Drawing.Size(91, 15);
            this.BrojLokacijeLabel.TabIndex = 1;
            this.BrojLokacijeLabel.Text = "Broj lokacije:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis:";
            // 
            // DodajUredjajBtn
            // 
            this.DodajUredjajBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.DodajUredjajBtn.Location = new System.Drawing.Point(300, 367);
            this.DodajUredjajBtn.Name = "DodajUredjajBtn";
            this.DodajUredjajBtn.Size = new System.Drawing.Size(159, 35);
            this.DodajUredjajBtn.TabIndex = 9;
            this.DodajUredjajBtn.Text = "Dodaj Uredjaj";
            this.DodajUredjajBtn.UseVisualStyleBackColor = false;
            this.DodajUredjajBtn.Click += new System.EventHandler(this.DodajUredjajBtn_Click);
            // 
            // SerBrHubaGS
            // 
            this.SerBrHubaGS.AutoSize = true;
            this.SerBrHubaGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerBrHubaGS.Location = new System.Drawing.Point(7, 16);
            this.SerBrHubaGS.Name = "SerBrHubaGS";
            this.SerBrHubaGS.Size = new System.Drawing.Size(37, 15);
            this.SerBrHubaGS.TabIndex = 12;
            this.SerBrHubaGS.Text = "Hub:";
            // 
            // SerBrHubovaCB
            // 
            this.SerBrHubovaCB.FormattingEnabled = true;
            this.SerBrHubovaCB.Location = new System.Drawing.Point(71, 16);
            this.SerBrHubovaCB.Name = "SerBrHubovaCB";
            this.SerBrHubovaCB.Size = new System.Drawing.Size(158, 21);
            this.SerBrHubovaCB.TabIndex = 13;
            // 
            // SerBrGSCB
            // 
            this.SerBrGSCB.FormattingEnabled = true;
            this.SerBrGSCB.Location = new System.Drawing.Point(122, 167);
            this.SerBrGSCB.Name = "SerBrGSCB";
            this.SerBrGSCB.Size = new System.Drawing.Size(158, 21);
            this.SerBrGSCB.TabIndex = 14;
            // 
            // DodajUredjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 414);
            this.Controls.Add(this.DodajUredjajBtn);
            this.Controls.Add(this.KomCvorGB);
            this.Controls.Add(this.GlavnaStanicaGB);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DodajUredjaj";
            this.Text = "Dodaj Uredjaj";
            this.Load += new System.EventHandler(this.DodajUredjaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerijskiBrojNum)).EndInit();
            this.GlavnaStanicaGB.ResumeLayout(false);
            this.GlavnaStanicaGB.PerformLayout();
            this.KomCvorGB.ResumeLayout(false);
            this.KomCvorGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrLokacijeKCNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TipUredjajaCb;
        private System.Windows.Forms.Label TipUredjajaLabel;
        private System.Windows.Forms.TextBox ProizvodjacTB;
        private System.Windows.Forms.DateTimePicker DatumPocDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RazlogServisaBox;
        private System.Windows.Forms.NumericUpDown SerijskiBrojNum;
        private System.Windows.Forms.Label DatumPocLabela;
        private System.Windows.Forms.Label RazlogServisaLabel;
        private System.Windows.Forms.Label ProizvodjacLabel;
        private System.Windows.Forms.Label SerijskiBrojLabel;
        private System.Windows.Forms.GroupBox GlavnaStanicaGB;
        private System.Windows.Forms.TextBox RegionTB;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.GroupBox KomCvorGB;
        private System.Windows.Forms.RichTextBox OpisTB;
        private System.Windows.Forms.NumericUpDown BrLokacijeKCNum;
        private System.Windows.Forms.TextBox AdresaTB;
        private System.Windows.Forms.Label AdresaLabel;
        private System.Windows.Forms.Label BrojLokacijeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajUredjajBtn;
        private System.Windows.Forms.CheckBox ProglasiHubCheckBox;
        private System.Windows.Forms.Label SerBrGlavneStananiceKCLabel;
        private System.Windows.Forms.Label SerBrHubaGS;
        private System.Windows.Forms.ComboBox SerBrHubovaCB;
        private System.Windows.Forms.ComboBox SerBrGSCB;
    }
}