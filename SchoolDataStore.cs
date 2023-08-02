using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec10
{
    public class SchoolDataStore
    {
        private static SchoolDataStore instance;
        private SchoolDataStore() { }

        public static SchoolDataStore Instance
        {
            get
            {
                if (instance == null)
                    instance = new SchoolDataStore();
                return instance;
            }
        }

        public List<Student> Students { get; } = new List<Student>();
        public List<Teacher> Teachers { get; } = new List<Teacher>();
        public List<Subject> Subjects { get; } = new List<Subject>();

        public void FillData()
        {
            // Fill up the lists with dummy data for testing
            Students.Add(new Student { Name = "John Doe", ClassAndSection = "10A" });
            Students.Add(new Student { Name = "Jane Smith", ClassAndSection = "9B" });

            Teachers.Add(new Teacher { Name = "Mr. Anderson", ClassAndSection = "10A" });
            Teachers.Add(new Teacher { Name = "Ms. Johnson", ClassAndSection = "9B" });

            Subjects.Add(new Subject { Name = "Math", SubjectCode = "MATH101", Teacher = Teachers[0] });
            Subjects.Add(new Subject { Name = "Science", SubjectCode = "SCI101", Teacher = Teachers[1] });
        }

        public List<Student> GetStudentsInClass(string className)
        {
            return Students.Where(s => s.ClassAndSection.Equals(className)).ToList();
        }

        public List<Subject> GetSubjectsTaughtByTeacher(string teacherName)
        {
            return Subjects.Where(s => s.Teacher.Name.Equals(teacherName)).ToList();
        }
    }
}
