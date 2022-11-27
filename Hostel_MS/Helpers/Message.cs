using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS.Helpers
{
    public static class MyMessage
    {
        public static void Success(string Name)
        {
            MessageBox.Show(Name+" saved successfully!","Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Error(string Name)
        {
            MessageBox.Show(Name + " Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
