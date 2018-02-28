using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic8
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Value was negitive");
            }

            else
            {
                Console.WriteLine("Value was postive");
            }

        }
    }
}
