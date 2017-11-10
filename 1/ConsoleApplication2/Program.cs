using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f = 0;
            for (int s = 0; s <= n;s++)
            {
                f = f + s;
                
              

            }
            Console.WriteLine(f/n);
           
        }
    }
}
