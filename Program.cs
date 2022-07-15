using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius = 4;
            const double pi = 3.14159;
            double area;
            area = pi * radius * radius;
            Console.WriteLine("Radius = {0}. PI = {0}", radius, pi);
            Console.WriteLine("The area is {0}", area);
        }
    }
}
