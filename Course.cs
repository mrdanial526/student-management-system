using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Student_Mangement_System
{
    public partial class Course : Form
    {
        Form dashboard;

        string connectionString = "Server=SMS\\SQLEXPRESS;Database=StdForm;Trusted_Connection=True;TrustServerCertificate=True;";
        int selectedCourseID = 0;

        // Course Code Validation: CS-402, CSSCS-4023 etc.
        bool IsValidCourseCode(string code)
        {
            return Regex.IsMatch(code, @"^[A-Za-z]+-\d+$");
        }

        // Course Name Validation: only letters and spaces
        bool IsValidCourseName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Za-z\s]+$");
        }
        public Course(Form dash)
        {
            InitializeComponent();
            dashboard = dash;
            LoadCourses();
            LoadCourseNames();
            this.ActiveControl = textBox3;
        }

        // ================= LOAD COURSES =================
        void LoadCourses()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT CourseCode, CourseName, CreditHours, Department, Semester, CourseID FROM Courses", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AllowUserToAddRows = false;

                dataGridView1.Columns["CourseID"].Visible = false;

                textBox3.Focus();
            }
        }

        // ================= LOAD COURSE NAMES =================
        void LoadCourseNames()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT DISTINCT CourseName FROM Courses", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "CourseName";
                comboBox3.ValueMember = "CourseName";
                comboBox3.SelectedIndex = -1;
            }
        }

        // ================= ADD COURSE =================
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == "" || textBox1.Text.Trim() == "" ||
                combo1.Text.Trim() == "" || comboBox1.Text.Trim() == "" ||
                comboBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields first ❌");
                return;
            }
            string code = textBox3.Text.Trim();
            string name = textBox1.Text.Trim();

            if (!IsValidCourseCode(code))
            {
                MessageBox.Show("Invalid Course Code ❌ Format should be like CS-402 or CSSCS-4023");
                return;
            }

            if (!IsValidCourseName(name))
            {
                MessageBox.Show("Course Name must contain only letters and spaces ❌");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Courses WHERE CourseCode=@code OR CourseName=@name", con);

                checkCmd.Parameters.AddWithValue("@code", textBox3.Text.Trim());
                checkCmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This course already exists ❌");
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Courses (CourseCode, CourseName, CreditHours, Department, Semester) " +
                    "VALUES (@code,@name,@credit,@dept,@sem)", con);

                cmd.Parameters.AddWithValue("@code", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@credit", combo1.Text.Trim());
                cmd.Parameters.AddWithValue("@dept", comboBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@sem", comboBox2.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course Added ✔");
            LoadCourses();
        }

        // ================= UPDATE COURSE =================
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Please select a course first");
                return;
            }
            string code = textBox3.Text.Trim();
            string name = textBox1.Text.Trim();

            if (!IsValidCourseCode(code))
            {
                MessageBox.Show("Invalid Course Code ❌ Format: CS-402");
                return;
            }

            if (!IsValidCourseName(name))
            {
                MessageBox.Show("Course Name must contain only letters and spaces ❌");
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Courses WHERE (CourseCode=@code OR CourseName=@name) AND CourseID<>@id", con);

                checkCmd.Parameters.AddWithValue("@code", textBox3.Text.Trim());
                checkCmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                checkCmd.Parameters.AddWithValue("@id", selectedCourseID);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Course Code or Name already exists ❌");
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Courses SET CourseCode=@code, CourseName=@name, CreditHours=@credit, Department=@dept, Semester=@sem " +
                    "WHERE CourseID=@id", con);

                cmd.Parameters.AddWithValue("@id", selectedCourseID);
                cmd.Parameters.AddWithValue("@code", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@credit", combo1.Text.Trim());
                cmd.Parameters.AddWithValue("@dept", comboBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@sem", comboBox2.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Updated ✔");
            LoadCourses();
        }

        // ================= DELETE COURSE =================
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Select a course first");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Courses WHERE CourseID=@id", con);

                cmd.Parameters.AddWithValue("@id", selectedCourseID);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Deleted ✔");
            LoadCourses();
        }

        // ================= SEARCH =================
        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Courses WHERE CourseName LIKE @name", con);

                da.SelectCommand.Parameters.AddWithValue("@name", "%" + comboBox3.Text.Trim() + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        // ================= RESET =================
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();

            combo1.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            selectedCourseID = 0;

            LoadCourses();
            textBox3.Focus();
        }

        // ================= GRID SELECT =================
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox3.Text = row.Cells["CourseCode"].Value.ToString();
                textBox1.Text = row.Cells["CourseName"].Value.ToString();
                combo1.Text = row.Cells["CreditHours"].Value.ToString();
                comboBox1.Text = row.Cells["Department"].Value.ToString();
                comboBox2.Text = row.Cells["Semester"].Value.ToString();

                selectedCourseID = Convert.ToInt32(row.Cells["CourseID"].Value);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        }
    }
}