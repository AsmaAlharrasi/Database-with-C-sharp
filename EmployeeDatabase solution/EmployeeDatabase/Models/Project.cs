using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabase.Models
{
    internal class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Descreption { get; set; }

        [ForeignKey("Employees")]
        public int? EmpID { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();


    }
}
