using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    internal class Student
    {
        private int _rollno;
        private string _id;
        private float _cgpa;
        public Student()
        {
            _cgpa = 0;
        }
        //setter methods
        public void SetRollNo(int rollno)
        { _rollno = rollno; }
        public void SetId(string id)
        { _id = id.Length>=5?id:string.Empty; }
        public void SetCgpa(float cgpa)
        { _cgpa = Math.Max(0,Math.Min(10,cgpa)); } //default cgpa is 2: to do
        //getter methods
        public int GetRollNo()
        { return _rollno; }
        public string GetId()
        { return _id; }
        public float GetCgpa()
        { return _cgpa; }
        public float CalculatePercentage()
        {
            return _cgpa * 10;
        }
}
}
