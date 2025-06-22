using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace management
{
    public partial class Form1 : Form
    {
        SqlConnection connection
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registerForm regForm = new registerForm();
            regForm.Show();
            this.Hide();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (login_password.Text == "" || login_username.Text == "")
            {
                MessageBox.Show("fill the empty feilds", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        string getUser = "select * from users where username = @user " +
                            "and password = @pass";
                        using (SqlCommand cmd = new SqlCommand(getUser, connection))
                        {
                            cmd.Parameters.AddWithValue("@user", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1) 
                            {
                                MessageBox.Show("Login Succesfully!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mainForm mForm = new mainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    { 
                    connection.Close();
                    }

                }
            }
          
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*'; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
