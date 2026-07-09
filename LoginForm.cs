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

namespace Student_Mangement_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Empty field validation
            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter Username and Password",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Admin Login
            if (username == "admin" && password == "dani")
            {
                Dashboard db = new Dashboard("Admin");
                db.Show();

                this.Hide();
                return;
            }

            // Student Login
            try
            {
                SqlConnection con = new SqlConnection(
                 "Server=SMS\\SQLEXPRESS;Database=StdForm;Trusted_Connection=True;TrustServerCertificate=True;");
                {
                    con.Open();

                    string query = @"SELECT COUNT(*) 
                             FROM Students
                             WHERE StudentName = @StudentName
                             AND StudentID = @StudentID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@StudentName", username);
                    cmd.Parameters.AddWithValue("@StudentID", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        Result rf = new Result(null, "Student");
                        rf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Incorrect Username or Password",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.ActiveControl = textBox1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                button1.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                button1.Text = "Show";
            }
        }
    }
    
}
