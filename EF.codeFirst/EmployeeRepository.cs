using System.Collections.Generic;
using System.Linq;

namespace EF.codeFirst
{
    public class EmployeeRepository
    {
        EmployeeDBContext edbc = new EmployeeDBContext();
        public List<Employee> GetEmployees()
        {
            
            return edbc.Employees.ToList();
        }
        public void InsertEmployee(Employee e)
        {
            edbc.Employees.Add(e);
            edbc.SaveChanges();
           
        }
        public void UpdateEmployee(Employee e)
        {
          var emp=  edbc.Employees.FirstOrDefault(x => x.Id == e.Id);
            emp.FirstName = e.FirstName;
            emp.LastName = e.LastName;
            emp.Gender = e.Gender;
            emp.JobTitle = e.JobTitle;
            emp.Salary = e.Salary;
            edbc.SaveChanges();
        }
        public void DeleteEmployee(Employee e)
        {
            var emp = edbc.Employees.FirstOrDefault(x => x.Id == e.Id);
            edbc.Employees.Remove(emp);
            edbc.SaveChanges();
        }

    }
}
