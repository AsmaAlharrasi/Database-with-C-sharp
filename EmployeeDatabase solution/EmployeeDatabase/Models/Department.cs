using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabase.Models
{
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepId { get; set; }

        [Required]
        [StringLength(50, MinimumLength =15)]
        public string Name { get; set; }
      
        [Range(1,5)]
        public int Floor { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
    
}
