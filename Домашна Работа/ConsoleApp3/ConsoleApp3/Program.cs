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
                int m = 0;
                int v = 0;
                while (a > 0)
                {
                    k = a % 10;
                    a = a / 10;
                    v = v + k * (int)Math.Pow(2, m);
                    m = m + 1;
                }
                Console.WriteLine(v);
            }
        }
    }
}