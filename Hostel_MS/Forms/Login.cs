using Hostel_MS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

		private void chk_ShowPass_CheckedChanged(object sender, EventArgs e)
		{
            if(chk_ShowPass.CheckState == CheckState.Checked)
            {
                txt_password.UseSystemPasswordChar = false;   
            }
            else if(chk_ShowPass.CheckState == CheckState.Unchecked)
            {
				txt_password.UseSystemPasswordChar = true;

			}
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
            string Query = "SELECT * from tbl_login Where Username='"+txt_username.Text+"' AND Password='"+txt_password.Text+"'";
            SqlConnection con = new SqlConnection(SqlData.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader(); 
            if (dr.Read())
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                MyMessage.Error("Invalid Username or Password");
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
		}
	}
}
