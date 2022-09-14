using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Area
    {
        public static void areacal(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void areacal(double h, double b)
        {
            Console.WriteLine((h * b) / 2);
        }
        public static void areacal(double r)
        {
            Console.WriteLine(3.14 * r * r);
        }
        public static void areacal(int s)
        {
            Console.WriteLine(s * s);
        }




        public static void Main()
        {

            Area.areacal(5, 5);//rectangle
            Area.areacal(5.00, 2.5);//triangle

            Area.areacal(5.230);//circle
            Area.areacal(5);//square
        }

    }
}






//public static void Add(int a, int b)
//{
//    Console.WriteLine(a + b);
//}
//public static int Add(int a)
//{
//    return a + a;
//}