using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3012_
{
    class Program
    {
        static void Main(string[] args)
        {
            Q1();

            Q2();

            Q3();

            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    continue;
                }

                sum = sum + num;

                if (sum > 100_000)
                {
                    break;
                }

            }

            Console.WriteLine();

        }

        private static void Q3()
        {
            int a, b;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (a % b != 0);
        }

        private static void Q2()
        {
            for (int i = 1120; i <= 7; i = i - 7)
            {
                Console.WriteLine(i);
            }
        }

        private static void Q1()
        {
            for (int i = 2; i <= 200; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
