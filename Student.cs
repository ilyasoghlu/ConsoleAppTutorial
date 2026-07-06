using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTutorial
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LaststName { get; set; }
        public int Course {  get; set; }
        public string Skills { get; set; }
        public int Age { get; set; }
        public static int Count = 0;

        public static string University { get; set; } = "MIT"; 
        
        public Student() {
            Count++;
        }

        public void Learning()
        {
            Console.WriteLine($"The Student of the {University} {LaststName} {FirstName} studies in the {Course} and {Age} years old, {FirstName} Learning {Skills} and there are {Count} students in his group");
        }


    }
}
