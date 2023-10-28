using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number:");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Arithmetic action (+,-,*,/ or :):");
            String ar = Console.ReadLine();
            Console.Write("Second number:");
            int b = Int32.Parse(Console.ReadLine());
            if (ar == "+")
            {
                int an = a + b;
                Console.WriteLine(a + "+" + b + "=" + an);
                Console.ReadLine();
            }
            else if (ar == "-")
            {
                int an = a - b;
                Console.WriteLine(a + "-" + b + "=" + an);
                Console.ReadLine();
            }
            else if (ar == "/" || ar == ":")
            {
                if (b == 0)
                {
                    Console.WriteLine(a + ":" + b + "=" + "Error");
                    Console.ReadLine();
                }
                else
                {
                    double an = (double)a / b;
                    Console.WriteLine(a + ":" + b + "=" + an);
                    Console.ReadLine();
                }
            }
            else if (ar == "*")
            {
                int an = a * b;
                Console.WriteLine(a + "*" + b + "=" + an);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
        }
    }
}
