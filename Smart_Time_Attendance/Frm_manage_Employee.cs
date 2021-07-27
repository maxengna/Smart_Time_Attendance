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
    public partial class Frm_manage_Employee : Form
    {
        public Frm_manage_Employee()
        {
            InitializeComponent();
        }

        private void Frm_manage_Employee_Load(object sender, EventArgs e)
        {
            txt_id_emp.Enabled = false;
            txt_name.Enabled = false;
            txt_lastname.Enabled = false;
            dpk_DOB.Enabled = false;
            txt_email.Enabled = false;
            txt_tel.Enabled = false;
            txt_address.Enabled = false;
            txt_position.Enabled = false;
            txt_section.Enabled = false;
            dpk_startdate.Enabled = false;
            dpk_terminatedate.Enabled = false;
            txt_password.Enabled = false;
            txt_conrfirm_password.Enabled = false;


            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id_emp.Enabled = true;
            txt_name.Enabled = true;
            txt_lastname.Enabled = true;
            dpk_DOB.Enabled = true;
            txt_email.Enabled = true;
            txt_tel.Enabled = true;
            txt_address.Enabled = true;
            txt_position.Enabled = true;
            txt_section.Enabled = true;
            dpk_startdate.Enabled = true;
            dpk_terminatedate.Enabled = true;
            txt_password.Enabled = true;
            txt_conrfirm_password.Enabled = true;


            // create id_employee
            Manage_system manage = new Manage_system();
            string new_id = manage.Check_Create_ID("employee_info");
            txt_id_emp.Text = new_id;

            btn_add.Enabled = false;

            //create SALT for hash password
            string new_salt = manage.GenerateSalt();

            //create new password without hash
            string new_password_Origin = manage.New_password(8, 2, 3, 1, 2);


            // Hash pasword => SALT + new password
            string new_hashPassword = manage.Hash_function(new_password_Origin, new_salt);

            txt_password.Text = new_password_Origin;

        
        
        
        
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "File images(*.Png,*Jpg,*Bmp,*Giff)|*.png;*jpg;*bmp;*.giff)";
            ofd.InitialDirectory = @"C:\Users\maxxx\source\repos";
        
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var filename = ofd.FileName;
                pictureBox1.Image = new Bitmap(filename);
                
            }
        
        }
    }
}
