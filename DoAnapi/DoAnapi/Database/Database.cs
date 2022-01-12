using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoAnapi.Database
{
    public class Database
    {
        public static DataTable ReadTable(string StoredProcedureName, Dictionary<string, object> para = null)
        {
            try
            {
                DataTable resultTable = new DataTable();

                string SQLConnectionString = ConfigurationManager.ConnectionStrings["QLTRUYENConnectString"].ConnectionString;
                SqlConnection connect = new SqlConnection(SQLConnectionString);

                connect.Open();

                SqlCommand sqlCmd = connect.CreateCommand();
                sqlCmd.Connection = connect;
                sqlCmd.CommandText = StoredProcedureName;
                sqlCmd.CommandType = CommandType.StoredProcedure;

                if (para != null)
                {
                    foreach (KeyValuePair<string, object> data in para)
                    {
                        if (data.Value == null)
                        {
                            sqlCmd.Parameters.AddWithValue("@" + data.Key, DBNull.Value);
                        }    
                        else
                        {
                            sqlCmd.Parameters.AddWithValue("@" + data.Key, data.Value);
                        }    
                    }    
                }

                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = sqlCmd;
                sqlDA.Fill(resultTable);

                connect.Close();
                return resultTable;
            }
            catch
            {
                return null;
            }
        }
    }
}