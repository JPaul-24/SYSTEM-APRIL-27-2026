using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRUD_APP
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbSection.Items.AddRange(new string[] { "1A", "1B", "1C", "1D" });
            LoadStudents();
        }
        private void LoadStudents()
        {
            string search = txtSearch.Text.Trim();
            //call database connection
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT * FROM students WHERE" +
                    "firstname LIKE @search" +
                    " OR lastname LIKE @search" +
                    " OR course LIKE @search" +
                    "OR section LIKE @search";
                //CREATE MY SQL
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                //Declare dataadapter for dta table with query result
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                //Create data table
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                dgvStudents.DataSource = table;


                //chanmge collum headaer
                dgvStudents.Columns["id"].HeaderText = "Student ID";
                dgvStudents.Columns["firstname"].HeaderText = "First Name";
                dgvStudents.Columns["lastname"].HeaderText = "Last Name ";
                dgvStudents.Columns["course"].HeaderText = "Course";
                dgvStudents.Columns["section"].HeaderText = "Section";
                dgvStudents.Columns["age"].HeaderText = "Age";
                adapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                //Transfer data from table textbox
                txtID.Text = row.Cells["id"].Value.ToString();
                txtFirstName.Text = row.Cells["firstname"].Value.ToString();
                txtLastName.Text = row.Cells["lastname"].Value.ToString();
                cmbCourse.Text = row.Cells["course"].Value.ToString();
                cmbSection.Text = row.Cells["section"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DECLERATION INPUT
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string course = cmbCourse.SelectedItem.ToString();
            string section = cmbSection.SelectedItem.ToString();
            int age;
            int ID;
            //Validate inputs if empty
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(course) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill all fields");
                return;//stop the process
            }
            //validate age
            if (!int.TryParse(txtAge.Text.Trim(), out age))
            {
                MessageBox.Show("Please enter valid age");
                return;//Stop the process
            }
            //call database connection
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please enter valid age");
                return;//Stop the process

            }
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"UPDATE students  
                    SET firstname=@firstname, 
                    lastname=@lastname, 
                    course=@course 
                    section=@section
                    age=@age
                    WHERE id=@id";
                //CREATE SQL COMMAND
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //ADD PARAMETERS
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                cmd.Parameters.AddWithValue("@section", cmbSection.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                //execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Succesfulyy");
                txtID.Clear();
                txtAge.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                db.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DELETE
            int ID;
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Click to Delete Record");
                return;//Stop the process
            }
            DialogResult result = MessageBox.Show("Are you sure you want to" +
                "delete this student", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) ;
            {
                return;
            }
private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }