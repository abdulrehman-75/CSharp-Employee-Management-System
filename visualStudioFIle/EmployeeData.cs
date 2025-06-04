using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace management
{
    internal class EmployeeData
    {
        public int ID {  get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string Contact {  get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public List<EmployeeData> EmployeeListData ()
        {
            List<EmployeeData> listEmployee = new List<EmployeeData> ();
            if (connect.State == ConnectionState.Closed) 
            {
                try
                {
                    connect.Open ();
                    string query = "select * from employees where deleteDate is null";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                            EmployeeData ed = new EmployeeData();

                            ed.ID = (int)reader["id"];
                            ed.EmployeeID = reader["employeeId"].ToString();
                            ed.EmployeeName = reader["fullName"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["phoneNumber"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Salary = (int)reader["salary"];
                            ed.Status = reader["status"].ToString();
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
