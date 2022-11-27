using Hostel_MS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS.Forms
{
    public partial class Room : Form
    {
        SqlData sqlData = new SqlData();
        public Room()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Query = "INSERT INTO tbl_Room VALUES('"+txt_Number.Text+"','"+txt_Floot.Text+"','"+cmb_Type.Text+"','"+cmb_washRoom.Text+"','"+txt_SeatRent.Text+"')";
            sqlData.OpenCon();
            sqlData.NonQueryExecuter(Query);
            sqlData.CloseCon();
            MyMessage.Success("Room");
            
        }
    }
}
