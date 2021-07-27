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
    public partial class Frm_login : Form
    {
        private string n;
        //public Frmstart frmstart = new Frmstart();

        public Frm_login()
        {
            InitializeComponent();

            
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            lbl_notiUser.Visible = false;

            // ตรวจสอบว่าเป็นการใช้งานโปรแกรมครั้งแรกหรือไม่ => โดยเช็คว่าในฐานข้อมูลมี employee อยู่หรือไม่
            // ถ้าใช้งานครั้งแรก ให้โชว์ label เริ่มต้นใช้งาน

            using (var db = new Time_AttendanceEntities())
            {
                var emp = (from value in db.Employee_info
                           select value).ToList();


                if (emp.Count > 0)
                {
                    linkLabel1.Visible = false;
                }
                else
                {
                    linkLabel1.Visible = true;
                }

            }





            //Email system_mail = new Email();
            //system_mail.Send_email(); 



            //HRadmin admin = new HRadmin();

            //*********************
            //1.select data with ef + store procedure

            //var dataemp = admin.Find_employee("emp6400000");
            //DateTime effectiveemp = Convert.ToDateTime(dataemp.st_effectivedate);


            //MessageBox.Show($"name employee:{effectiveemp}");

            //*********************************



            //2. insert data with ef + store procedure            

            //using (var db = new Time_AttendanceEntities())

            //{
            //  db.Insert_employee_info("emp6400001", "santi", "duansawang",Convert.ToDateTime("1980-01-01"), "santi@mail.com"
            //                           , "012345678", "staff1", "accounting", Convert.ToDateTime("2020-01-01"), Convert.ToDateTime("2020-12-01"), "buider tower Usa");

            //}

            //var target_staff = admin.Find_employee("emp6400001");
            //MessageBox.Show($"finding name 'staff is: {target_staff.st_firstname} \n " +
            //    $"lastname'staff {target_staff.st_lastname} \n" + $"effective date: {target_staff.st_effectivedate}"); 



            //3.Delete data
            //string id_emp = "emp6400001";
            //admin.Delete_emp(id_emp);
            //MessageBox.Show($"delete {id_emp} \t complete");

            //Manage_system manage = new Manage_system();

            //string newpassword = manage.New_password(11, 3, 3, 3, 2);
            //MessageBox.Show($"New password: {newpassword}");

            //    string new_password2 = "AAz123*";
            //    if (manage.Validate_password(new_password2))
            //    {
            //        string hashedpassword = manage.Hash_function(new_password2);
            //        MessageBox.Show($"Origainal password = {new_password2} {Environment.NewLine} new password = {hashedpassword} ");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Password Invalid");
            //    }



        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
             if(Rdb_Admin.Checked && txt_username.Text == "ADMIN_SYSTEM" && Txt_password.Text == "Admin@#64")
            {
                Frmmain frmmain = new Frmmain(txt_username.Text);
                this.Hide();
                frmmain.Show();
                
            }
            else
            {
                lbl_notiUser.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmstart frmstart = new Frmstart();
            frmstart.Show();
          
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chk_showPassword_CheckedChanged(object sender, EventArgs e)
        {
           Txt_password.PasswordChar = chk_showPassword.Checked ? '\0' : '*';
           
        }

        private void Frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
