using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LTUDQL1_DuLieu
{
    public class DataProvider
    {
        

        //Tín
        public string connectionString = @"Data Source=DESKTOP-T1HU900;Initial Catalog=QuanLiCaoOc;Persist Security Info=True;User ID=sa;Password=220515";


        SqlConnection conn = null;

        public void Connect()
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(connectionString);
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        public void Disconnect()
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecuteNonQuery(CommandType cmt, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand comd = conn.CreateCommand();

                comd.CommandType = cmt;
                comd.CommandText = strSql;
                if (parameters != null && parameters.Length > 0)
                    comd.Parameters.AddRange(parameters);
                int Rows = comd.ExecuteNonQuery();
                return Rows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable Select(CommandType cmt, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand comd = conn.CreateCommand();
                comd.CommandType = cmt;
                comd.CommandText = strSql;
                if (parameters != null && parameters.Length > 0)
                    comd.Parameters.AddRange(parameters);
                comd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(comd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable GetReader(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = conn.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);

                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


    }
}
