using System;

namespace EF.codeFirst
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("hello");
            EmployeeRepository erdb = new EmployeeRepository();
           
            Console.WriteLine("now updatinng database:");
            var empInsert = new Employee { FirstName = "vishnu", LastName = "Mallipudi", Gender = "Male", JobTitle = "Developer", Salary = 45000, DepartmentId = 3 };
            erdb.InsertEmployee(empInsert);


            Console.WriteLine("Getting employees");
            var result = erdb.GetEmployees();
            foreach (var item in result)
            {
                Console.WriteLine($"\t{item.Id,-5}-{item.FirstName,-10}-{item.Gender,-5}");
            }
            
            Console.WriteLine("success");
        }
    }
}
