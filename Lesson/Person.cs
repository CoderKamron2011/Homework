using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public Person(int id, string fullName, int age)
        {
            Id = id;
            FullName = fullName;
            Age = age;
        }

        public virtual void Displey()
        {
            Console.WriteLine($"person is id is {this.Id}");
            Console.WriteLine($"person is full name is {this.FullName}");
            Console.WriteLine($"person is age is {this.Age}");
        }

    }
}
