//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Smart_Time_Attendance
//{


//    //Interface
//    public interface Iuseremployee
//    {
//        string Firstname { get; set; }
//        string Lastname { get; set; }
//        DateTime DOB { get; set; }
//        string Email { get; set; }
//        string Mobile_phone { get; set; }
//        string Position { get; set; }
//        string Section { get; set; }
//        DateTime Effectivedate { get; set; }
//        DateTime Terminateddate { get; set; }
//        string Address_emp { get; set; }
        
//        //Method 
//        void scanin();
//        void scanout();
//        void Login_system();
//        void Make_OT();
//        void Regis_Holiday();
//        void View_employeeinfo();
//        void Update_employeeinfo();
//        void Print_Personal_emp();
//    }
//    public class RoleforEmployee  //ระเบียบปฏิบัติของพนักงาน
//    {
//        private int Workingdays;
//        private TimeSpan Scan_in;
//        private TimeSpan Scan_out;
//        private TimeSpan OT_time;
//        private double Sick_DayAmount;
//        private double Vacation_DayAmount;
//        private double Private_DayAmount;
        

//        //วันทำงานขั้นต่ำ/ปี
//        public int SetWorkingDay
//        {
//            get { return Workingdays; }
//            set { Workingdays = value; }

//        }


//        //สิทธิ์วันลาป่วย
//        public double SetSickleave
//        {
//            get { return Sick_DayAmount; }
//            set { Sick_DayAmount = value; }


//        }

//        //สิทธิ์วันลาพักร้อน
//        public double SetVacationleave
//        {
//            get { return Vacation_DayAmount; }
//            set { Vacation_DayAmount = value; }


//        }

//        //สิทธิ์วันลากิจ
//        public double SetPrivateleave
//        {
//            get { return Private_DayAmount; }
//            set { Private_DayAmount = value; }

//        }


//        //เวลาเข้างาน
//        public TimeSpan SetScanIn
//        {
//            get { return Scan_in; }
//            set { SetScanIn = value; }
//        }

//        //เวลาออกงาน
//        public TimeSpan SetScanOut
//        {
//            get { return Scan_out; }
//            set { Scan_out = value; }
//        }


//        //เวลาเริ่มทำโอที
//        public TimeSpan Set_Ottime
//        {
//            get { return OT_time; }
//            set { OT_time = value; }
//        }


   



//        // HR กำหนดสิทธิ์ให้กับพนักงาน
//        public class Hradmin :RoleforEmployee,Iuseremployee
//          {

//            //สิทธิ์ของ HR ในฐานะเป็นพนักงานบริษัท
//            public string Firstname {get; set; }
//            public string Lastname { get; set; }
//            public DateTime DOB { get; set; }
//            public string Email { get; set; }
//            public string Mobile_phone { get; set; }
//            public string Position { get; set; }
//            public string Section { get; set; }
//            public DateTime Effectivedate { get; set; }
//            public DateTime Terminateddate { get; set; }
//            public string Address_emp { get; set; }
//            private string password { get; set; }

//            public void scanin() 
//            { 
            
//            }
//            public void scanout()
//            {

//            }
//            public void Login_system()
//            {

//            }
//            public void Make_OT()
//            {

//            }
//            public void Regis_Holiday()
//            {

//            }
//            public void View_employeeinfo()
//            {

//            }

//            public void Update_employeeinfo()
//            {

//            }
//            public void Print_Personal_emp()
//            {

//            }

//            public void Set_password(string value)
//            {
//                password = value;
//            }

//            //สิทธิ์ของ HR ในฐานะเป็น HR Admin 
//            public void Set_RoleworkingDay(int workinddays)  // กำหนดวันทำงาน
//            {
//                SetWorkingDay = workinddays;

//            }

//            public void Set_Rolesickdays(double sick_days) // กำหนดวันลาป่วย
//            {
//                SetSickleave = sick_days;
//            }


//            public void Set_RoleVacationdays(double vacation_days) //กำหนดวันลาพักร้อน
//            {
//                SetVacationleave = vacation_days;
//            }


                
//            public void Set_Roleprivatedays(double private_days) //กำหนดวันลากิจ
//            {
//                SetPrivateleave = private_days;
//            }
        
        
//            public void Add_employee() // เพิ่มข้อมูลพนักงานลงในระบบ
//            {

//            }
        
        
//            public void Print_empcard()//พิมพ์บัตรพนักงาน
//            {

//            }
            
            
            

            
//            public void Find_employeeinfo() //ค้นหาข้อมูลพนักงาน
//            {

//            }
        
//            public void Delete_emp() //ลบข้อมุลพนักงาน
//            {

//            }
        
        
//            public void Print_listemp() //พิมพ์รายชื่อพนักงาน
//            {

//            }


        
                    
        
        
//        }


//        public class Employee
//        {

//            public string Firstname { get; set; }
//            public string Lastname { get; set; }
//            public DateTime DOB { get; set; }
//            public string Email { get; set; }
//            public string Mobile_phone { get; set; }
//            public string Position { get; set; }
//            public string Section { get; set; }
//            public DateTime Effectivedate { get; set; }
//            public DateTime Terminateddate { get; set; }
//            public string Address_emp { get; set; }
//            private string password { get; set; }

//            public void scanin()
//            {

//            }
//            public void scanout()
//            {

//            }
//            public void Login_system()
//            {

//            }
//            public void Make_OT()
//            {

//            }
//            public void Regis_Holiday()
//            {

//            }
//            public void View_employeeinfo()
//            {

//            }

//            public void Update_employeeinfo()
//            {

//            }
//            public void Print_Personal_emp()
//            {

//            }

//            public void Set_password(string value)
//            {
//                password = value;
//            }





//        }











//    }


  







//}



