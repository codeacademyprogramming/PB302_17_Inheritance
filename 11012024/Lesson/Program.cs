using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Hikmet","Abbasov")
            {
                Age = 30,
                Salary = 4500
            };

            emp1.ShowInfo();


            Teacher tch = new Teacher("Hikmet","Abbasov");

            Console.WriteLine(tch.Salary);
            Console.WriteLine(tch.GetFullname());


        }
    }
}
