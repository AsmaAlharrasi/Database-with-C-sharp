using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int TeachId { get; set; }

        public Teacher Teachers { get; set; }
    }
}
