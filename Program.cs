using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolDataStore dataStore = SchoolDataStore.Instance;
            dataStore.FillData();

            Console.WriteLine("Students in Class 10A:");
            var studentsInClass = dataStore.GetStudentsInClass("10A");
            foreach (var student in studentsInClass)
            {
                Console.WriteLine($"{student.Name} - {student.ClassAndSection}");
            }

            Console.WriteLine("\nSubjects taught by Mr. Anderson:");
            var subjectsTaughtByTeacher = dataStore.GetSubjectsTaughtByTeacher("Mr. Anderson");
            foreach (var subject in subjectsTaughtByTeacher)
            {
                Console.WriteLine($"{subject.Name} - {subject.SubjectCode}");
            }
            Console.ReadKey();
        }

    }
}
