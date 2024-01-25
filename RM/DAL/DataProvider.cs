using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RM.DAL
{
    public class DataProvider
    {
        private static string connString = "Data Source =(local); Initial Catalog =DB13; Integrated Security = true;";
        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get {
                if(instance == null)
                    instance = new DataProvider();
                return instance; 
            }
            private set => instance = value; 
        }
        private DataProvider() { }

        public DataTable ExcuteQuerry(string sql , object[] parameters = null)
        {
            DataTable data = new DataTable();

            
            using (SqlConnection _conn = new SqlConnection(connString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = _conn;

                if(parameters != null)
                {
                    string[] list = sql.Split(' ');
                    int i = 0;

                    foreach (string s in list)
                    {
                        if (s.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(s, parameters[i]);
                            i++;
                        }

                    }
                }

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(data);
                _conn.Close();
            }

            return data;
        }

        public int ExcuteNonQuerry(string sql, object[] parameters = null)
        {
            int num;


            using (SqlConnection _conn = new SqlConnection(connString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = _conn;

                if (parameters != null)
                {
                    String[] list = sql.Split(' ');
                    int i = 0;

                    foreach (String s in list)
                    {
                        if (s.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(s, parameters[i]);
                            i++;
                        }

                    }
                }

                num = cmd.ExecuteNonQuery();
                _conn.Close();
            }

            return num;

        }
    }
}
