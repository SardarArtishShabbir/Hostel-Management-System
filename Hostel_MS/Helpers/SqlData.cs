using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_MS.Helpers
{
    public class SqlData
    {
        
        public static string ConString = ConfigurationManager.ConnectionStrings["conString"].ToString();
        SqlConnection con = new SqlConnection(ConString);
       
        public void OpenCon()
        {
            con.Open();
        }

        public void CloseCon()
        {
            con.Close();
        }

        public void NonQueryExecuter(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }

    }
}
