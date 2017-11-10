using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFDBFirstEntities dbc=new EFDBFirstEntities())
            {
                Console.WriteLine("Please wait");

                var result=dbc.Employees;

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.EmployeeID,-2}-{item.FirstName,-8}-{item.Gender,-6}-");
                }


            }
           

    }
}
}
