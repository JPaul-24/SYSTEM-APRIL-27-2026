namespace CRUD_APP
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnRegisterStudent = new Button();
            btnStudentList = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            btnTeacher = new Button();
            btnAdmin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.BackColor = Color.Purple;
            btnRegisterStudent.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStudent.ForeColor = Color.White;
            btnRegisterStudent.Location = new Point(101, 41);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(353, 76);
            btnRegisterStudent.TabIndex = 0;
            btnRegisterStudent.Text = "REGISTER STUDENT";
            btnRegisterStudent.UseVisualStyleBackColor = false;
            btnRegisterStudent.Click += btnRegisterStudent_Click;
            // 
            // btnStudentList
            // 
            btnStudentList.BackColor = Color.FromArgb(192, 0, 192);
            btnStudentList.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentList.ForeColor = Color.White;
            btnStudentList.Location = new Point(101, 141);
            btnStudentList.Name = "btnStudentList";
            btnStudentList.Size = new Size(353, 76);
            btnStudentList.TabIndex = 1;
            btnStudentList.Text = "STUDENT LIST";
            btnStudentList.UseVisualStyleBackColor = false;
            btnStudentList.Click += btnStudentList_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.System;
            btnLogout.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(64, 0, 64);
            btnLogout.Location = new Point(178, 475);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(193, 47);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "LOG-OUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnAdmin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(btnTeacher);
            panel1.Controls.Add(btnRegisterStudent);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnStudentList);
            panel1.Location = new Point(104, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 587);
            panel1.TabIndex = 4;
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = Color.FromArgb(123, 31, 162);
            btnTeacher.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacher.ForeColor = Color.White;
            btnTeacher.Location = new Point(101, 246);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(353, 76);
            btnTeacher.TabIndex = 3;
            btnTeacher.Text = "TEACHER";
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(106, 27, 154);
            btnAdmin.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(101, 351);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(353, 76);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 99, 235);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(727, 641);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterStudent;
        private Button btnStudentList;
        private Button btnLogout;
        private Panel panel1;
        private Button btnTeacher;
        private Button btnAdmin;
    }
}