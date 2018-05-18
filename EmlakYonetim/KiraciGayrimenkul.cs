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
    public partial class KiraciGayrimenkul : Form
    {
        DAL dl = new DAL();
        OleDbConnection dataConnection;
        FillCombobox flcmb = new FillCombobox();
        int MusteriGayrimenkulId;

        public KiraciGayrimenkul()
        {            
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable MusteriGayrimenkulSelect = new DataTable();
                OleDbDataAdapter MusteriGayrimenkulSelectadapter = new OleDbDataAdapter();

                if (cmbmüsteriad.SelectedIndex == -1)
                {
                    MessageBox.Show("KIRACİ ADINI BOŞ BIRAKMAYIN");
                    return;
                }


                using (OleDbCommand dataCommand1 = dataConnection.CreateCommand())
                {
                    if (dataConnection.State == ConnectionState.Closed)
                    {
                        dataConnection.Open();
                    }

                    dataCommand1.CommandText = " select * from MUSTERIGAYRIMENKUL where MUSTERIGAYRIMENKUL.GAYRIMENKULID =" + Convert.ToInt32(cmbgayrimenkulad.SelectedValue.ToString()) + " and MUSTERIGAYRIMENKUL.KIRABITISTARIHI is null ";
                    MusteriGayrimenkulSelectadapter.SelectCommand = dataCommand1;
                    MusteriGayrimenkulSelectadapter.Fill(MusteriGayrimenkulSelect);
                }


                if (MusteriGayrimenkulSelect.Rows.Count > 0)
                {
                    MessageBox.Show("AYNI GAYRİMENKULU KONTRAT TARİHİ BİTMEDİĞİNDEN GİREMEZSİNİZ");
                    MusteriGayrimenkulSelect.Clear();
                    dataConnection.Close();
                    return;
                }

                DAL.Parameters[] prm = new DAL.Parameters[3];
                prm[0].name = "MUSTERIID";
                prm[0].value = cmbmüsteriad.SelectedValue.ToString();
                prm[1].name = "KIRABASLANGICTARIHI";
                prm[1].value = dtkirabaslangaictarihi.Value.ToShortDateString();
                prm[2].name = "GAYRIMENKULID";
                prm[2].value = cmbgayrimenkulad.SelectedValue.ToString();

                int numberOfRecords = dl.InsertSQL("MUSTERIGAYRIMENKUL", prm);

                if (numberOfRecords > 0)
                {
                    ClearCustomerHome();
                    MessageBox.Show("KAYIT BAŞARILI");
                    Musterigayrimenkulgrid();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private DataTable Musterigayrimenkulgrid()
        {
            DataTable MusteriGayrimenkulCheck = new DataTable();
            OleDbDataAdapter MusteriGayrimenkulCheckadapter = new OleDbDataAdapter();
            MusteriGayrimenkulCheck.Clear();
            try
            {
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {

                    dataCommand.CommandText = " SELECT MUSTERIGAYRIMENKUL.ID,MUSTERI.AD,GAYRIMENKUL.AD,MUSTERIGAYRIMENKUL.KIRABASLANGICTARIHI,MUSTERIGAYRIMENKUL.KIRABITISTARIHI " +
                       " FROM MUSTERI INNER JOIN(MUSTERIGAYRIMENKUL INNER JOIN GAYRIMENKUL ON MUSTERIGAYRIMENKUL.GAYRIMENKULID = GAYRIMENKUL.ID) ON MUSTERI.ID = MUSTERIGAYRIMENKUL.MUSTERIID " +
                        " WHERE MUSTERIGAYRIMENKUL.KIRABITISTARIHI is null and MUSTERI.AKTIF = 1 and GAYRIMENKUL.AKTIF = 1 ";

                    MusteriGayrimenkulCheckadapter.SelectCommand = dataCommand;
                    MusteriGayrimenkulCheckadapter.Fill(MusteriGayrimenkulCheck);

                    dtmüsterigayrimenkul.DataSource = MusteriGayrimenkulCheck;
                    dtmüsterigayrimenkul.Columns[1].Width = 250;
                    dtmüsterigayrimenkul.Columns[2].Width = 250;
                    dtmüsterigayrimenkul.Columns[3].Width = 250;
                    dtmüsterigayrimenkul.Columns[4].Width = 250;
                    dtmüsterigayrimenkul.Columns[0].Visible = false;
                    dtmüsterigayrimenkul.Columns[1].HeaderText = "MÜŞTERİ ADI";
                    dtmüsterigayrimenkul.Columns[2].HeaderText = "GAYRİMENKUL ADI";
                    dtmüsterigayrimenkul.Columns[3].HeaderText = "KİRA BAŞLANGIÇ TARİHİ";
                    dtmüsterigayrimenkul.Columns[4].HeaderText = "KİRA BİTİŞ TARİHİ";
                    dataConnection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return MusteriGayrimenkulCheck;
        }

        private void ClearCustomerHome()
        {
            cmbmüsteriad.SelectedIndex = -1;
            cmbgayrimenkulad.SelectedIndex = -1;
        }

        private string GayrimenkulAdı(int MusteriId)
        {
            string Gayrimnekulad = null;
            using (OleDbCommand dataCommand2 = dataConnection.CreateCommand())
            {
                if (dataConnection.State == ConnectionState.Closed)
                {
                    dataConnection.Open();
                }

                dataCommand2.CommandText = "select GAYRIMENKUL.AD from MUSTERIGAYRIMENKUL INNER JOIN GAYRIMENKUL ON MUSTERIGAYRIMENKUL.GAYRIMENKULID = GAYRIMENKUL.ID " +
               " Where MUSTERIGAYRIMENKUL.MUSTERIID=" + MusteriId + " and MUSTERIGAYRIMENKUL.KIRABITISTARIHI IS NULL";
                dataCommand2.ExecuteNonQuery();

                int numberOfRecords = dataCommand2.ExecuteNonQuery();
                OleDbDataReader accessReader = dataCommand2.ExecuteReader();
                while (accessReader.Read())
                {
                    Gayrimnekulad = Convert.ToString(accessReader.GetValue(0));
                    if (!string.IsNullOrEmpty(Gayrimnekulad))
                    {
                        break;
                    }
                }
                return Gayrimnekulad;

            }
        }

        private void cmbkrcgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue;
            bool selectedValueOK = int.TryParse(Convert.ToString(cmbmüsteriad.SelectedValue), out selectedValue);

            if (selectedValueOK == true)
            {
                cmbgayrimenkulad.SelectedIndex = -1;
                cmbgayrimenkulad.Text = GayrimenkulAdı(Convert.ToInt32(cmbmüsteriad.SelectedValue.ToString()));
            }
        }

        private void cmbmüsteriad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue;
            bool selectedValueOK = int.TryParse(Convert.ToString(cmbmüsteriad.SelectedValue), out selectedValue);

            if (selectedValueOK == true)
            {
                cmbgayrimenkulad.SelectedIndex = -1;
                cmbgayrimenkulad.Text = GayrimenkulAdı(Convert.ToInt32(cmbmüsteriad.SelectedValue.ToString()));
            }
        }

        private void dtmüsterigayrimenkul_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

            DataTable ComboboxMusteriGayrimenkul = new DataTable();
            OleDbDataAdapter ComboboxMusteriGayrimenkuladapter = new OleDbDataAdapter();
            if (dtmüsterigayrimenkul.SelectedRows[0].DataBoundItem != null)
            {
                rdbguncelle.Checked = true;
                btnekle.Visible = false;
                btngüncelle.Visible = true;
                grbkrgy.Visible = true;
                MusteriGayrimenkulId = Convert.ToInt32(dtmüsterigayrimenkul.SelectedRows[0].Cells[0].Value.ToString());
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {

                    dataCommand.CommandText = " SELECT MUSTERI.AD & ' ' &  MUSTERI.SOYAD,GAYRIMENKUL.AD,MUSTERIGAYRIMENKUL.KIRABASLANGICTARIHI " +
" FROM GAYRIMENKUL INNER JOIN (MUSTERIGAYRIMENKUL INNER JOIN MUSTERI ON MUSTERIGAYRIMENKUL.MUSTERIID = MUSTERI.ID) ON GAYRIMENKUL.ID = MUSTERIGAYRIMENKUL.GAYRIMENKULID " +
" where MUSTERIGAYRIMENKUL.ID =  " + MusteriGayrimenkulId;
                    ComboboxMusteriGayrimenkuladapter.SelectCommand = dataCommand;
                    ComboboxMusteriGayrimenkuladapter.Fill(ComboboxMusteriGayrimenkul);

                    foreach (DataRow row in ComboboxMusteriGayrimenkul.Rows)
                    {
                        cmbmüsteriad.Text = row.ItemArray[0].ToString();
                        cmbgayrimenkulad.Text = row.ItemArray[1].ToString();
                        dtkirabaslangaictarihi.Text = row.ItemArray[2].ToString();
                    }

                    dataConnection.Close();

                }
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int parameters = 3;
            if (chkkirabitistarihi.Checked == true)
            {
                parameters = 4;
            }

            if (cmbmüsteriad.SelectedIndex == -1)
            {
                MessageBox.Show("KİRACI ADINI BOŞ BIRAKMAYIN");
                return;
            }


            if (cmbgayrimenkulad.SelectedIndex==-1)
            {
                MessageBox.Show("GAYRİMENKUL ADINI BOŞ BIRAKMAYIN");
                return;
            }

            if (dtmüsterigayrimenkul.SelectedRows.Count == 0)
            {
                MessageBox.Show("GÜNCELLEYECEĞİNİZ GAYRİMENKULU SEÇİN");
                return;
            }

            int result = DateTime.Compare(Convert.ToDateTime(dtkirabitiştarihi.Value.ToShortDateString()), Convert.ToDateTime(dtkirabaslangaictarihi.Value.ToShortDateString()));
            if (result < 0)
            {
                MessageBox.Show("KİRA BİTİŞ TARİHİ BAŞLANGIÇ TARİHİNDEN KÜÇÜK OLAMAZ");
                return;
            }

            if (dtmüsterigayrimenkul.SelectedRows.Count == 0)
            {
                MessageBox.Show("SİLECEĞİNİZ MUSTERIYI SEÇİN");
                return;
            }

            if (cmbkrcgy.SelectedIndex == -1)
            {
                MessageBox.Show("GAYRİMENKUL DURUMUNU SEÇİN");
                return;
            }

            if (cmbkrcgy.Text.Trim() == "BOŞ")
            {
                int affectedRecords = dl.DeleteSQL("MUSTERIGAYRIMENKUL", "ID", MusteriGayrimenkulId);
                if (affectedRecords > 0)
                {
                    MessageBox.Show("SİLME BAŞARILI");
                    Musterigayrimenkulgrid();
                }
            }

            Musterigayrimenkulgrid();

            DAL.Parameters[] prm = new DAL.Parameters[parameters];
            prm[0].name = "MUSTERIID";
            prm[0].value = cmbmüsteriad.SelectedValue.ToString();
            prm[1].name = "KIRABASLANGICTARIHI";
            prm[1].value = dtkirabaslangaictarihi.Value.ToShortDateString();
            prm[2].name = "GAYRIMENKULID";
            prm[2].value = cmbgayrimenkulad.SelectedValue.ToString();
            if (parameters == 4)
            {
                prm[3].name = "KIRABITISTARIHI";
                prm[3].value = dtkirabitiştarihi.Value.ToShortDateString();
            }

            int numberOfRecords = dl.UpdateSQL("MUSTERIGAYRIMENKUL", prm, "ID", MusteriGayrimenkulId);

            if (numberOfRecords > 0)
            {
                MessageBox.Show("GUNCELLEME BAŞARILI");

            }
        }

        private void KiraciGayrimenkul_Load(object sender, EventArgs e)
        {
            if (rdbekle.Checked==true)
            {
                btnekle.Visible = true;
                btngüncelle.Visible = false;
            }

            dataConnection = new
OleDbConnection(Connection.GetConnection());
           
            cmbgayrimenkulad.ValueMember = "ID";
            cmbgayrimenkulad.DisplayMember = "AD";
            cmbgayrimenkulad.DataSource = flcmb.Populatecombobox("GAYRIMENKUL", "AKTIF", 1);

            cmbmüsteriad.ValueMember = "ID";
            cmbmüsteriad.DisplayMember = "AD";
            cmbmüsteriad.DataSource = flcmb.Populatecombobox("MUSTERI", "AKTIF", 1);

            cmbkrcgy.SelectedIndex = 1;
            if (cmbgayrimenkulad.Items.Count>0)
            {
                cmbgayrimenkulad.SelectedIndex = 0;
            }

            if (cmbmüsteriad.Items.Count>0)
            {
                cmbmüsteriad.SelectedIndex = 0;
            }
            Musterigayrimenkulgrid();
        }

        private void rdbekle_Click(object sender, EventArgs e)
        {
            cmbmüsteriad.SelectedIndex = -1;
            cmbgayrimenkulad.SelectedIndex = -1;            
            grbkrgy.Visible = false;
            btngüncelle.Visible = false;
            btnekle.Visible = true;
        }

        private void rdbguncelle_Click(object sender, EventArgs e)
        {
            btngüncelle.Visible = true;
            btnekle.Visible = false;
            grbkrgy.Visible = true;
        }

        private void cmbmüsteriad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (cmbmüsteriad.SelectedIndex == -1 && cmbmüsteriad.Items.Count>0)
            {
                cmbmüsteriad.SelectedIndex = 0;
            }
        }

        private void cmbkrcgy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (cmbkrcgy.SelectedIndex == -1)
            {
                cmbkrcgy.SelectedIndex = 0;
            }
        }

        private void cmbgayrimenkulad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (cmbgayrimenkulad.SelectedIndex == -1 && cmbgayrimenkulad.Items.Count>0)
            {
                cmbgayrimenkulad.SelectedIndex = 0;
            }
        }
    }
}
