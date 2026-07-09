using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Student_Mangement_System
{
    public partial class Result : Form
    {
        Form dashboard;
        string userType;
        PrintDocument printDocument = new PrintDocument();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        public Result(Form dash, string type)
        {
            InitializeComponent();

            dashboard = dash;
            userType = type;

            printDocument.PrintPage += PrintDocument_PrintPage;
            this.Load += Result_Load_1;

            // IMPORTANT DEFAULT STATE
            label13.Visible = false;
        }

        // DATABASE CONNECTION
        SqlConnection con = new SqlConnection(
        @"Server=SMS\SQLEXPRESS;Database=StdForm;Trusted_Connection=True;TrustServerCertificate=True;");

        private void ResetUI()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            dataGridView1.DataSource = null;

            label11.Text = "Overall Grade : ";
            label12.Text = "Overall Percentage : ";

            label13.Text = "";
            label13.Visible = false;

            ClearFields();
        }
        private void PrintDocument_PrintPage(
object sender,
PrintPageEventArgs e)
        {
            Font titleFont =
            new Font("Arial", 20, FontStyle.Bold);

            Font headerFont =
            new Font("Arial", 12, FontStyle.Bold);

            Font dataFont =
            new Font("Arial", 11, FontStyle.Regular);

            int currentY = 50;

            // TITLE
            if (e.Graphics != null && titleFont != null)
            {
                e.Graphics.DrawString(
                    "Student Result Report",
                    titleFont,
                    Brushes.DarkBlue,
                    250,
                    currentY);
            }

            currentY += 60;

            // STUDENT NAME
            e.Graphics.DrawString(
            label13.Text,
            headerFont,
            Brushes.Black,
            50,
            currentY);

            currentY += 30;

            // OVERALL PERCENTAGE
            e.Graphics.DrawString(
            label12.Text,
            headerFont,
            Brushes.Black,
            50,
            currentY);

            currentY += 30;

            // OVERALL GRADE
            e.Graphics.DrawString(
            label11.Text,
            headerFont,
            Brushes.Black,
            50,
            currentY);

            currentY += 50;

            int codeX = 30;
            int nameX = 140;
            int obtainedX = 480;
            int totalX = 580;
            int percentageX = 670;
            int gradeX = 780;

            // TABLE HEADERS
            e.Graphics.DrawString(
            "Course Code",
            headerFont,
            Brushes.Black,
            codeX,
            currentY);

            e.Graphics.DrawString(
            "Course Name",
            headerFont,
            Brushes.Black,
            nameX,
            currentY);

            e.Graphics.DrawString(
            "Obtained",
            headerFont,
            Brushes.Black,
            obtainedX,
            currentY);

            e.Graphics.DrawString(
            "Total",
            headerFont,
            Brushes.Black,
            totalX,
            currentY);

            e.Graphics.DrawString(
            "Percentage",
            headerFont,
            Brushes.Black,
            percentageX,
            currentY);

            e.Graphics.DrawString(
            "Grade",
            headerFont,
            Brushes.Black,
            gradeX,
            currentY);

            currentY += 30;

            // LINE
            e.Graphics.DrawLine(
            Pens.Black,
            30,
            currentY,
            800,
            currentY);

            currentY += 15;

            // STRING FORMAT
            StringFormat format = new StringFormat();

            format.Trimming =
            StringTrimming.EllipsisCharacter;

            format.FormatFlags =
            StringFormatFlags.NoWrap;

            // PRINT DATA
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string code =
                row.Cells["CourseCode"].Value?.ToString() ?? "";

                string name =
                row.Cells["CourseName"].Value?.ToString() ?? "";

                string obtained =
                row.Cells["ObtainedMarks"].Value?.ToString() ?? "";

                string total =
                row.Cells["TotalMarks"].Value?.ToString() ?? "";

                string percentage =
                row.Cells["Percentage"].Value?.ToString() ?? "";

                string grade =
                row.Cells["Grade"].Value?.ToString() ?? "";

                RectangleF nameRect =
                    new RectangleF(
                    nameX,
                    currentY,
                    320,
                    25);

                // DRAW DATA
                e.Graphics.DrawString(
                code,
                dataFont,
                Brushes.Black,
                codeX,
                currentY);

                e.Graphics.DrawString(
                name,
                dataFont,
                Brushes.Black,
                nameRect,
                format);

                e.Graphics.DrawString(
                obtained,
                dataFont,
                Brushes.Black,
                obtainedX,
                currentY);

                e.Graphics.DrawString(
                total,
                dataFont,
                Brushes.Black,
                totalX,
                currentY);

                e.Graphics.DrawString(
                percentage,
                dataFont,
                Brushes.Black,
                percentageX,
                currentY);

                e.Graphics.DrawString(
                grade,
                dataFont,
                Brushes.Black,
                gradeX,
                currentY);

                currentY += 30;
            }
        }
        // FORM LOAD
        private void Result_Load_1(object? sender, EventArgs e)
        {
            LoadStudents();
            LoadCourses();

            // DATAGRIDVIEW SETTINGS
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        }

        // LOAD STUDENT IDS
        private void LoadStudents()
        {
            try
            {
                SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT StudentID FROM Students", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "StudentID";
                comboBox2.ValueMember = "StudentID";

                comboBox2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // LOAD COURSE CODES
        private void LoadCourses()
        {
            try
            {
                SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT CourseCode FROM Courses", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "CourseCode";
                comboBox1.ValueMember = "CourseCode";

                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // SHOW SINGLE RESULT
        private void button1_Click(object sender, EventArgs e)
        {
            label13.Visible = false;
            label13.Text = "";
            // VALIDATION
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Student ID");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Course Code");
                return;
            }

            try
            {
                string query = @"
                SELECT
                Students.StudentName,
                Courses.CourseName,
                Marks.ObtainedMarks,
                Marks.TotalMarks

                FROM Marks

                INNER JOIN Students
                ON Marks.StudentID = Students.StudentID

                INNER JOIN Courses
                ON Marks.CourseCode = Courses.CourseCode

                WHERE Marks.StudentID = @StudentID
                AND Marks.CourseCode = @CourseCode";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                "@StudentID", comboBox2.Text);

                cmd.Parameters.AddWithValue(
                "@CourseCode", comboBox1.Text);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // STUDENT NAME
                    textBox5.Text =
                    dr["StudentName"].ToString();

                    // COURSE NAME
                    textBox7.Text =
                    dr["CourseName"].ToString();

                    // MARKS
                    int obtained =
                    Convert.ToInt32(
                    dr["ObtainedMarks"]);

                    int total =
                    Convert.ToInt32(
                    dr["TotalMarks"]);

                    textBox1.Text =
                    obtained.ToString();

                    textBox2.Text =
                    total.ToString();

                    // PERCENTAGE
                    double per =
                    (obtained * 100.0) / total;

                    textBox3.Text =
                    per.ToString("0.00") + "%";

                    // GRADE
                    if (per >= 80)
                        textBox4.Text = "A+";
                    else if (per >= 70)
                        textBox4.Text = "A";
                    else if (per >= 60)
                        textBox4.Text = "B";
                    else if (per >= 50)
                        textBox4.Text = "C";
                    else
                        textBox4.Text = "Fail";
                }
                else
                {
                    MessageBox.Show("No Record Found");

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // SHOW COMPLETE RESULT
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please Enter Student ID");
                return;
            }

            try
            {
                string query = @"
        SELECT
        Courses.CourseCode,
        Courses.CourseName,
        Marks.ObtainedMarks,
        Marks.TotalMarks,

        CAST(
        (Marks.ObtainedMarks * 100.0)
        / Marks.TotalMarks AS DECIMAL(10,2)
        ) AS Percentage,

        CASE
        WHEN (Marks.ObtainedMarks * 100.0 / Marks.TotalMarks) >= 80 THEN 'A+'
        WHEN (Marks.ObtainedMarks * 100.0 / Marks.TotalMarks) >= 70 THEN 'A'
        WHEN (Marks.ObtainedMarks * 100.0 / Marks.TotalMarks) >= 60 THEN 'B'
        WHEN (Marks.ObtainedMarks * 100.0 / Marks.TotalMarks) >= 50 THEN 'C'
        ELSE 'Fail'
        END AS Grade

        FROM Marks
        INNER JOIN Students ON Marks.StudentID = Students.StudentID
        INNER JOIN Courses ON Marks.CourseCode = Courses.CourseCode
        WHERE Marks.StudentID = @StudentID";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue("@StudentID", textBox6.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // ❗ CHECK FIRST
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student marks  not exist");

                    dataGridView1.DataSource = null;

                    label11.Text = "Overall Grade : ";
                    label12.Text = "Overall Percentage : ";

                    label13.Visible = false;
                    label13.Text = "";

                    return;
                }

                // SHOW DATA
                dataGridView1.DataSource = dt;

                // GET STUDENT NAME
                string studentName = "";

                string nameQuery =
                    "SELECT StudentName FROM Students WHERE StudentID=@StudentID";

                SqlCommand cmd = new SqlCommand(nameQuery, con);
                cmd.Parameters.AddWithValue("@StudentID", textBox6.Text);

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null)
                {
                    studentName = result.ToString();
                }

                // ✔ NOW SHOW LABEL (ONLY WHEN VALID)
                label13.Visible = true;
                label13.Text = "Student Name : " + studentName;

                // SHOW DATA
                dataGridView1.DataSource = dt;

                // OVERALL PERCENTAGE
                double totalObtained = 0;
                double totalMarks = 0;

                foreach (DataGridViewRow row
                in dataGridView1.Rows)
                {
                    if (row.Cells["ObtainedMarks"].Value != null)
                    {
                        totalObtained +=
                        Convert.ToDouble(
                        row.Cells["ObtainedMarks"].Value);

                        totalMarks +=
                        Convert.ToDouble(
                        row.Cells["TotalMarks"].Value);
                    }
                }

                double overallPer = 0;

                if (totalMarks > 0)
                {
                    overallPer =
                    (totalObtained * 100.0) / totalMarks;
                }

                label12.Text =
                "Overall Percentage : " +
                overallPer.ToString("0.00") + "%";

                // OVERALL GRADE
                if (overallPer >= 80)
                    label11.Text = "Overall Grade : A+";
                else if (overallPer >= 70)
                    label11.Text = "Overall Grade : A";
                else if (overallPer >= 60)
                    label11.Text = "Overall Grade : B";
                else if (overallPer >= 50)
                    label11.Text = "Overall Grade : C";
                else
                    label11.Text = "Overall Grade : Fail";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CLEAR BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            ResetUI();

            comboBox2.Focus();
        }

        // CLEAR TEXTBOXES
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
        }

        // BACK BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            if (userType == "Student")
            {
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Close();
            }
            else
            {
                dashboard.Show();
                this.Close();
            }
        }

        // OPTIONAL GRID CLICK
        private void dataGridView1_CellContentClick(
        object sender,
        DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }
}