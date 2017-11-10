using System.Collections.Generic;
using System.Linq;

namespace EFDemo.CodeFirst
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBContext edbc = new EmployeeDBContext();
            return edbc.Departments.ToList();
        }
    }
}
