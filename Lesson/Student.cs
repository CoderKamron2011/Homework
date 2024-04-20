using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Student(string universityName, string stipendiya) : Person
    {

        public string UniversityName { get; set; } = universityName;
        public string Stipendiya { get; set; } = stipendiya;

        public override void Displey()
        {
            Console.WriteLine($"student is university is {this.UniversityName}");
            Console.WriteLine($"student is stipendiye is {this.Stipendiya}");
        }
    }
}
