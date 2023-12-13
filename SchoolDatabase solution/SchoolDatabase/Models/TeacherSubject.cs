using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase.Models
{
    internal class TeacherSubject
    {
        public int SubjectId { get; set; }
        public Subject Subjects { get; set; }

        public int TeachId { get; set; }
        public Teacher Teachers { get; set; }
    }
}
