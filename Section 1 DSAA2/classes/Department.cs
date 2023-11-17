using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_1_DSAA2.classes
{
    public partial class Department
    {
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Department> SubDepartments { get; set; }
        public Department ParentDepartment { get; set; }


        public Department()
        {
            Employees = new List<Employee>();
            SubDepartments = new List<Department>();
        }
    }
}
