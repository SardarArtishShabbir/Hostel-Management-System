using Hostel_MS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS.Forms
{
    public partial class Staff : Form
    {
        SqlData sqlData = new SqlData();
        public Staff()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Query = "INSERT INTO tbl_Staff VALUES('"+txt_CNIC.Text+"','"+txt_Name.Text+"','"+txt_FatherName.Text+"','"+txt_Mobile.Text+"','"+dt_DateOfRegistration.Text+"','"+dt_DoB.Text+"','"+txt_BloodGroup.Text+"','"+txt_Address.Text+"')";
            sqlData.OpenCon();
            sqlData.NonQueryExecuter(Query);
            sqlData.CloseCon();
            MyMessage.Success("Staff");
        }
    }
}
