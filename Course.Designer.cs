namespace Student_Mangement_System
{
    partial class Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            combo1 = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel5 = new Panel();
            comboBox3 = new ComboBox();
            button4 = new Button();
            label8 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 84);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(430, 91);
            panel4.Name = "panel4";
            panel4.Size = new Size(585, 28);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(441, 20);
            label1.Name = "label1";
            label1.Size = new Size(295, 36);
            label1.TabIndex = 0;
            label1.Text = "Course Mangement";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 540);
            panel3.Name = "panel3";
            panel3.Size = new Size(1075, 15);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 161);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 17;
            label2.Text = "Course Code :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 22);
            textBox1.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 22);
            textBox3.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 346);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 20;
            label4.Text = "Semester :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 297);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 21;
            label5.Text = "Department :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 249);
            label6.Name = "label6";
            label6.Size = new Size(109, 19);
            label6.TabIndex = 22;
            label6.Text = "Credit Hours :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 207);
            label7.Name = "label7";
            label7.Size = new Size(123, 19);
            label7.TabIndex = 23;
            label7.Text = "Course Name :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // combo1
            // 
            combo1.DropDownStyle = ComboBoxStyle.DropDownList;
            combo1.FormattingEnabled = true;
            combo1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            combo1.Location = new Point(169, 244);
            combo1.Name = "combo1";
            combo1.Size = new Size(280, 25);
            combo1.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CS" });
            comboBox1.Location = new Point(169, 292);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 25);
            comboBox1.TabIndex = 25;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBox2.Location = new Point(169, 341);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(280, 25);
            comboBox2.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(41, 405);
            button1.Name = "button1";
            button1.Size = new Size(123, 62);
            button1.TabIndex = 27;
            button1.Text = "Add Course";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Chocolate;
            button2.FlatAppearance.MouseOverBackColor = Color.Orange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(200, 405);
            button2.Name = "button2";
            button2.Size = new Size(133, 62);
            button2.TabIndex = 28;
            button2.Text = "Update Course";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(41, 482);
            button3.Name = "button3";
            button3.Size = new Size(123, 53);
            button3.TabIndex = 29;
            button3.Text = "Delete Course";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(comboBox3);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(1075, 45);
            panel5.TabIndex = 30;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(479, 8);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(293, 25);
            comboBox3.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(778, 3);
            button4.Name = "button4";
            button4.Size = new Size(85, 39);
            button4.TabIndex = 2;
            button4.Text = "Search";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(406, 6);
            label8.Name = "label8";
            label8.Size = new Size(72, 21);
            label8.TabIndex = 0;
            label8.Text = "Search :";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(479, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 317);
            panel2.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(577, 317);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(200, 483);
            button5.Name = "button5";
            button5.Size = new Size(133, 52);
            button5.TabIndex = 32;
            button5.Text = "Clear";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(357, 436);
            button6.Name = "button6";
            button6.Size = new Size(116, 63);
            button6.TabIndex = 33;
            button6.Text = "Back";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 555);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(combo1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Course";
            Text = "Course";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox combo1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel5;
        private ComboBox comboBox3;
        private Button button4;
        private Label label8;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button6;
    }
}