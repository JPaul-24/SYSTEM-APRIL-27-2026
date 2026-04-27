namespace CRUD_APP
{
    partial class StudentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentList));
            btnSearch = new Button();
            txtSearch = new TextBox();
            button1 = new Button();
            txtID = new TextBox();
            btnSave = new Button();
            txtAge = new TextBox();
            cmbSection = new ComboBox();
            cmbCourse = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            btnRefresh = new Button();
            label1 = new Label();
            dgvStudents = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Lime;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(498, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 41);
            btnSearch.TabIndex = 48;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(234, 64);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(258, 39);
            txtSearch.TabIndex = 47;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(239, 68, 68);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(795, 420);
            button1.Name = "button1";
            button1.Size = new Size(237, 43);
            button1.TabIndex = 46;
            button1.Text = "DELETE RECORD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(798, 107);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(237, 23);
            txtID.TabIndex = 45;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(795, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(237, 43);
            btnSave.TabIndex = 43;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(798, 285);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(237, 23);
            txtAge.TabIndex = 42;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(798, 250);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(237, 23);
            cmbSection.TabIndex = 40;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(798, 215);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(237, 23);
            cmbCourse.TabIndex = 38;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(798, 180);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(237, 23);
            txtLastName.TabIndex = 36;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(798, 145);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(237, 23);
            txtFirstName.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(37, 99, 235);
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(696, 148);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 33;
            label2.Text = "First Name:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(250, 204, 21);
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(798, 469);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(234, 37);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(24, 74);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 30;
            label1.Text = "STUDENT MASTER LIST";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 109);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.Size = new Size(670, 402);
            dgvStudents.TabIndex = 29;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(37, 99, 235);
            label9.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(709, 254);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 50;
            label9.Text = "Section:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(37, 99, 235);
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(726, 289);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 51;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(37, 99, 235);
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(696, 180);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 49;
            label3.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(37, 99, 235);
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(712, 219);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 52;
            label5.Text = "Course:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(37, 99, 235);
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(726, 111);
            label6.Name = "label6";
            label6.Size = new Size(29, 19);
            label6.TabIndex = 53;
            label6.Text = "ID:";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(693, 56);
            label8.Name = "label8";
            label8.Size = new Size(0, 19);
            label8.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveBorder;
            label7.Font = new Font("Dubai", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(651, 56);
            label7.Name = "label7";
            label7.Size = new Size(381, 40);
            label7.TabIndex = 32;
            label7.Text = "UPDATE STUDENT INFORMATION";
            label7.Click += label7_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(34, 197, 94);
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.FromArgb(31, 41, 55);
            btnCreate.Location = new Point(795, 314);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(237, 43);
            btnCreate.TabIndex = 55;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1044, 523);
            Controls.Add(btnCreate);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(txtID);
            Controls.Add(btnSave);
            Controls.Add(txtAge);
            Controls.Add(cmbSection);
            Controls.Add(cmbCourse);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(btnRefresh);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Name = "StudentList";
            Text = "StudentList";
            Load += StudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Button button1;
        private TextBox txtID;
        private Button btnSave;
        private TextBox txtAge;
        private ComboBox cmbSection;
        private ComboBox cmbCourse;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label2;
        private Button btnRefresh;
        private Label label1;
        private DataGridView dgvStudents;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Button btnCreate;
    }
}