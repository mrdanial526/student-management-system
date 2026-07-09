using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Student_Mangement_System
{
    public partial class Marks : Form
    {
        Form dashboard;

        SqlConnection con = new SqlConnection("Server=SMS\\SQLEXPRESS;Database=StdForm;Trusted_Connection=True;TrustServerCertificate=True;");
        int markID = 0;

        private void LoadStudents()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT StudentID FROM Students", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            comboBox2.DataSource = dt;

            comboBox2.DisplayMember = "StudentID";

            comboBox2.ValueMember = "StudentID";
        }


        private void ClearFields()
        {
            comboBox1.SelectedIndex = -1;

            comboBox2.SelectedIndex = -1;

            textBox1.Clear();

            textBox2.Clear();
        }
        private void LoadMarks()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Marks", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MarkID"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadCourses()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT CourseCode FROM Courses", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            comboBox1.DataSource = dt;

            comboBox1.DisplayMember = "CourseCode";

            comboBox1.ValueMember = "CourseCode";
        }
        public Marks(Form dash)
        {
            InitializeComponent();

            dashboard = dash;
        }

        // ================= UPDATE BUTTON =================

        private void button2_Click(object sender, EventArgs e)
        {
            // RECORD CHECK
            if (markID == 0)
            {
                MessageBox.Show("Please select a record first ❌");
                return;
            }

            // EMPTY CHECK
            if (comboBox1.Text.Trim() == "" ||
                comboBox2.Text.Trim() == "" ||
                textBox1.Text.Trim() == "" ||
                textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields ❌");
                return;
            }

            // NUMERIC VALIDATION
            if (!int.TryParse(textBox1.Text, out int obtained) ||
                !int.TryParse(textBox2.Text, out int total))
            {
                MessageBox.Show("Enter valid numeric marks ❌");
                return;
            }

            // MARKS VALIDATION
            if (obtained > total)
            {
                MessageBox.Show("Obtained marks cannot be greater than total marks ❌");
                return;
            }

            // DUPLICATE CHECK
            SqlDataAdapter checkDA = new SqlDataAdapter(
                "SELECT * FROM Marks WHERE StudentID=@StudentID AND CourseCode=@CourseCode AND MarkID<>@ID",
                con);

            checkDA.SelectCommand.Parameters.AddWithValue("@StudentID", comboBox2.Text);
            checkDA.SelectCommand.Parameters.AddWithValue("@CourseCode", comboBox1.Text);
            checkDA.SelectCommand.Parameters.AddWithValue("@ID", markID);

            DataTable checkDT = new DataTable();

            checkDA.Fill(checkDT);

            if (checkDT.Rows.Count > 0)
            {
                MessageBox.Show("This student already has marks for this course ❌");
                return;
            }

            // UPDATE
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Marks SET StudentID=@StudentID, CourseCode=@CourseCode, ObtainedMarks=@Obtained, TotalMarks=@Total WHERE MarkID=@ID",
                con);

            cmd.Parameters.AddWithValue("@StudentID", comboBox2.Text);
            cmd.Parameters.AddWithValue("@CourseCode", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Obtained", obtained);
            cmd.Parameters.AddWithValue("@Total", total);
            cmd.Parameters.AddWithValue("@ID", markID);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Updated Successfully ✔");

            LoadMarks();

            ClearFields();

            markID = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Marks_Load(object sender, EventArgs e)
        {
            LoadMarks();

            LoadStudents();

            LoadCourses();

            comboBox3.DataSource = comboBox2.DataSource;

            comboBox3.DisplayMember = "StudentID";

            comboBox3.ValueMember = "StudentID";
        }

        // ================= ADD BUTTON =================

        private void button1_Click(object sender, EventArgs e)
        {
            // EMPTY CHECK
            if (comboBox1.Text.Trim() == "" ||
                comboBox2.Text.Trim() == "" ||
                textBox1.Text.Trim() == "" ||
                textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields ❌");
                return;
            }

            // NUMERIC VALIDATION
            if (!int.TryParse(textBox1.Text, out int obtained) ||
                !int.TryParse(textBox2.Text, out int total))
            {
                MessageBox.Show("Enter valid numeric marks ❌");
                return;
            }

            // MARKS VALIDATION
            if (obtained > total)
            {
                MessageBox.Show("Obtained marks cannot be greater than total marks ❌");
                return;
            }

            // DUPLICATE CHECK
            SqlDataAdapter checkDA = new SqlDataAdapter(
                "SELECT * FROM Marks WHERE StudentID=@StudentID AND CourseCode=@CourseCode",
                con);

            checkDA.SelectCommand.Parameters.AddWithValue("@StudentID", comboBox2.Text);
            checkDA.SelectCommand.Parameters.AddWithValue("@CourseCode", comboBox1.Text);

            DataTable checkDT = new DataTable();

            checkDA.Fill(checkDT);

            if (checkDT.Rows.Count > 0)
            {
                MessageBox.Show("This student already has marks for this course ❌");
                return;
            }

            // INSERT
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Marks(StudentID,CourseCode,ObtainedMarks,TotalMarks) VALUES(@StudentID,@CourseCode,@Obtained,@Total)",
                con);

            cmd.Parameters.AddWithValue("@StudentID", comboBox2.Text);
            cmd.Parameters.AddWithValue("@CourseCode", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Obtained", obtained);
            cmd.Parameters.AddWithValue("@Total", total);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Marks Added Successfully ✔");

            LoadMarks();

            ClearFields();

            comboBox2.Focus();
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ================= DATAGRIDVIEW CELL CLICK =================

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                markID = Convert.ToInt32(row.Cells["MarkID"].Value);

                comboBox2.Text = row.Cells["StudentID"].Value.ToString();

                comboBox1.Text = row.Cells["CourseCode"].Value.ToString();

                textBox1.Text = row.Cells["ObtainedMarks"].Value.ToString();

                textBox2.Text = row.Cells["TotalMarks"].Value.ToString();
            }
        }

        // ================= DELETE BUTTON =================

        private void button3_Click(object sender, EventArgs e)
        {
            if (markID == 0)
            {
                MessageBox.Show("Please select a record first ❌");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Marks WHERE MarkID=@ID",
                con);

            cmd.Parameters.AddWithValue("@ID", markID);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Deleted Successfully ✔");

            LoadMarks();

            ClearFields();

            markID = 0;
        }

        // ================= SEARCH BUTTON =================

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Marks WHERE StudentID LIKE @ID",
                con);

            da.SelectCommand.Parameters.AddWithValue("@ID", "%" + comboBox3.Text + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["MarkID"].Visible = false;
        }

        // ================= CLEAR BUTTON =================

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            textBox1.Clear();
            textBox2.Clear();

            markID = 0;

            LoadMarks();

            comboBox2.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        
        }
    }
}

