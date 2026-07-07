using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTutorial
{
    public class University
    {
        // static fields 
        public static string UniversityName = "Azərbaycan Texniki Universiteti";
        public static int FoundationYear = 1950;
        public static int TotalStudents = 0;

        // Instance fields
        public string StudentName;
        public int StudentAge;
        public string Faculty;
        public double GPA;


        // Constructor
        public University(string studentName, int studentAge, string faculty, double gpa)
        {
            StudentName = studentName;
            StudentAge = studentAge;
            Faculty = faculty;
            GPA = gpa;


            TotalStudents++;
        }


        // Instance methods
        public void ShowStudentInfo()
        {
            Console.WriteLine($"Ad: {StudentName}");
            Console.WriteLine($"Yaş: {StudentAge}");
            Console.WriteLine($"Fakultet: {Faculty}");
            Console.WriteLine($"GPA: {GPA}");
        }


        // Static methods 

        public static void ShowUniversityInfo()
        {
            Console.WriteLine($"Universitet: {UniversityName}");
            Console.WriteLine($"Yaradılma ili: {FoundationYear}");
            Console.WriteLine($"Ümumi Tələbə sayı: {TotalStudents}");
        }
    }
}
