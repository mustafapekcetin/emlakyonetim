namespace EmlakYonetim
{
    partial class Kiraci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.cmbkrc = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.dtMusteri = new System.Windows.Forms.DataGridView();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.rdbguncelle = new System.Windows.Forms.RadioButton();
            this.rdbekle = new System.Windows.Forms.RadioButton();
            this.grbkrc = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtMusteri)).BeginInit();
            this.grbkrc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kiracı Durumu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(57, 19);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(100, 20);
            this.txtAD.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(211, 22);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(423, 23);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 6;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // cmbkrc
            // 
            this.cmbkrc.FormattingEnabled = true;
            this.cmbkrc.Items.AddRange(new object[] {
            "BOŞ",
            "DOLU"});
            this.cmbkrc.Location = new System.Drawing.Point(99, 13);
            this.cmbkrc.Name = "cmbkrc";
            this.cmbkrc.Size = new System.Drawing.Size(121, 21);
            this.cmbkrc.TabIndex = 41;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(31, 101);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(134, 41);
            this.btnekle.TabIndex = 42;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dtMusteri
            // 
            this.dtMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMusteri.Location = new System.Drawing.Point(4, 158);
            this.dtMusteri.Name = "dtMusteri";
            this.dtMusteri.Size = new System.Drawing.Size(1260, 564);
            this.dtMusteri.TabIndex = 43;
            this.dtMusteri.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtMusteri_RowHeaderMouseClick);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(31, 101);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(134, 41);
            this.btngüncelle.TabIndex = 44;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // rdbguncelle
            // 
            this.rdbguncelle.AutoSize = true;
            this.rdbguncelle.Location = new System.Drawing.Point(117, 64);
            this.rdbguncelle.Name = "rdbguncelle";
            this.rdbguncelle.Size = new System.Drawing.Size(82, 17);
            this.rdbguncelle.TabIndex = 58;
            this.rdbguncelle.Text = "GÜNCELLE";
            this.rdbguncelle.UseVisualStyleBackColor = true;
            this.rdbguncelle.Click += new System.EventHandler(this.rdbguncelle_Click);
            // 
            // rdbekle
            // 
            this.rdbekle.AutoSize = true;
            this.rdbekle.Checked = true;
            this.rdbekle.Location = new System.Drawing.Point(44, 64);
            this.rdbekle.Name = "rdbekle";
            this.rdbekle.Size = new System.Drawing.Size(52, 17);
            this.rdbekle.TabIndex = 57;
            this.rdbekle.TabStop = true;
            this.rdbekle.Text = "EKLE";
            this.rdbekle.UseVisualStyleBackColor = true;
            this.rdbekle.Click += new System.EventHandler(this.rdbekle_Click);
            // 
            // grbkrc
            // 
            this.grbkrc.Controls.Add(this.label3);
            this.grbkrc.Controls.Add(this.cmbkrc);
            this.grbkrc.Location = new System.Drawing.Point(544, 12);
            this.grbkrc.Name = "grbkrc";
            this.grbkrc.Size = new System.Drawing.Size(276, 40);
            this.grbkrc.TabIndex = 59;
            this.grbkrc.TabStop = false;
            this.grbkrc.Visible = false;
            // 
            // Kiraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 724);
            this.Controls.Add(this.grbkrc);
            this.Controls.Add(this.rdbguncelle);
            this.Controls.Add(this.rdbekle);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.dtMusteri);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kiraci";
            this.Text = "Kiracı";
            this.Load += new System.EventHandler(this.Kiraci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMusteri)).EndInit();
            this.grbkrc.ResumeLayout(false);
            this.grbkrc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbkrc;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dtMusteri;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.RadioButton rdbguncelle;
        private System.Windows.Forms.RadioButton rdbekle;
        private System.Windows.Forms.GroupBox grbkrc;
    }
}