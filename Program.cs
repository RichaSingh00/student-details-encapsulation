using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetRollNo(1);
            student.SetId("Richa");
            student.SetCgpa(9.25f);

            int rollno =student.GetRollNo();
            string id=student.GetId();
            float cgpa=student.GetCgpa();

            Console.WriteLine("Roll No: " + student.GetRollNo());
            Console.WriteLine("Name: " + student.GetId());
            Console.WriteLine("CGPA: " + student.GetCgpa());
            Console.WriteLine("Percentage: " +student.CalculatePercentage());
        }
    }
}
