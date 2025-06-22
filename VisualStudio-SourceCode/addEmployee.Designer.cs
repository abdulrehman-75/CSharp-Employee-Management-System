namespace management
{
    partial class addEmployee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_clear = new System.Windows.Forms.Button();
            this.addEmployee_update = new System.Windows.Forms.Button();
            this.addEmployee_delete = new System.Windows.Forms.Button();
            this.addEmployee_add = new System.Windows.Forms.Button();
            this.addEmployee_import = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployee_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployee_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 420);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 269);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addEmployee_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addEmployee_clear);
            this.panel2.Controls.Add(this.addEmployee_update);
            this.panel2.Controls.Add(this.addEmployee_delete);
            this.panel2.Controls.Add(this.addEmployee_add);
            this.panel2.Controls.Add(this.addEmployee_import);
            this.panel2.Controls.Add(this.addEmployee_picture);
            this.panel2.Controls.Add(this.addEmployee_position);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addEmployee_phone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addEmployee_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addEmployee_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addEmployee_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 468);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 325);
            this.panel2.TabIndex = 1;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmployee_status.Location = new System.Drawing.Point(538, 149);
            this.addEmployee_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(205, 28);
            this.addEmployee_status.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addEmployee_clear
            // 
            this.addEmployee_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmployee_clear.FlatAppearance.BorderSize = 0;
            this.addEmployee_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_clear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_clear.Location = new System.Drawing.Point(688, 237);
            this.addEmployee_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_clear.Name = "addEmployee_clear";
            this.addEmployee_clear.Size = new System.Drawing.Size(138, 69);
            this.addEmployee_clear.TabIndex = 12;
            this.addEmployee_clear.Text = "Clear";
            this.addEmployee_clear.UseVisualStyleBackColor = false;
            this.addEmployee_clear.Click += new System.EventHandler(this.addEmployee_clear_Click);
            // 
            // addEmployee_update
            // 
            this.addEmployee_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmployee_update.FlatAppearance.BorderSize = 0;
            this.addEmployee_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_update.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_update.Location = new System.Drawing.Point(363, 237);
            this.addEmployee_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_update.Name = "addEmployee_update";
            this.addEmployee_update.Size = new System.Drawing.Size(138, 69);
            this.addEmployee_update.TabIndex = 12;
            this.addEmployee_update.Text = "Update";
            this.addEmployee_update.UseVisualStyleBackColor = false;
            this.addEmployee_update.Click += new System.EventHandler(this.addEmployee_update_Click);
            // 
            // addEmployee_delete
            // 
            this.addEmployee_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmployee_delete.FlatAppearance.BorderSize = 0;
            this.addEmployee_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_delete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_delete.Location = new System.Drawing.Point(525, 237);
            this.addEmployee_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_delete.Name = "addEmployee_delete";
            this.addEmployee_delete.Size = new System.Drawing.Size(138, 69);
            this.addEmployee_delete.TabIndex = 12;
            this.addEmployee_delete.Text = "Delete";
            this.addEmployee_delete.UseVisualStyleBackColor = false;
            this.addEmployee_delete.Click += new System.EventHandler(this.addEmployee_delete_Click);
            // 
            // addEmployee_add
            // 
            this.addEmployee_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmployee_add.FlatAppearance.BorderSize = 0;
            this.addEmployee_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_add.Location = new System.Drawing.Point(200, 237);
            this.addEmployee_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_add.Name = "addEmployee_add";
            this.addEmployee_add.Size = new System.Drawing.Size(138, 69);
            this.addEmployee_add.TabIndex = 12;
            this.addEmployee_add.Text = "Add";
            this.addEmployee_add.UseVisualStyleBackColor = false;
            this.addEmployee_add.Click += new System.EventHandler(this.addEmployee_add_Click);
            // 
            // addEmployee_import
            // 
            this.addEmployee_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmployee_import.FlatAppearance.BorderSize = 0;
            this.addEmployee_import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_import.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_import.Location = new System.Drawing.Point(890, 197);
            this.addEmployee_import.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_import.Name = "addEmployee_import";
            this.addEmployee_import.Size = new System.Drawing.Size(134, 35);
            this.addEmployee_import.TabIndex = 11;
            this.addEmployee_import.Text = "Import";
            this.addEmployee_import.UseVisualStyleBackColor = false;
            this.addEmployee_import.Click += new System.EventHandler(this.addEmployee_import_Click);
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picture.Location = new System.Drawing.Point(890, 52);
            this.addEmployee_picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(132, 148);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 10;
            this.addEmployee_picture.TabStop = false;
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "Business Manager",
            "Front-End Developer",
            "Back-End Developer",
            "Data Administrator",
            "UI/UX Designer"});
            this.addEmployee_position.Location = new System.Drawing.Point(538, 111);
            this.addEmployee_position.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(205, 28);
            this.addEmployee_position.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Position";
            // 
            // addEmployee_phone
            // 
            this.addEmployee_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_phone.Location = new System.Drawing.Point(538, 57);
            this.addEmployee_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_phone.Name = "addEmployee_phone";
            this.addEmployee_phone.Size = new System.Drawing.Size(186, 26);
            this.addEmployee_phone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number";
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.addEmployee_gender.Location = new System.Drawing.Point(170, 171);
            this.addEmployee_gender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(205, 28);
            this.addEmployee_gender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // addEmployee_name
            // 
            this.addEmployee_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_name.Location = new System.Drawing.Point(170, 112);
            this.addEmployee_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_name.Name = "addEmployee_name";
            this.addEmployee_name.Size = new System.Drawing.Size(206, 26);
            this.addEmployee_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name";
            // 
            // addEmployee_id
            // 
            this.addEmployee_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_id.Location = new System.Drawing.Point(170, 55);
            this.addEmployee_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee_id.Name = "addEmployee_id";
            this.addEmployee_id.Size = new System.Drawing.Size(140, 26);
            this.addEmployee_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee\'s ID";
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addEmployee";
            this.Size = new System.Drawing.Size(1112, 814);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmployee_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployee_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addEmployee_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.Button addEmployee_clear;
        private System.Windows.Forms.Button addEmployee_update;
        private System.Windows.Forms.Button addEmployee_delete;
        private System.Windows.Forms.Button addEmployee_add;
        private System.Windows.Forms.Button addEmployee_import;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label7;
    }
}
