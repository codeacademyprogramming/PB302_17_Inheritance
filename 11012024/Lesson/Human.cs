using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public Human(string name)
        {
            this.Name = name;
            Console.WriteLine("Human created");
        }
        public string Name;
        public string Surname;
        public byte Age;

        public string GetFullname()
        {
            return Name+" "+Surname;
        }
    }
}
