using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class student
    {
        public int rollno;
        public string name;
        public string Class;
        public int sem;
        public string branch;
        public int[] marks = new int[5];

        public float DisplayMarks()
        {
            int sum = 0;
            foreach(var mark in marks)
            {
                sum += mark;
            }
            return (float)sum / 5;
        }

        public void Display()
        {
            Console.WriteLine($"rollno:{rollno}\nname:{name}\nclass:{Class}\nsemester:{sem}\nbranch:{branch}");
            Console.WriteLine("Marks:");
            foreach (var mark in marks)
                Console.WriteLine(mark);
        }

        static void Main()
        {
            student s1 = new student();
            Console.WriteLine("Enter roll no:");
            s1.rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter class:");
            s1.Class = Console.ReadLine();
            Console.WriteLine("Enter sem:");
            s1.sem=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter branch:");
            s1.branch = Console.ReadLine();

            Console.WriteLine("Enter marks of 5 subjects:");
            for(int i = 0; i < 5; i++)
            {
                s1.marks[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Average marks:"+s1.DisplayMarks());

            if (s1.DisplayMarks() < 50)
                Console.WriteLine("Failed");
            else
            {
                foreach (var mark in s1.marks)
                {
                    if (mark < 35)
                        Console.WriteLine("Failed");
                    break;
                }
                if(s1.DisplayMarks() > 50)
                    Console.WriteLine("Passed");
            }
            s1.Display();
        }
    }
}
