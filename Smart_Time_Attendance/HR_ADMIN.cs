using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Time_Attendance
{
    class HR_ADMIN : Employee, Irole_Employee
    {

        
        

            private int workingdays;
            private double sickdays;
            private double vacationdays;
            private double privatedays;
            private TimeSpan scanin;
            private TimeSpan scanout;
            private TimeSpan OTtime;
            public string name_emp;


            //hr เมีหน้าที่กำหนด-เปลี่ยนแปลง ข้อปฏิบัติให้กับพนักงาน
            public void Setworking_days(int value)
            {
                workingdays = value;

            }


            public void Setsick_days(double value)
            {
                sickdays = value;


            }
            public void Setvacation_days(double value)
            {
                vacationdays = value;
            }
            public void SetPrivateleave(double value)
            {
                privatedays = value;
            }
            public void SetScanIn(TimeSpan timevalue)
            {
                scanin = timevalue;
            }
            public void SetScanout(TimeSpan timevalue)
            {
                scanout = timevalue;
            }

            public void Set_OTtime(TimeSpan timevalue)
            {
                OTtime = timevalue;
            }

            // hr มีหน้าที่ เพิ่ม -ลดพนักงาน -ดูแลข้อมูลพนักงาน

            public void Add_employee(string idemp, string firstname, string lastname, DateTime DOB
                                      , string email, string mobilephone, string position, string section
                                        , DateTime effectivedate, DateTime terminateddate, string address,string path_image) // เพิ่มข้อมูลพนักงานลงในระบบ
            {
                using (var db = new Time_AttendanceEntities())
                {

                    string id_emp = idemp;
                    string first_name = firstname;
                    string last_name = lastname;
                    DateTime date_ofbirth = DOB;
                    string e_mail = email;
                    string mobile_phone = mobilephone;
                    string positiondata = position;
                    string sectiondata = section;
                    DateTime effectivedate_emp = effectivedate;
                    DateTime terminateddate_emp = terminateddate;
                    string Address_emp = address;
                    string Path_image = path_image; 


                    db.Insert_employee_info(id_emp, first_name, last_name, DOB, email, mobile_phone
                                                , positiondata, sectiondata, effectivedate_emp, terminateddate_emp, Address_emp,Path_image);

                }
            }


            public void Print_empcard()//พิมพ์บัตรพนักงาน
            {




            }


            //public void Viewemployeeinfo(string id_emp,string Firstname_emp = "", string Lastname_emp = "") //ค้นหาข้อมูลพนักงาน
            //{

            //   // string emp_name;
            //    //string name;
            //    using (var db = new Time_AttendanceEntities())
            //    {

            //        var ds = db.View_EmpInfo(id_emp,Firstname_emp, Lastname_emp);
            //        foreach (var dt in ds)
            //        {



            //            name_emp = dt.FIRSTNAME_EMP;



            //        }





            //    }



            //public HRadmin staff;

            //}

            public struct temp_emp
            {
                public string st_id_emp;
                public string st_firstname;
                public string st_lastname;
                public DateTime st_DOB;
                public string st_email;
                public string st_mobilephone;
                public string st_position;
                public string st_section;
                public DateTime st_effectivedate;
                public DateTime st_terminatdate;
                public string sg_address;

            }


            // function return struct(temp employee)

            public temp_emp Find_employee(string id_emp, string Firstname_emp = "", string Lastname_emp = "")
            {
                using (var db = new Time_AttendanceEntities())
                {
                    var ds = db.View_EmpInfo(id_emp, Firstname_emp, Lastname_emp);
                    temp_emp staff = new temp_emp();


                    foreach (var data in ds)
                    {
                        staff.st_firstname = data.FIRSTNAME_EMP;
                        staff.st_lastname = data.LASTNAME_EMP;
                        staff.st_DOB = Convert.ToDateTime(data.DOB);
                        staff.st_email = data.EMAIL;
                        staff.st_mobilephone = data.MOBILE_PHONE;
                        staff.st_position = data.POSITION;
                        staff.st_section = data.SECTION;
                        staff.st_effectivedate = Convert.ToDateTime(data.EFFECTIVE_DATE);
                        staff.st_terminatdate = Convert.ToDateTime(data.TERMINATED_DATE);
                        staff.sg_address = data.ADDRESS_EMP;


                    }



                    return staff;




                }




            }





            public void Delete_emp(string emp_id) //ลบข้อมุลพนักงาน
            {
                using (var db = new Time_AttendanceEntities())
                {
                    var employee = db.Employee_info.Where(e => e.ID_EMP == emp_id).FirstOrDefault();

                    if (employee != null)
                    {
                        db.Employee_info.Remove(employee);
                    }

                    db.SaveChanges();

                }


            }


            public void Print_listemp() //พิมพ์รายชื่อพนักงาน
            {

            }

        }

     



    }

