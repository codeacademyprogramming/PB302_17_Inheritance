using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Student
    {
        public Student(string fullname, byte point)
        {
            this.Fullname= fullname;
            this.Point = point;
        }

        public Student(string fullname, byte point,string groupNo, DateTime bDate):this(fullname,point)
        {
            this.GroupNo = groupNo;
            this.BirthDate= bDate;
        }

        public string Fullname;
        public DateTime BirthDate;
        public string GroupNo;
        public byte Point;

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {Fullname}\nGroupNo: {GroupNo}\nPoint: {Point}\nBirthDate: {BirthDate.ToString("dd.MM.yyyy")}");
        }
    }
}
