
namespace Smart_Time_Attendance
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_notiUser = new System.Windows.Forms.Label();
            this.chk_showPassword = new System.Windows.Forms.CheckBox();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lnklbl_scantime = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rdb_Admin = new System.Windows.Forms.RadioButton();
            this.Rdb_emp = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(164, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 62);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 450);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(26, 421);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "เริ่มต้นใช้งาน";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_username.Location = new System.Drawing.Point(108, 53);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(67, 25);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "ชื่อผู้ใช้";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_password.Location = new System.Drawing.Point(275, 236);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(79, 25);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "รหัสผ่าน";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_notiUser);
            this.groupBox1.Controls.Add(this.chk_showPassword);
            this.groupBox1.Controls.Add(this.Txt_password);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Location = new System.Drawing.Point(181, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lbl_notiUser
            // 
            this.lbl_notiUser.AutoSize = true;
            this.lbl_notiUser.ForeColor = System.Drawing.Color.Red;
            this.lbl_notiUser.Location = new System.Drawing.Point(199, 17);
            this.lbl_notiUser.Name = "lbl_notiUser";
            this.lbl_notiUser.Size = new System.Drawing.Size(183, 20);
            this.lbl_notiUser.TabIndex = 5;
            this.lbl_notiUser.Text = "ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง";
            // 
            // chk_showPassword
            // 
            this.chk_showPassword.AutoSize = true;
            this.chk_showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chk_showPassword.Location = new System.Drawing.Point(399, 149);
            this.chk_showPassword.Name = "chk_showPassword";
            this.chk_showPassword.Size = new System.Drawing.Size(22, 21);
            this.chk_showPassword.TabIndex = 4;
            this.chk_showPassword.UseVisualStyleBackColor = true;
            this.chk_showPassword.CheckedChanged += new System.EventHandler(this.chk_showPassword_CheckedChanged);
            // 
            // Txt_password
            // 
            this.Txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Txt_password.ForeColor = System.Drawing.Color.Blue;
            this.Txt_password.Location = new System.Drawing.Point(183, 110);
            this.Txt_password.Multiline = true;
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.PasswordChar = '*';
            this.Txt_password.Size = new System.Drawing.Size(235, 35);
            this.Txt_password.TabIndex = 3;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_username.ForeColor = System.Drawing.Color.Blue;
            this.txt_username.Location = new System.Drawing.Point(183, 43);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(235, 35);
            this.txt_username.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Green;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(282, 317);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(168, 50);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(487, 317);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(168, 50);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lnklbl_scantime
            // 
            this.lnklbl_scantime.AutoSize = true;
            this.lnklbl_scantime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lnklbl_scantime.Location = new System.Drawing.Point(595, 417);
            this.lnklbl_scantime.Name = "lnklbl_scantime";
            this.lnklbl_scantime.Size = new System.Drawing.Size(172, 25);
            this.lnklbl_scantime.TabIndex = 5;
            this.lnklbl_scantime.TabStop = true;
            this.lnklbl_scantime.Text = "ลงเวลา เข้า-ออก งาน";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(666, 352);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.Rdb_Admin);
            this.panel3.Controls.Add(this.Rdb_emp);
            this.panel3.Location = new System.Drawing.Point(572, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 40);
            this.panel3.TabIndex = 7;
            // 
            // Rdb_Admin
            // 
            this.Rdb_Admin.AutoSize = true;
            this.Rdb_Admin.ForeColor = System.Drawing.Color.Transparent;
            this.Rdb_Admin.Location = new System.Drawing.Point(108, 6);
            this.Rdb_Admin.Name = "Rdb_Admin";
            this.Rdb_Admin.Size = new System.Drawing.Size(79, 24);
            this.Rdb_Admin.TabIndex = 1;
            this.Rdb_Admin.TabStop = true;
            this.Rdb_Admin.Text = "Admin";
            this.Rdb_Admin.UseVisualStyleBackColor = true;
            // 
            // Rdb_emp
            // 
            this.Rdb_emp.AutoSize = true;
            this.Rdb_emp.ForeColor = System.Drawing.Color.Transparent;
            this.Rdb_emp.Location = new System.Drawing.Point(4, 6);
            this.Rdb_emp.Name = "Rdb_emp";
            this.Rdb_emp.Size = new System.Drawing.Size(104, 24);
            this.Rdb_emp.TabIndex = 0;
            this.Rdb_emp.TabStop = true;
            this.Rdb_emp.Text = "Employee";
            this.Rdb_emp.UseVisualStyleBackColor = true;
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lnklbl_scantime);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart_Time_Attendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_login_FormClosed);
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox chk_showPassword;
        private System.Windows.Forms.LinkLabel lnklbl_scantime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_notiUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton Rdb_Admin;
        private System.Windows.Forms.RadioButton Rdb_emp;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

