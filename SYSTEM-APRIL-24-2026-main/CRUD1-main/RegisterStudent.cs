using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRUD_APP
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {

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
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "INSERT INTO students (firstname,lastname,course,section,age) VALUES(@firstname,@lastname,@course,@section,@age) ";
                //CREATE SQL COMMAND
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //ADD PARAMETERS
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@age", age);
                //execute cmd
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added succesfully");
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
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
