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
    public partial class Frm_Rules : Form
    {
        public Frm_Rules()
        {
            InitializeComponent();

        }

        private void Frm_Rules_Load(object sender, EventArgs e)
        {
            
            // กำหนดวัน- เวลาทำงาน
            txt_total_working.Enabled = false;
            cmb_working_days.Enabled = false;
            lbl_custom_working_days.Visible = false;
            txt_custom_workingdays.Visible = false;
            txt_working_From_Hour.Enabled = false;
            txt_working_to_Hour.Enabled = false;

            btn_total_working_days.Visible = false;
            btn_working_days.Visible = false;
            btn_working_Hours.Visible = false;

            // กำหนดการทำงานล่วงเวลา
            txt_fromOT_workingdays.Enabled = false;
            txt_toOT_workingdays.Enabled = false;
            txt_fromOT_weekend.Enabled = false;
            txt_toOT_weekend.Enabled = false;
            btn_edit_OT_workingdays.Visible = false;
            btn_edit_OT_weekend.Visible = false;

            // กำหนดวันหยุด
            txt_sick.Enabled = false;
            txt_private.Enabled = false;
            txt_vacation.Enabled = false;

            btn_sick.Visible = false;
            btn_private.Visible = false;
            btn_vacation.Visible = false;

            btn_save.Visible = false;



        }

       
    }
}
