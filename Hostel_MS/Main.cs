using Hostel_MS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Registration student = new Student_Registration();
            student.MdiParent = this;
            student.Show();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff= new Staff();
            staff.MdiParent = this;
            staff.Show();
        }

        private void registerRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room= new Room();
            room.MdiParent = this; 
            room.Show();
        }

        private void asignRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignRoom assignRoom = new AssignRoom();
            assignRoom.MdiParent = this;    
            assignRoom.Show();
        }

        private void addVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor();
            visitor.MdiParent = this;
            visitor.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AssignRoom assignRoom = new AssignRoom();
            assignRoom.MdiParent = this;
            assignRoom.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor();
            visitor.MdiParent = this;
            visitor.Show();
        }
    }
}
