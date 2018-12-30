using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3012
{
    class Program
    {
        static void Main(string[] args)
        {
            // question 1
            Question1();

            // queestion 2
            Question2();

            // question 3
            Question3();

            Question4();

            // question 6
            Question6();

            Question7();

            Console.ReadLine();

        }

        private static void Question7()
        {
            int a, b;
            Console.WriteLine("Please enter two numbers :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 0;
            while (i < b)
            {
                sum = sum + a;
                i++;
            }

            Console.WriteLine(sum);
        }

        private static void Question6()
        {
            int i = 2;
            int atz = 1;
            Console.WriteLine("Please enter number for factorial");
            int a = Convert.ToInt32(Console.ReadLine());

            while (i <= a)
            {
                atz = atz * i;
                i++;
            }

            Console.WriteLine($"Factorial is {atz}");
        }

        private static void Question3()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number >= 0)
            {
                sum = sum + number;
            }
            Console.WriteLine($"The sum is {sum}");
        }

        private static void Question4()
        {
            int a;
            Console.WriteLine("Please enter number (Prime checking) :");
            a = Convert.ToInt32(Console.ReadLine());

            int m = 2;
            while (a % m != 0)
            {
                m++;
            }

            if (m < a)
            {
                Console.WriteLine($"{a} is NOT prime");
            }
            else
            {
                Console.WriteLine($"{a} is prime indeed");
            }
        }

        private static void Question2()
        {
            int a, b;
            Console.WriteLine("Please enter two numbers :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            double avg = sum / 2.0;

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"average = {avg}");
        }

        private static void Question1()
        {
            // question 1
            int a, b;
            Console.WriteLine("Please enter two numbers :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine($"{a} can be divided by {b} with no remaining!");
            }
            else
            {
                Console.WriteLine($"{a} CANNOT be divided by {b} with no remaining1");
            }
        }
    }
}
