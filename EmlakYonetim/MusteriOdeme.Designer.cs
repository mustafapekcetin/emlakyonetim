namespace EmlakYonetim
{
    partial class MusteriOdeme
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
            this.cmbmstodm = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtGayrimenkulAdı = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOdemetutarı = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtOdemetarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbmusteriadodeme = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtmusteriodeme = new System.Windows.Forms.DataGridView();
            this.rdbguncelle = new System.Windows.Forms.RadioButton();
            this.rdbekle = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbmstodm = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtmusteriodeme)).BeginInit();
            this.grbmstodm.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbmstodm
            // 
            this.cmbmstodm.FormattingEnabled = true;
            this.cmbmstodm.Items.AddRange(new object[] {
            "BOŞ",
            "DOLU"});
            this.cmbmstodm.Location = new System.Drawing.Point(133, 15);
            this.cmbmstodm.Name = "cmbmstodm";
            this.cmbmstodm.Size = new System.Drawing.Size(121, 21);
            this.cmbmstodm.TabIndex = 54;
            this.cmbmstodm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbmstodm_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "Müşteri Ödeme Durumu:";
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(15, 118);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(141, 51);
            this.btngüncelle.TabIndex = 52;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.Btngüncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(15, 118);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(141, 51);
            this.btnekle.TabIndex = 51;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.Btnekle_Click);
            // 
            // txtGayrimenkulAdı
            // 
            this.txtGayrimenkulAdı.Enabled = false;
            this.txtGayrimenkulAdı.Location = new System.Drawing.Point(323, 7);
            this.txtGayrimenkulAdı.Name = "txtGayrimenkulAdı";
            this.txtGayrimenkulAdı.Size = new System.Drawing.Size(110, 20);
            this.txtGayrimenkulAdı.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(235, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Gayrimenkul Adı:";
            // 
            // txtOdemetutarı
            // 
            this.txtOdemetutarı.Location = new System.Drawing.Point(323, 38);
            this.txtOdemetutarı.Name = "txtOdemetutarı";
            this.txtOdemetutarı.Size = new System.Drawing.Size(110, 20);
            this.txtOdemetutarı.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Odeme Tutarı:";
            // 
            // dtOdemetarihi
            // 
            this.dtOdemetarihi.Location = new System.Drawing.Point(87, 38);
            this.dtOdemetarihi.Name = "dtOdemetarihi";
            this.dtOdemetarihi.Size = new System.Drawing.Size(153, 20);
            this.dtOdemetarihi.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Odeme Tarihi:";
            // 
            // cmbmusteriadodeme
            // 
            this.cmbmusteriadodeme.Location = new System.Drawing.Point(80, 6);
            this.cmbmusteriadodeme.Name = "cmbmusteriadodeme";
            this.cmbmusteriadodeme.Size = new System.Drawing.Size(121, 21);
            this.cmbmusteriadodeme.TabIndex = 55;
            this.cmbmusteriadodeme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbmusteriadodeme_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Müşteri Adı:";
            // 
            // dtmusteriodeme
            // 
            this.dtmusteriodeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmusteriodeme.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtmusteriodeme.Location = new System.Drawing.Point(3, 175);
            this.dtmusteriodeme.Name = "dtmusteriodeme";
            this.dtmusteriodeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtmusteriodeme.Size = new System.Drawing.Size(1257, 556);
            this.dtmusteriodeme.TabIndex = 56;
            this.dtmusteriodeme.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dtmusteriodeme_RowHeaderMouseClick);
            // 
            // rdbguncelle
            // 
            this.rdbguncelle.AutoSize = true;
            this.rdbguncelle.Location = new System.Drawing.Point(95, 82);
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
            this.rdbekle.Location = new System.Drawing.Point(22, 82);
            this.rdbekle.Name = "rdbekle";
            this.rdbekle.Size = new System.Drawing.Size(52, 17);
            this.rdbekle.TabIndex = 57;
            this.rdbekle.TabStop = true;
            this.rdbekle.Text = "EKLE";
            this.rdbekle.UseVisualStyleBackColor = true;
            this.rdbekle.Click += new System.EventHandler(this.rdbekle_Click);
            // 
            // grbmstodm
            // 
            this.grbmstodm.Controls.Add(this.label20);
            this.grbmstodm.Controls.Add(this.cmbmstodm);
            this.grbmstodm.Location = new System.Drawing.Point(472, 26);
            this.grbmstodm.Name = "grbmstodm";
            this.grbmstodm.Size = new System.Drawing.Size(273, 47);
            this.grbmstodm.TabIndex = 59;
            this.grbmstodm.TabStop = false;
            this.grbmstodm.Visible = false;
            // 
            // MusteriOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 724);
            this.Controls.Add(this.grbmstodm);
            this.Controls.Add(this.rdbguncelle);
            this.Controls.Add(this.rdbekle);
            this.Controls.Add(this.dtmusteriodeme);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtGayrimenkulAdı);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtOdemetutarı);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtOdemetarihi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbmusteriadodeme);
            this.Controls.Add(this.label12);
            this.Name = "MusteriOdeme";
            this.Text = "MusteriOdeme";
            this.Load += new System.EventHandler(this.MusteriOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtmusteriodeme)).EndInit();
            this.grbmstodm.ResumeLayout(false);
            this.grbmstodm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmstodm;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtGayrimenkulAdı;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOdemetutarı;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtOdemetarihi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbmusteriadodeme;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtmusteriodeme;
        private System.Windows.Forms.RadioButton rdbguncelle;
        private System.Windows.Forms.RadioButton rdbekle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbmstodm;
    }
}