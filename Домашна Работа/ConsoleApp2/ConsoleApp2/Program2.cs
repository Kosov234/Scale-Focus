using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)

            {
                int a = int.Parse(Console.ReadLine());
                int k = 0;
                while (a > 0)
                {
                    k = k * 10 + a % 10;
                    a = a / 10;
                }
                Console.WriteLine(k);
            }
        }
    }
}