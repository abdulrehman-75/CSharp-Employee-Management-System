using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management
{
    internal class SalaryData
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public List<SalaryData> salaryEmployeeListData()
        {
            List<SalaryData> listEmployee = new List<SalaryData>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string query = "select * from employees where deleteDate is null";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData ed = new SalaryData();

                            ed.EmployeeID = reader["employeeId"].ToString();
                            ed.EmployeeName = reader["fullName"].ToString();
                            ed.gender = reader["gender"].ToString();
                            ed.phone = reader["phoneNumber"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Salary = (int)reader["salary"];
                            listEmployee.Add(ed);
                        }

                        reader.Close();
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
            return listEmployee;
        }
    }
}
