using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Student_Mangement_System
{
    public partial class Students : Form
    {
        Form dashboard;
        SqlConnection con = new SqlConnection("Server=SMS\\SQLEXPRESS;Database=StdForm;Trusted_Connection=True;TrustServerCertificate=True;");

        int selectedSrNo;
        void LoadStudentCombo()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT StudentID FROM Students", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "StudentID";
            comboBox2.ValueMember = "StudentID";
        }
        void LoadStudents()
        {

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT StudentID, StudentName, Gender, Department,SrNo FROM Students", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["SrNo"].Visible = false;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;



            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 220;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 60;

        }
        public Students(Form dash)
        {
            InitializeComponent();

            dashboard = dash;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" ||
                textBox1.Text.Trim() == "" ||
                comboBox1.Text.Trim() == "" ||
                textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields first ❌");
                return;
            }
            string studentID = textBox2.Text.Trim().ToLower();

            if (!Regex.IsMatch(studentID, @"^\d{4}-ag-\d{4,5}$"))
            {
                MessageBox.Show(
                    "Student ID must be in format: ****-ag-****",
                    "Invalid Student ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textBox2.Focus();
                return;
            }
            string studentName = textBox1.Text.Trim();

            if (!Regex.IsMatch(studentName, @"^[A-Za-z ]+$"))
            {
                MessageBox.Show(
                    "Student Name should not be empty and contain only alphabets and spaces",
                    "Invalid Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textBox1.Focus();
                return;
            }
            con.Open();

            SqlCommand checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM Students WHERE StudentID=@ID", con);

            checkCmd.Parameters.AddWithValue("@ID", textBox2.Text);

            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Student ID already exists ❌");
                con.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Students (StudentID, StudentName, Gender, Department) VALUES (@ID,@Name,@Gender,@Dept)", con);

            cmd.Parameters.AddWithValue("@ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Dept", textBox3.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Student Added ✔");

            LoadStudents();
            LoadStudentCombo();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Students_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadStudentCombo();
            this.ActiveControl = textBox2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (textBox2.Text.Trim() == "" || textBox1.Text.Trim() == "" || comboBox1.Text.Trim() == "" || textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields first ❌");
                return;
            }

            if (selectedSrNo == 0)
            {
                MessageBox.Show("Please select a record first");
                return;
            }
            string studentID = textBox2.Text.Trim().ToLower();

            studentID = studentID.Replace(" ", "");

            if (!Regex.IsMatch(studentID, @"^\d{4}-ag-\d{4}$"))
            {
                MessageBox.Show(
                    "Student ID must be in format: ****-ag-****",
                    "Invalid Student ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textBox2.Focus();
                return;
            }

            textBox2.Text = studentID;

            // NAME VALIDATION
            string studentName = textBox1.Text.Trim();

            if (!Regex.IsMatch(studentName, @"^[A-Za-z]+( [A-Za-z]+)*$"))
            {
                MessageBox.Show(
                    "Student Name should not be empty and contain only alphabets and spaces",
                    "Invalid Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textBox1.Focus();
                return;
            }
            con.Open();

            // CHECK DUPLICATE StudentID (EXCEPT CURRENT RECORD)
            SqlCommand checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM Students WHERE StudentID=@ID AND SrNo<>@SrNo", con);

            checkCmd.Parameters.AddWithValue("@ID", textBox2.Text);
            checkCmd.Parameters.AddWithValue("@SrNo", selectedSrNo);

            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                con.Close();
                MessageBox.Show("Student ID already exists ❌");
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "UPDATE Students SET StudentID=@ID, StudentName=@Name, Gender=@Gender, Department=@Dept WHERE SrNo=@SrNo", con);

            cmd.Parameters.AddWithValue("@SrNo", selectedSrNo);
            cmd.Parameters.AddWithValue("@ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Dept", textBox3.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Updated ✔");

            LoadStudents();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedSrNo = Convert.ToInt32(row.Cells["SrNo"].Value);

                textBox2.Text = row.Cells["StudentID"].Value.ToString();
                textBox1.Text = row.Cells["StudentName"].Value.ToString();
                comboBox1.Text = row.Cells["Gender"].Value.ToString();
                textBox3.Text = row.Cells["Department"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Students WHERE SrNo=@SrNo", con);

            cmd.Parameters.AddWithValue("@SrNo", selectedSrNo);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Deleted ✔");

            LoadStudents();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT StudentID, StudentName, Gender, Department, SrNo FROM Students WHERE StudentID LIKE @StudentID";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.SelectCommand.Parameters.AddWithValue("@StudentID", "%" + comboBox2.Text + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["SrNo"].Visible = false;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            selectedSrNo = 0;
            LoadStudents();

            textBox2.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            dashboard.Show();
            this.Close();
        }
    }
}

