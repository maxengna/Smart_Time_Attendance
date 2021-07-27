
namespace Smart_Time_Attendance
{
    partial class Frmmain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tstrip_profile = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_OT = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_leave = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_report = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานลงเวลาเขาออกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานทำงานลวงเวลาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานวนหยดToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_about = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_rule = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_lockout = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_manageEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_user_active = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrip_profile,
            this.tstrip_OT,
            this.tstrip_leave,
            this.tstrip_report,
            this.tstrip_changePassword,
            this.tstrip_about,
            this.tstrip_rule,
            this.tstrip_lockout,
            this.tstrip_manageEmp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1356, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tstrip_profile
            // 
            this.tstrip_profile.BackColor = System.Drawing.Color.DarkCyan;
            this.tstrip_profile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrip_profile.ForeColor = System.Drawing.Color.White;
            this.tstrip_profile.Name = "tstrip_profile";
            this.tstrip_profile.Size = new System.Drawing.Size(144, 30);
            this.tstrip_profile.Text = "ข้อมูลพนักงาน";
            // 
            // tstrip_OT
            // 
            this.tstrip_OT.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tstrip_OT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrip_OT.ForeColor = System.Drawing.Color.White;
            this.tstrip_OT.Name = "tstrip_OT";
            this.tstrip_OT.Size = new System.Drawing.Size(148, 30);
            this.tstrip_OT.Text = "ทำงานล่วงเวลา";
            // 
            // tstrip_leave
            // 
            this.tstrip_leave.BackColor = System.Drawing.Color.ForestGreen;
            this.tstrip_leave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrip_leave.ForeColor = System.Drawing.Color.White;
            this.tstrip_leave.Name = "tstrip_leave";
            this.tstrip_leave.Size = new System.Drawing.Size(109, 30);
            this.tstrip_leave.Text = "รายการลา";
            // 
            // tstrip_report
            // 
            this.tstrip_report.BackColor = System.Drawing.Color.LimeGreen;
            this.tstrip_report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รายงานลงเวลาเขาออกงานToolStripMenuItem,
            this.รายงานทำงานลวงเวลาToolStripMenuItem,
            this.รายงานวนหยดToolStripMenuItem});
            this.tstrip_report.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrip_report.ForeColor = System.Drawing.Color.White;
            this.tstrip_report.Name = "tstrip_report";
            this.tstrip_report.Size = new System.Drawing.Size(89, 30);
            this.tstrip_report.Text = "รายงาน";
            // 
            // รายงานลงเวลาเขาออกงานToolStripMenuItem
            // 
            this.รายงานลงเวลาเขาออกงานToolStripMenuItem.Name = "รายงานลงเวลาเขาออกงานToolStripMenuItem";
            this.รายงานลงเวลาเขาออกงานToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.รายงานลงเวลาเขาออกงานToolStripMenuItem.Text = "รายงานลงเวลาเข้า -ออกงาน";
            // 
            // รายงานทำงานลวงเวลาToolStripMenuItem
            // 
            this.รายงานทำงานลวงเวลาToolStripMenuItem.Name = "รายงานทำงานลวงเวลาToolStripMenuItem";
            this.รายงานทำงานลวงเวลาToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.รายงานทำงานลวงเวลาToolStripMenuItem.Text = "รายงานทำงานล่วงเวลา";
            // 
            // รายงานวนหยดToolStripMenuItem
            // 
            this.รายงานวนหยดToolStripMenuItem.Name = "รายงานวนหยดToolStripMenuItem";
            this.รายงานวนหยดToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.รายงานวนหยดToolStripMenuItem.Text = "รายงานวันหยุด";
            // 
            // tstrip_changePassword
            // 
            this.tstrip_changePassword.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tstrip_changePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrip_changePassword.ForeColor = System.Drawing.Color.White;
            this.tstrip_changePassword.Name = "tstrip_changePassword";
            this.tstrip_changePassword.Size = new System.Drawing.Size(112, 30);
            this.tstrip_changePassword.Text = "เปลี่ยนรหัส";
            // 
            // tstrip_about
            // 
            this.tstrip_about.BackColor = System.Drawing.Color.RoyalBlue;
            this.tstrip_about.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrip_about.ForeColor = System.Drawing.Color.White;
            this.tstrip_about.Name = "tstrip_about";
            this.tstrip_about.Size = new System.Drawing.Size(88, 30);
            this.tstrip_about.Text = "เกี่ยวกับ";
            // 
            // tstrip_rule
            // 
            this.tstrip_rule.BackColor = System.Drawing.Color.MediumBlue;
            this.tstrip_rule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrip_rule.ForeColor = System.Drawing.Color.White;
            this.tstrip_rule.Name = "tstrip_rule";
            this.tstrip_rule.Size = new System.Drawing.Size(128, 30);
            this.tstrip_rule.Text = "ระเบียบปฎิบัติ";
            this.tstrip_rule.Click += new System.EventHandler(this.tstrip_rule_Click);
            // 
            // tstrip_lockout
            // 
            this.tstrip_lockout.BackColor = System.Drawing.Color.Red;
            this.tstrip_lockout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrip_lockout.ForeColor = System.Drawing.Color.White;
            this.tstrip_lockout.Name = "tstrip_lockout";
            this.tstrip_lockout.Size = new System.Drawing.Size(130, 30);
            this.tstrip_lockout.Text = "ออกจากระบบ";
            // 
            // tstrip_manageEmp
            // 
            this.tstrip_manageEmp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstrip_manageEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstrip_manageEmp.ForeColor = System.Drawing.Color.White;
            this.tstrip_manageEmp.Name = "tstrip_manageEmp";
            this.tstrip_manageEmp.Size = new System.Drawing.Size(195, 30);
            this.tstrip_manageEmp.Text = "จัดการข้อมูลพนักงาน";
            this.tstrip_manageEmp.Click += new System.EventHandler(this.tstrip_manageEmp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 617);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.lbl_user_active);
            this.panel2.Controls.Add(this.lbl_timer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(136, 616);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 37);
            this.panel2.TabIndex = 3;
            // 
            // timer1
            // 
            //this.timer1.Enabled = true;
            //this.timer1.Interval = 5;
            //this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_timer.Location = new System.Drawing.Point(1020, 8);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(84, 20);
            this.lbl_timer.TabIndex = 0;
            this.lbl_timer.Text = "00:00:00 ";
            // 
            // lbl_user_active
            // 
            this.lbl_user_active.AutoSize = true;
            this.lbl_user_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_user_active.Location = new System.Drawing.Point(912, 8);
            this.lbl_user_active.Name = "lbl_user_active";
            this.lbl_user_active.Size = new System.Drawing.Size(106, 20);
            this.lbl_user_active.TabIndex = 1;
            this.lbl_user_active.Text = "Active_User";
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ยินดีต้อนรับเข้าสู่โปรแกรม Smart Time Attendance ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmmain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tstrip_profile;
        private System.Windows.Forms.ToolStripMenuItem tstrip_OT;
        private System.Windows.Forms.ToolStripMenuItem tstrip_leave;
        private System.Windows.Forms.ToolStripMenuItem tstrip_report;
        private System.Windows.Forms.ToolStripMenuItem tstrip_changePassword;
        private System.Windows.Forms.ToolStripMenuItem tstrip_about;
        private System.Windows.Forms.ToolStripMenuItem tstrip_rule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem รายงานลงเวลาเขาออกงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายงานทำงานลวงเวลาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายงานวนหยดToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstrip_lockout;
        private System.Windows.Forms.ToolStripMenuItem tstrip_manageEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_user_active;
    }
}