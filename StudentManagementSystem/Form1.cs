namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panel_std_submenu.Visible = false;
            panel_course_submenu.Visible = false;
            panel_score_submenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_std_submenu.Visible == true)
                panel_std_submenu.Visible = false;
            if (panel_course_submenu.Visible == true)
                panel_course_submenu.Visible = false;
            if (panel_score_submenu.Visible == true)
                panel_score_submenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;               
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_std_submenu);
        }

        #region stdSubmenu
        private void button_reg_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_man_std_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_print_std_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }
        #endregion

        private void button_courses_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_course_submenu);
        }

        #region courseSubmenu
        private void button_new_course_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_man_course_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_man_print_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }
        #endregion

        private void button_scores_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_score_submenu);
        }

        #region scoreSubmenu
        private void button_add_score_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_man_score_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_score_print_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }
        #endregion 
    }
}