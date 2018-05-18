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
    public partial class MusteriOdeme : Form
    {
        DAL dl = new DAL();
        OleDbConnection dataConnection;
        FillCombobox flcmb = new FillCombobox();
        int MusteriId;

        public MusteriOdeme()
        {
            dataConnection = new
    OleDbConnection(Connection.GetConnection());
            InitializeComponent();
        }

        private void Btngüncelle_Click(object sender, EventArgs e)
        {
            using (OleDbCommand dataCommand1 = dataConnection.CreateCommand())
            {

                if (dtmusteriodeme.SelectedRows.Count == 0)
                {
                    MessageBox.Show("GÜNCELLEYECEĞİNİZ KAYITI SEÇİN");
                    return;
                }

                DAL.Parameters[] prm = new DAL.Parameters[2];
                prm[0].name = "ODEMETARIHI";
                prm[0].value = dtOdemetarihi.Value.ToShortDateString();
                prm[1].name = "ODEMETUTARI";
                prm[1].value = txtOdemetutarı.Text;

                if (cmbmstodm.SelectedIndex == -1)
                {
                    MessageBox.Show("MÜŞTERİ ÖDEME DURUMUNU SEÇİN");
                    return;
                }

                if (cmbmstodm.Text.Trim() == "BOŞ")
                {
                    int affectedRecords = dl.DeleteSQL("MUSTERIODEME", "MUSTERIID", MusteriId);
                    if (affectedRecords > 0)
                    {
                        ClearCustomerHomePrice();
                        MessageBox.Show("SİLME BAŞARILI");
                        Musterigayrimenkulodemegrid();
                    }

                }

                int numberOfRecords = dl.UpdateSQL("MUSTERIODEME", prm, "MUSTERIID", MusteriId);
                if (numberOfRecords > 0)
                {
                    ClearCustomerHomePrice();
                    MessageBox.Show("KAYIT BAŞARILI");
                    Musterigayrimenkulodemegrid();
                }
            }
        }

        private DataTable Musterigayrimenkulodemegrid()
        {
            DataTable MusteriGayrimenkulOdeme = new DataTable();
            MusteriGayrimenkulOdeme.Clear();
            DataTable GayrimenkulFiyat = new DataTable();
            OleDbDataAdapter GayrimenkulFiyatadapter = new OleDbDataAdapter();
            OleDbDataAdapter MusteriGayrimenkulOdemeadapter = new OleDbDataAdapter();

            try
            {
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {

                    dataCommand.CommandText = " SELECT GAYRIMENKUL.ID,MUSTERIODEME.MUSTERIID,MUSTERI.AD & ' ' & MUSTERI.SOYAD, MUSTERI.TELEFONNUMARASI ," +
" GAYRIMENKUL.AD, MUSTERIODEME.ODEMETUTARI, MUSTERIODEME.ODEMETARIHI,GAYRIMENKULFIYAT.KIRAFIYATI " +
" FROM(((MUSTERIODEME INNER JOIN MUSTERIGAYRIMENKUL ON MUSTERIODEME.MUSTERIID = MUSTERIGAYRIMENKUL.MUSTERIID) " +
"INNER JOIN MUSTERI ON MUSTERIGAYRIMENKUL.MUSTERIID = MUSTERI.ID) " +
                    " INNER JOIN GAYRIMENKULFIYAT ON MUSTERIODEME.GAYRIMENKULFIYATID = GAYRIMENKULFIYAT.ID) " +
                    " INNER JOIN GAYRIMENKUL ON MUSTERIGAYRIMENKUL.GAYRIMENKULID = GAYRIMENKUL.ID WHERE(((MUSTERI.AKTIF) = 1) AND((GAYRIMENKUL.AKTIF) = 1)) order by MUSTERIODEME.ODEMETARIHI asc ; ";

                    MusteriGayrimenkulOdemeadapter.SelectCommand = dataCommand;
                    MusteriGayrimenkulOdemeadapter.Fill(MusteriGayrimenkulOdeme);


                    dtmusteriodeme.DataSource = MusteriGayrimenkulOdeme;
                    dtmusteriodeme.Columns[2].Width = 150;
                    dtmusteriodeme.Columns[3].Width = 200;
                    dtmusteriodeme.Columns[4].Width = 150;
                    dtmusteriodeme.Columns[5].Width = 150;
                    dtmusteriodeme.Columns[6].Width = 150;
                    dtmusteriodeme.Columns[7].Width = 150;
                    dtmusteriodeme.Columns[0].Visible = false;
                    dtmusteriodeme.Columns[1].Visible = false;

                    dtmusteriodeme.Columns[2].HeaderText = "KİRACI ADI";
                    dtmusteriodeme.Columns[3].HeaderText = "KİRACI TELEFON";
                    dtmusteriodeme.Columns[4].HeaderText = "GAYRİMENKUL ADI";
                    dtmusteriodeme.Columns[5].HeaderText = "ODEME TUTARI";
                    dtmusteriodeme.Columns[6].HeaderText = "ODEME  TARİHİ";
                    dtmusteriodeme.Columns[7].HeaderText = "KİRA  DEĞERİ";
                    dataConnection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return MusteriGayrimenkulOdeme;
        }

        private void ClearCustomerHomePrice()
        {
            txtGayrimenkulAdı.Text = null;
            cmbmusteriadodeme.SelectedIndex = -1;
            txtOdemetutarı.Text = null;
        }

        private void Dtmusteriodeme_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            if (dtmusteriodeme.SelectedRows[0].DataBoundItem!=null)
            {
                rdbguncelle.Checked = true;
                btnekle.Visible = false;
                btngüncelle.Visible = true;

                int GayrimenkulId = Convert.ToInt32(dtmusteriodeme.SelectedRows[0].Cells[0].Value.ToString());
                MusteriId = Convert.ToInt32(dtmusteriodeme.SelectedRows[0].Cells[1].Value.ToString());

                using (OleDbCommand dataCommand2 = dataConnection.CreateCommand())
                {
                    dataConnection.Open();

                    dataCommand2.CommandText = " SELECT GAYRIMENKUL.ID,MUSTERI.AD, GAYRIMENKUL.AD, MUSTERIODEME.ODEMETUTARI, MUSTERIODEME.ODEMETARIHI " +
" FROM GAYRIMENKUL INNER JOIN ((MUSTERIODEME INNER JOIN MUSTERI ON MUSTERIODEME.[MUSTERIID] = MUSTERI.ID) " +
" INNER JOIN MUSTERIGAYRIMENKUL ON MUSTERIODEME.[MUSTERIID] = MUSTERIGAYRIMENKUL.MUSTERIID) ON GAYRIMENKUL.ID = MUSTERIGAYRIMENKUL.GAYRIMENKULID " +
" WHERE(((MUSTERI.AKTIF) = 1) AND((GAYRIMENKUL.AKTIF) = 1))" + " and GAYRIMENKUL.ID=" + GayrimenkulId;
                    dataCommand2.ExecuteNonQuery();

                    OleDbDataReader accessReader = dataCommand2.ExecuteReader();
                    while (accessReader.Read())
                    {
                        cmbmusteriadodeme.Text = Convert.ToString(accessReader.GetValue(1));
                        txtGayrimenkulAdı.Text = Convert.ToString(accessReader.GetValue(2));
                        txtOdemetutarı.Text = Convert.ToString(accessReader.GetValue(3));
                        dtOdemetarihi.Text = Convert.ToString(accessReader.GetValue(4));
                    }
                    dataConnection.Close();
                }

            }


        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                int GayrimnekulFiyatId = 0;
                if (cmbmusteriadodeme.SelectedIndex == -1)
                {
                    MessageBox.Show("KİRACI ADINI GİRİN");
                    return;
                }

                if (string.IsNullOrEmpty(txtOdemetutarı.Text.Trim()))
                {
                    MessageBox.Show("ÖDEME TUTARINI GİRİN");
                    return;
                }

                if (string.IsNullOrEmpty(txtGayrimenkulAdı.Text))
                {
                    MessageBox.Show("KİRACININ GAYRİMENKUL KONTRATI BİTTİĞİNDEN KAYIT EKLEYEMEZSİNİZ");
                    return;
                }

                using (OleDbCommand dataCommand2 = dataConnection.CreateCommand())
                {
                    if (dataConnection.State == ConnectionState.Closed)
                    {
                        dataConnection.Open();
                    }

                    dataCommand2.CommandText = "SELECT TOP 1 GAYRIMENKULFIYAT.ID,GAYRIMENKULFIYAT.TARIH  FROM GAYRIMENKUL" +
" INNER JOIN GAYRIMENKULFIYAT ON GAYRIMENKUL.ID = GAYRIMENKULFIYAT.GAYRIMENKULID where GAYRIMENKUL.AD='" + txtGayrimenkulAdı.Text + "' order by GAYRIMENKULFIYAT.TARIH desc";

                    dataCommand2.ExecuteNonQuery();

                    OleDbDataReader accessReader = dataCommand2.ExecuteReader();
                    while (accessReader.Read())
                    {
                        GayrimnekulFiyatId = Convert.ToInt32(accessReader.GetValue(0));
                    }

                    if (GayrimnekulFiyatId == 0)
                    {
                        MessageBox.Show("İLGİLİ GAYRİMENKULUN ÖNCE FİYATINI GİRİN");
                        return;
                    }
                }

                DAL.Parameters[] prm = new DAL.Parameters[4];
                prm[0].name = "MUSTERIID";
                prm[0].value = cmbmusteriadodeme.SelectedValue.ToString();
                prm[1].name = "ODEMETARIHI";
                prm[1].value = dtOdemetarihi.Value.ToShortDateString();
                prm[2].name = "ODEMETUTARI";
                prm[2].value = txtOdemetutarı.Text;
                prm[3].name = "GAYRIMENKULFIYATID";
                prm[3].value = GayrimnekulFiyatId;
                int numberOfRecords = dl.InsertSQL("MUSTERIODEME", prm);

                if (numberOfRecords > 0)
                {
                    ClearCustomerHomePrice();
                    MessageBox.Show("KAYIT BAŞARILI");
                    Musterigayrimenkulodemegrid();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Cmbmusteriadodeme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (cmbmusteriadodeme.SelectedIndex == -1 && cmbmusteriadodeme.Items.Count > 0)
            {
                cmbmusteriadodeme.SelectedIndex = 0;
            }
        }

        private void MusteriOdeme_Load(object sender, EventArgs e)
        {
            if (rdbekle.Checked==true)
            {
                btnekle.Visible = true;
                btngüncelle.Visible = false;
            }

            cmbmstodm.SelectedIndex = 1;
            cmbmusteriadodeme.ValueMember = "ID";
            cmbmusteriadodeme.DisplayMember = "AD";
            cmbmusteriadodeme.DataSource = flcmb.Populatecombobox("MUSTERI", "AKTIF", 1);

            if (cmbmusteriadodeme.Items.Count>0)
            {
                cmbmusteriadodeme.SelectedIndex = 0;
            }
            Musterigayrimenkulodemegrid();
        }

        private void rdbguncelle_Click(object sender, EventArgs e)
        {
            grbmstodm.Visible = true;
            btngüncelle.Visible = true;
            btnekle.Visible = false;
        }

        private void cmbmstodm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (cmbmstodm.SelectedIndex == -1)
            {
                cmbmstodm.SelectedIndex = 0;
            }
        }

        private void rdbekle_Click(object sender, EventArgs e)
        {
            grbmstodm.Visible = false;
            btngüncelle.Visible = false;
            btnekle.Visible = true;
        }
    }
}
