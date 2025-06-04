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
    public partial class registerForm : Form
    {
        SqlConnection connection
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public registerForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_password.Text == "") {
                MessageBox.Show("fill the empty feilds", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            else
            {
                if(connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        string selectUser = "select count(id) from users where username = @user";
                        using (SqlCommand checkUser = new SqlCommand(selectUser, connection))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = Convert.ToInt32(checkUser.ExecuteScalar());
                           if (count >= 1) {
                                MessageBox.Show(signup_username.Text.Trim() + " already exist", "Error Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                           else
                            {
                                DateTime date = DateTime.Today;
                                string insertData = "insert into users" +
                                    "(username, password, date_register)" +
                                    "values(@username, @password, @date_register)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {

                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date_register", date);
                                    cmd.ExecuteNonQuery();


                                    MessageBox.Show("Registered Succesfully!", "Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }

                        
                        }

                       
                    }
                    catch(Exception ex) {
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
    }
}
