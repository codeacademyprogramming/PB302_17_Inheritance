using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Employee:Human
    {
        //public Employee()
        //{
        //    Console.WriteLine("Employee created-1");
        //}

        public Employee(string name,string surname):base(name)
        {
            Surname=surname;
        }
        public Employee(string name, string surname,byte age) : base(name)
        {
            Surname = surname;
            Age=age;
        }
        public double Salary=350;

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {GetFullname()}\nSalary: {Salary}\nAge: {Age}");
        }
    }
}
