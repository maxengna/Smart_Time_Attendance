
namespace Smart_Time_Attendance
{
    partial class Frm_manage_Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_manage_Employee));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_printCard = new System.Windows.Forms.Button();
            this.btn_print_list_emp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Id_emp = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.lbl_effective_date = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_section = new System.Windows.Forms.Label();
            this.lbl_terminated_date = new System.Windows.Forms.Label();
            this.lbl_confirm_password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_id_emp = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_section = new System.Windows.Forms.TextBox();
            this.txt_conrfirm_password = new System.Windows.Forms.TextBox();
            this.dpk_DOB = new System.Windows.Forms.DateTimePicker();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_start_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpk_terminatedate = new System.Windows.Forms.DateTimePicker();
            this.dpk_startdate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.BackColor = System.Drawing.Color.Blue;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(44, 576);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(154, 53);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "เพิ่ม";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.BackColor = System.Drawing.Color.Blue;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(205, 576);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(154, 53);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "บันทึก";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search.BackColor = System.Drawing.Color.Blue;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(367, 577);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(154, 53);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "ค้นหา";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete.BackColor = System.Drawing.Color.Blue;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(530, 577);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(154, 53);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "ลบพนักงาน";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_printCard
            // 
            this.btn_printCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_printCard.BackColor = System.Drawing.Color.Blue;
            this.btn_printCard.ForeColor = System.Drawing.Color.White;
            this.btn_printCard.Image = ((System.Drawing.Image)(resources.GetObject("btn_printCard.Image")));
            this.btn_printCard.Location = new System.Drawing.Point(690, 577);
            this.btn_printCard.Name = "btn_printCard";
            this.btn_printCard.Size = new System.Drawing.Size(154, 53);
            this.btn_printCard.TabIndex = 11;
            this.btn_printCard.Text = "พิมพ์บัตร";
            this.btn_printCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_printCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_printCard.UseVisualStyleBackColor = false;
            // 
            // btn_print_list_emp
            // 
            this.btn_print_list_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_print_list_emp.BackColor = System.Drawing.Color.Blue;
            this.btn_print_list_emp.ForeColor = System.Drawing.Color.White;
            this.btn_print_list_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_print_list_emp.Image")));
            this.btn_print_list_emp.Location = new System.Drawing.Point(850, 577);
            this.btn_print_list_emp.Name = "btn_print_list_emp";
            this.btn_print_list_emp.Size = new System.Drawing.Size(154, 53);
            this.btn_print_list_emp.TabIndex = 9;
            this.btn_print_list_emp.Text = "พิมพ์รายชื่อ";
            this.btn_print_list_emp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print_list_emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_print_list_emp.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.Controls.Add(this.dpk_startdate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Id_emp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_DOB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_position, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_effective_date, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_password, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_lastname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_email, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_address, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_section, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_terminated_date, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_confirm_password, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_id_emp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_tel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_position, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_lastname, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_email, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_address, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_section, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_conrfirm_password, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dpk_DOB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_password, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_start_search, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dpk_terminatedate, 3, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.87501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1076, 528);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // lbl_Id_emp
            // 
            this.lbl_Id_emp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Id_emp.AutoSize = true;
            this.lbl_Id_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Id_emp.Location = new System.Drawing.Point(28, 39);
            this.lbl_Id_emp.Name = "lbl_Id_emp";
            this.lbl_Id_emp.Size = new System.Drawing.Size(93, 20);
            this.lbl_Id_emp.TabIndex = 0;
            this.lbl_Id_emp.Text = "รหัสพนักงาน";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_name.Location = new System.Drawing.Point(36, 124);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(85, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "ชื่อพนักงาน";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_DOB.Location = new System.Drawing.Point(21, 195);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(100, 20);
            this.lbl_DOB.TabIndex = 2;
            this.lbl_DOB.Text = "วันเดือนปีเกิด";
            // 
            // lbl_tel
            // 
            this.lbl_tel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_tel.Location = new System.Drawing.Point(19, 266);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(102, 20);
            this.lbl_tel.TabIndex = 3;
            this.lbl_tel.Text = "เบอร์โทรศัพท์";
            // 
            // lbl_position
            // 
            this.lbl_position.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_position.AutoSize = true;
            this.lbl_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_position.Location = new System.Drawing.Point(56, 337);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(65, 20);
            this.lbl_position.TabIndex = 4;
            this.lbl_position.Text = "ตำแหน่ง";
            // 
            // lbl_effective_date
            // 
            this.lbl_effective_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_effective_date.AutoSize = true;
            this.lbl_effective_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_effective_date.Location = new System.Drawing.Point(42, 408);
            this.lbl_effective_date.Name = "lbl_effective_date";
            this.lbl_effective_date.Size = new System.Drawing.Size(79, 20);
            this.lbl_effective_date.TabIndex = 5;
            this.lbl_effective_date.Text = "วันเริ่มงาน";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_password.Location = new System.Drawing.Point(57, 481);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(64, 20);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "รหัสผ่าน";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_name.Location = new System.Drawing.Point(127, 106);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(407, 56);
            this.txt_name.TabIndex = 8;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_lastname.Location = new System.Drawing.Point(592, 124);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(66, 20);
            this.lbl_lastname.TabIndex = 15;
            this.lbl_lastname.Text = "นามสกุล";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_email.Location = new System.Drawing.Point(604, 195);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(54, 20);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "อีเมลล์";
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_address.Location = new System.Drawing.Point(563, 266);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(95, 20);
            this.lbl_address.TabIndex = 17;
            this.lbl_address.Text = "ที่อยู่พนักงาน";
            // 
            // lbl_section
            // 
            this.lbl_section.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_section.AutoSize = true;
            this.lbl_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_section.Location = new System.Drawing.Point(609, 337);
            this.lbl_section.Name = "lbl_section";
            this.lbl_section.Size = new System.Drawing.Size(49, 20);
            this.lbl_section.TabIndex = 18;
            this.lbl_section.Text = "แผนก";
            // 
            // lbl_terminated_date
            // 
            this.lbl_terminated_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_terminated_date.AutoSize = true;
            this.lbl_terminated_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_terminated_date.Location = new System.Drawing.Point(586, 408);
            this.lbl_terminated_date.Name = "lbl_terminated_date";
            this.lbl_terminated_date.Size = new System.Drawing.Size(72, 20);
            this.lbl_terminated_date.TabIndex = 19;
            this.lbl_terminated_date.Text = "วันลาออก";
            // 
            // lbl_confirm_password
            // 
            this.lbl_confirm_password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_confirm_password.AutoSize = true;
            this.lbl_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_confirm_password.Location = new System.Drawing.Point(556, 481);
            this.lbl_confirm_password.Name = "lbl_confirm_password";
            this.lbl_confirm_password.Size = new System.Drawing.Size(102, 20);
            this.lbl_confirm_password.TabIndex = 20;
            this.lbl_confirm_password.Text = "ยืนยันรหัสผ่าน";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightYellow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(774, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // txt_id_emp
            // 
            this.txt_id_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_id_emp.Location = new System.Drawing.Point(127, 21);
            this.txt_id_emp.Multiline = true;
            this.txt_id_emp.Name = "txt_id_emp";
            this.txt_id_emp.Size = new System.Drawing.Size(407, 56);
            this.txt_id_emp.TabIndex = 21;
            // 
            // txt_tel
            // 
            this.txt_tel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_tel.Location = new System.Drawing.Point(127, 248);
            this.txt_tel.Multiline = true;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(407, 56);
            this.txt_tel.TabIndex = 23;
            // 
            // txt_position
            // 
            this.txt_position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_position.Location = new System.Drawing.Point(127, 319);
            this.txt_position.Multiline = true;
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(407, 56);
            this.txt_position.TabIndex = 24;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_lastname.Location = new System.Drawing.Point(664, 106);
            this.txt_lastname.Multiline = true;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(409, 56);
            this.txt_lastname.TabIndex = 27;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_email.Location = new System.Drawing.Point(664, 177);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(409, 56);
            this.txt_email.TabIndex = 26;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_address.Location = new System.Drawing.Point(664, 248);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(409, 56);
            this.txt_address.TabIndex = 28;
            // 
            // txt_section
            // 
            this.txt_section.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_section.Location = new System.Drawing.Point(664, 319);
            this.txt_section.Multiline = true;
            this.txt_section.Name = "txt_section";
            this.txt_section.Size = new System.Drawing.Size(409, 56);
            this.txt_section.TabIndex = 30;
            // 
            // txt_conrfirm_password
            // 
            this.txt_conrfirm_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_conrfirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_conrfirm_password.Location = new System.Drawing.Point(664, 463);
            this.txt_conrfirm_password.Multiline = true;
            this.txt_conrfirm_password.Name = "txt_conrfirm_password";
            this.txt_conrfirm_password.PasswordChar = '*';
            this.txt_conrfirm_password.Size = new System.Drawing.Size(409, 56);
            this.txt_conrfirm_password.TabIndex = 31;
            // 
            // dpk_DOB
            // 
            this.dpk_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dpk_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dpk_DOB.Location = new System.Drawing.Point(127, 191);
            this.dpk_DOB.Name = "dpk_DOB";
            this.dpk_DOB.Size = new System.Drawing.Size(407, 28);
            this.dpk_DOB.TabIndex = 33;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_password.Location = new System.Drawing.Point(127, 463);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(407, 56);
            this.txt_password.TabIndex = 32;
            // 
            // btn_start_search
            // 
            this.btn_start_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_start_search.BackColor = System.Drawing.Color.Green;
            this.btn_start_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_start_search.Image")));
            this.btn_start_search.Location = new System.Drawing.Point(540, 27);
            this.btn_start_search.Name = "btn_start_search";
            this.btn_start_search.Size = new System.Drawing.Size(75, 44);
            this.btn_start_search.TabIndex = 34;
            this.btn_start_search.UseVisualStyleBackColor = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(1379, -6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 44);
            this.btn_refresh.TabIndex = 35;
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 632);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1265, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 632);
            this.panel2.TabIndex = 37;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear.BackColor = System.Drawing.Color.Blue;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.Location = new System.Drawing.Point(1010, 577);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(154, 53);
            this.btn_clear.TabIndex = 38;
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(48, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 568);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // dpk_terminatedate
            // 
            this.dpk_terminatedate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dpk_terminatedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dpk_terminatedate.Location = new System.Drawing.Point(664, 404);
            this.dpk_terminatedate.Name = "dpk_terminatedate";
            this.dpk_terminatedate.Size = new System.Drawing.Size(409, 28);
            this.dpk_terminatedate.TabIndex = 35;
            // 
            // dpk_startdate
            // 
            this.dpk_startdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dpk_startdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dpk_startdate.Location = new System.Drawing.Point(127, 404);
            this.dpk_startdate.Name = "dpk_startdate";
            this.dpk_startdate.Size = new System.Drawing.Size(407, 26);
            this.dpk_startdate.TabIndex = 36;
            // 
            // Frm_manage_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1283, 632);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_print_list_emp);
            this.Controls.Add(this.btn_printCard);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1305, 688);
            this.Name = "Frm_manage_Employee";
            this.Text = "จัดการข้อมูลพนักงาน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_manage_Employee_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_printCard;
        private System.Windows.Forms.Button btn_print_list_emp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Id_emp;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label lbl_effective_date;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_section;
        private System.Windows.Forms.Label lbl_terminated_date;
        private System.Windows.Forms.Label lbl_confirm_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_id_emp;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_section;
        private System.Windows.Forms.TextBox txt_conrfirm_password;
        private System.Windows.Forms.DateTimePicker dpk_DOB;
        private System.Windows.Forms.Button btn_start_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpk_startdate;
        private System.Windows.Forms.DateTimePicker dpk_terminatedate;
    }
}