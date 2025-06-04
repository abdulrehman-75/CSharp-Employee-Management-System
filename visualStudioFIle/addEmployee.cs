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
using System.IO;

namespace management
{
    public partial class addEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public addEmployee()
        {
            InitializeComponent();
            displayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return; 
            }
            displayData();
        }

        private void addEmployee_add_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == "" ||
                addEmployee_name.Text == "" ||
                addEmployee_gender.Text == "" ||
                addEmployee_phone.Text == "" ||
                addEmployee_position.Text == "" ||
                addEmployee_status.Text == "" ||
                addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmId = "SELECT COUNT(*) FROM employees WHERE " +
                              "employeeId = @emId AND deleteDate IS NULL";
                        using (SqlCommand command = new SqlCommand(checkEmId, connect))
                        {
                            command.Parameters.AddWithValue("@emId", addEmployee_id.Text.Trim());
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " already exists",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Create directory path
                                string directoryPath = @"D:\Program Files\C# practice\management\directory\";
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                string fileName = addEmployee_id.Text.Trim() + ".jpg";
                                string destinationPath = Path.Combine(directoryPath, fileName);

                                // Handle image saving
                                try
                                {
                                    // Save the current image to the destination path
                                    if (addEmployee_picture.Image != null)
                                    {
                                        // Create a copy of the image to avoid file locking issues
                                        using (Bitmap bmp = new Bitmap(addEmployee_picture.Image))
                                        {
                                            bmp.Save(destinationPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                                        }
                                    }
                                    else if (!string.IsNullOrEmpty(addEmployee_picture.ImageLocation) &&
                                             File.Exists(addEmployee_picture.ImageLocation))
                                    {
                                        // If ImageLocation is available, copy from there
                                        File.Copy(addEmployee_picture.ImageLocation, destinationPath, true);
                                    }
                                    else
                                    {
                                        throw new Exception("No valid image source found");
                                    }
                                }
                                catch (Exception imgEx)
                                {
                                    MessageBox.Show("Error saving image: " + imgEx.Message, "Image Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Exit if image saving fails
                                }

                                DateTime date = DateTime.Today;
                                string insertData = "INSERT INTO employees " +
                                "(employeeId, fullName, gender, phoneNumber, position, image, salary, insertDate, status) " +
                                "VALUES (@emId, @n, @g, @pn, @pos, @i, @sa, @date, @s)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@emId", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@n", addEmployee_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@g", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pn", addEmployee_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pos", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@i", destinationPath);
                                    cmd.Parameters.AddWithValue("@sa", 0);
                                    cmd.Parameters.AddWithValue("@date", date);
                                    cmd.Parameters.AddWithValue("@s", addEmployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    displayData();
                                    MessageBox.Show("Added Successfully!", "Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void displayData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> employee = ed.EmployeeListData();
            dataGridView1.DataSource = employee;
        }

        private void addEmployee_import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg;*.png;*.jpeg;*.bmp)|*.jpg;*.png;*.jpeg;*.bmp|All files (*.*)|*.*";
                dialog.Title = "Select Employee Image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = dialog.FileName;

                    // Dispose previous image to free memory
                    if (addEmployee_picture.Image != null)
                    {
                        addEmployee_picture.Image.Dispose();
                        addEmployee_picture.Image = null;
                    }

                    // Load image from file stream to avoid file locking
                    try
                    {
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            addEmployee_picture.Image = Image.FromStream(fs);
                        }
                        addEmployee_picture.ImageLocation = imagePath; // Keep reference to original path
                    }
                    catch (Exception imgEx)
                    {
                        MessageBox.Show("Error loading image: " + imgEx.Message, "Image Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                addEmployee_id.Text = row.Cells[1].Value?.ToString();
                addEmployee_name.Text = row.Cells[2].Value?.ToString();
                addEmployee_gender.Text = row.Cells[3].Value?.ToString();
                addEmployee_phone.Text = row.Cells[4].Value?.ToString();
                addEmployee_position.Text = row.Cells[5].Value?.ToString();

                string imagePath = row.Cells[6].Value?.ToString();

                // Dispose previous image to prevent memory leaks
                if (addEmployee_picture.Image != null)
                {
                    addEmployee_picture.Image.Dispose();
                    addEmployee_picture.Image = null;
                }

                try
                {
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        // Load image using FileStream to avoid file locking
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            addEmployee_picture.Image = Image.FromStream(fs);
                        }
                        addEmployee_picture.ImageLocation = imagePath; // Keep reference
                    }
                    else
                    {
                        addEmployee_picture.Image = null;
                        addEmployee_picture.ImageLocation = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}", "Image Load Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addEmployee_picture.Image = null;
                    addEmployee_picture.ImageLocation = null;
                }

                addEmployee_status.Text = row.Cells[8].Value?.ToString();
            }
        }


        public void clearFields ()
        {
            addEmployee_id.Text = "";
            addEmployee_name.Text = "";
            addEmployee_gender.SelectedIndex = -1;
            addEmployee_phone.Text = "";
            addEmployee_position.SelectedIndex = -1;
            addEmployee_status.SelectedIndex = -1;
            addEmployee_picture.Image = null;
        }
        private void addEmployee_update_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == "" ||
               addEmployee_name.Text == "" ||
               addEmployee_gender.Text == "" ||
               addEmployee_phone.Text == "" ||
               addEmployee_position.Text == "" ||
               addEmployee_status.Text == "" ||
               addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To Update EmployeeId: " + addEmployee_id.Text.Trim() +
                    "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime date = DateTime.Today;

                        string updateData = "UPDATE employees SET " +
                            "fullName = @n, " +
                            "gender = @g, " +
                            "phoneNumber = @pn, " +
                            "position = @pos, " +
                            "updateDate = @updateDate, " +
                            "status = @s " +
                            "WHERE employeeId = @emId";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@emId", addEmployee_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@n", addEmployee_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@g", addEmployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@pn", addEmployee_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@pos", addEmployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", date);
                            cmd.Parameters.AddWithValue("@s", addEmployee_status.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayData();
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
                else
                {
                    MessageBox.Show("Cancelled", "Information Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void addEmployee_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addEmployee_delete_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == "" ||
              addEmployee_name.Text == "" ||
              addEmployee_gender.Text == "" ||
              addEmployee_phone.Text == "" ||
              addEmployee_position.Text == "" ||
              addEmployee_status.Text == "" ||
              addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To Delete EmployeeId: " + addEmployee_id.Text.Trim() +
                    "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime date = DateTime.Today;

                        string deleteData = "UPDATE employees SET deleteDate = @deleteDate WHERE employeeId = @emId";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", date);
                            cmd.Parameters.AddWithValue("@emId", addEmployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayData();
                            MessageBox.Show("Deleted Successfully!", "Information Message",
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
                else
                {
                    MessageBox.Show("Cancelled", "Information Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
