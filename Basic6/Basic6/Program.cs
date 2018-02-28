using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the radius of a circle to found the area and perimeter");
            const double pi = 3.14159;
            var input = double.Parse(Console.ReadLine());

            var radius = Math.Sqrt(input);
            var area = Math.Round(pi * radius, 4);

            Console.WriteLine($"{area}");
        }
    }
}
