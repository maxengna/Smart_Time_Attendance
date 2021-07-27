using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Time_Attendance
{
    public partial class Frmstart : Form
    {
        public Frmstart()
        {
            InitializeComponent();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {

            Frm_login login = new Frm_login();
            this.Hide();
            login.ShowDialog();   
        
        }

        
        
    }
}
