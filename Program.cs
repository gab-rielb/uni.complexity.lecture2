using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture2
{
    internal class Program
    {
        static void Task1(int n)
        {
            Console.WriteLine($"\n\nn: {n}");
            Console.WriteLine("Alg1:");
            for (int i = 1; i <= 1.5 * n; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Alg2:");
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void Task2(int n) 
        {
            Console.WriteLine($"\nn: {n}");
            for (int i = 2; i <= n; i++)
            {
                for(int j = 0; j<= n;)
                {
                    Console.WriteLine($"i: {i} j: {j}");
                    j = j + (n / 4);
                }
            }
        }

        static void Main(string[] args)
        {
            Task1(2);
            Task1(4);
            Task1(6);

            Console.WriteLine("\n\n\n\n\n");
            Task2(4);
            Task2(16);
            Task2(32);
        }
    }
}
