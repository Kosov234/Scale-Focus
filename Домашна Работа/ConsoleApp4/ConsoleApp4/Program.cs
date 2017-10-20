using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
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
                while (a > 0)
                {
                k = a % 10;
                    a = a / 10;
                    m = k % 2;
                    if (m != 0)
                    {
                        Console.WriteLine("...");
                       
                       
                    }
                    else
                    {

                        Console.WriteLine(k);
                    }

                }
            }
        }
    }
}
