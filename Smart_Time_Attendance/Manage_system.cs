using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Smart_Time_Attendance
{

    public class Manage_system
    {
        public string member_entity;
        public string lastid;
        private string encrypt_id;




        // function check totalrow in each entity  and create id employee

        public string Check_Create_ID(string entityname)
        {

            int lastid;
            int newid;
            string transfrom_entity = entityname.ToLower();


            if (transfrom_entity == "employee_info")
            {
                using (var db = new Time_AttendanceEntities())
                {
                    var data = (from val in db.Employee_info
                                orderby val.ID_EMP descending
                                select val).ToList();

                    if (data.Count > 0)
                    {
                        foreach (var emp in data)
                        {
                            lastid = Convert.ToInt32(emp.ID_EMP.Substring(3));
                            newid = lastid + 1;
                            member_entity = Convert.ToString($"emp{newid}");

                        }
                    }
                    else
                    {
                        member_entity = "emp6400000";
                    }
                }
            }
            else if (transfrom_entity == "holiday_emp")
            {
                using (var db = new Time_AttendanceEntities())
                {
                    var data = (from val in db.Holiday_emp
                                orderby val.HOLIDAY_ID descending
                                select val).ToList();

                    if (data.Count > 0)
                    {
                        foreach (var emp in data)
                        {
                            lastid = Convert.ToInt32(emp.HOLIDAY_ID.Substring(3));
                            newid = lastid + 1;
                            member_entity = Convert.ToString($"emp{newid}");

                        }
                    }
                    else
                    {
                        member_entity = "hol6500000";
                    }
                }
            }
            else if (transfrom_entity == "ot_emp")
            {
                using (var db = new Time_AttendanceEntities())
                {
                    var data = (from val in db.OT_EMP
                                orderby val.OT_ID descending
                                select val).ToList();

                    if (data.Count > 0)
                    {
                        foreach (var emp in data)
                        {
                            lastid = Convert.ToInt32(emp.OT_ID.Substring(2));
                            newid = lastid + 1;
                            member_entity = Convert.ToString($"emp{newid}");

                        }
                    }
                    else
                    {
                        member_entity = "OT6800000";
                    }
                }
            }
            else if (transfrom_entity == "logtime_id")
            {
                using (var db = new Time_AttendanceEntities())
                {
                    var data = (from val in db.Timesheet_emp
                                orderby val.LOGTIME_ID descending
                                select val).ToList();

                    if (data.Count > 0)
                    {
                        foreach (var emp in data)
                        {
                            lastid = Convert.ToInt32(emp.LOGTIME_ID.Substring(3));
                            newid = lastid + 1;
                            member_entity = Convert.ToString($"emp{newid}");

                        }
                    }
                    else
                    {
                        member_entity = "TMS7100000";
                    }
                }
            }
            else
            {
                using (var db = new Time_AttendanceEntities())
                {
                    var data = (from val in db.Transac_login
                                orderby val.LOG_IN_ID descending
                                select val).ToList();

                    if (data.Count > 0)
                    {
                        foreach (var emp in data)
                        {
                            lastid = Convert.ToInt32(emp.LOG_IN_ID.Substring(3));
                            newid = lastid + 1;
                            member_entity = Convert.ToString($"emp{newid}");

                        }
                    }
                    else
                    {
                        member_entity = "LOG7500000";
                    }
                }
            }

            return member_entity;

        }



        // hr กด ADD => ระบบ Auto gen ID => Insert employee => employee_info => fuction create password => encrypt password =>table user Authen
        // => พนักงานดูได้คนเดียว hr ดูไม่ได้

        // Create password

        //step create => random pass => send to emp => encrypt into => database
        public string CreatepassWord(string emp_id)
        {

            var string_group = new StringBuilder();
            Random _random = new Random();



            int random_number = _random.Next(1, 9);


            // สุ่ม เพื่อจะได้ตัว key ในการ Create password

            //string key_encrypt = random_number == 1 ? "A" :
            //                        random_number == 2 ? "B" :
            //                            random_number == 3 ? "C" :
            //                                random_number == 4 ? "D" :
            //                                    random_number == 5 ? "E" :
            //                                        random_number == 6 ? "F" :
            //                                            random_number == 7 ? "G" :
            //                                                random_number == 8 ? "H" :
            //                                                    "I";





            //แยก char ออกจาก id_employee

            for (int i = 0; i < 3; i++)
            {
                int ascii_num = (int)emp_id[i] + random_number;

                char ascii_transform = (char)ascii_num;

                string_group.Append(ascii_transform);



            }

            //แยก ตัวเลขออกจาก id_employee

            for (int j = 3; j < emp_id.Length - 1; j++)
            {
                int ascii_num2 = (int)emp_id[j] + random_number;
                char ascii_transform2 = (char)ascii_num2;

                string_group.Append(ascii_transform2);
            }


            // บวก KEY เข้าไปใน Password

            char keytransform = (char)random_number;
            string_group.Append(keytransform.ToString().ToUpper());



            return string_group.ToString();

        }


        // function create password with option (Upper,Lower,number,Total,sort) -- 2 overload
        public string New_password(int total = 0, int upper = 0, int lower = 0, int num = 0)
        {

            try
            {


                var string_set = new StringBuilder(total);
                // create upper case

                if (total > 0)
                {

                    if (upper > 0)
                    {
                        for (int i = 0; i < upper; i++)
                        {

                            Random Rnd_upper = new Random();

                            int num_upper = Rnd_upper.Next(65, 90);

                            // หน่วงเวลาเพื่อรอ ให้ Process การสุ่มตัวเลขใน step ก่อนหน้าทำเสร็จก่อน
                            Thread.Sleep(20);

                            char chr_upper = (char)num_upper;
                            string_set.Append(chr_upper);
                        }


                    }
                    // create lower case

                    if (lower > 0)
                    {

                        for (int i = 0; i < lower; i++)
                        {
                            Random Rnd_lower = new Random();
                            int num_lower = Rnd_lower.Next(97, 122);

                            // หน่วงเวลาเพื่อรอ ให้ Process การสุ่มตัวเลขใน step ก่อนหน้าทำเสร็จก่อน

                            Thread.Sleep(20);
                            char chr_lower = (char)num_lower;
                            string_set.Append(chr_lower);




                        }



                    }

                    // create number 

                    if (num > 0)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            Random Rnd_upper = new Random();
                            int num_upper = Rnd_upper.Next(0, 9);

                            // หน่วงเวลาเพื่อรอ ให้ Process การสุ่มตัวเลขใน step ก่อนหน้าทำเสร็จก่อน

                            Thread.Sleep(20);
                            string_set.Append(num_upper.ToString());
                        }
                    }

                    // sort ให้ข้อมูลไม่จัดกลุ่มกัน

                    //string subpassword = string_set.ToString();
                    //var new_string = new StringBuilder();
                    int totals = string_set.Length;

                    Random numRnd = new Random();





                    // หา คีย์ในการสุ่ม
                    int Key = numRnd.Next(5, 100);

                    for (int j = 0; j < totals - 1; j++)
                    {

                        // นำ key มาบวกตำแหน่งที่ละตำแหน่งเพื่อหาตำแหน่งที่จะเลื่อนไป หากเกินตำแหน่งสุดท้ายจะกลับ
                        // มายังตำแหน่งแรกแล้วนับต่อไปเรื่อยๆ
                        int next_position = j + Key;


                        // ถ้า next position มีค่ามากกว่าจำนวน char ทั้งหมด ใน string_set
                        if (next_position > totals)
                        {

                            // ให้ทำการลบ กับจำนวนตัวอักษรทั้งหมด ใน string_set หากมีเศษเหลือให้ = ตำแหน่งที่จะย้ายไป
                            int dest_position = next_position - totals;


                            // ตรวจสอบว่าตำแหน่งที่ได้ไม่เกินตำแหน่งที่มีอยู่ใน string_set ถ้าเกินให้ คำนวณต่อ

                            while (dest_position > totals)
                            {
                                dest_position = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(dest_position / totals)));
                            }





                            // เก็บค่าตัวอักษรเดิมที่จะถูกแทนที่ไว้ในตัวแปร
                            var old_item = string_set[dest_position];

                            // ย้าย ตัวอักษรตำแหน่งปัจจุบันไปตำแหน่งใหม่
                            string_set[dest_position] = string_set[j];

                            // นำตัวอักษรเดิมก่อนย้ายไปแทนที่ในตำแหน่งปัจจุบัน

                            string_set[j] = old_item;



                        }


                        // ถ้า next position มีค่ามากกว่าจำนวน char ทั้งหมด ใน string_set
                        else if (next_position <= totals)
                        {

                            // ให้ทำการลบ กับจำนวนตัวอักษรทั้งหมด ใน string_set หากมีเศษเหลือให้ = ตำแหน่งที่จะย้ายไป
                            int dest_position2 = totals - next_position;


                            // เก็บค่าตัวอักษรเดิมที่จะถูกแทนที่ไว้ในตัวแปร
                            var old_item = string_set[dest_position2];


                            // ย้าย ตัวอักษรตำแหน่งปัจจุบันไปตำแหน่งใหม่ 
                            string_set[dest_position2] = string_set[j];


                            // นำตัวอักษรเดิมก่อนย้ายไปแทนที่ในตำแหน่งปัจจุบัน

                            string_set[j] = old_item;

                        }

                    }

                }

                return string_set.ToString();

            }
            catch (Exception)
            {
                throw;

            }


        }


        //กรณี User เปลี่ยน Password
        // สร้าง Password โดยสามารถมี ตัวอักษรภาษาอังกฤษ พิมพ์ใหญ่ / พิมพ์เล็ก / ตัวเลข / ตัวอักษรพิเศษ +  จัดกลุ่ม หรือไม่จัดกลุ่ม

        public string New_password(int total, int upper, int lower, int num, int specialcharecter)
        {
            var string_set2 = new StringBuilder(total);
            // create upper case

            if (total > 0)
            {

                if (upper > 0)
                {
                    for (int i = 0; i < upper; i++)
                    {

                        Random Rnd_upper = new Random();

                        int num_upper = Rnd_upper.Next(65, 90);

                        // หน่วงเวลาเพื่อรอ ให้ Process การสุ่มตัวเลขใน step ก่อนหน้าทำเสร็จก่อน
                        Thread.Sleep(20);

                        char chr_upper = (char)num_upper;
                        string_set2.Append(chr_upper);
                    }


                }
                // create lower case

                if (lower > 0)
                {

                    for (int i = 0; i < lower; i++)
                    {
                        Random Rnd_lower = new Random();
                        int num_lower = Rnd_lower.Next(97, 122);

                        // หน่วงเวลาเพื่อรอ ให้ Process การสุ่มตัวเลขใน step ก่อนหน้าทำเสร็จก่อน

                        Thread.Sleep(20);
                        char chr_lower = (char)num_lower;
                        string_set2.Append(chr_lower);




                    }



                }

                // create number 

                if (num > 0)
                {
                    for (int i = 0; i < num; i++)
                    {
                        Random Rnd_upper = new Random();
                        int num_upper = Rnd_upper.Next(0, 9);

                        // หน่วงเวลาเพื่อรอ ให้ Process การสุ่มตัวเลขใน step ก่อนหน้าทำเสร็จก่อน

                        Thread.Sleep(20);
                        string_set2.Append(num_upper.ToString());
                    }
                }


                //create Special charecter 
                if (specialcharecter > 0)
                {
                    char chr_special;
                    bool result = true;


                    for (int i = 0; i < specialcharecter; i++)
                    {
                        Random Rnd_special = new Random();


                        while (result = true)
                        {
                            int num_special = Rnd_special.Next(33, 64);

                            Thread.Sleep(20);

                            if (num_special == 33 || num_special == 42 || num_special == 47 || num_special == 63 || num_special == 64)
                            {

                                chr_special = (char)num_special;
                                string_set2.Append(chr_special);
                                break;


                                //string_set2.Append(num_upper.ToString());
                            }
                            else if (num_special >= 35 && num_special <= 38)
                            {
                                chr_special = (char)num_special;
                                string_set2.Append(chr_special);
                                break;
                            }
                            else
                            {
                                result = false;

                            }




                        }

                    }


                    // sort ให้ข้อมูลไม่จัดกลุ่มกัน

                    //string subpassword = string_set.ToString();
                    //var new_string = new StringBuilder();
                    int totals = string_set2.Length;

                    Random numRnd = new Random();





                    // หา คีย์ในการสุ่ม
                    int Key = numRnd.Next(5, 100);

                    for (int j = 0; j < totals - 1; j++)
                    {

                        // นำ key มาบวกตำแหน่งที่ละตำแหน่งเพื่อหาตำแหน่งที่จะเลื่อนไป หากเกินตำแหน่งสุดท้ายจะกลับ
                        // มายังตำแหน่งแรกแล้วนับต่อไปเรื่อยๆ
                        int next_position = j + Key;


                        // ถ้า next position มีค่ามากกว่าจำนวน char ทั้งหมด ใน string_set
                        if (next_position > totals)
                        {

                            // ให้ทำการลบ กับจำนวนตัวอักษรทั้งหมด ใน string_set หากมีเศษเหลือให้ = ตำแหน่งที่จะย้ายไป
                            int dest_position = next_position - totals;


                            // ตรวจสอบว่าตำแหน่งที่ได้ไม่เกินตำแหน่งที่มีอยู่ใน string_set ถ้าเกินให้ คำนวณต่อ

                            while (dest_position > totals)
                            {
                                dest_position = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(dest_position / totals)));
                            }





                            // เก็บค่าตัวอักษรเดิมที่จะถูกแทนที่ไว้ในตัวแปร
                            var old_item = string_set2[dest_position];

                            // ย้าย ตัวอักษรตำแหน่งปัจจุบันไปตำแหน่งใหม่
                            string_set2[dest_position] = string_set2[j];

                            // นำตัวอักษรเดิมก่อนย้ายไปแทนที่ในตำแหน่งปัจจุบัน

                            string_set2[j] = old_item;



                        }


                        // ถ้า next position มีค่ามากกว่าจำนวน char ทั้งหมด ใน string_set
                        else if (next_position <= totals)
                        {

                            // ให้ทำการลบ กับจำนวนตัวอักษรทั้งหมด ใน string_set หากมีเศษเหลือให้ = ตำแหน่งที่จะย้ายไป
                            int dest_position2 = totals - next_position;


                            // เก็บค่าตัวอักษรเดิมที่จะถูกแทนที่ไว้ในตัวแปร
                            var old_item = string_set2[dest_position2];


                            // ย้าย ตัวอักษรตำแหน่งปัจจุบันไปตำแหน่งใหม่ 
                            string_set2[dest_position2] = string_set2[j];


                            // นำตัวอักษรเดิมก่อนย้ายไปแทนที่ในตำแหน่งปัจจุบัน

                            string_set2[j] = old_item;

                        }

                    }



                }


            }

            return string_set2.ToString();

        }

        public bool Validate_password(string password) // upper ,lower,number,special case อย่างน้อย 1 => ขั้นต่ำ 8 ตัว
        {

            bool final_result = true;
            bool check_upper = true;
            bool check_lower = true;
            bool check_number = true;
            bool check_specialcase = true;


            //var string_buider = new StringBuilder();


            for (int i = 0; i < password.Length; i++)
            {
                int char_item = (int)(password[i]);


                // check upper
                if (char_item >= 65 && char_item <= 90)
                {
                    check_upper = true;
                    break;
                }
                else
                {
                    check_upper = false;
                }
            }


            //check lower

            for (int j = 0; j < password.Length; j++) {

                int char_item = (int)(password[j]);

                if (char_item >= 97 && char_item <= 122)
                {
                    check_lower = true;
                    break;
                }
                else
                {
                    check_lower = false;
                }
            }
            // check number 

            for (int k = 0; k < password.Length; k++)
            {
                int char_item = (int)(password[k]);


                if (char_item >= 48 && char_item <= 57)
                {
                    check_number = true;
                    break;
                }
                else
                {
                    check_number = false;
                }
            }
            //check special case

            for (int m = 0; m < password.Length; m++)
            {

                int char_item = (int)(password[m]);

                if (char_item >= 35 && char_item <= 38 || char_item >= 63 && char_item <= 64)
                {
                    check_specialcase = true;
                    break;
                }
                else if (char_item == 33 || char_item == 42 || char_item == 47)
                {
                    check_specialcase = true;
                    break;
                }
                else
                {
                    check_specialcase = false;
                }

            

            }





            // summary 
            if (check_upper == true &&  check_lower == true && check_number == true && check_specialcase == true )
            {
                final_result = true;
            }
            else
            {
                final_result = false;
            }

            return final_result;


        }
    

        // เข้ารหัส
        
        // หากต้องการ ตรวจสอบว่า password ที่ user กรอกถูกต้องหรือไม่ ให้เก็บรหัส salt ของ User ไว้ ใน database
        // เมื่อ user login เข้ามา จะนำ password ที่ user กรอก = > hash => byte แล้ว นำมาบวกกับ ค่า salt ที่เก็บไว้ ใน database
        // หากได้ค่าตรง => log in complete 
        
        //มี Overload 2 ตัว
        
        public string Hash_function(string original_password)
        {
            string Hashedpassword;
            
            var new_salt = GenerateSalt();
            
            
            //string byte_pass = Convert.ToBase64String(Encoding.UTF8.GetBytes(original_password));
            //string salt =  Convert.ToBase64String(Encoding.UTF8.GetBytes(new_salt));




            Hashedpassword = computeHash(Encoding.UTF8.GetBytes(original_password), Encoding.UTF8.GetBytes(new_salt));


            return Hashedpassword;
        }


        // กรณี User จะเข้าใช้งาน Log in 
        //Process => จะนำ password ไปหา result key เก็บในตัวแปร และนำเข้าไปในฟังก์ชั่น Hash => return ผลลัพธ์ 
        // นำผลลัพธ์มา เปรียบเทียบ password ใน database 

        public string Hash_function(string original_password,string Result_key)
        {
            string Hashedpassword;

            var new_salt = GenerateSalt();


            //string byte_pass = Convert.ToBase64String(Encoding.UTF8.GetBytes(original_password));
            //string salt =  Convert.ToBase64String(Encoding.UTF8.GetBytes(new_salt));




            Hashedpassword = computeHash(Encoding.UTF8.GetBytes(original_password), Encoding.UTF8.GetBytes(Result_key));


            return Hashedpassword;
        }









        // นำค่าที่ได้จาก การแปลง original password => byte +  key salt แล้วทำการ loop เพื่อ random ตัวเลขอีก 1000 รอบ 
        public string computeHash(byte[] bytetoHash , byte[] salt)
        {
            var byteresult = new Rfc2898DeriveBytes(bytetoHash, salt,1000);
            return Convert.ToBase64String(byteresult.GetBytes(24));
        }
    
        // generate key ของ salt  ทำงานพร้อมกับ create id_employee
        public string GenerateSalt()
        {
            var bytes = new byte[128/8];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }


        // Insert User_authen
        public void Insert_Password_Salt(string id_emp, string password_encrypt, string salt)
        {
            using (var db = new Time_AttendanceEntities())
            {
                string Id_employee = id_emp;
                string Encrypt_password = password_encrypt;
                string Salt_key = salt;


                db.Insert_authen_User(Id_employee, Encrypt_password, Salt_key);

            }
        }



        // ใช้สำหรับไม่ให้มีการเปิด ฟอร์มซ้ำ 

        public void Check_FormDuplicate(string Form_name,Form parent_form)
        {
            // ให้เช็คว่า ถ้าเปิดฟอร์มค้างอยู่ เมื่อคลิกซ้ำให้ focus ที่ฟอร์มเดิม แต่ถ้าไม่มีฟอร์มเปิดค้างจะเปิดฟอร์มใหม่ 

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == Form_name)
                {

                    isopen = true;
                    f.Focus();
                    break;
                }

            }
            if (isopen == false)
            {
                Frm_Rules frm_Rules = new Frm_Rules();
                frm_Rules.MdiParent = parent_form;
                frm_Rules.Show();



            }
        }


        //

        public void Check_FormDuplicate2(Form newform , Form parent_form)
        {
            // ให้เช็คว่า ถ้าเปิดฟอร์มค้างอยู่ เมื่อคลิกซ้ำให้ focus ที่ฟอร์มเดิม แต่ถ้าไม่มีฟอร์มเปิดค้างจะเปิดฟอร์มใหม่ 

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == newform.Text)
                {

                    isopen = true;
                    f.Focus();
                    break;
                }

            }
            if (isopen == false)
            {
                if(newform.Text == "จัดการข้อมูลพนักงาน")
                {
                    Frm_manage_Employee frm_Manage = new Frm_manage_Employee();
                    frm_Manage.MdiParent = parent_form;
                    frm_Manage.Show();
                    
                
                }
               
                


            }
        }










        //


    }











}