using Section_1_DSAA2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_1_DSAA2.utils
{
    internal static class CompanyDataGenerator
    {
        public static List<Department> GenerateCompanyStructure()
        {
            var departments = new List<Department>();

            // Create top-level departments
            var department1 = new Department
            {
                Name = "HR",
                ManagerName = "HR Manager"
            };

            var department2 = new Department
            {
                Name = "Engineering",
                ManagerName = "Engineering Manager"
            };

            // Create sub-departments
            var subDepartment1_1 = new Department
            {
                Name = "Recruitment",
                ManagerName = "Recruitment Manager"
            };

            var subDepartment1_2 = new Department
            {
                Name = "Training",
                ManagerName = "Training Manager"
            };

            var subDepartment2_1 = new Department
            {
                Name = "Software",
                ManagerName = "Software Manager"
            };

            var subDepartment2_2 = new Department
            {
                Name = "Hardware",
                ManagerName = "Hardware Manager"
            };

            // Create employees
            var employee1 = new Employee
            {
                EmployeeName = "John Doe",
                SubDep = subDepartment1_1
            };

            var employee2 = new Employee
            {
                EmployeeName = "Jane Smith",
                SubDep = subDepartment2_1
            };

            subDepartment1_1.ParentDepartment = department1;
            subDepartment1_2.ParentDepartment = department1;
            subDepartment2_1.ParentDepartment = department2;
            subDepartment2_2.ParentDepartment = department2;

            subDepartment1_1.Employees.Add(employee1);
            subDepartment1_1.Employees.Add(employee1);
            subDepartment2_2.Employees.Add(employee2);
            subDepartment2_2.Employees.Add(employee2);

            department1.SubDepartments.Add(subDepartment1_1);
            department1.SubDepartments.Add(subDepartment1_2);
            department2.SubDepartments.Add(subDepartment2_1);
            department2.SubDepartments.Add(subDepartment2_2);

            departments.Add(department1);
            departments.Add(department2);
            for (int i = 3; i <= 15; i++)
            {
                var mainDepartment = new Department
                {
                    Name = $"Main Department {i}",
                    ManagerName = $"Manager {i}"
                };

                departments.Add(mainDepartment);

                for (int j = 1; j <= 4; j++)
                {
                    var subDepartment = new Department
                    {
                        Name = $"Sub Department {i}-{j}",
                        ManagerName = $"Sub Manager {i}-{j}"
                    };

                    mainDepartment.SubDepartments.Add(subDepartment);

                    for (int k = 1; k <= 5; k++)
                    {
                        var employee = new Employee
                        {
                            EmployeeName = $"Employee {i}-{j}-{k}",
                            SubDep = subDepartment
                        };

                        subDepartment.Employees.Add(employee);
                    }
                }
            }


            return departments;
        }
    }
}

