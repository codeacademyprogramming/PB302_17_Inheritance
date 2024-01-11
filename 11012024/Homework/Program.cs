using System;
using System.Data;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentCountStr;
            int studentCount;
            do
            {
                Console.WriteLine("Students count:");
                studentCountStr = Console.ReadLine();
            } while (!int.TryParse(studentCountStr,out studentCount) || studentCount<0);

            Student[] students = new Student[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                string fullname;
                do
                {
                    Console.Write("Fullname: ");
                    fullname = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(fullname) || fullname.Length < 3 || fullname.Length > 20);

                string pointStr;
                byte point;
                do
                {
                    Console.Write("Point: ");
                    pointStr = Console.ReadLine();

                } while (!byte.TryParse(pointStr, out point) || point < 0 || point > 100);


                Console.Write("GroupNo: ");
                string groupNo = Console.ReadLine();

                string bDateStr;
                DateTime bDate;
                do
                {
                    Console.Write("BirthDate: ");
                    bDateStr = Console.ReadLine();

                } while (!DateTime.TryParse(bDateStr, out bDate) || (DateTime.Now.Year - bDate.Year) < 15);


                Student std = new Student(fullname, point)
                {
                    GroupNo = groupNo,
                    BirthDate = bDate,
                };

                students[i] = std;
            }


            Console.WriteLine("\n Students");
            for (int i = 0; i < students.Length; i++)
            {
                students[i].ShowInfo();
            }

            Student maxPointStudent = FindMaxPoint(students);

            Console.WriteLine("Max:");
            maxPointStudent.ShowInfo();
        }

        static Student FindMaxPoint(Student[] students)
        {
            Student wanted = students[0];

            for (int i = 1; i < students.Length; i++)
            {
                if (students[i].Point > wanted.Point)
                {
                    wanted= students[i];
                }
            }

            return wanted;
        }
    }
}
