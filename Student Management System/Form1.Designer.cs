namespace Student_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Submenu = new System.Windows.Forms.Panel();
            this.button_score = new System.Windows.Forms.Button();
            this.button_courses = new System.Windows.Forms.Button();
            this.button_students = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel_scoresubmenu = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panel_coursessubmenu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel_logo_container = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_studentsubmenu = new System.Windows.Forms.Panel();
            this.button_print = new System.Windows.Forms.Button();
            this.button_status = new System.Windows.Forms.Button();
            this.button_managestudents = new System.Windows.Forms.Button();
            this.button_registration = new System.Windows.Forms.Button();
            this.Submenu.SuspendLayout();
            this.panel_scoresubmenu.SuspendLayout();
            this.panel_coursessubmenu.SuspendLayout();
            this.panel_logo_container.SuspendLayout();
            this.panel_studentsubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submenu
            // 
            this.Submenu.AutoScroll = true;
            this.Submenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Submenu.Controls.Add(this.button_score);
            this.Submenu.Controls.Add(this.button_courses);
            this.Submenu.Controls.Add(this.button_students);
            this.Submenu.Controls.Add(this.button_exit);
            this.Submenu.Controls.Add(this.panel_scoresubmenu);
            this.Submenu.Controls.Add(this.panel_coursessubmenu);
            this.Submenu.Controls.Add(this.panel_logo_container);
            this.Submenu.Controls.Add(this.panel_studentsubmenu);
            this.Submenu.Location = new System.Drawing.Point(0, 0);
            this.Submenu.Name = "Submenu";
            this.Submenu.Size = new System.Drawing.Size(282, 1061);
            this.Submenu.TabIndex = 0;
            // 
            // button_score
            // 
            this.button_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_score.FlatAppearance.BorderSize = 0;
            this.button_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_score.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_score.ForeColor = System.Drawing.Color.White;
            this.button_score.Location = new System.Drawing.Point(1, 592);
            this.button_score.Name = "button_score";
            this.button_score.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_score.Size = new System.Drawing.Size(290, 52);
            this.button_score.TabIndex = 11;
            this.button_score.Text = "Score";
            this.button_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_score.UseVisualStyleBackColor = false;
            this.button_score.Click += new System.EventHandler(this.button_score_Click);
            // 
            // button_courses
            // 
            this.button_courses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_courses.FlatAppearance.BorderSize = 0;
            this.button_courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_courses.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_courses.ForeColor = System.Drawing.Color.White;
            this.button_courses.Location = new System.Drawing.Point(0, 419);
            this.button_courses.Name = "button_courses";
            this.button_courses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_courses.Size = new System.Drawing.Size(291, 52);
            this.button_courses.TabIndex = 10;
            this.button_courses.Text = "Courses";
            this.button_courses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_courses.UseVisualStyleBackColor = false;
            this.button_courses.Click += new System.EventHandler(this.button_courses_Click);
            // 
            // button_students
            // 
            this.button_students.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_students.FlatAppearance.BorderSize = 0;
            this.button_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_students.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_students.ForeColor = System.Drawing.Color.White;
            this.button_students.Location = new System.Drawing.Point(1, 207);
            this.button_students.Name = "button_students";
            this.button_students.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_students.Size = new System.Drawing.Size(290, 52);
            this.button_students.TabIndex = 9;
            this.button_students.Text = "Students";
            this.button_students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_students.UseVisualStyleBackColor = false;
            this.button_students.Click += new System.EventHandler(this.button_students_Click);
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(0, 765);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_exit.Size = new System.Drawing.Size(291, 52);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Exit";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel_scoresubmenu
            // 
            this.panel_scoresubmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_scoresubmenu.Controls.Add(this.button12);
            this.panel_scoresubmenu.Controls.Add(this.button13);
            this.panel_scoresubmenu.Controls.Add(this.button14);
            this.panel_scoresubmenu.Location = new System.Drawing.Point(-7, 643);
            this.panel_scoresubmenu.Name = "panel_scoresubmenu";
            this.panel_scoresubmenu.Size = new System.Drawing.Size(298, 122);
            this.panel_scoresubmenu.TabIndex = 7;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(6, 80);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(291, 40);
            this.button12.TabIndex = 4;
            this.button12.Text = "Print";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(6, 40);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(288, 40);
            this.button13.TabIndex = 3;
            this.button13.Text = "Manage Score";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(6, 0);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(291, 40);
            this.button14.TabIndex = 2;
            this.button14.Text = "New Score";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel_coursessubmenu
            // 
            this.panel_coursessubmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_coursessubmenu.Controls.Add(this.button7);
            this.panel_coursessubmenu.Controls.Add(this.button8);
            this.panel_coursessubmenu.Controls.Add(this.button9);
            this.panel_coursessubmenu.Location = new System.Drawing.Point(-9, 470);
            this.panel_coursessubmenu.Name = "panel_coursessubmenu";
            this.panel_coursessubmenu.Size = new System.Drawing.Size(300, 122);
            this.panel_coursessubmenu.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(8, 80);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(291, 40);
            this.button7.TabIndex = 4;
            this.button7.Text = "Print";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(8, 40);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(291, 40);
            this.button8.TabIndex = 3;
            this.button8.Text = "Manage Course";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(8, 0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(291, 40);
            this.button9.TabIndex = 2;
            this.button9.Text = "New Course";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel_logo_container
            // 
            this.panel_logo_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_logo_container.Controls.Add(this.panel_logo);
            this.panel_logo_container.Location = new System.Drawing.Point(-9, 0);
            this.panel_logo_container.Name = "panel_logo_container";
            this.panel_logo_container.Size = new System.Drawing.Size(300, 207);
            this.panel_logo_container.TabIndex = 2;
            // 
            // panel_logo
            // 
            this.panel_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_logo.BackgroundImage")));
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_logo.Location = new System.Drawing.Point(42, 34);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(221, 122);
            this.panel_logo.TabIndex = 7;
            // 
            // panel_studentsubmenu
            // 
            this.panel_studentsubmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_studentsubmenu.Controls.Add(this.button_print);
            this.panel_studentsubmenu.Controls.Add(this.button_status);
            this.panel_studentsubmenu.Controls.Add(this.button_managestudents);
            this.panel_studentsubmenu.Controls.Add(this.button_registration);
            this.panel_studentsubmenu.Location = new System.Drawing.Point(-8, 258);
            this.panel_studentsubmenu.Name = "panel_studentsubmenu";
            this.panel_studentsubmenu.Size = new System.Drawing.Size(299, 161);
            this.panel_studentsubmenu.TabIndex = 1;
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(7, 120);
            this.button_print.Name = "button_print";
            this.button_print.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_print.Size = new System.Drawing.Size(291, 40);
            this.button_print.TabIndex = 5;
            this.button_print.Text = "Print";
            this.button_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_status
            // 
            this.button_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_status.FlatAppearance.BorderSize = 0;
            this.button_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_status.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_status.ForeColor = System.Drawing.Color.White;
            this.button_status.Location = new System.Drawing.Point(7, 80);
            this.button_status.Name = "button_status";
            this.button_status.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_status.Size = new System.Drawing.Size(291, 40);
            this.button_status.TabIndex = 4;
            this.button_status.Text = "Status";
            this.button_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_status.UseVisualStyleBackColor = false;
            this.button_status.Click += new System.EventHandler(this.button_status_Click);
            // 
            // button_managestudents
            // 
            this.button_managestudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_managestudents.FlatAppearance.BorderSize = 0;
            this.button_managestudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managestudents.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_managestudents.ForeColor = System.Drawing.Color.White;
            this.button_managestudents.Location = new System.Drawing.Point(8, 40);
            this.button_managestudents.Name = "button_managestudents";
            this.button_managestudents.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_managestudents.Size = new System.Drawing.Size(290, 40);
            this.button_managestudents.TabIndex = 3;
            this.button_managestudents.Text = "Manage Students";
            this.button_managestudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_managestudents.UseVisualStyleBackColor = false;
            this.button_managestudents.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_registration
            // 
            this.button_registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_registration.FlatAppearance.BorderSize = 0;
            this.button_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registration.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_registration.ForeColor = System.Drawing.Color.White;
            this.button_registration.Location = new System.Drawing.Point(7, 0);
            this.button_registration.Name = "button_registration";
            this.button_registration.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_registration.Size = new System.Drawing.Size(291, 40);
            this.button_registration.TabIndex = 2;
            this.button_registration.Text = "Registration";
            this.button_registration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_registration.UseVisualStyleBackColor = false;
            this.button_registration.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.Submenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Submenu.ResumeLayout(false);
            this.Submenu.PerformLayout();
            this.panel_scoresubmenu.ResumeLayout(false);
            this.panel_coursessubmenu.ResumeLayout(false);
            this.panel_logo_container.ResumeLayout(false);
            this.panel_studentsubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Submenu;
        private Panel panel_studentsubmenu;
        private Button button_managestudents;
        private Button button_registration;
        private Panel panel_logo_container;
        private Panel panel_logo;
        private Button button_print;
        private Button button_status;
        private Panel panel_scoresubmenu;
        private Button button12;
        private Button button13;
        private Button button14;
        private Panel panel_coursessubmenu;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button_exit;
        private Button button_score;
        private Button button_courses;
        private Button button_students;
    }
}