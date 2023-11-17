using Section_1_DSAA2.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_1_DSAA2
{
    public partial class Form1 : Form
    {
        public Form1(List<Department> departments)
        {
            InitializeComponent();

            MainDepartments.DisplayMember = "Name";
            SubDepartments.DisplayMember = "Name";
            subToMainLIst.DisplayMember = "Name";
            moveEMmpList.DisplayMember = "Name";
            employeesList.DisplayMember = "EmployeeName";
            MainDepartments.DataSource = departments;
            subToMainLIst.DataSource = MainDepartments.Items;
        }

        private void Clean_After()
        {
            SubDepartments.Items.Clear();
            moveEMmpList.Items.Clear();
            employeesList.Items.Clear();
            employeeToAddBox.Clear();
            departmentToRmoveLabel.Text = "";
            employeeToRemoveLable.Text = "";
            empCountLabel.Text = "";
            subDepCount.Text = "";
        }


        private void MainDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clean_After();

            if (MainDepartments.SelectedItem is Department selectedMainDepartment)
            {
                var empCount = 0;
                foreach (var subDepartment in selectedMainDepartment.SubDepartments)
                {
                    SubDepartments.Items.Add(subDepartment);
                    moveEMmpList.Items.Add(subDepartment);
                    empCount += subDepartment.Employees.Count;
                }
                empCountLabel.Text = $"number of total employees in department {selectedMainDepartment.Name} is : " + empCount.ToString();
            }

        }

        private void SubDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

            departmentToRmoveLabel.Text = "";
            subDepCount.Text = "";
            employeesList.Items.Clear();
            if (SubDepartments.SelectedItem is Department selectedSubDepartment)
            {
                Console.WriteLine("Selected sub-department: " + selectedSubDepartment.Name); // Debugging statement
                departmentToRmoveLabel.Text = selectedSubDepartment.Name;
                foreach(var emp in selectedSubDepartment.Employees)
                {
                    employeesList.Items.Add(emp);
                }
                subDepCount.Text = $"The count of employyes in sub-department ({selectedSubDepartment.Name}) is : {selectedSubDepartment.Employees.Count}";
            }
            else
            {
                Console.WriteLine("No sub-department selected.");
            }

        }

        private void moveSub_Click(object sender, EventArgs e)
        {
            if (SubDepartments.SelectedItem is Department selectedSubDepartment &&
                subToMainLIst.SelectedItem is Department selectedMainDepartment)
            {
                if (MainDepartments.Items.Contains(selectedMainDepartment) && SubDepartments.Items.Contains(selectedSubDepartment))
                {
                    // Remove the sub-department from its current parent main department
                    selectedSubDepartment.ParentDepartment.SubDepartments.Remove(selectedSubDepartment);
                    selectedSubDepartment.ParentDepartment = selectedMainDepartment;

                    // Add the sub-department to the selected new main department
                    selectedMainDepartment.SubDepartments.Add(selectedSubDepartment);

                    MessageBox.Show($"Sub-Department ({selectedSubDepartment.Name}) has been moved to ({selectedMainDepartment.Name}) Department.");

                }
                else
                {
                    MessageBox.Show("please choose the Sub-Department and the parent Department to move to");
                }
                Clean_After();
            }
        }

        private void RemoveSubBtn_Click(object sender, EventArgs e)
        {
            if (SubDepartments.SelectedItem is Department selectedSubDepartment)
            {
                string message = $"Are you sure you want to delete this sub-department: {selectedSubDepartment.Name}?";
                string caption = "Confirm Deletion";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User confirmed the deletion, perform the deletion here
                    // Assuming you have a list of departments and need to remove the sub-department
                    if (selectedSubDepartment.ParentDepartment.SubDepartments.Contains(selectedSubDepartment))
                    {
                        // Remove the sub-department
                        selectedSubDepartment.ParentDepartment.SubDepartments.Remove(selectedSubDepartment);

                        // Refresh the ComboBox
                        Clean_After();
                    }
                }
            }

        }

        private void AddSubBtn_Click(object sender, EventArgs e)
        {
            var newSubName = subToAddBox.Text;

            if (MainDepartments.SelectedItem is Department selectedDepartment && !string.IsNullOrEmpty(newSubName))
            {
                string managerName = ShowInputDialog("Enter the Manager's Name:", "Manager Name");

                if (!string.IsNullOrEmpty(managerName))
                {
                    string message = $"Are you sure you want to add this sub-department: {newSubName} to {selectedDepartment.Name} with Manager: {managerName}?";
                    string caption = "Confirm Addition";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var newSub = new Department
                        {
                            Name = newSubName,
                            ManagerName = managerName,
                            ParentDepartment = selectedDepartment,
                        };

                        selectedDepartment.SubDepartments.Add(newSub);

                        Clean_After();
                    }
                }
            }
        }
        private string ShowInputDialog(string prompt, string title)
        {
            Form promptForm = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label label = new Label() { Left = 50, Top = 20, Text = prompt };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 75, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(label);

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }

        private void employeesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeToRemoveLable.Text = "";
            if (employeesList.SelectedItem is Employee selectedEmployee)
            {
                Console.WriteLine("Selected Employee: " + selectedEmployee.EmployeeName);
                employeeToRemoveLable.Text = selectedEmployee.EmployeeName;
            }

        }

        private void employeeToRemoveBtn_Click(object sender, EventArgs e)
        {
            if (employeesList.SelectedItem is Employee selectedEmployee)
            {
                string message = $"Are you sure you want to remove this Employee: {selectedEmployee.EmployeeName}?";
                string caption = "Confirm Deletion";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (selectedEmployee.SubDep.Employees.Contains(selectedEmployee))
                    {
                        selectedEmployee.SubDep.Employees.Remove(selectedEmployee);

                        Clean_After();
                    }
                }
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            var newEmployee = employeeToAddBox.Text;
            if (SubDepartments.SelectedItem is Department selectedSubDepartment && !string.IsNullOrEmpty(newEmployee))
            {
                string message = $"Are you sure you want to add this Employee: {newEmployee} to {selectedSubDepartment.Name} sub-department?";
                string caption = "Confirm Addition";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var employee = new Employee
                    {
                        EmployeeName = newEmployee,
                        SubDep = selectedSubDepartment
                    };
                    selectedSubDepartment.Employees.Add(employee);

                    Clean_After();
                }
            }
        }

        private void moveEmpBtn_Click(object sender, EventArgs e)
        {
            if (moveEMmpList.SelectedItem is Department selectedSubDepartment &&
                employeesList.SelectedItem is Employee selectedEmployee)
            {
                if (selectedEmployee.SubDep.Employees.Contains(selectedEmployee))
                {
                    selectedEmployee.SubDep.Employees.Remove(selectedEmployee);
                    selectedEmployee.SubDep = selectedSubDepartment;
                    selectedSubDepartment.Employees.Add(selectedEmployee);

                    MessageBox.Show($"Employee ({selectedEmployee.EmployeeName}) has been moved to ({selectedSubDepartment.Name}) Department.");

                }
                else
                {
                    MessageBox.Show("please choose the Sub-Department and the parent Department to move to");
                }
                Clean_After();
            }
        }
    }
}
