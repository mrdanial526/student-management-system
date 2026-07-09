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
    public partial class Dashboard : Form
    {
        string userRole;
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string role)
        {
            InitializeComponent();
            userRole = role;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();

                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students sr = new Students(this);
            sr.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Course cf = new Course(this);
            cf.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Marks mf = new Marks(this);
            mf.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Result rf = new Result(this, "Admin");
            rf.Show();
            this.Hide();
        }
    }


}
