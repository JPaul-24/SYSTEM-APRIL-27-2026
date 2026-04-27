namespace CRUD_APP
{
    partial class RegisterStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudent));
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            label5 = new Label();
            txtAge = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(463, 36);
            label1.TabIndex = 0;
            label1.Text = "REGISTER STUDENT INFORMATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(132, 89);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(132, 113);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(237, 29);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(132, 169);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(237, 29);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(132, 145);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 3;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(132, 201);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 5;
            label4.Text = "Course:";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "ACT", "BSOA", "HM" });
            cmbCourse.Location = new Point(132, 225);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(237, 29);
            cmbCourse.TabIndex = 6;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "1A", "1B", "1C", "1D" });
            cmbSection.Location = new Point(132, 281);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(237, 29);
            cmbSection.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(132, 257);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 7;
            label5.Text = "Section:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(132, 337);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(237, 29);
            txtAge.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(132, 313);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 9;
            label6.Text = "Age:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(132, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(237, 43);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(cmbSection);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(cmbCourse);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(176, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 441);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(676, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 441);
            panel2.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(142, 250);
            button1.Name = "button1";
            button1.Size = new Size(136, 59);
            button1.TabIndex = 2;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(109, 201);
            label8.Name = "label8";
            label8.Size = new Size(204, 21);
            label8.TabIndex = 1;
            label8.Text = "Already have an account?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(103, 131);
            label7.Name = "label7";
            label7.Size = new Size(210, 47);
            label7.TabIndex = 0;
            label7.Text = "Get Started";
            label7.Click += label7_Click;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1275, 586);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            Load += RegisterStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
        private Label label5;
        private TextBox txtAge;
        private Label label6;
        private Button btnSave;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Button button1;
        private Label label8;
    }
}