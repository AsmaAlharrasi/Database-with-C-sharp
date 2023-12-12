using EmployeeDatabase.Models;
using EmployeeDatabase.MyDbContext;

namespace EmployeeDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Employee emp = new Employee
            {
                Name = " kk",
            };
        }
    }
}
