namespace CRUD_APP
{
    partial class TeacherDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboard));
            textBox1 = new TextBox();
            label1 = new Label();
            txtFirst = new TextBox();
            txtForth = new TextBox();
            txtThird = new TextBox();
            txtSecond = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            lblResult = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Highlight;
            textBox1.Location = new Point(25, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "Grade Computation System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 142);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "First Quater:";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(195, 142);
            txtFirst.Multiline = true;
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(152, 34);
            txtFirst.TabIndex = 5;
            // 
            // txtForth
            // 
            txtForth.Location = new Point(195, 258);
            txtForth.Multiline = true;
            txtForth.Name = "txtForth";
            txtForth.Size = new Size(152, 34);
            txtForth.TabIndex = 6;
            // 
            // txtThird
            // 
            txtThird.Location = new Point(195, 221);
            txtThird.Multiline = true;
            txtThird.Name = "txtThird";
            txtThird.Size = new Size(152, 34);
            txtThird.TabIndex = 7;
            // 
            // txtSecond
            // 
            txtSecond.Location = new Point(195, 183);
            txtSecond.Multiline = true;
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(152, 34);
            txtSecond.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(195, 104);
            label7.Name = "label7";
            label7.Size = new Size(144, 25);
            label7.TabIndex = 12;
            label7.Text = "INPUT GRADES";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(45, 183);
            label8.Name = "label8";
            label8.Size = new Size(144, 25);
            label8.TabIndex = 13;
            label8.Text = "Second Quater:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(60, 258);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 14;
            label9.Text = "Forth Quater:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(63, 221);
            label10.Name = "label10";
            label10.Size = new Size(126, 25);
            label10.TabIndex = 15;
            label10.Text = "Third Quater:";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 358);
            button1.Name = "button1";
            button1.Size = new Size(322, 49);
            button1.TabIndex = 16;
            button1.Text = "COMPUTE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(25, 306);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(171, 25);
            lblResult.TabIndex = 17;
            lblResult.Text = "TOTAL OF GRADES";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column2, Column3 });
            dataGridView1.Location = new Point(363, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 337);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "85";
            Column1.HeaderText = "1st Quater";
            Column1.Name = "Column1";
            // 
            // Column4
            // 
            Column4.HeaderText = "2nd Quater";
            Column4.Name = "Column4";
            // 
            // Column2
            // 
            Column2.HeaderText = "3rd Quater";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "4th Quater";
            Column3.Name = "Column3";
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 500);
            Controls.Add(dataGridView1);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtSecond);
            Controls.Add(txtThird);
            Controls.Add(txtForth);
            Controls.Add(txtFirst);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "TeacherDashboard";
            Text = "TeacherDashboard";
            Load += TeacherDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox txtFirst;
        private TextBox txtForth;
        private TextBox txtThird;
        private TextBox txtSecond;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label lblResult;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}