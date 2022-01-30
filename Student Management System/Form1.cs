namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panel_studentsubmenu.Visible = false;
            panel_coursessubmenu.Visible = false;
            panel_scoresubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_studentsubmenu.Visible == true)
            {
                panel_studentsubmenu.Visible = false;

            }
            if (panel_coursessubmenu.Visible == true)
            {
                panel_coursessubmenu.Visible = false;

            }
            if (panel_scoresubmenu.Visible == true)
            {
                panel_scoresubmenu.Visible = false;
            }

        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible = false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }


        private void button_students_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_studentsubmenu);
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_courses_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_coursessubmenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoresubmenu);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }
    }
}