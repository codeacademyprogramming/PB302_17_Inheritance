using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Teacher:Employee
    {
        public Teacher(string name,string surname):base(name,surname)
        {
            Console.WriteLine("Teacher created");
        }
        public Teacher(string name, string surname,byte age) : base(name, surname,age)
        {
            Console.WriteLine("Teacher created");
        }
        public string LessonHours;
    }
}
