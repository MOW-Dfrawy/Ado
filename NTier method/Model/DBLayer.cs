using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace NTier_method.Model
{
   

    internal class DBLayer
    {
    
            public static DataTable select(SqlCommand cmd)
        {

            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            cmd.Connection = con;
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adpter.Fill(dataTable);
            return dataTable;
        }

        public static int DML(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            cmd.Connection = con;
            con.Open();
            int roweffect = cmd.ExecuteNonQuery();
            con.Close();
            return roweffect;
        }
    }
}