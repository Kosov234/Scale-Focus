using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program

    {
        static void Main(string[] args)
        {
            while (true)

            {
                int a = int.Parse(Console.ReadLine());
                int b = a % 2;
        

                if (b != 0)
                {
                    Console.WriteLine("Odd");
                }
                else
                {
                    Console.WriteLine("Even");
                }
                
            }
        }
    }
}
 