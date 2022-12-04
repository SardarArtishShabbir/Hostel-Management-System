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
	public partial class Search_Student : Form
	{
		public Search_Student()
		{
			InitializeComponent();
		}

		private void Search_Student_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'hostelDbDataSet.tbl_Student' table. You can move, or remove it, as needed.
            this.tbl_StudentTableAdapter.Fill(this.hostelDbDataSet.tbl_Student);

        }

		private void btn_Search_Click(object sender, EventArgs e)
		{

			if (cmb_Choice.Text == "Name")
			{
				SearchWithName();
			}
			else if (cmb_Choice.Text == "CNIC")
			{
				SearchWithCNIC();
			}
		}

		private void cmb_Choice_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmb_Choice.Text == "Name")
			{
				txt_Cnic.Enabled = false;
				txt_Name.Enabled = true;
			}
			else if(cmb_Choice.Text == "CNIC")
			{
				txt_Cnic.Enabled = true;
				txt_Name.Enabled = false;
			}
		}


		private void SearchWithName()
		{
			string Query = "SELECT * FROM tbl_Student Where Name LIKE '%" + txt_Name.Text + "%'";
			SqlDataAdapter da = new SqlDataAdapter(Query, SqlData.ConString);
			DataSet ds = new DataSet();
			da.Fill(ds);
			dg_Student.DataSource = ds.Tables[0];
		}

		private void SearchWithCNIC()
		{
			string Query = "SELECT * FROM tbl_Student Where CNIC LIKE '%" + txt_Cnic.Text + "%'";
			SqlDataAdapter da = new SqlDataAdapter(Query, SqlData.ConString);
			DataSet ds = new DataSet();
			da.Fill(ds);
			dg_Student.DataSource = ds.Tables[0];
		}
	}
}
