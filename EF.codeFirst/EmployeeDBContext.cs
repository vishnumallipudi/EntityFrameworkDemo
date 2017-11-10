using System.Data.Entity;

namespace EF.codeFirst
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .MapToStoredProcedures(p=>p.Insert(x=>x.HasName("Insert_Employee")
                                            .Parameter(b=>b.JobTitle,"EmpJobTitle")
                                            .Parameter(b => b.DepartmentId, "EmpDeptId")
                                            .Parameter(b => b.LastName, "EmpLastName")
                                            .Parameter(b => b.FirstName, "EmpFirstName")
                                            .Parameter(b => b.Salary, "EmpSalary")
                                            .Parameter(b => b.Gender, "EmpGender"))
                                            
            );
            modelBuilder.Entity<Employee>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("Delete_Employee")
                                                .Parameter(b=>b.Id,"EmpId")));
            modelBuilder.Entity<Employee>().MapToStoredProcedures(p => p.Update(x => x.HasName("Update_Employee")
                                            .Parameter(b => b.JobTitle, "EmpJobTitle")
                                            .Parameter(b => b.DepartmentId, "EmpDeptId")
                                            .Parameter(b => b.LastName, "EmpLastName")
                                            .Parameter(b => b.FirstName, "EmpFirstName")
                                            .Parameter(b => b.Salary, "EmpSalary")
                                            .Parameter(b => b.Gender, "EmpGender")
                                            .Parameter(b => b.Id, "EmpId")));
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
