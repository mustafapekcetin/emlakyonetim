using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakYonetim
{
    public class DAL
    {
        public int InsertSQL(string pTableName, Parameters[] prm)
        {
            string sqlQuery = "INSERT INTO " + pTableName + " (";

            OleDbConnection connection = new OleDbConnection(Connection.GetConnection());
            connection.Open();
            
            for (int i = 0; i < prm.Length; i++)
            {
                sqlQuery += prm[i].name;
                if (i != prm.Length - 1)
                    sqlQuery += ",";
            }
            sqlQuery += ") VALUES (";
            for (int i = 0; i < prm.Length; i++)
            {
                sqlQuery += "@" + prm[i].name;
                if (i != prm.Length - 1)
                    sqlQuery += ",";
            }
            sqlQuery += ")";

            OleDbCommand query = new OleDbCommand(sqlQuery, connection);

            for (int i = 0; i < prm.Length; i++)
            {
                query.Parameters.AddWithValue(prm[i].name, prm[i].value);
            }

            int result = 0;

            try
            {
                result = query.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + " (" + sqlQuery + ")");
            }

            connection.Close();
            connection.Dispose();
            query.Dispose();

            return result;
        }

        public int UpdateSQL(string pTableName, Parameters[] prm, string whereColumnName, int whereColumnIDValue)
        {
            string sqlQuery = "UPDATE " + pTableName + " SET ";

            OleDbConnection connection = new OleDbConnection(Connection.GetConnection());
            connection.Open();

            for (int i = 0; i < prm.Length; i++)
            {
                sqlQuery += prm[i].name + " = @" + prm[i].name;
                if (i != prm.Length - 1)
                    sqlQuery += ",";
            }
            sqlQuery += " WHERE " + whereColumnName + " = " + whereColumnIDValue;

            OleDbCommand query = new OleDbCommand(sqlQuery, connection);

            for (int i = 0; i < prm.Length; i++)
            {
                query.Parameters.AddWithValue(prm[i].name, prm[i].value);
            }

            int result = 0;

            try
            {
                result = query.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + " (" + sqlQuery + ")");
            }

            connection.Close();
            connection.Dispose();
            query.Dispose();

            return result;
        }

        public int DeleteSQL(string pTableName, string whereColumnName, int whereColumnIDValue)
        {
            string sqlQuery = "DELETE FROM " + pTableName + " WHERE " + whereColumnName + " = " + whereColumnIDValue;

            OleDbConnection connection = new OleDbConnection(Connection.GetConnection());
            connection.Open();
            OleDbCommand query = new OleDbCommand(sqlQuery, connection);

            int result = 0;

            try
            {
                result = query.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + " (" + sqlQuery + ")");
            }

            connection.Close();
            connection.Dispose();
            query.Dispose();

            return result;
        }

        public struct Parameters
        {
            public string name;
            public object value;
        }
    }
}
