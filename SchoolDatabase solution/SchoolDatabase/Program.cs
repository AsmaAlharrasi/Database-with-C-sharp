using SchoolDatabase.Models;
using SchoolDatabase.MyDbContext;

namespace SchoolDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ApplicationDbContext db = new ApplicationDbContext();

            Teacher teacher1 = new Teacher { Name = "Asma" };
            Teacher teacher2 = new Teacher { Name = "Rhaf" };
            Teacher teacher3 = new Teacher { Name = "Ahmed" };

            Subject subject1 = new Subject { SubjectName = "Math" };
            Subject subject2 = new Subject { SubjectName = "Science" };
            Subject subject3 = new Subject { SubjectName = "History" };

            Student student1 = new Student { StudentName = "Sara", Teachers = teacher1 };
            Student student2 = new Student { StudentName = "Meera", Teachers = teacher2 };
            Student student3 = new Student { StudentName = "Bader", Teachers = teacher3 };

            teacher1.Subjects = new List<Subject> { subject1, subject2 };
            teacher2.Subjects = new List<Subject> { subject2, subject3 };
            teacher3.Subjects = new List<Subject> { subject1, subject3 };

            db.AddRange(teacher1, teacher2, teacher3);
            db.AddRange(subject1, subject2, subject3);
            db.AddRange(student1, student2, student3);
            db.SaveChanges();

        }
    }
}
