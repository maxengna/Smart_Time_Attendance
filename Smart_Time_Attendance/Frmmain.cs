using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Time_Attendance
{
    public partial class Frmmain : Form
    {

        public string user;
        public Frmmain(string Username)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            lbl_user_active.Text = "ยินดีต้อนรับคุณ : " + Username;

            //timer1.Start();

        }

        public void tstrip_rule_Click(object sender, EventArgs e)
        {
            Manage_system systems = new Manage_system();
            Frm_Rules frm_Rules = new Frm_Rules();

           // จะบังคับไม่ให้เปิดฟอร์มซ้ำ 
           systems.Check_FormDuplicate(frm_Rules.Text, this);
           
            
        }

        private void tstrip_manageEmp_Click(object sender, EventArgs e)
        {
            Manage_system systems = new Manage_system();
            Frm_manage_Employee frm_Manage_Employee = new Frm_manage_Employee();
            systems.Check_FormDuplicate2(frm_Manage_Employee, this);

        }

        private void Frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {


        //        Timer timer1 = new Timer();
        //        timer1.Interval = 1000;
        //        timer1.Enabled = true;
        //        timer1.Tick += new EventHandler(Ontime_event);

        //    }
        //    catch (Exception)
        //    {

                
        //    }
       // }


        //public void  Ontime_event(object sender ,EventArgs e)
        //{
        //    lbl_timer.Text = DateTime.Now.ToLongDateString() + "," + DateTime.Now.ToLongTimeString();
        //}



     






    }
}
