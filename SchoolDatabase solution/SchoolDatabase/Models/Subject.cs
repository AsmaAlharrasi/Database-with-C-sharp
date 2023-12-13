using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase.Models
{
    internal class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjejtId { get; set; }
        public string SubjectName { get; set; }
       
        public List<TeacherSubject> TeacherSubject { get; set; } = new List<TeacherSubject>();
    }
}
