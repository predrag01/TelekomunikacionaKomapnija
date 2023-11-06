namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class PotvrdiBrisanjeUredjaja
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
            this.PotvrdaLabel = new System.Windows.Forms.Label();
            this.DABtn = new System.Windows.Forms.Button();
            this.NEBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PotvrdaLabel
            // 
            this.PotvrdaLabel.AutoSize = true;
            this.PotvrdaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotvrdaLabel.Location = new System.Drawing.Point(19, 9);
            this.PotvrdaLabel.Name = "PotvrdaLabel";
            this.PotvrdaLabel.Size = new System.Drawing.Size(439, 20);
            this.PotvrdaLabel.TabIndex = 0;
            this.PotvrdaLabel.Text = "Da li ste sigurni da zelite da izvrsite brisanje uredjaja?";
            // 
            // DABtn
            // 
            this.DABtn.BackColor = System.Drawing.Color.Green;
            this.DABtn.Location = new System.Drawing.Point(12, 72);
            this.DABtn.Name = "DABtn";
            this.DABtn.Size = new System.Drawing.Size(181, 33);
            this.DABtn.TabIndex = 1;
            this.DABtn.Text = "DA";
            this.DABtn.UseVisualStyleBackColor = false;
            this.DABtn.Click += new System.EventHandler(this.DABtn_Click);
            // 
            // NEBtn
            // 
            this.NEBtn.BackColor = System.Drawing.Color.Firebrick;
            this.NEBtn.Location = new System.Drawing.Point(284, 72);
            this.NEBtn.Name = "NEBtn";
            this.NEBtn.Size = new System.Drawing.Size(181, 33);
            this.NEBtn.TabIndex = 2;
            this.NEBtn.Text = "NE";
            this.NEBtn.UseVisualStyleBackColor = false;
            this.NEBtn.Click += new System.EventHandler(this.NEBtn_Click);
            // 
            // PotvrdiBrisanjeUredjaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 140);
            this.Controls.Add(this.NEBtn);
            this.Controls.Add(this.DABtn);
            this.Controls.Add(this.PotvrdaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PotvrdiBrisanjeUredjaja";
            this.Text = "Potvrdi Brisanje";
            this.Load += new System.EventHandler(this.PotvrdiBrisanjeUredjaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PotvrdaLabel;
        private System.Windows.Forms.Button DABtn;
        private System.Windows.Forms.Button NEBtn;
    }
}