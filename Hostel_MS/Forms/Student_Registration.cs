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
    public partial class Student_Registration : Form
    {
        SqlData sqlData = new SqlData();
        public Student_Registration()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String Query = "INSERT INTO tbl_Student Values('"+txt_CNIC.Text+"','"+txt_Name.Text+"','"+txt_fathername.Text+"','"+txt_address.Text+"','"+txt_mobile.Text+"','"+txt_educational.Text+"','"+txt_class.Text+"','"+dt_dateofReg.Text+"','"+dt_dob.Text+"','"+txt_bloodgrp.Text+"','"+txt_guardiannum.Text+"','"+txt_guardianname.Text+"')";
            sqlData.OpenCon();
            sqlData.NonQueryExecuter(Query);
            sqlData.CloseCon();
            MyMessage.Success("Student");

        }
    }
}
