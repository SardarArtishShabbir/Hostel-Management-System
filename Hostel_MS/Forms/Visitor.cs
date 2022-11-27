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
    public partial class Visitor : Form
    {
        SqlData sqlData = new SqlData();
        public Visitor()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Query = "INSERT INTO tbl_Visitor VALUES('"+txt_cnic.Text+"','"+txt_name.Text+"','"+txt_visit_time.Text+"','"+txt_relation.Text+"','"+cmb_name.Text+"','"+txt_name.Text+"')";
            sqlData.OpenCon();
            sqlData.NonQueryExecuter(Query);
            sqlData.CloseCon();
            MyMessage.Success("Visitor");
        }
    }
}
