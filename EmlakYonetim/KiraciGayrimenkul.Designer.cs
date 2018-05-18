namespace EmlakYonetim
{
    partial class KiraciGayrimenkul
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
            this.cmbkrcgy = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.grpmüsterigayrimenkul = new System.Windows.Forms.GroupBox();
            this.dtkirabitiştarihi = new System.Windows.Forms.DateTimePicker();
            this.chkkirabitistarihi = new System.Windows.Forms.CheckBox();
            this.cmbmüsteriad = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtkirabaslangaictarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtmüsterigayrimenkul = new System.Windows.Forms.DataGridView();
            this.rdbguncelle = new System.Windows.Forms.RadioButton();
            this.rdbekle = new System.Windows.Forms.RadioButton();
            this.grbkrgy = new System.Windows.Forms.GroupBox();
            this.cmbgayrimenkulad = new System.Windows.Forms.ComboBox();
            this.grpmüsterigayrimenkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmüsterigayrimenkul)).BeginInit();
            this.grbkrgy.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbkrcgy
            // 
            this.cmbkrcgy.FormattingEnabled = true;
            this.cmbkrcgy.Items.AddRange(new object[] {
            "BOŞ",
            "DOLU"});
            this.cmbkrcgy.Location = new System.Drawing.Point(149, 14);
            this.cmbkrcgy.Name = "cmbkrcgy";
            this.cmbkrcgy.Size = new System.Drawing.Size(121, 21);
            this.cmbkrcgy.TabIndex = 52;
            this.cmbkrcgy.SelectedIndexChanged += new System.EventHandler(this.cmbkrcgy_SelectedIndexChanged);
            this.cmbkrcgy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbkrcgy_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "Kiracı Gayrimenkul Durumu:";
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(15, 141);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(141, 51);
            this.btngüncelle.TabIndex = 50;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(15, 141);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(141, 51);
            this.btnekle.TabIndex = 49;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // grpmüsterigayrimenkul
            // 
            this.grpmüsterigayrimenkul.Controls.Add(this.dtkirabitiştarihi);
            this.grpmüsterigayrimenkul.Controls.Add(this.chkkirabitistarihi);
            this.grpmüsterigayrimenkul.Location = new System.Drawing.Point(295, 42);
            this.grpmüsterigayrimenkul.Name = "grpmüsterigayrimenkul";
            this.grpmüsterigayrimenkul.Size = new System.Drawing.Size(256, 51);
            this.grpmüsterigayrimenkul.TabIndex = 48;
            this.grpmüsterigayrimenkul.TabStop = false;
            // 
            // dtkirabitiştarihi
            // 
            this.dtkirabitiştarihi.Location = new System.Drawing.Point(100, 16);
            this.dtkirabitiştarihi.Name = "dtkirabitiştarihi";
            this.dtkirabitiştarihi.Size = new System.Drawing.Size(152, 20);
            this.dtkirabitiştarihi.TabIndex = 32;
            // 
            // chkkirabitistarihi
            // 
            this.chkkirabitistarihi.AutoSize = true;
            this.chkkirabitistarihi.Location = new System.Drawing.Point(3, 19);
            this.chkkirabitistarihi.Name = "chkkirabitistarihi";
            this.chkkirabitistarihi.Size = new System.Drawing.Size(98, 17);
            this.chkkirabitistarihi.TabIndex = 30;
            this.chkkirabitistarihi.Text = "Kira Bitiş Tarihi:";
            this.chkkirabitistarihi.UseVisualStyleBackColor = true;
            // 
            // cmbmüsteriad
            // 
            this.cmbmüsteriad.FormattingEnabled = true;
            this.cmbmüsteriad.Location = new System.Drawing.Point(75, 15);
            this.cmbmüsteriad.Name = "cmbmüsteriad";
            this.cmbmüsteriad.Size = new System.Drawing.Size(121, 21);
            this.cmbmüsteriad.TabIndex = 46;
            this.cmbmüsteriad.SelectedIndexChanged += new System.EventHandler(this.cmbmüsteriad_SelectedIndexChanged);
            this.cmbmüsteriad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbmüsteriad_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Gayirmenkul Ad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "KiraBaslangıç Tarihi:";
            // 
            // dtkirabaslangaictarihi
            // 
            this.dtkirabaslangaictarihi.Location = new System.Drawing.Point(121, 56);
            this.dtkirabaslangaictarihi.Name = "dtkirabaslangaictarihi";
            this.dtkirabaslangaictarihi.Size = new System.Drawing.Size(152, 20);
            this.dtkirabaslangaictarihi.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "MüşteriAd:";
            // 
            // dtmüsterigayrimenkul
            // 
            this.dtmüsterigayrimenkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmüsterigayrimenkul.Location = new System.Drawing.Point(1, 211);
            this.dtmüsterigayrimenkul.Name = "dtmüsterigayrimenkul";
            this.dtmüsterigayrimenkul.Size = new System.Drawing.Size(1266, 513);
            this.dtmüsterigayrimenkul.TabIndex = 54;
            this.dtmüsterigayrimenkul.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtmüsterigayrimenkul_RowHeaderMouseClick);
            // 
            // rdbguncelle
            // 
            this.rdbguncelle.AutoSize = true;
            this.rdbguncelle.Location = new System.Drawing.Point(90, 103);
            this.rdbguncelle.Name = "rdbguncelle";
            this.rdbguncelle.Size = new System.Drawing.Size(82, 17);
            this.rdbguncelle.TabIndex = 56;
            this.rdbguncelle.Text = "GÜNCELLE";
            this.rdbguncelle.UseVisualStyleBackColor = true;
            this.rdbguncelle.Click += new System.EventHandler(this.rdbguncelle_Click);
            // 
            // rdbekle
            // 
            this.rdbekle.AutoSize = true;
            this.rdbekle.Checked = true;
            this.rdbekle.Location = new System.Drawing.Point(17, 103);
            this.rdbekle.Name = "rdbekle";
            this.rdbekle.Size = new System.Drawing.Size(52, 17);
            this.rdbekle.TabIndex = 55;
            this.rdbekle.TabStop = true;
            this.rdbekle.Text = "EKLE";
            this.rdbekle.UseVisualStyleBackColor = true;
            this.rdbekle.Click += new System.EventHandler(this.rdbekle_Click);
            // 
            // grbkrgy
            // 
            this.grbkrgy.Controls.Add(this.label19);
            this.grbkrgy.Controls.Add(this.cmbkrcgy);
            this.grbkrgy.Location = new System.Drawing.Point(572, 44);
            this.grbkrgy.Name = "grbkrgy";
            this.grbkrgy.Size = new System.Drawing.Size(306, 49);
            this.grbkrgy.TabIndex = 57;
            this.grbkrgy.TabStop = false;
            this.grbkrgy.Visible = false;
            // 
            // cmbgayrimenkulad
            // 
            this.cmbgayrimenkulad.FormattingEnabled = true;
            this.cmbgayrimenkulad.Location = new System.Drawing.Point(295, 16);
            this.cmbgayrimenkulad.Name = "cmbgayrimenkulad";
            this.cmbgayrimenkulad.Size = new System.Drawing.Size(121, 21);
            this.cmbgayrimenkulad.TabIndex = 58;
            this.cmbgayrimenkulad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbgayrimenkulad_KeyPress);
            // 
            // KiraciGayrimenkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 724);
            this.Controls.Add(this.cmbgayrimenkulad);
            this.Controls.Add(this.grbkrgy);
            this.Controls.Add(this.rdbguncelle);
            this.Controls.Add(this.rdbekle);
            this.Controls.Add(this.dtmüsterigayrimenkul);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.grpmüsterigayrimenkul);
            this.Controls.Add(this.cmbmüsteriad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtkirabaslangaictarihi);
            this.Controls.Add(this.label10);
            this.Name = "KiraciGayrimenkul";
            this.Text = "KİRACI GAYRİMENKUL";
            this.Load += new System.EventHandler(this.KiraciGayrimenkul_Load);
            this.grpmüsterigayrimenkul.ResumeLayout(false);
            this.grpmüsterigayrimenkul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmüsterigayrimenkul)).EndInit();
            this.grbkrgy.ResumeLayout(false);
            this.grbkrgy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbkrcgy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.GroupBox grpmüsterigayrimenkul;
        private System.Windows.Forms.DateTimePicker dtkirabitiştarihi;
        private System.Windows.Forms.CheckBox chkkirabitistarihi;
        private System.Windows.Forms.ComboBox cmbmüsteriad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtkirabaslangaictarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtmüsterigayrimenkul;
        private System.Windows.Forms.RadioButton rdbguncelle;
        private System.Windows.Forms.RadioButton rdbekle;
        private System.Windows.Forms.GroupBox grbkrgy;
        private System.Windows.Forms.ComboBox cmbgayrimenkulad;
    }
}