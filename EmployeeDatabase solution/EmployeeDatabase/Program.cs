using EmployeeDatabase.Models;
using EmployeeDatabase.MyDbContext;

namespace EmployeeDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using ApplicationDbContext db = new ApplicationDbContext();

            //Employee emp = new Employee { Name = "Sultana", Age = 25, Salary = 500000};
            //Employee emp1 = new Employee {  Name = "Sara", Age = 23, Salary = 1760};
            //Employee emp2 = new Employee { Name = "Ahmed", Age = 31, Salary = 2550 };

            //db.Employees.Add(emp);
            //db.Employees.Add(emp1);
            //db.Employees.Add(emp2);

            //Department dept = new Department{Name = "IT",Floor = 3};
            //Department dept1 = new Department{Name = "HR",Floor = 2};
            //Department dept2 = new Department{Name = "Admin", Floor = 1};

            //db.Departments.Add(dept);
            //db.Departments.Add(dept1);
            //db.Departments.Add(dept2);

            //var emp3 = (from i in db.Employees
            //            where i.Name == "Asma"
            //            select i).FirstOrDefault();

            //emp3.Salary = 23000;
            //db.Employees.Update(emp3);
            //db.SaveChanges();
            //Console.WriteLine(emp3.Salary);
        }
    }
}
