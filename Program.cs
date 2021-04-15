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
            testGenerator(7000);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        // Creates a random number between 1 and 7 inclusive.
        public static int numberGenerator()
        {
            Random rng = new Random();
            int num1, num2;
            int result = 0;

            while (result == 0)
            {
                // Create a random number between 1 and 5. Random.Next() excludes the upper limmit.
                num1 = rng.Next(1, 6);
                num2 = rng.Next(1, 6);

                // Only accept valid combinations. Else, while loop runs again.
                if (num1 == 1 && num2 == 1) result = 1;
                else if (num1 == 2 && num2 == 1) result = 2;
                else if (num1 == 3 && num2 == 1) result = 3;
                else if (num1 == 4 && num2 == 1) result = 4;
                else if (num1 == 5 && num2 == 1) result = 5;
                else if (num1 == 1 && num2 == 2) result = 6;
                else if (num1 == 1 && num2 == 3) result = 7;
            }

            return result;
        }

        // Prints total occurences for each number.
        public static void testGenerator(int iterations)
        {
            int output;
            int[] occurenceCount = new int[7];
            for (int i = 0; i < iterations; i++)
            {
                //output = numberGenerator();
                Console.WriteLine(output);
                //occurenceCount[output - 1]++;
            }

            Console.WriteLine("Number of occurences:");
            Console.WriteLine("1: " + occurenceCount[0]);
            Console.WriteLine("2: " + occurenceCount[1]);
            Console.WriteLine("3: " + occurenceCount[2]);
            Console.WriteLine("4: " + occurenceCount[3]);
            Console.WriteLine("5: " + occurenceCount[4]);
            Console.WriteLine("6: " + occurenceCount[5]);
            Console.WriteLine("7: " + occurenceCount[6]);
        }
    }
}
