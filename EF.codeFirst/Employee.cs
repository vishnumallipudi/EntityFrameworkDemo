using System.ComponentModel.DataAnnotations.Schema;

namespace EF.codeFirst
{
    [Table("tblEmployees")]
    public class Employee
    {
        public int Id { get; set; }
        [Column("First_Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        //this data annotation takes another property as only input
        public Department Department { get; set; }
        public string JobTitle { get; set; }
    }
}
