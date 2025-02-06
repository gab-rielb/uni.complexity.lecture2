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
            for (int i = 1; i <= 1.5 * n; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Task1(2);
            Task1(4);
            Task1(6);
        }1
    }
}
