namespace EmlakYonetim
{
    partial class GayrimenkulFiyat
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
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dtgyfiyat = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGayrimenkulFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGayrimenkul = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtGayrimenkulFiyat = new System.Windows.Forms.DataGridView();
            this.rdbguncelle = new System.Windows.Forms.RadioButton();
            this.rdbekle = new System.Windows.Forms.RadioButton();
            this.grbgyfyt = new System.Windows.Forms.GroupBox();
            this.cmbgyfytdrm = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGayrimenkulFiyat)).BeginInit();
            this.grbgyfyt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(30, 128);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(139, 51);
            this.btnguncelle.TabIndex = 34;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(30, 128);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(139, 51);
            this.btnekle.TabIndex = 33;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dtgyfiyat
            // 
            this.dtgyfiyat.Location = new System.Drawing.Point(517, 32);
            this.dtgyfiyat.Name = "dtgyfiyat";
            this.dtgyfiyat.Size = new System.Drawing.Size(154, 20);
            this.dtgyfiyat.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Kira Zam Tarihi:";
            // 
            // txtGayrimenkulFiyat
            // 
            this.txtGayrimenkulFiyat.Location = new System.Drawing.Point(328, 32);
            this.txtGayrimenkulFiyat.Name = "txtGayrimenkulFiyat";
            this.txtGayrimenkulFiyat.Size = new System.Drawing.Size(89, 20);
            this.txtGayrimenkulFiyat.TabIndex = 30;
            this.txtGayrimenkulFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGayrimenkulFiyat_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Gayrimenkul Fiyatı:";
            // 
            // cmbGayrimenkul
            // 
            this.cmbGayrimenkul.FormattingEnabled = true;
            this.cmbGayrimenkul.Location = new System.Drawing.Point(101, 29);
            this.cmbGayrimenkul.Name = "cmbGayrimenkul";
            this.cmbGayrimenkul.Size = new System.Drawing.Size(121, 21);
            this.cmbGayrimenkul.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Gayrimenkul Adı:";
            // 
            // dtGayrimenkulFiyat
            // 
            this.dtGayrimenkulFiyat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGayrimenkulFiyat.Location = new System.Drawing.Point(-1, 203);
            this.dtGayrimenkulFiyat.Name = "dtGayrimenkulFiyat";
            this.dtGayrimenkulFiyat.Size = new System.Drawing.Size(1269, 524);
            this.dtGayrimenkulFiyat.TabIndex = 37;
            this.dtGayrimenkulFiyat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGayrimenkulFiyat_RowHeaderMouseClick);
            // 
            // rdbguncelle
            // 
            this.rdbguncelle.AutoSize = true;
            this.rdbguncelle.Location = new System.Drawing.Point(103, 75);
            this.rdbguncelle.Name = "rdbguncelle";
            this.rdbguncelle.Size = new System.Drawing.Size(82, 17);
            this.rdbguncelle.TabIndex = 39;
            this.rdbguncelle.Text = "GÜNCELLE";
            this.rdbguncelle.UseVisualStyleBackColor = true;
            this.rdbguncelle.Click += new System.EventHandler(this.rdbguncelle_Click);
            // 
            // rdbekle
            // 
            this.rdbekle.AutoSize = true;
            this.rdbekle.Checked = true;
            this.rdbekle.Location = new System.Drawing.Point(30, 75);
            this.rdbekle.Name = "rdbekle";
            this.rdbekle.Size = new System.Drawing.Size(52, 17);
            this.rdbekle.TabIndex = 38;
            this.rdbekle.TabStop = true;
            this.rdbekle.Text = "EKLE";
            this.rdbekle.UseVisualStyleBackColor = true;
            this.rdbekle.Click += new System.EventHandler(this.rdbekle_Click);
            // 
            // grbgyfyt
            // 
            this.grbgyfyt.Controls.Add(this.cmbgyfytdrm);
            this.grbgyfyt.Controls.Add(this.label21);
            this.grbgyfyt.Location = new System.Drawing.Point(702, 12);
            this.grbgyfyt.Name = "grbgyfyt";
            this.grbgyfyt.Size = new System.Drawing.Size(295, 64);
            this.grbgyfyt.TabIndex = 40;
            this.grbgyfyt.TabStop = false;
            this.grbgyfyt.Visible = false;
            // 
            // cmbgyfytdrm
            // 
            this.cmbgyfytdrm.FormattingEnabled = true;
            this.cmbgyfytdrm.Items.AddRange(new object[] {
            "BOŞ",
            "DOLU"});
            this.cmbgyfytdrm.Location = new System.Drawing.Point(141, 20);
            this.cmbgyfytdrm.Name = "cmbgyfytdrm";
            this.cmbgyfytdrm.Size = new System.Drawing.Size(121, 21);
            this.cmbgyfytdrm.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Gayrimenkul Fiyat Durumu:";
            // 
            // GayrimenkulFiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 724);
            this.Controls.Add(this.grbgyfyt);
            this.Controls.Add(this.rdbguncelle);
            this.Controls.Add(this.rdbekle);
            this.Controls.Add(this.dtGayrimenkulFiyat);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dtgyfiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGayrimenkulFiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbGayrimenkul);
            this.Controls.Add(this.label6);
            this.Name = "GayrimenkulFiyat";
            this.Text = "GayrimenkulFiyat";
            this.Load += new System.EventHandler(this.GayrimenkulFiyat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGayrimenkulFiyat)).EndInit();
            this.grbgyfyt.ResumeLayout(false);
            this.grbgyfyt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DateTimePicker dtgyfiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGayrimenkulFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGayrimenkul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtGayrimenkulFiyat;
        private System.Windows.Forms.RadioButton rdbguncelle;
        private System.Windows.Forms.RadioButton rdbekle;
        private System.Windows.Forms.GroupBox grbgyfyt;
        private System.Windows.Forms.ComboBox cmbgyfytdrm;
        private System.Windows.Forms.Label label21;
    }
}