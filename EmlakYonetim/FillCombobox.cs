using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakYonetim
{


    public class FillCombobox
    {
        DataTable PopulateCombobox;
        OleDbDataAdapter PopulateComboboxAdapter = new OleDbDataAdapter();

        OleDbConnection dataConnection = new OleDbConnection(Connection.GetConnection());


        public DataTable Populatecombobox(string pTableName, string whereColumnName, int whereColumnIDValue)
        {
            try
            {
                PopulateCombobox = new DataTable();
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    string sql = "SELECT AD,ID  FROM " + pTableName;
                    string where = string.Empty;
                    if (!string.IsNullOrEmpty(whereColumnName))
                    {
                        where = " WHERE " + whereColumnName + " = " + whereColumnIDValue;
                    }

                    dataCommand.CommandText = sql + where;
                    dataConnection.Open();
                    PopulateComboboxAdapter.SelectCommand = dataCommand;
                    PopulateComboboxAdapter.Fill(PopulateCombobox);
                    dataConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return PopulateCombobox;
        }

    }
}
