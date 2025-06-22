using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace management
{
    public partial class salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public salary()
        {
            InitializeComponent();
            displayEmployees();
            salaryDisabled();
        }
        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployees();
            salaryDisabled();
        }
       public void salaryDisabled()
        {
            salary_id.Enabled = false;
            salary_name.Enabled = false;
            salary_position.Enabled = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        public void displayEmployees ()
        {
            SalaryData ed = new SalaryData();
            List < SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }
        public void clearFields()
        {
            salary_id.Text = "";
            salary_name.Text = "";
            salary_position.Text = "";
            salary_salary.Text = "";

        }
        private void salary_update_Click(object sender, EventArgs e)
        {
            if (salary_id.Text == "" ||
               salary_name.Text == "" ||
               salary_position.Text == "" ||
               salary_salary.Text == "" )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To Update EmployeeId: " + salary_id.Text.Trim() +
                                    "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            DateTime date = DateTime.Today;
                            connect.Open();
                            string querry = "update employees set salary = @salary, updateDate = @date " +
                                "where employeeId = @emId";
                            using (SqlCommand cmd = new SqlCommand(querry, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", salary_salary.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", date);
                                cmd.Parameters.AddWithValue("@emId", salary_id.Text.Trim());
                                cmd.ExecuteNonQuery();
                                displayEmployees();
                                MessageBox.Show("Updated Successfully!", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show("Error: " + ex, "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 )
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_id.Text = row.Cells[0].Value.ToString();
                salary_name.Text = row.Cells[1].Value.ToString();
                salary_position.Text = row.Cells[4].Value.ToString();
                salary_salary.Text = row.Cells[5].Value.ToString();
            }

        }
    }
}
