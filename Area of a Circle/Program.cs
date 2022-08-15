using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = pi * rad * rad;
            Console.WriteLine("Area of the circle is " + area + ".");


        }
    }
}