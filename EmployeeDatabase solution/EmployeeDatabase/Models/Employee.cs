using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabase.Models
{
    internal class Employee
    {
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Range(18 , 50)]
        public int Age { get; set; }

        [DataType(DataType.Currency)]
        public  decimal Salary { get; set; }

        [ForeignKey("Departments")]
        public int? deptID { get; set; }
        public Department? Departments { get; set; }

        [ForeignKey("Projects")]
        public int? ProjID { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();


    }
}
