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
	public partial class AssignRoom : Form
	{
		public AssignRoom()
		{
			InitializeComponent();
		}

		private void AssignRoom_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'roomNumberDataSet.tbl_Room' table. You can move, or remove it, as needed.
			this.tbl_RoomTableAdapter.Fill(this.roomNumberDataSet.tbl_Room);
			// TODO: This line of code loads data into the 'hostelDbDataSet1.tbl_Student' table. You can move, or remove it, as needed.
			this.tbl_StudentTableAdapter.Fill(this.hostelDbDataSet1.tbl_Student);


		}

		private void cmb_CNIC_SelectedIndexChanged(object sender, EventArgs e)
		{
			string Query = "SELECT * FROM tbl_Student Where CNIC='" + cmb_CNIC.Text + "'";
			SqlConnection con = new SqlConnection(SqlData.ConString);
			con.Open();
			SqlCommand cmd = new SqlCommand(Query, con);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				txt_StudentName.Text = dr["Name"].ToString();
			}
		}

		private void cmb_RoomNo_SelectedIndexChanged(object sender, EventArgs e)
		{
			string Query = "SELECT * FROM tbl_Room Where RoomNumber='" + cmb_RoomNo.Text + "'";
			SqlConnection con = new SqlConnection(SqlData.ConString);
			con.Open();
			SqlCommand cmd = new SqlCommand(Query, con);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				txt_AvailSeat.Text = dr["AvailablSeat"].ToString();
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			int NumberOfSeats;
			string Query = "INSERT INTO tbl_AssignRoom Values('" + cmb_CNIC.Text + "','" + txt_StudentName.Text + "','" + cmb_RoomNo.Text + "')";
			SqlData sql= new SqlData();
			sql.OpenCon();
			sql.NonQueryExecuter(Query);
			NumberOfSeats = Convert.ToInt32(txt_AvailSeat.Text);
			NumberOfSeats = NumberOfSeats - 1;
			sql.NonQueryExecuter("UPDATE tbl_Room SET AvailablSeat='" + NumberOfSeats + "' Where RoomNumber='" + cmb_RoomNo.Text + "'");
			sql.CloseCon();


		}
	}
}
