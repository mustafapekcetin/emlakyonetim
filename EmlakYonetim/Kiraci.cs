using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakYonetim
{
    public partial class Kiraci : Form
    {
        DAL dl = new DAL();
        OleDbConnection dataConnection;
        int MusteriId;

        public Kiraci()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAD.Text))
                {
                    MessageBox.Show("KİRACI ADINI BOŞ BIRAKMAYIN");
                    return;
                }

                if (txtTelefon.Text.Trim().Length > 11)
                {
                    MessageBox.Show("TELEFON NUMARASI 11 HANEDEN BÜYÜK OLAMAZ!");
                    return;
                }

                if (string.IsNullOrEmpty(txtSoyad.Text))
                {
                    MessageBox.Show("KİRACI SOYADINI BIRAKMAYIN");
                    return;
                }


                if (string.IsNullOrEmpty(txtTelefon.Text))
                {
                    MessageBox.Show("TELEFONU BOŞ BIRAKMAYIN");
                    return;
                }


                DAL.Parameters[] prm = new DAL.Parameters[4];
                prm[0].name = "AD";
                prm[0].value = txtAD.Text;
                prm[1].name = "SOYAD";
                prm[1].value = txtSoyad.Text;
                prm[2].name = "AKTIF";
                prm[2].value = 1;
                prm[3].name = "TELEFONNUMARASI";
                prm[3].value = txtTelefon.Text;
                int numberOfRecords = dl.InsertSQL("MUSTERI", prm);

                if (numberOfRecords > 0)
                {
                    ClearCustomer();
                    MessageBox.Show("KAYIT BAŞARILI");
                    musterigrid();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private DataTable musterigrid()
        {
            DataTable ComboboxMusteriGrid = new DataTable();
            OleDbDataAdapter ComboboxMusteriGridadapter = new OleDbDataAdapter();
            ComboboxMusteriGrid.Clear();
            try
            {
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.CommandText = " SELECT MUSTERI.ID, MUSTERI.AD,MUSTERI.SOYAD, MUSTERI.TELEFONNUMARASI from MUSTERI WHERE MUSTERI.AKTIF=1";
                    ComboboxMusteriGridadapter.SelectCommand = dataCommand;
                    ComboboxMusteriGridadapter.Fill(ComboboxMusteriGrid);

                    dtMusteri.DataSource = ComboboxMusteriGrid;
                    dtMusteri.Columns[1].Width = 250;
                    dtMusteri.Columns[2].Width = 250;
                    dtMusteri.Columns[3].Width = 250;

                    dtMusteri.Columns[0].Visible = false;
                    dtMusteri.Columns[1].HeaderText = "KİRACI ADI";
                    dtMusteri.Columns[2].HeaderText = "KİRACI SOYADI";
                    dtMusteri.Columns[3].HeaderText = "KİRACI TELEFON NUMARASI ";
                    dataConnection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ComboboxMusteriGrid;
        }

        
        private void ClearCustomer()
        {
            txtAD.Text = null;
            txtSoyad.Text = null;
            txtTelefon.Text = null;
        }

        private void dtMusteri_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            DataTable TxtMusteri = new DataTable();
            OleDbDataAdapter TxtMusteriadapter = new OleDbDataAdapter();
            if (dtMusteri.SelectedRows[0].DataBoundItem != null)
            {
                rdbguncelle.Checked = true;
                btnekle.Visible = false;
                btngüncelle.Visible = true;
                grbkrc.Visible = true;
                MusteriId = Convert.ToInt32(dtMusteri.SelectedRows[0].Cells[0].Value.ToString());
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {

                    dataCommand.CommandText = " SELECT  MUSTERI.AD,MUSTERI.SOYAD, MUSTERI.TELEFONNUMARASI from MUSTERI WHERE MUSTERI.ID = " + MusteriId;
                    TxtMusteriadapter.SelectCommand = dataCommand;
                    TxtMusteriadapter.Fill(TxtMusteri);

                    foreach (DataRow row in TxtMusteri.Rows)
                    {
                        txtAD.Text = row.ItemArray[0].ToString();
                        txtSoyad.Text = row.ItemArray[1].ToString();
                        txtTelefon.Text = row.ItemArray[2].ToString();
                        dataConnection.Close();
                    }
                }

            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int parameter = 3;
            if (string.IsNullOrEmpty(txtAD.Text))
            {
                MessageBox.Show("KİRACI ADINI BOŞ BIRAKMAYIN");
                return;
            }

            if (txtTelefon.Text.Trim().Length > 11)
            {
                MessageBox.Show("TELEFON NUMARASI 11 HANEDEN BÜYÜK OLAMAZ!");
                return;
            }

            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("KİRACI SOYADINI BIRAKMAYIN");
                return;
            }


            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("TELEFONU BOŞ BIRAKMAYIN");
                return;
            }

            if (dtMusteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("GÜNCELLEYECEĞİNİZ MÜŞTERİYİ SEÇİN");
                return;
            }

            if (cmbkrc.SelectedIndex == -1)
            {
                MessageBox.Show("KİRACI DURUMUNU SEÇİNİZ");
                return;
            }

            if (cmbkrc.Text.Trim() == "BOŞ")
            {
                parameter++;
                using (OleDbCommand dataCommand2 = dataConnection.CreateCommand())
                {
                    dataConnection.Open();

                    dataCommand2.CommandText = "select MUSTERIGAYRIMENKUL.KIRABITISTARIHI from MUSTERIGAYRIMENKUL  Where MUSTERIGAYRIMENKUL.MUSTERIID=" + MusteriId + " and MUSTERIGAYRIMENKUL.KIRABITISTARIHI IS NULL";
                    dataCommand2.ExecuteNonQuery();

                    OleDbDataReader accessReader = dataCommand2.ExecuteReader();
                    while (accessReader.Read())
                    {
                        string KıraBıtısTarıhı = Convert.ToString(accessReader.GetValue(0));
                        if (string.IsNullOrEmpty(KıraBıtısTarıhı))
                        {
                            MessageBox.Show("ILGILI MUSTERININ KONTRATI DEVAM ETTİĞİNDEN SİLEMEZSİNİZ");
                            return;
                        }
                    }
                }
            }



            DAL.Parameters[] prm = new DAL.Parameters[parameter];
            prm[0].name = "AD";
            prm[0].value = txtAD.Text;
            prm[1].name = "SOYAD";
            prm[1].value = txtSoyad.Text;
            prm[2].name = "TELEFONNUMARASI";
            prm[2].value = txtTelefon.Text;
            if (parameter == 4)
            {
                prm[3].name = "AKTIF";
                prm[3].value = 0;
            }

            int numberOfRecords = dl.UpdateSQL("MUSTERI", prm, "ID", MusteriId);

            if (numberOfRecords > 0)
            {
                MessageBox.Show("GUNCELLEME BAŞARILI");
                ClearCustomer();
                musterigrid();
            }
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }

        private void Kiraci_Load(object sender, EventArgs e)
        {
            dataConnection = new
OleDbConnection(Connection.GetConnection());
            if (rdbekle.Checked==true)
            {
                btnekle.Visible = true;
                btngüncelle.Visible = false;
            }
            cmbkrc.SelectedIndex = 1;
            musterigrid();
        }

        private void rdbekle_Click(object sender, EventArgs e)
        {
            grbkrc.Visible = false;
            btnekle.Visible = true;
            btngüncelle.Visible = false;
        }

        private void rdbguncelle_Click(object sender, EventArgs e)
        {
            ClearCustomer();
            grbkrc.Visible = true;
            btnekle.Visible = false;
            btngüncelle.Visible = true;
        }
    }
}
