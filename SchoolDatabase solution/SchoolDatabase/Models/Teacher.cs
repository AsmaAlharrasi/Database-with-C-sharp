using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase.Models
{
    internal class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public List<TeacherSubject> TeacherSubject { get; set; } = new List<TeacherSubject>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();

    }
}
