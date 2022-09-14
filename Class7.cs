using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Student
    {
        public int RollNo;
        public string StudName;

        public float MarksInEng;
        public float MarksInMaths;

        public float MarksInScience;

        public float TotalMarks()
        {
            return MarksInEng + MarksInMaths + MarksInScience;
        }

        public float Percent()
        {
            return TotalMarks() /(float)3;
        }

        static void Main()
        {
            Student s1 = new Student();
            s1.MarksInMaths = 32;
            s1.MarksInEng = 48;
            s1.MarksInScience = 76;
            Console.WriteLine("Total Marks:" + s1.TotalMarks());
            Console.WriteLine("Percentage={0}%", s1.Percent());
        }

    }
}
