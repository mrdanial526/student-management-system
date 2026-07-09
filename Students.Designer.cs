namespace Student_Mangement_System
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            textBox3 = new TextBox();
            panel5 = new Panel();
            comboBox2 = new ComboBox();
            button4 = new Button();
            label6 = new Label();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 74);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(430, 81);
            panel4.Name = "panel4";
            panel4.Size = new Size(585, 24);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 36);
            label1.TabIndex = 0;
            label1.Text = "Students Mangement";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 176);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 1;
            label2.Text = "Student Name :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 127);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 3;
            label3.Text = "Student ID :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 27);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 221);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 5;
            label4.Text = "Gender :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(174, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 29);
            comboBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 269);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 7;
            label5.Text = "Department :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
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
            button1.Location = new Point(30, 320);
            button1.Name = "button1";
            button1.Size = new Size(156, 63);
            button1.TabIndex = 9;
            button1.Text = "Add Student";
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
            button2.Location = new Point(204, 320);
            button2.Name = "button2";
            button2.Size = new Size(195, 63);
            button2.TabIndex = 10;
            button2.Text = "Update Student";
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
            button3.Location = new Point(26, 406);
            button3.Name = "button3";
            button3.Size = new Size(160, 63);
            button3.TabIndex = 11;
            button3.Text = "Delete Student";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(460, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 386);
            panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(663, 386);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 577);
            panel3.Name = "panel3";
            panel3.Size = new Size(1139, 28);
            panel3.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 27);
            textBox3.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 74);
            panel5.Name = "panel5";
            panel5.Size = new Size(1139, 34);
            panel5.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(669, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(293, 29);
            comboBox2.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.BottomLeft;
            button4.Location = new Point(968, 0);
            button4.Name = "button4";
            button4.Size = new Size(89, 34);
            button4.TabIndex = 2;
            button4.Text = "Search";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(591, 7);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 0;
            label6.Text = "Search :";
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(204, 406);
            button5.Name = "button5";
            button5.Size = new Size(195, 63);
            button5.TabIndex = 16;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(142, 491);
            button6.Name = "button6";
            button6.Size = new Size(116, 63);
            button6.TabIndex = 17;
            button6.Text = "Back";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 605);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(panel5);
            Controls.Add(textBox3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Students";
            Text = "Student Records";
            Load += Students_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private TextBox textBox3;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
        private Button button4;
        private ComboBox comboBox2;
        private Button button5;
        private Button button6;
    }
}