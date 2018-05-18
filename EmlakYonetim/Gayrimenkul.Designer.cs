namespace EmlakYonetim
{
    partial class Gayrimenkul
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
            this.cmbgydr = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtgayrimenkulad = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.cmbgayrimenkultip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbilce = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.dtGayrimenkul = new System.Windows.Forms.DataGridView();
            this.grpgydrm = new System.Windows.Forms.GroupBox();
            this.rdbekle = new System.Windows.Forms.RadioButton();
            this.rdbguncelle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtGayrimenkul)).BeginInit();
            this.grpgydrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbgydr
            // 
            this.cmbgydr.FormattingEnabled = true;
            this.cmbgydr.Items.AddRange(new object[] {
            "BOŞ",
            "DOLU"});
            this.cmbgydr.Location = new System.Drawing.Point(120, 14);
            this.cmbgydr.Name = "cmbgydr";
            this.cmbgydr.Size = new System.Drawing.Size(121, 21);
            this.cmbgydr.TabIndex = 33;
            this.cmbgydr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbgydr_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Gayrimenkul Durumu:";
            // 
            // txtgayrimenkulad
            // 
            this.txtgayrimenkulad.Location = new System.Drawing.Point(41, 12);
            this.txtgayrimenkulad.Name = "txtgayrimenkulad";
            this.txtgayrimenkulad.Size = new System.Drawing.Size(110, 20);
            this.txtgayrimenkulad.TabIndex = 31;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(41, 85);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(139, 51);
            this.btnguncelle.TabIndex = 30;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // cmbgayrimenkultip
            // 
            this.cmbgayrimenkultip.FormattingEnabled = true;
            this.cmbgayrimenkultip.Location = new System.Drawing.Point(413, 11);
            this.cmbgayrimenkultip.Name = "cmbgayrimenkultip";
            this.cmbgayrimenkultip.Size = new System.Drawing.Size(121, 21);
            this.cmbgayrimenkultip.TabIndex = 28;
            this.cmbgayrimenkultip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbgayrimenkultip_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "GayrimenkulTipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "İlçe:";
            // 
            // cmbilce
            // 
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(192, 12);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(121, 21);
            this.cmbilce.TabIndex = 29;
            this.cmbilce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbilce_KeyPress);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(23, 13);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Ad:";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(41, 85);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(139, 51);
            this.btnekle.TabIndex = 24;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dtGayrimenkul
            // 
            this.dtGayrimenkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGayrimenkul.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGayrimenkul.Location = new System.Drawing.Point(0, 159);
            this.dtGayrimenkul.Name = "dtGayrimenkul";
            this.dtGayrimenkul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGayrimenkul.Size = new System.Drawing.Size(1268, 568);
            this.dtGayrimenkul.TabIndex = 34;
            this.dtGayrimenkul.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGayrimenkul_RowHeaderMouseClick);
            // 
            // grpgydrm
            // 
            this.grpgydrm.Controls.Add(this.label16);
            this.grpgydrm.Controls.Add(this.cmbgydr);
            this.grpgydrm.Location = new System.Drawing.Point(553, 1);
            this.grpgydrm.Name = "grpgydrm";
            this.grpgydrm.Size = new System.Drawing.Size(344, 48);
            this.grpgydrm.TabIndex = 35;
            this.grpgydrm.TabStop = false;
            this.grpgydrm.Visible = false;
            // 
            // rdbekle
            // 
            this.rdbekle.AutoSize = true;
            this.rdbekle.Checked = true;
            this.rdbekle.Location = new System.Drawing.Point(41, 50);
            this.rdbekle.Name = "rdbekle";
            this.rdbekle.Size = new System.Drawing.Size(52, 17);
            this.rdbekle.TabIndex = 36;
            this.rdbekle.TabStop = true;
            this.rdbekle.Text = "EKLE";
            this.rdbekle.UseVisualStyleBackColor = true;
            this.rdbekle.Click += new System.EventHandler(this.rdbekle_Click);
            // 
            // rdbguncelle
            // 
            this.rdbguncelle.AutoSize = true;
            this.rdbguncelle.Location = new System.Drawing.Point(114, 50);
            this.rdbguncelle.Name = "rdbguncelle";
            this.rdbguncelle.Size = new System.Drawing.Size(82, 17);
            this.rdbguncelle.TabIndex = 37;
            this.rdbguncelle.Text = "GÜNCELLE";
            this.rdbguncelle.UseVisualStyleBackColor = true;
            this.rdbguncelle.Click += new System.EventHandler(this.rdbguncelle_Click);
            // 
            // Gayrimenkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 724);
            this.Controls.Add(this.rdbguncelle);
            this.Controls.Add(this.rdbekle);
            this.Controls.Add(this.grpgydrm);
            this.Controls.Add(this.dtGayrimenkul);
            this.Controls.Add(this.txtgayrimenkulad);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.cmbgayrimenkultip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbilce);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnekle);
            this.Name = "Gayrimenkul";
            this.Text = "Gayrimenkul";
            this.Load += new System.EventHandler(this.Gayrimenkul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGayrimenkul)).EndInit();
            this.grpgydrm.ResumeLayout(false);
            this.grpgydrm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbgydr;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtgayrimenkulad;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ComboBox cmbgayrimenkultip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbilce;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dtGayrimenkul;
        private System.Windows.Forms.GroupBox grpgydrm;
        private System.Windows.Forms.RadioButton rdbekle;
        private System.Windows.Forms.RadioButton rdbguncelle;
    }
}