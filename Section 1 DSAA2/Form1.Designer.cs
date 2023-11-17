namespace Section_1_DSAA2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.employeeToAddBox = new System.Windows.Forms.TextBox();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.employeeToRemoveBtn = new System.Windows.Forms.Button();
            this.employeeToRemoveLable = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.moveEmpBtn = new System.Windows.Forms.Button();
            this.moveEMmpList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeesList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moveSub = new System.Windows.Forms.Button();
            this.subToMainLIst = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubDepartments = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subToAddBox = new System.Windows.Forms.TextBox();
            this.AddSubBtn = new System.Windows.Forms.Button();
            this.RemoveSubBtn = new System.Windows.Forms.Button();
            this.departmentToRmoveLabel = new System.Windows.Forms.Label();
            this.departments = new System.Windows.Forms.Label();
            this.MainDepartments = new System.Windows.Forms.ListBox();
            this.empCountLabel = new System.Windows.Forms.Label();
            this.subDepCount = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.subDepCount);
            this.panel2.Controls.Add(this.empCountLabel);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.employeesList);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SubDepartments);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.departments);
            this.panel2.Controls.Add(this.MainDepartments);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 446);
            this.panel2.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.employeeToAddBox);
            this.groupBox4.Controls.Add(this.addEmployeeBtn);
            this.groupBox4.Controls.Add(this.employeeToRemoveBtn);
            this.groupBox4.Controls.Add(this.employeeToRemoveLable);
            this.groupBox4.Location = new System.Drawing.Point(735, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 125);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add/Remove Employees";
            // 
            // employeeToAddBox
            // 
            this.employeeToAddBox.Location = new System.Drawing.Point(6, 80);
            this.employeeToAddBox.Name = "employeeToAddBox";
            this.employeeToAddBox.Size = new System.Drawing.Size(131, 22);
            this.employeeToAddBox.TabIndex = 5;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(143, 78);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(169, 25);
            this.addEmployeeBtn.TabIndex = 6;
            this.addEmployeeBtn.Text = "Add Employee";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // employeeToRemoveBtn
            // 
            this.employeeToRemoveBtn.Location = new System.Drawing.Point(143, 30);
            this.employeeToRemoveBtn.Name = "employeeToRemoveBtn";
            this.employeeToRemoveBtn.Size = new System.Drawing.Size(169, 25);
            this.employeeToRemoveBtn.TabIndex = 5;
            this.employeeToRemoveBtn.Text = "Remove Employee";
            this.employeeToRemoveBtn.UseVisualStyleBackColor = true;
            this.employeeToRemoveBtn.Click += new System.EventHandler(this.employeeToRemoveBtn_Click);
            // 
            // employeeToRemoveLable
            // 
            this.employeeToRemoveLable.AutoSize = true;
            this.employeeToRemoveLable.Location = new System.Drawing.Point(6, 34);
            this.employeeToRemoveLable.Name = "employeeToRemoveLable";
            this.employeeToRemoveLable.Size = new System.Drawing.Size(0, 16);
            this.employeeToRemoveLable.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.moveEmpBtn);
            this.groupBox3.Controls.Add(this.moveEMmpList);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(735, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 148);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Move Employees";
            // 
            // moveEmpBtn
            // 
            this.moveEmpBtn.Location = new System.Drawing.Point(155, 97);
            this.moveEmpBtn.Name = "moveEmpBtn";
            this.moveEmpBtn.Size = new System.Drawing.Size(71, 40);
            this.moveEmpBtn.TabIndex = 7;
            this.moveEmpBtn.Text = "Save";
            this.moveEmpBtn.UseVisualStyleBackColor = true;
            this.moveEmpBtn.Click += new System.EventHandler(this.moveEmpBtn_Click);
            // 
            // moveEMmpList
            // 
            this.moveEMmpList.FormattingEnabled = true;
            this.moveEMmpList.ItemHeight = 16;
            this.moveEMmpList.Location = new System.Drawing.Point(6, 37);
            this.moveEMmpList.Name = "moveEMmpList";
            this.moveEMmpList.Size = new System.Drawing.Size(143, 100);
            this.moveEMmpList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Choose Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employees";
            // 
            // employeesList
            // 
            this.employeesList.FormattingEnabled = true;
            this.employeesList.ItemHeight = 16;
            this.employeesList.Location = new System.Drawing.Point(591, 49);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(138, 292);
            this.employeesList.TabIndex = 6;
            this.employeesList.SelectedIndexChanged += new System.EventHandler(this.employeesList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.moveSub);
            this.groupBox2.Controls.Add(this.subToMainLIst);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(339, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 148);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move Sub-department";
            // 
            // moveSub
            // 
            this.moveSub.Location = new System.Drawing.Point(155, 97);
            this.moveSub.Name = "moveSub";
            this.moveSub.Size = new System.Drawing.Size(71, 40);
            this.moveSub.TabIndex = 7;
            this.moveSub.Text = "Save";
            this.moveSub.UseVisualStyleBackColor = true;
            this.moveSub.Click += new System.EventHandler(this.moveSub_Click);
            // 
            // subToMainLIst
            // 
            this.subToMainLIst.FormattingEnabled = true;
            this.subToMainLIst.ItemHeight = 16;
            this.subToMainLIst.Location = new System.Drawing.Point(6, 37);
            this.subToMainLIst.Name = "subToMainLIst";
            this.subToMainLIst.Size = new System.Drawing.Size(143, 100);
            this.subToMainLIst.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose the department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sub-Departments";
            // 
            // SubDepartments
            // 
            this.SubDepartments.FormattingEnabled = true;
            this.SubDepartments.ItemHeight = 16;
            this.SubDepartments.Location = new System.Drawing.Point(159, 49);
            this.SubDepartments.Name = "SubDepartments";
            this.SubDepartments.Size = new System.Drawing.Size(174, 148);
            this.SubDepartments.TabIndex = 3;
            this.SubDepartments.SelectedIndexChanged += new System.EventHandler(this.SubDepartments_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subToAddBox);
            this.groupBox1.Controls.Add(this.AddSubBtn);
            this.groupBox1.Controls.Add(this.RemoveSubBtn);
            this.groupBox1.Controls.Add(this.departmentToRmoveLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Remove Sub-departments";
            // 
            // subToAddBox
            // 
            this.subToAddBox.Location = new System.Drawing.Point(6, 78);
            this.subToAddBox.Name = "subToAddBox";
            this.subToAddBox.Size = new System.Drawing.Size(131, 22);
            this.subToAddBox.TabIndex = 5;
            // 
            // AddSubBtn
            // 
            this.AddSubBtn.Location = new System.Drawing.Point(143, 78);
            this.AddSubBtn.Name = "AddSubBtn";
            this.AddSubBtn.Size = new System.Drawing.Size(169, 25);
            this.AddSubBtn.TabIndex = 6;
            this.AddSubBtn.Text = "Add sub-department";
            this.AddSubBtn.UseVisualStyleBackColor = true;
            this.AddSubBtn.Click += new System.EventHandler(this.AddSubBtn_Click);
            // 
            // RemoveSubBtn
            // 
            this.RemoveSubBtn.Location = new System.Drawing.Point(143, 30);
            this.RemoveSubBtn.Name = "RemoveSubBtn";
            this.RemoveSubBtn.Size = new System.Drawing.Size(169, 25);
            this.RemoveSubBtn.TabIndex = 5;
            this.RemoveSubBtn.Text = "Remove sub-department";
            this.RemoveSubBtn.UseVisualStyleBackColor = true;
            this.RemoveSubBtn.Click += new System.EventHandler(this.RemoveSubBtn_Click);
            // 
            // departmentToRmoveLabel
            // 
            this.departmentToRmoveLabel.AutoSize = true;
            this.departmentToRmoveLabel.Location = new System.Drawing.Point(6, 34);
            this.departmentToRmoveLabel.Name = "departmentToRmoveLabel";
            this.departmentToRmoveLabel.Size = new System.Drawing.Size(0, 16);
            this.departmentToRmoveLabel.TabIndex = 5;
            // 
            // departments
            // 
            this.departments.AutoSize = true;
            this.departments.Location = new System.Drawing.Point(12, 30);
            this.departments.Name = "departments";
            this.departments.Size = new System.Drawing.Size(84, 16);
            this.departments.TabIndex = 1;
            this.departments.Text = "Departments";
            // 
            // MainDepartments
            // 
            this.MainDepartments.FormattingEnabled = true;
            this.MainDepartments.ItemHeight = 16;
            this.MainDepartments.Location = new System.Drawing.Point(15, 49);
            this.MainDepartments.Name = "MainDepartments";
            this.MainDepartments.Size = new System.Drawing.Size(138, 148);
            this.MainDepartments.TabIndex = 0;
            this.MainDepartments.SelectedIndexChanged += new System.EventHandler(this.MainDepartments_SelectedIndexChanged);
            // 
            // empCountLabel
            // 
            this.empCountLabel.AutoSize = true;
            this.empCountLabel.Location = new System.Drawing.Point(18, 360);
            this.empCountLabel.Name = "empCountLabel";
            this.empCountLabel.Size = new System.Drawing.Size(77, 16);
            this.empCountLabel.TabIndex = 9;
            this.empCountLabel.Text = "Department";
            // 
            // subDepCount
            // 
            this.subDepCount.AutoSize = true;
            this.subDepCount.Location = new System.Drawing.Point(18, 398);
            this.subDepCount.Name = "subDepCount";
            this.subDepCount.Size = new System.Drawing.Size(112, 16);
            this.subDepCount.TabIndex = 10;
            this.subDepCount.Text = "Sub-Departments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 446);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1084, 493);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox MainDepartments;
        private System.Windows.Forms.Label departments;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox employeeToAddBox;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button employeeToRemoveBtn;
        private System.Windows.Forms.Label employeeToRemoveLable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button moveEmpBtn;
        private System.Windows.Forms.ListBox moveEMmpList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox employeesList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button moveSub;
        private System.Windows.Forms.ListBox subToMainLIst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SubDepartments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox subToAddBox;
        private System.Windows.Forms.Button AddSubBtn;
        private System.Windows.Forms.Button RemoveSubBtn;
        private System.Windows.Forms.Label departmentToRmoveLabel;
        private System.Windows.Forms.Label empCountLabel;
        private System.Windows.Forms.Label subDepCount;
    }
}

