using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You Sure You Want To Logout?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes) {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salary1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

            dashboard dashForm = dashboard1 as dashboard;
            if(dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;

            addEmployee emForm = addEmployee1 as addEmployee;
            if(emForm != null)
            {
                emForm.RefreshData();
            }
        }

        private void salary_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;

            salary salaryForm = salary1 as salary;
            if(salary1 != null)
            {
                salaryForm.RefreshData();
            }
        }
    }
}
