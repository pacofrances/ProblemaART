using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaART
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int num1, num2;
            int result = 0;

            Console.WriteLine("Press enter to generate numbers between 1 and 7...");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                while (result == 0)
                {
                    num1 = rng.Next(1, 6);
                    num2 = rng.Next(1, 6);

                    if (num1 == 1 && num2 == 1) result = 1;
                    else if (num1 == 2 && num2 == 1) result = 2;
                    else if (num1 == 3 && num2 == 1) result = 3;
                    else if (num1 == 4 && num2 == 1) result = 4;
                    else if (num1 == 5 && num2 == 1) result = 5;
                    else if (num1 == 1 && num2 == 2) result = 6;
                    else if (num1 == 1 && num2 == 3) result = 7;
                }

                Console.WriteLine(result);
                result = 0;
            }
        }
    }
}
