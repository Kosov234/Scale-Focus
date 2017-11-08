using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int s = 0; s <= n; s++)
            {
                int b = s % 2;
                if (b != 0)
                {
                    sum = sum + s;
                }
                else
                {

                }



            }
            Console.WriteLine(sum);
        }
    }
}
