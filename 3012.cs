using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3012
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i = i * 2)
            {
                Console.WriteLine(i);
            }

            // readline 2 numbers until avg  > 80
            int a, b;
            double avg = 0;
            do
            {

                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                avg = a / b;
            }
            while (avg < 80 && a % 2 == 0 && b % 3 != 0);


            int x = 100;
            do
            {
                //
            }
            while (x < 10);

            int number = 0;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number > 0);


            Console.ReadLine();
        }
    }
}
