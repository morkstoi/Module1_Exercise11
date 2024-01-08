using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquasion
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());

            Linear linear = new Linear(k, b);
            Console.WriteLine(linear.Root());
            Console.ReadKey();
        }
    }
}
