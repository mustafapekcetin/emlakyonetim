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
    public partial class Gayrimenkul : Form
    {
        OleDbConnection dataConnection;
        FillCombobox flcmb = new FillCombobox();
        DAL dl = new DAL();
        string GayrimenkulAd;
        int GayrimenkulId;

        public Gayrimenkul()
        {            
            InitializeComponent();
        }

        private DataTable gayrimenkulgrid()
        {

            DataTable ComboboxGayrimenkulGrid = new DataTable();
            OleDbDataAdapter ComboboxGayrimenkulGridadapter = new OleDbDataAdapter();
            ComboboxGayrimenkulGrid.Clear();
            try
            {
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {

                    dataCommand.CommandText = " SELECT GAYRIMENKUL.ID, GAYRIMENKUL.AD,ILCE.AD, GAYRIMENKULTIP.AD " +
    " FROM (GAYRIMENKUL INNER JOIN GAYRIMENKULTIP ON GAYRIMENKUL.GAYRIMENKULTIPID = GAYRIMENKULTIP.ID) INNER JOIN ILCE ON GAYRIMENKUL.ILCEID = ILCE.ID " +
    " where GAYRIMENKUL.AKTIF = 1;";

                    ComboboxGayrimenkulGridadapter.SelectCommand = dataCommand;
                    ComboboxGayrimenkulGridadapter.Fill(ComboboxGayrimenkulGrid);

                    dtGayrimenkul.DataSource = ComboboxGayrimenkulGrid;
                    dtGayrimenkul.Columns[1].Width = 250;
                    dtGayrimenkul.Columns[2].Width = 250;
                    dtGayrimenkul.Columns[3].Width = 250;
                    dtGayrimenkul.Columns[0].Visible = false;
                    dtGayrimenkul.Columns[1].HeaderText = "GAYRİMENKUL ADI";
                    dtGayrimenkul.Columns[2].HeaderText = "İLÇE ADI";
                    dtGayrimenkul.Columns[3].HeaderText = "GAYRİMENKUL TİPİ";
                    dataConnection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ComboboxGayrimenkulGrid;
        }

        private void GridDoldur()
        {             
            cmbilce.ValueMember = "ID";
            cmbilce.DisplayMember = "AD";
            cmbilce.DataSource = flcmb.Populatecombobox("ILCE", null, 0);

            cmbgayrimenkultip.DataSource = flcmb.Populatecombobox("GAYRIMENKULTIP", "DURUM", 1);
            cmbgayrimenkultip.ValueMember = "ID";
            cmbgayrimenkultip.DisplayMember = "AD";
            cmbgydr.SelectedIndex = 1;
            gayrimenkulgrid();

        }


        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int parameter = 3;

            if (cmbgydr.SelectedIndex == -1)
            {
                MessageBox.Show("GEÇERLİ BİR DURUM SEÇİN");
                return;
            }

            if (dtGayrimenkul.SelectedRows.Count == 0)
            {
                MessageBox.Show("GÜNCELLEYECEĞİNİZ GAYRİMENKULU SEÇİN");
                return;
            }

            if (string.IsNullOrEmpty(txtgayrimenkulad.Text))
            {
                MessageBox.Show("GAYRİMENKUL ADINI BOŞ BIRAKMAYIN");
                return;
            }

            if (cmbilce.SelectedIndex == -1)
            {
                MessageBox.Show("İLÇEYİ BOŞ BIRAKMAYIN");
                return;
            }

            if (cmbgayrimenkultip.SelectedIndex == -1)
            {
                MessageBox.Show("GAYRİMENKUL TİPİNİ BOŞ BIRAKMAYIN");
                return;
            }

            if (cmbgydr.Text.Trim() == "BOŞ")
            {
                parameter++;
                using (OleDbCommand dataCommand2 = dataConnection.CreateCommand())
                {
                    dataConnection.Open();

                    dataCommand2.CommandText = "select MUSTERIGAYRIMENKUL.KIRABITISTARIHI from MUSTERIGAYRIMENKUL  Where MUSTERIGAYRIMENKUL.GAYRIMENKULID=" + GayrimenkulId + " and MUSTERIGAYRIMENKUL.KIRABITISTARIHI IS NULL";
                    dataCommand2.ExecuteNonQuery();

                    OleDbDataReader accessReader = dataCommand2.ExecuteReader();
                    while (accessReader.Read())
                    {
                        string KıraBıtısTarıhı = Convert.ToString(accessReader.GetValue(0));
                        if (string.IsNullOrEmpty(KıraBıtısTarıhı))
                        {
                            MessageBox.Show("ILGILI GAYRİMENKULU KONTRATI DEVAM ETTİĞİNDEN SİLEMEZSİNİZ");
                            return;
                        }
                    }
                    dataConnection.Close();
                }
            }

            DAL.Parameters[] prm = new DAL.Parameters[parameter];
            prm[0].name = "AD";
            prm[0].value = txtgayrimenkulad.Text;
            prm[1].name = "ILCEID";
            prm[1].value = cmbilce.SelectedValue.ToString();
            prm[2].name = "GAYRIMENKULTIPID";
            prm[2].value = cmbgayrimenkultip.SelectedValue.ToString();

            if (parameter == 4)
            {
                prm[3].name = "AKTIF";
                prm[3].value = 0;
            }

            int numberOfRecords = dl.UpdateSQL("GAYRIMENKUL", prm, "ID", GayrimenkulId);
            if (numberOfRecords > 0)
            {
                MessageBox.Show("GUNCELLEME BAŞARILI");
                ClearHome();
                gayrimenkulgrid();
            }
        }

        private void ClearHome()
        {
            txtgayrimenkulad.Text = null;
            cmbilce.SelectedIndex = -1;
            cmbgayrimenkultip.SelectedIndex = -1;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtgayrimenkulad.Text))
                {
                    MessageBox.Show("GAYRİMENKUL ADINI BOŞ BIRAKMAYIN");
                    return;
                }

                if (cmbilce.SelectedIndex == -1)
                {
                    MessageBox.Show("İLÇEYİ BOŞ BIRAKMAYIN");
                    return;
                }


                if (cmbgayrimenkultip.SelectedIndex == -1)
                {
                    MessageBox.Show("GAYRİMENKUL TİPİNİ BOŞ BIRAKMAYIN");
                    return;
                }

                DAL.Parameters[] prm = new DAL.Parameters[4];
                prm[0].name = "AD";
                prm[0].value = txtgayrimenkulad.Text;
                prm[1].name = "ILCEID";
                prm[1].value = cmbilce.SelectedValue.ToString();
                prm[2].name = "AKTIF";
                prm[2].value = 1;
                prm[3].name = "GAYRIMENKULTIPID";
                prm[3].value = cmbgayrimenkultip.SelectedValue.ToString();
                int numberOfRecords = dl.InsertSQL("GAYRIMENKUL", prm);

                if (numberOfRecords > 0)
                {
                    ClearHome();
                    MessageBox.Show("KAYIT BAŞARILI");
                    gayrimenkulgrid();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbilce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (cmbilce.SelectedIndex==-1)
            {
                cmbilce.SelectedIndex = 0;
            }      
        }

        private void cmbgayrimenkultip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (cmbgayrimenkultip.SelectedIndex == -1)
            {
                cmbgayrimenkultip.SelectedIndex = 0;
            }
        }

        private void dtGayrimenkul_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        
            DataTable TxtGayrimenkul = new DataTable();
            OleDbDataAdapter TxtGayrimenkuladapter = new OleDbDataAdapter();
            if (dtGayrimenkul.SelectedRows[0].DataBoundItem != null)
            {
                rdbguncelle.Checked = true;
                btnekle.Visible = false;
                btnguncelle.Visible = true;
                grpgydrm.Visible = true;
                GayrimenkulId = Convert.ToInt32(dtGayrimenkul.SelectedRows[0].Cells[0].Value.ToString());

                using (OleDbCommand dtCommand = dataConnection.CreateCommand())
                {
                    
                    dtCommand.CommandText = " SELECT  GAYRIMENKUL.AD FROM GAYRIMENKUL where GAYRIMENKUL.ID= " + GayrimenkulId;
                    TxtGayrimenkuladapter.SelectCommand = dtCommand;
                    TxtGayrimenkuladapter.Fill(TxtGayrimenkul);

                    foreach (DataRow row in TxtGayrimenkul.Rows)
                    {
                        GayrimenkulAd = row.ItemArray[0].ToString();
                        txtgayrimenkulad.Text = GayrimenkulAd;
                        dataConnection.Close();
                    }
                }
                cmbilce.Text = dtGayrimenkul.SelectedRows[0].Cells[2].Value.ToString();
                cmbgayrimenkultip.Text = dtGayrimenkul.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

       

        private void Gayrimenkul_Load(object sender, EventArgs e)
        {
            if (rdbekle.Checked==true)
            {
                btnguncelle.Visible = false;
            }

            dataConnection = new
OleDbConnection(Connection.GetConnection());
            GridDoldur();
        }

        private void rdbguncelle_Click(object sender, EventArgs e)
        {
            ClearHome();
            grpgydrm.Visible = true;
            btnekle.Visible = false;
            btnguncelle.Visible = true;
        }

        private void rdbekle_Click(object sender, EventArgs e)
        {
            txtgayrimenkulad.Text = null;
            grpgydrm.Visible = false;
            btnekle.Visible = true;
            btnguncelle.Visible = false;
        }

        private void cmbgydr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (cmbgydr.SelectedIndex == -1)
            {
                cmbgydr.SelectedIndex = 0;
            }
        }
    }
}
