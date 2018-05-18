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
    public partial class GayrimenkulFiyat : Form
    {
        DAL dl = new DAL();
        OleDbConnection dataConnection;
        FillCombobox flcmb = new FillCombobox();

        int GayrimenkulFIYATId;
        string Gayrimenkulfiyat;

        public GayrimenkulFiyat()
        {
            dataConnection = new
      OleDbConnection(Connection.GetConnection());
            InitializeComponent();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            int parameter = 2;

            if (dtGayrimenkulFiyat.SelectedRows.Count == 0)
            {
                MessageBox.Show("GÜNCELLEYECEĞİNİZ GAYRİMENKULU SEÇİN");
                return;
            }

            if (string.IsNullOrEmpty(txtGayrimenkulFiyat.Text))
            {
                MessageBox.Show("GAYRİMENKUL FİYATINI BOŞ BIRAKMAYIN");
                return;
            }

            if (cmbgyfytdrm.SelectedIndex == -1)
            {
                MessageBox.Show("GAYRİMENKUL FİYATIN DURUMUNU BOŞ BIRAKMAYIN");
                return;
            }

            if (cmbGayrimenkul.SelectedIndex == -1)
            {
                MessageBox.Show("GAYRİMENKUL ADINI BOŞ BIRAKMAYIN");
                return;
            }

            if (cmbgyfytdrm.Text.Trim() == "BOŞ")
            {
                parameter++;
                using (OleDbCommand dataCommand2 = dataConnection.CreateCommand())
                {
                    dataConnection.Open();

                    dataCommand2.CommandText = "SELECT MUSTERIGAYRIMENKUL.KIRABITISTARIHI FROM GAYRIMENKULFIYAT INNER JOIN MUSTERIGAYRIMENKUL ON GAYRIMENKULFIYAT.GAYRIMENKULID = MUSTERIGAYRIMENKUL.GAYRIMENKULID where GAYRIMENKULFIYAT.ID=" + GayrimenkulFIYATId + " and MUSTERIGAYRIMENKUL.KIRABITISTARIHI is null";
                    dataCommand2.ExecuteNonQuery();

                    OleDbDataReader accessReader = dataCommand2.ExecuteReader();
                    while (accessReader.Read())
                    {
                        string KıraBıtısTarıhı = Convert.ToString(accessReader.GetValue(0));
                        if (string.IsNullOrEmpty(KıraBıtısTarıhı))
                        {
                            MessageBox.Show("ILGILI GAYRİMENKULU KONTRATI DEVAM ETTİĞİNDEN SİLEMEZSİNİZ");
                            dataConnection.Close();
                            return;
                        }
                    }
                }
            }



            DAL.Parameters[] prm = new DAL.Parameters[parameter];
            prm[0].name = "KIRAFIYATI";
            prm[0].value = txtGayrimenkulFiyat.Text;
            prm[1].name = "TARIH";
            prm[1].value = dtgyfiyat.Value.ToShortDateString();
            if (parameter == 3)
            {
                prm[2].name = "DURUM";
                prm[2].value = 0;
            }
            int numberOfRecords = dl.UpdateSQL("GAYRIMENKULFIYAT", prm, "GAYRIMENKULFIYAT.ID", GayrimenkulFIYATId);

            if (numberOfRecords > 0)
            {
                MessageBox.Show("GUNCELLEME BAŞARILI");
                ClearHomePrice();
                gayrimenkulfiyatgrid();
            }

        }

        private DataTable gayrimenkulfiyatgrid()
        {
            DataTable ComboboxGayrimenkulFiyatGrid = new DataTable();
            OleDbDataAdapter ComboboxGayrimenkulFiyatadapter = new OleDbDataAdapter();
            ComboboxGayrimenkulFiyatGrid.Clear();
            try
            {
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.CommandText = " SELECT GAYRIMENKULFIYAT.ID, GAYRIMENKUL.AD,GAYRIMENKULFIYAT.KIRAFIYATI, GAYRIMENKULFIYAT.TARIH from GAYRIMENKULFIYAT " +
                        " INNER JOIN GAYRIMENKUL ON GAYRIMENKULFIYAT.GAYRIMENKULID=GAYRIMENKUL.ID WHERE GAYRIMENKULFIYAT.DURUM=1 AND GAYRIMENKUL.AKTIF=1";

                    ComboboxGayrimenkulFiyatadapter.SelectCommand = dataCommand;
                    ComboboxGayrimenkulFiyatadapter.Fill(ComboboxGayrimenkulFiyatGrid);

                    dtGayrimenkulFiyat.DataSource = ComboboxGayrimenkulFiyatGrid;
                    dtGayrimenkulFiyat.Columns[1].Width = 250;
                    dtGayrimenkulFiyat.Columns[2].Width = 250;
                    dtGayrimenkulFiyat.Columns[3].Width = 250;

                    dtGayrimenkulFiyat.Columns[0].Visible = false;
                    dtGayrimenkulFiyat.Columns[1].HeaderText = "GAYRIMENKUL ADI";
                    dtGayrimenkulFiyat.Columns[2].HeaderText = "GAYRIMENKUL KIRAFIYATI";
                    dtGayrimenkulFiyat.Columns[3].HeaderText = "GAYRIMENKUL TARIH ";
                    dataConnection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ComboboxGayrimenkulFiyatGrid;
        }

        private void ClearHomePrice()
        {
            txtGayrimenkulFiyat.Text = null;
            cmbGayrimenkul.SelectedIndex = -1;
        }

        private void dtGayrimenkulFiyat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtGayrimenkulFiyat.SelectedRows[0].DataBoundItem != null)
            {
                grbgyfyt.Visible = true;
                    rdbguncelle.Checked = true;
                    btnekle.Visible = false;
                    btnguncelle.Visible = true;

                    GayrimenkulFIYATId = Convert.ToInt32(dtGayrimenkulFiyat.SelectedRows[0].Cells[0].Value.ToString());
                    using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                    {
                        dataConnection.Open();
                        dataCommand.CommandText = " SELECT GAYRIMENKUL.AD, GAYRIMENKULFIYAT.KIRAFIYATI,GAYRIMENKULFIYAT.TARIH from GAYRIMENKULFIYAT INNER JOIN GAYRIMENKUL ON GAYRIMENKULFIYAT.GAYRIMENKULID=GAYRIMENKUL.ID " +
                            " WHERE GAYRIMENKULFIYAT.ID = " + GayrimenkulFIYATId;
                        dataCommand.ExecuteNonQuery();
                        OleDbDataReader accessReader = dataCommand.ExecuteReader();

                        while (accessReader.Read())
                        {
                            cmbGayrimenkul.Text = Convert.ToString(accessReader.GetValue(0));
                            txtGayrimenkulFiyat.Text = Convert.ToString(accessReader.GetValue(1));
                            dtgyfiyat.Text = Convert.ToString(accessReader.GetValue(2));

                        }
                        dataConnection.Close();
                    }
                }                           
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ComboboxGayrimenkulFiyatCheckGrid = new DataTable();
                DataTable MusteriGayrimenkul = new DataTable();
                DataTable MusteriGayrimenkulSonuc = new DataTable();
                OleDbDataAdapter ComboboxGayrimenkulFiyatCheckadapter = new OleDbDataAdapter();
                OleDbDataAdapter MusteriGayrimenkuladapter = new OleDbDataAdapter();
                OleDbDataAdapter MusteriGayrimenkulSonucadapter = new OleDbDataAdapter();
                string MusteriGayrimenkulsql = string.Empty;


                if (string.IsNullOrEmpty(txtGayrimenkulFiyat.Text))
                {
                    MessageBox.Show("GAYRİMENKUL FİYATINI BOŞ BIRAKMAYIN");
                    return;
                }

                if (cmbGayrimenkul.SelectedIndex == -1)
                {
                    MessageBox.Show("GAYRİMENKUL ADINI BOŞ BIRAKMAYIN");
                    return;
                }

                using (OleDbCommand dataCommand1 = dataConnection.CreateCommand())
                {
                    dataConnection.Open();

                    MusteriGayrimenkulsql = "select * from MUSTERIGAYRIMENKUL where MUSTERIGAYRIMENKUL.GAYRIMENKULID =" + cmbGayrimenkul.SelectedValue.ToString();

                    dataCommand1.CommandText = MusteriGayrimenkulsql;
                    MusteriGayrimenkuladapter.SelectCommand = dataCommand1;
                    MusteriGayrimenkuladapter.Fill(MusteriGayrimenkul);

                    if (MusteriGayrimenkul.Rows.Count == 0)
                    {
                        MessageBox.Show("İLGİLİ GAYRİMENKULUN KİRACISI OLMADIĞINDAN GAYRİMENKUL FİYATI EKLEYEMEZSİNİZ");
                        dataConnection.Close();
                        return;
                    }

                }

                using (OleDbCommand dataCommand2 = dataConnection.CreateCommand())
                {
                    string YeniMusteriGayrimenkulsql = MusteriGayrimenkulsql + "  and MUSTERIGAYRIMENKUL.KIRABITISTARIHI is not null ";
                    dataCommand2.CommandText = YeniMusteriGayrimenkulsql;
                    MusteriGayrimenkulSonucadapter.SelectCommand = dataCommand2;
                    MusteriGayrimenkulSonucadapter.Fill(MusteriGayrimenkulSonuc);

                    if (MusteriGayrimenkulSonuc.Rows.Count == 1)
                    {
                        MessageBox.Show("İLGİLİ GAYRİMENKULUN KONTRATI BİTTİĞİNDEN FİYATI EKLEYEMEZSİNİZ");
                        dataConnection.Close();
                        return;
                    }

                }


                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.CommandText = " SELECT TOP 1  GAYRIMENKUL.ID,GAYRIMENKULFIYAT.KIRAFIYATI, GAYRIMENKULFIYAT.TARIH from GAYRIMENKULFIYAT " +
                        " INNER JOIN GAYRIMENKUL ON GAYRIMENKULFIYAT.GAYRIMENKULID=GAYRIMENKUL.ID WHERE GAYRIMENKULFIYAT.DURUM=1 AND GAYRIMENKUL.AKTIF=1 and  GAYRIMENKUL.ID=" + cmbGayrimenkul.SelectedValue.ToString() + " order by GAYRIMENKULFIYAT.KIRAFIYATI desc ";

                    ComboboxGayrimenkulFiyatCheckadapter.SelectCommand = dataCommand;
                    ComboboxGayrimenkulFiyatCheckadapter.Fill(ComboboxGayrimenkulFiyatCheckGrid);

                    if (ComboboxGayrimenkulFiyatCheckGrid.Rows.Count > 0)
                    {
                        foreach (DataRow row in ComboboxGayrimenkulFiyatCheckGrid.Rows)
                        {
                            Gayrimenkulfiyat = row.ItemArray[1].ToString();
                            if (Convert.ToDateTime(row.ItemArray[2].ToString()) >= Convert.ToDateTime(dtgyfiyat.Value.ToShortDateString()))
                            {
                                MessageBox.Show("KIRA ZAM TARIHI ONCEKINDEN KUCUK VEYA EŞİT OLAMAZ");
                                dataConnection.Close();
                                return;
                            }

                        }
                    }

                    if (Convert.ToInt32(txtGayrimenkulFiyat.Text.Trim()) <= Convert.ToInt32(Gayrimenkulfiyat))
                    {
                        DialogResult d = MessageBox.Show("KIRA ZAM FIYATI ÖNCEKİ KIRA FİYATINDAN KÜÇÜK OLACAK", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (d == DialogResult.No)
                        {
                            dataConnection.Close();
                            return;
                        }
                    }
                }

                DAL.Parameters[] prm = new DAL.Parameters[4];
                prm[0].name = "GAYRIMENKULID";
                prm[0].value = cmbGayrimenkul.SelectedValue.ToString();
                prm[1].name = "KIRAFIYATI";
                prm[1].value = txtGayrimenkulFiyat.Text;
                prm[2].name = "TARIH";
                prm[2].value = dtgyfiyat.Value.ToShortDateString();
                prm[3].name = "DURUM";
                prm[3].value = 1;
                int numberOfRecords = dl.InsertSQL("GAYRIMENKULFIYAT", prm);

                if (numberOfRecords > 0)
                {
                    ClearHomePrice();
                    MessageBox.Show("KAYIT BAŞARILI");
                    gayrimenkulfiyatgrid();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GayrimenkulFiyat_Load(object sender, EventArgs e)
        {
            if (rdbekle.Visible == true)
            {
                btnekle.Visible = true;
                btnguncelle.Visible = false;
            }

            cmbgyfytdrm.SelectedIndex = 1;
            cmbGayrimenkul.ValueMember = "ID";
            cmbGayrimenkul.DisplayMember = "AD";
            cmbGayrimenkul.DataSource = flcmb.Populatecombobox("GAYRIMENKUL", "AKTIF", 1);
            gayrimenkulfiyatgrid();
        }

        private void txtGayrimenkulFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }

        private void rdbekle_Click(object sender, EventArgs e)
        {
            ClearHomePrice();
            grbgyfyt.Visible = false;
            btnekle.Visible = true;
            btnguncelle.Visible = false;
        }

        private void rdbguncelle_Click(object sender, EventArgs e)
        {
            ClearHomePrice();
            grbgyfyt.Visible = true;
            btnekle.Visible = false;
            btnguncelle.Visible = true;
        }
    }
}


