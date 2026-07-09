namespace Student_Mangement_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button6 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 44);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(39, 436);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(187, 76);
            button2.Name = "button2";
            button2.Size = new Size(185, 111);
            button2.TabIndex = 3;
            button2.Text = "Student Records";
            button2.TextAlign = ContentAlignment.BottomLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(405, 76);
            button3.Name = "button3";
            button3.Size = new Size(185, 111);
            button3.TabIndex = 7;
            button3.Text = "Courses";
            button3.TextAlign = ContentAlignment.BottomLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(187, 203);
            button4.Name = "button4";
            button4.Size = new Size(185, 111);
            button4.TabIndex = 8;
            button4.Text = "Marks Entry";
            button4.TextAlign = ContentAlignment.BottomLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(297, 331);
            button5.Name = "button5";
            button5.Size = new Size(185, 111);
            button5.TabIndex = 9;
            button5.Text = "Logout";
            button5.TextAlign = ContentAlignment.BottomLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(797, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 436);
            panel3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 174);
            label1.Name = "label1";
            label1.Size = new Size(186, 38);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(405, 203);
            button6.Name = "button6";
            button6.Size = new Size(185, 111);
            button6.TabIndex = 11;
            button6.Text = "Results";
            button6.TextAlign = ContentAlignment.BottomLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 480);
            Controls.Add(button6);
            Controls.Add(panel3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button6;
    }
}